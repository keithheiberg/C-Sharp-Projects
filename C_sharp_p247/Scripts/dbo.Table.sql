CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(50) NULL, 
    [LastName] VARCHAR(50) NULL, 
    [EmailAddress] VARCHAR(50) NULL, 
    [DOB] VARCHAR(15) NULL, 
    [CarYear] INT NULL, 
    [CarMake] VARCHAR(50) NULL, 
    [CarModel] VARCHAR(50) NULL, 
    [DUI] VARCHAR(15) NULL, 
    [SpeedingTickets] INT NULL, 
    [Coverage] VARCHAR(15) NULL
)
