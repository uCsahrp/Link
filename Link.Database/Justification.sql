CREATE TABLE [dbo].[Justification]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [path] VARCHAR(50) NOT NULL, 
    [approved] BIT NOT NULL,
    [timestamp] TIME NOT NULL
)
