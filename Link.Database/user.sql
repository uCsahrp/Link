CREATE TABLE [dbo].[user]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [username] VARCHAR(50) NOT NULL, 
    [password] TEXT NOT NULL, 
    [email] VARCHAR(255) NOT NULL, 
    [access] INT NOT NULL,
    [timestamp] TIME NOT NULL
)
