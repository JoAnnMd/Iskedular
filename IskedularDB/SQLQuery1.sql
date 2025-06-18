CREATE DATABASE IskedularDB;

SELECT * FROM Users

-- ROOM TABLE --
CREATE TABLE Rooms (
    RoomNumber INT PRIMARY KEY
    ,Capacity INT NOT NULL
    ,Status VARCHAR NOT NULL
);

-- USER TABLE -- 
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY, -- auto increment --
    FName VARCHAR(100) NOT NULL,
    MName VARCHAR(100),
    LName VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    Password VARCHAR(100) NOT NULL
);

-- RESERVATION TABLE --
CREATE TABLE Reservation (
    RSVDID INTEGER PRIMARY KEY
    ,StartDateTime DATETIME NOT NULL
    ,EndDateTime DATETIME NOT NULL
    ,RoomNumber INT NOT NULL
    ,UserID INT NOT NULL
    ,FOREIGN KEY(RooMNumber)
        REFERENCES Rooms(RoomNumber)
    ,FOREIGN KEY(UserID)
        REFERENCES Users(UserID)
);

-- FEATURE TABLE -- 
CREATE TABLE Features(
    FeatureID INTEGER PRIMARY KEY
    ,FeatureName VARCHAR(100) NOT NULL
    ,RoomNumber INTEGER NOT NULL
    ,FOREIGN KEY (RoomNumber)
        REFERENCES Rooms(RoomNumber)
);

-- ROLE --
CREATE TABLE Role(
    RoleID INTEGER PRIMARY KEY
    ,RoleName VARCHAR(100) NOT NULL
);