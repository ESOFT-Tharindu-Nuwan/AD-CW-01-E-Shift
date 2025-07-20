USE eShiftDB;
GO

-- 1. Users Table
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(256) NOT NULL, -- Store hashed passwords!
    UserRole NVARCHAR(20) NOT NULL, -- 'Admin', 'Customer'
    IsActive BIT DEFAULT 1,
    DateCreated DATETIME DEFAULT GETDATE()
);
GO

-- 2. Customers Table
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL UNIQUE, -- Link to Users table for login
    CustomerNumber NVARCHAR(20) NOT NULL UNIQUE,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    AddressLine1 NVARCHAR(100),
    AddressLine2 NVARCHAR(100),
    City NVARCHAR(50),
    Province NVARCHAR(50),
    PostalCode NVARCHAR(10),
    PhoneNumber NVARCHAR(20),
    Email NVARCHAR(100) UNIQUE,
    RegistrationDate DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_Customers_Users FOREIGN KEY (UserID) REFERENCES Users(UserID)
);
GO

-- 3. Lorries Table
CREATE TABLE Lorries (
    LorryID INT PRIMARY KEY IDENTITY(1,1),
    RegistrationNumber NVARCHAR(20) NOT NULL UNIQUE,
    Make NVARCHAR(50),
    Model NVARCHAR(50),
    Capacity DECIMAL(10, 2), -- e.g., in tons or CBM
    FuelType NVARCHAR(20),
    CurrentMileage DECIMAL(18, 2),
    IsAvailable BIT DEFAULT 1
);
GO

-- 4. Drivers Table
CREATE TABLE Drivers (
    DriverID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    LicenseNumber NVARCHAR(20) NOT NULL UNIQUE,
    PhoneNumber NVARCHAR(20),
    Email NVARCHAR(100),
    Address NVARCHAR(200),
    IsAvailable BIT DEFAULT 1
);
GO

-- 5. Assistants Table
CREATE TABLE Assistants (
    AssistantID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    PhoneNumber NVARCHAR(20),
    Email NVARCHAR(100),
    Address NVARCHAR(200),
    IsAvailable BIT DEFAULT 1
);
GO

-- 6. Containers Table
CREATE TABLE Containers (
    ContainerID INT PRIMARY KEY IDENTITY(1,1),
    ContainerNumber NVARCHAR(20) NOT NULL UNIQUE,
    Type NVARCHAR(50), -- e.g., 'Standard', 'Refrigerated'
    CapacityCBM DECIMAL(10, 2), -- Cubic meters
    IsAvailable BIT DEFAULT 1
);
GO

-- 7. TransportUnits Table
CREATE TABLE TransportUnits (
    TransportUnitID INT PRIMARY KEY IDENTITY(1,1),
    LorryID INT NOT NULL,
    DriverID INT NOT NULL,
    AssistantID INT, -- Can be NULL
    ContainerID INT, -- Can be NULL
    UnitName NVARCHAR(100),
    IsOperational BIT DEFAULT 1,
    CONSTRAINT FK_TransportUnits_Lorries FOREIGN KEY (LorryID) REFERENCES Lorries(LorryID),
    CONSTRAINT FK_TransportUnits_Drivers FOREIGN KEY (DriverID) REFERENCES Drivers(DriverID),
    CONSTRAINT FK_TransportUnits_Assistants FOREIGN KEY (AssistantID) REFERENCES Assistants(AssistantID),
    CONSTRAINT FK_TransportUnits_Containers FOREIGN KEY (ContainerID) REFERENCES Containers(ContainerID)
);
GO

-- 8. Jobs Table
CREATE TABLE Jobs (
    JobID INT PRIMARY KEY IDENTITY(1,1),
    JobNumber NVARCHAR(20) NOT NULL UNIQUE,
    CustomerID INT NOT NULL,
    RequestedDate DATETIME DEFAULT GETDATE(),
    ScheduledPickupDate DATETIME,
    ScheduledDeliveryDate DATETIME,
    ActualPickupDate DATETIME,
    ActualDeliveryDate DATETIME,
    PickupLocation NVARCHAR(200) NOT NULL,
    DeliveryLocation NVARCHAR(200) NOT NULL,
    JobStatus NVARCHAR(50) NOT NULL, -- 'Pending', 'Scheduled', 'In Progress', 'Completed', 'Cancelled', 'Quoted'
    TransportUnitID INT, -- Can be NULL initially
    QuotedPrice DECIMAL(18, 2),
    FinalPrice DECIMAL(18, 2),
    Remarks NVARCHAR(MAX),
    AdminAssignedDate DATETIME,
    CONSTRAINT FK_Jobs_Customers FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    CONSTRAINT FK_Jobs_TransportUnits FOREIGN KEY (TransportUnitID) REFERENCES TransportUnits(TransportUnitID)
);
GO

-- 9. Loads Table
CREATE TABLE Loads (
    LoadID INT PRIMARY KEY IDENTITY(1,1),
    LoadNumber NVARCHAR(20) NOT NULL UNIQUE,
    JobID INT NOT NULL,
    Description NVARCHAR(250),
    WeightKG DECIMAL(10, 2),
    VolumeCBM DECIMAL(10, 2),
    LoadStatus NVARCHAR(50), -- 'Packed', 'Loaded', 'In Transit', 'Delivered'
    SpecialInstructions NVARCHAR(MAX),
    CONSTRAINT FK_Loads_Jobs FOREIGN KEY (JobID) REFERENCES Jobs(JobID)
);
GO

-- 10. Notifications Table
CREATE TABLE Notifications (
    NotificationID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    MessageType NVARCHAR(50) NOT NULL, -- e.g., 'Registration_NewCustomer', 'Job_NewRequest', 'Job_Assigned'
    MessageContent NVARCHAR(MAX) NOT NULL,
    Timestamp DATETIME DEFAULT GETDATE(),
    IsRead BIT DEFAULT 0,
    RelatedEntityID INT, -- e.g., CustomerID, JobID
    RelatedEntityType NVARCHAR(50), -- e.g., 'Customer', 'Job'
    CONSTRAINT FK_Notifications_Users FOREIGN KEY (UserID) REFERENCES Users(UserID)
);
GO

-- Create Initial Admin User
INSERT INTO Users (Username, PasswordHash, UserRole, IsActive, DateCreated) VALUES ('superadmin','$2a$11$zbNKYrdqMBvepEz6Deyxlu1Pvla63ra.fVho5WrVw7aQPWULQQjne', 'Admin', 1, GETDATE()); 
GO
