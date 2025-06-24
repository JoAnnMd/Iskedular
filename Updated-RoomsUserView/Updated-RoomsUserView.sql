-- Ensure proper error handling and batch separation
SET NOCOUNT ON;   -- Prevents messages showing the count of rows affected by SQL statements.
SET XACT_ABORT ON; -- Aborts the entire batch if a runtime error occurs, rolling back any open transaction.

-- 1. Create the database if it does not exist
--    Using brackets around the database name is good practice for names with hyphens.
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'Updated-RoomsUserView')
BEGIN
    CREATE DATABASE [Updated-RoomsUserView];
    PRINT 'Database [Updated-RoomsUserView] created.';
END
ELSE
BEGIN
    PRINT 'Database [Updated-RoomsUserView] already exists.';
END;
GO -- Separates this batch from the next, ensuring the database is created before we try to use it.

-- 2. Use the newly created or existing database
USE [Updated-RoomsUserView];
PRINT 'Switched to database [Updated-RoomsUserView].';
GO -- Ensures the database context is set for the following table creation commands.

-- 3. Create Tables (ensure these run after USE DATABASE and before any DELETE/INSERT statements)
-- Create the Role table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[dbo].[Role]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE Role (
        RoleID INT PRIMARY KEY IDENTITY(1,1),
        RoleName NVARCHAR(50) NOT NULL UNIQUE
    );
    PRINT 'Table Role created.';
END;
GO

-- Create the User table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[dbo].[User]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [User] (
        UserID INT PRIMARY KEY IDENTITY(1,1),
        User_Lname NVARCHAR(100) NOT NULL,
        User_Fname NVARCHAR(100) NOT NULL,
        User_Mname NVARCHAR(100),
        Email NVARCHAR(255) NOT NULL UNIQUE,
        Password NVARCHAR(255) NOT NULL,
        RoleID INT,
        FOREIGN KEY (RoleID) REFERENCES Role(RoleID)
    );
    PRINT 'Table [User] created.';
END;
GO

-- Create the Room table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[dbo].[Room]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE Room (
        RoomID INT PRIMARY KEY IDENTITY(1,1),
        RoomNumber NVARCHAR(50) NOT NULL UNIQUE,
        Capacity INT NOT NULL
    );
    PRINT 'Table Room created.';
END;
GO

-- Create the Features table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[dbo].[Features]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE Features (
        FeatureID INT PRIMARY KEY IDENTITY(1,1),
        FeatureName NVARCHAR(100) NOT NULL UNIQUE
    );
    PRINT 'Table Features created.';
END;
GO

-- Create the RoomFeatures junction table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[dbo].[RoomFeatures]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE RoomFeatures (
        RoomID INT,
        FeatureID INT,
        PRIMARY KEY (RoomID, FeatureID),
        FOREIGN KEY (RoomID) REFERENCES Room(RoomID),
        FOREIGN KEY (FeatureID) REFERENCES Features(FeatureID)
    );
    PRINT 'Table RoomFeatures created.';
END;
GO

-- Create the Reservation table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[dbo].[Reservation]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE Reservation (
        RSRVID INT PRIMARY KEY IDENTITY(1,1),
        Start_time DATETIME NOT NULL,
        End_time DATETIME NOT NULL,
        UserID INT,
        RoomID INT,
        FOREIGN KEY (UserID) REFERENCES [User](UserID),
        FOREIGN KEY (RoomID) REFERENCES Room(RoomID)
    );
    PRINT 'Table Reservation created.';
END;
GO

-- 4. Clean up existing data before inserting new data
PRINT 'Cleaning up existing data...';
DELETE FROM Reservation;
DELETE FROM RoomFeatures;
-- REMOVED: DELETE FROM [User]; - User data will not be pre-seeded.
DELETE FROM Room;
DELETE FROM Features;
DELETE FROM Role;
PRINT 'Data cleanup complete.';
GO

-- 5. Insert Sample Data

PRINT 'Inserting sample data...';

-- Roles
INSERT INTO Role (RoleName) VALUES ('Admin'), ('Faculty'), ('Student');
GO

-- Features
INSERT INTO Features (FeatureName) VALUES
('Whiteboard'),
('Projector'),
('TV'),
('20 computers'),
('Air conditioning');
GO

-- Rooms
INSERT INTO Room (RoomNumber, Capacity) VALUES
('Room 101', 30),
('Room 102', 30),
('Room 103', 30),
('Room 104', 30),
('Room 105', 30),
('Room 106', 30),
('Room 201', 30),
('Room 202', 30),
('Room 203', 30),
('Room 204', 30),
('Room 205', 30),
('Room 206', 30),
('Computer Laboratory', 25),
('(AVR) Audio visual room', 50);
GO

-- RoomFeatures (linking rooms to features - updated)
-- Room 101: whiteboard, projector
INSERT INTO RoomFeatures (RoomID, FeatureID) VALUES
((SELECT RoomID FROM Room WHERE RoomNumber = 'Room 101'), (SELECT FeatureID FROM Features WHERE FeatureName = 'Whiteboard')),
((SELECT RoomID FROM Room WHERE RoomNumber = 'Room 101'), (SELECT FeatureID FROM Features WHERE FeatureName = 'Projector'));
GO

-- Room 102: whiteboard, projector
INSERT INTO RoomFeatures (RoomID, FeatureID) VALUES
((SELECT RoomID FROM Room WHERE RoomNumber = 'Room 102'), (SELECT FeatureID FROM Features WHERE FeatureName = 'Whiteboard')),
((SELECT RoomID FROM Room WHERE RoomNumber = 'Room 102'), (SELECT FeatureID FROM Features WHERE FeatureName = 'Projector'));
GO

-- Room 103: whiteboard, projector
INSERT INTO RoomFeatures (RoomID, FeatureID) VALUES
((SELECT RoomID FROM Room WHERE RoomNumber = 'Room 103'), (SELECT FeatureID FROM Features WHERE FeatureName = 'Whiteboard')),
((SELECT RoomID FROM Room WHERE RoomNumber = 'Room 103'), (SELECT FeatureID FROM Features WHERE FeatureName = 'Projector'));
GO

-- Room 104: whiteboard, TV
INSERT INTO RoomFeatures (RoomID, FeatureID) VALUES
((SELECT RoomID FROM Room WHERE RoomNumber = 'Room 104'), (SELECT FeatureID FROM Features WHERE FeatureName = 'Whiteboard')),
((SELECT RoomID FROM Room WHERE RoomNumber = 'Room 104'), (SELECT FeatureID FROM Features WHERE FeatureName = 'TV'));
GO

-- Room 105: whiteboard, TV
INSERT INTO RoomFeatures (RoomID, FeatureID) VALUES
((SELECT RoomID FROM Room WHERE RoomNumber = 'Room 105'), (SELECT FeatureID FROM Features WHERE FeatureName = 'Whiteboard')),
((SELECT RoomID FROM Room WHERE RoomNumber = 'Room 105'), (SELECT FeatureID FROM Features WHERE FeatureName = 'TV'));
GO

-- Room 106: whiteboard, TV
INSERT INTO RoomFeatures (RoomID, FeatureID) VALUES
((SELECT RoomID FROM Room WHERE RoomNumber = 'Room 106'), (SELECT FeatureID FROM Features WHERE FeatureName = 'Whiteboard')),
((SELECT RoomID FROM Room WHERE RoomNumber = 'Room 106'), (SELECT FeatureID FROM Features WHERE FeatureName = 'TV'));
GO

-- Room 201: whiteboard, projector
INSERT INTO RoomFeatures (RoomID, FeatureID) VALUES
((SELECT RoomID FROM Room WHERE RoomNumber = 'Room 201'), (SELECT FeatureID FROM Features WHERE FeatureName = 'Whiteboard')),
((SELECT RoomID FROM Room WHERE RoomNumber = 'Room 201'), (SELECT FeatureID FROM Features WHERE FeatureName = 'Projector'));
GO

-- Room 202: whiteboard, projector
INSERT INTO RoomFeatures (RoomID, FeatureID) VALUES
((SELECT RoomID FROM Room WHERE RoomNumber = 'Room 202'), (SELECT FeatureID FROM Features WHERE FeatureName = 'Whiteboard')),
((SELECT RoomID FROM Room WHERE RoomNumber = 'Room 202'), (SELECT FeatureID FROM Features WHERE FeatureName = 'Projector'));
GO

-- Room 203: whiteboard, projector
INSERT INTO RoomFeatures (RoomID, FeatureID) VALUES
((SELECT RoomID FROM Room WHERE RoomNumber = 'Room 203'), (SELECT FeatureID FROM Features WHERE FeatureName = 'Whiteboard')),
((SELECT RoomID FROM Room WHERE RoomNumber = 'Room 203'), (SELECT FeatureID FROM Features WHERE FeatureName = 'Projector'));
GO

-- Room 204: whiteboard, TV
INSERT INTO RoomFeatures (RoomID, FeatureID) VALUES
((SELECT RoomID FROM Room WHERE RoomNumber = 'Room 204'), (SELECT FeatureID FROM Features WHERE FeatureName = 'Whiteboard')),
((SELECT RoomID FROM Room WHERE RoomNumber = 'Room 204'), (SELECT FeatureID FROM Features WHERE FeatureName = 'TV'));
GO

-- Room 205: whiteboard, TV
INSERT INTO RoomFeatures (RoomID, FeatureID) VALUES
((SELECT RoomID FROM Room WHERE RoomNumber = 'Room 205'), (SELECT FeatureID FROM Features WHERE FeatureName = 'Whiteboard')),
((SELECT RoomID FROM Room WHERE RoomNumber = 'Room 205'), (SELECT FeatureID FROM Features WHERE FeatureName = 'TV'));
GO

-- Room 206: whiteboard, TV
INSERT INTO RoomFeatures (RoomID, FeatureID) VALUES
((SELECT RoomID FROM Room WHERE RoomNumber = 'Room 206'), (SELECT FeatureID FROM Features WHERE FeatureName = 'Whiteboard')),
((SELECT RoomID FROM Room WHERE RoomNumber = 'Room 206'), (SELECT FeatureID FROM Features WHERE FeatureName = 'TV'));
GO

-- Computer Laboratory: 20 computers, whiteboard, TV, Air conditioning
INSERT INTO RoomFeatures (RoomID, FeatureID) VALUES
((SELECT RoomID FROM Room WHERE RoomNumber = 'Computer Laboratory'), (SELECT FeatureID FROM Features WHERE FeatureName = '20 computers')),
((SELECT RoomID FROM Room WHERE RoomNumber = 'Computer Laboratory'), (SELECT FeatureID FROM Features WHERE FeatureName = 'Whiteboard')),
((SELECT RoomID FROM Room WHERE RoomNumber = 'Computer Laboratory'), (SELECT FeatureID FROM Features WHERE FeatureName = 'TV')),
((SELECT RoomID FROM Room WHERE RoomNumber = 'Computer Laboratory'), (SELECT FeatureID FROM Features WHERE FeatureName = 'Air conditioning'));
GO

-- (AVR) Audio visual room: whiteboard, TV, air conditioning
INSERT INTO RoomFeatures (RoomID, FeatureID) VALUES
((SELECT RoomID FROM Room WHERE RoomNumber = '(AVR) Audio visual room'), (SELECT FeatureID FROM Features WHERE FeatureName = 'Whiteboard')),
((SELECT RoomID FROM Room WHERE RoomNumber = '(AVR) Audio visual room'), (SELECT FeatureID FROM Features WHERE FeatureName = 'TV')),
((SELECT RoomID FROM Room WHERE RoomNumber = '(AVR) Audio visual room'), (SELECT FeatureID FROM Features WHERE FeatureName = 'Air conditioning'));
GO

PRINT 'Sample data insertion complete.';