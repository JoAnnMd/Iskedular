
-- Drop all foreign keys in the current database
DECLARE @sql NVARCHAR(MAX) = '';
SELECT @sql += 'ALTER TABLE [' + OBJECT_SCHEMA_NAME(parent_object_id) + '].[' + OBJECT_NAME(parent_object_id) + '] DROP CONSTRAINT [' + name + '];' + CHAR(13)
FROM sys.foreign_keys;
EXEC sp_executesql @sql;
GO


-- 1. DROP EXISTING OBJECTS IN CORRECT ORDER
-- Views & Stored Procedures (they reference tables)
DROP VIEW IF EXISTS vw_UserUpcomingBookings;
DROP VIEW IF EXISTS vw_AvailableRoomsWithFeatures;
DROP PROCEDURE IF EXISTS usp_GetUserDashboardData;
DROP PROCEDURE IF EXISTS usp_GetFilteredRooms;
GO

-- Child tables (they reference parent tables)
DROP TABLE IF EXISTS RoomRoomFeatures;
DROP TABLE IF EXISTS Bookings;
GO

-- Parent tables (can be dropped once children are gone)
DROP TABLE IF EXISTS Rooms;
DROP TABLE IF EXISTS RoomFeatures;
DROP TABLE IF EXISTS Users;
DROP TABLE IF EXISTS RoomTypes;
DROP TABLE IF EXISTS Announcements;
GO


-- 2. TABLES
-- ROOM TYPES
CREATE TABLE RoomTypes (
    RoomTypeID INT PRIMARY KEY IDENTITY(1,1),
    TypeName NVARCHAR(50) NOT NULL UNIQUE,
    Description NVARCHAR(255)
);
GO

-- USERS
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    PasswordHash NVARCHAR(255) NOT NULL,
    UserType NVARCHAR(20) NOT NULL DEFAULT 'Student',
    DateCreated DATETIME DEFAULT GETDATE()
);
GO

-- ROOM FEATURES
CREATE TABLE RoomFeatures (
    FeatureID INT PRIMARY KEY IDENTITY(1,1),
    FeatureName NVARCHAR(50) NOT NULL UNIQUE
);
GO

-- ROOMS
CREATE TABLE Rooms (
    RoomID INT PRIMARY KEY IDENTITY(1,1),
    RoomName NVARCHAR(100) NOT NULL UNIQUE,
    Capacity INT NOT NULL,
    RoomTypeID INT NOT NULL,
    Location NVARCHAR(255),
    IsAvailable BIT DEFAULT 1,
    FOREIGN KEY (RoomTypeID) REFERENCES RoomTypes(RoomTypeID)
);
GO

-- ROOM-TO-FEATURE LINK
CREATE TABLE RoomRoomFeatures (
    RoomID INT NOT NULL,
    FeatureID INT NOT NULL,
    PRIMARY KEY (RoomID, FeatureID),
    FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID) ON DELETE CASCADE,
    FOREIGN KEY (FeatureID) REFERENCES RoomFeatures(FeatureID) ON DELETE CASCADE
);
GO

-- ANNOUNCEMENTS
CREATE TABLE Announcements (
    AnnouncementID INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(255) NOT NULL,
    Content NVARCHAR(MAX) NOT NULL,
    PublishDate DATETIME DEFAULT GETDATE(),
    ExpiryDate DATETIME
);
GO

-- BOOKINGS
CREATE TABLE Bookings (
    BookingID INT PRIMARY KEY IDENTITY(1,1),
    RoomID INT NOT NULL,
    UserID INT NOT NULL,
    BookingDate DATE NOT NULL,
    StartTime TIME NOT NULL,
    EndTime TIME NOT NULL,
    Status NVARCHAR(20) NOT NULL DEFAULT 'Pending',
    Purpose NVARCHAR(MAX),
    DateCreated DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID),
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    CONSTRAINT CHK_BookingStatus CHECK (Status IN ('Pending','Approved','Canceled','Completed')),
    CONSTRAINT UQ_RoomBookingTime UNIQUE (RoomID, BookingDate, StartTime, EndTime)
);
GO

-- INDEXES FOR PERFORMANCE
CREATE INDEX IX_Bookings_UserID ON Bookings (UserID);
CREATE INDEX IX_Bookings_RoomID ON Bookings (RoomID);
CREATE INDEX IX_Rooms_RoomTypeID ON Rooms (RoomTypeID);
GO


-- 3. CREATE VIEWS
CREATE VIEW vw_UserUpcomingBookings AS
SELECT
    b.BookingID, b.RoomID, r.RoomName,
    b.BookingDate, b.StartTime, b.EndTime, b.Status, b.Purpose,
    u.UserID, u.FirstName, u.LastName
FROM Bookings b
JOIN Rooms r ON b.RoomID = r.RoomID
JOIN Users u ON b.UserID = u.UserID
WHERE
    b.BookingDate > CAST(GETDATE() AS DATE)
    OR (b.BookingDate = CAST(GETDATE() AS DATE) AND b.EndTime > CAST(GETDATE() AS TIME));
GO

CREATE VIEW vw_AvailableRoomsWithFeatures AS
SELECT
    r.RoomID, r.RoomName, r.Capacity,
    rt.TypeName AS RoomType, r.Location, r.IsAvailable,
    STUFF((
        SELECT ', ' + rf.FeatureName
        FROM RoomRoomFeatures rrf
        JOIN RoomFeatures rf ON rrf.FeatureID = rf.FeatureID
        WHERE rrf.RoomID = r.RoomID
        FOR XML PATH(''), TYPE
    ).value('.', 'NVARCHAR(MAX)'), 1, 2, '') AS Features
FROM Rooms r
JOIN RoomTypes rt ON r.RoomTypeID = rt.RoomTypeID
WHERE r.IsAvailable = 1;
GO


-- 4. CREATE STORED PROCEDURES
CREATE PROCEDURE usp_GetUserDashboardData @UserID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT FirstName, LastName
    FROM Users
    WHERE UserID = @UserID;

    SELECT BookingID, RoomName, BookingDate, StartTime, EndTime, Status
    FROM vw_UserUpcomingBookings
    WHERE UserID = @UserID
    ORDER BY BookingDate, StartTime;

    SELECT Title, Content, PublishDate
    FROM Announcements
    WHERE GETDATE() BETWEEN PublishDate AND ISNULL(ExpiryDate, DATEADD(DAY,1,GETDATE()))
    ORDER BY PublishDate DESC;
END;
GO

CREATE PROCEDURE usp_GetFilteredRooms @FeatureNames NVARCHAR(MAX) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        r.RoomID, r.RoomName, r.Capacity, rt.TypeName AS RoomType, r.Location, vw.Features
    FROM Rooms r
    JOIN RoomTypes rt ON r.RoomTypeID = rt.RoomTypeID
    JOIN vw_AvailableRoomsWithFeatures vw ON r.RoomID = vw.RoomID
    WHERE r.IsAvailable = 1
      AND (
          @FeatureNames IS NULL
          OR EXISTS (
              SELECT 1
              FROM STRING_SPLIT(@FeatureNames, ',') fs
              WHERE CHARINDEX(LTRIM(RTRIM(fs.value)), vw.Features) > 0
          )
      );
END;
GO