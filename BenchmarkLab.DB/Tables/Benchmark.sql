﻿CREATE TABLE [dbo].[Benchmark]
(
	[Id] INT IDENTITY NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(60) NOT NULL, 
    [Description] NCHAR(400) NULL, 
    [OwnerId] NVARCHAR(128) NOT NULL, 
    CONSTRAINT [FK_Benchmark_ToUsers] FOREIGN KEY (OwnerId) REFERENCES [AspNetUsers]([Id])
)