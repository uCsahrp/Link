CREATE TABLE [dbo].[profil]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [nom] VARCHAR(50) NOT NULL, 
    [prenom] VARCHAR(50) NOT NULL, 
    [adresse] VARCHAR(255) NOT NULL, 
    [naissance] DATE NOT NULL
)
