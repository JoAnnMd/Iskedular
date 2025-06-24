-- Ensure proper error handling and batch separation
SET NOCOUNT ON;
SET XACT_ABORT ON; -- Abort the batch if a runtime error occurs

-- 1. Create the database if it does not exist
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'UniversityDB')
BEGIN
    CREATE DATABASE UniversityDB;
END;
GO

-- 2. Use the newly created or existing database
USE UniversityDB;
GO

-- 3. Create Tables (ensure these run before any DELETE/INSERT statements)
-- Create the Role table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[dbo].[Role]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE Role (
        RoleID INT PRIMARY KEY IDENTITY(1,1),
        RoleName NVARCHAR(50) NOT NULL UNIQUE
    );
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
        Password NVARCHAR(255) NOT NULL, -- In a real app, store hashed passwords
        RoleID INT,
        FOREIGN KEY (RoleID) REFERENCES Role(RoleID)
    );
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
END;
GO

-- Create the Features table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE id = OBJECT_ID(N'[dbo].[Features]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE Features (
        FeatureID INT PRIMARY KEY IDENTITY(1,1),
        FeatureName NVARCHAR(100) NOT NULL UNIQUE
    );
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
END;
GO

-- 4. Clean up existing data before inserting new data
DELETE FROM Reservation;
DELETE FROM RoomFeatures;
DELETE FROM [User];
DELETE FROM Room;
DELETE FROM Features;
DELETE FROM Role;
GO

-- 5. Insert Sample Data

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