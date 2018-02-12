CREATE TABLE [dbo].Model
(
	[id]   INT          IDENTITY (1, 1) NOT NULL,
    [category] VARCHAR (50) NOT NULL,
    [model] VARCHAR(50) NOT NULL, 
    [camera] CHAR(10) NULL, 
    [sim] CHAR(10) NULL, 
    PRIMARY KEY CLUSTERED ([id] ASC) 
)
