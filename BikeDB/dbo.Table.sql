CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Date] DATETIME NULL, 
    [Miles] DECIMAL NULL, 
    [Hours] TIME NULL, 
    [MilesWritten] INT NULL, 
    [Diff] INT NULL, 
    [AvgMPH] DECIMAL NULL, 
    [DaysSince] INT NULL
)
