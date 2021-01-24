CREATE TABLE [dbo].[classe]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [libelle] CHAR(11) NOT NULL, 
    [membre] BIT NOT NULL,
    [timestamp] TIME NOT NULL
)
