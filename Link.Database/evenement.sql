CREATE TABLE [dbo].[evenement]
(
	[Id] INT NOT NULL , 
    [user_id] INT NOT NULL, 
    [subject] NCHAR(10) NOT NULL, 
    [start_at] TIME(0) NOT NULL, 
    [end_at] TIME(0) NOT NULL, 
    PRIMARY KEY ([Id])
)
