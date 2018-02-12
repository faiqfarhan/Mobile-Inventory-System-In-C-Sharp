CREATE TABLE [dbo].[Model] (
	[id] SMALLINT IDENTITY(1,1) NOT NULL DEFAULT 2000,
    [category] VARCHAR (50) NULL,
    [model]    VARCHAR (50) NULL,
    [camera]   CHAR (10)    NULL,
    [sim]      CHAR (10)    NULL,
     
    PRIMARY KEY CLUSTERED ([id] ASC)
);

