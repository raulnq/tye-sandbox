USE [master]
GO
CREATE DATABASE [StatisticsDb]
GO
USE [StatisticsDb]
GO
CREATE TABLE [Statistics](
    [Id] int IDENTITY(1,1) NOT NULL,
    [Country] varchar(255) NOT NULL,
    [Population] decimal(15) NOT NULL,
	[Area] decimal(19,4) NOT NULL
    CONSTRAINT [PK_Statistics] PRIMARY KEY ([Id])
)
INSERT INTO [Statistics](Country, Population, Area) VALUES ('China',1448471400, 9706961)
INSERT INTO [Statistics](Country, Population, Area) VALUES ('India',1393409038, 3287590)
INSERT INTO [Statistics](Country, Population, Area) VALUES ('United States', 332915073, 9372610)