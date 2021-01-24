CREATE TABLE [dbo].[Absence]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [start_at] TIME(0) NOT NULL, 
    [end_at] TIME(0) NOT NULL,
    [Justification] BIT NOT NULL,
    [timestamp] TIME NOT NULL

)
