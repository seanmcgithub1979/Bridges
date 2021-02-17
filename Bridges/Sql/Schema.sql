--SELECT DB_NAME();

IF EXISTS (SELECT 1 FROM sys.tables WHERE name = 'Bridges') 
	DROP TABLE Bridges;
GO

CREATE TABLE Bridges
(
	Name			VARCHAR(255)	PRIMARY KEY,
	[Description]	VARCHAR(MAX),
	[Filename]		VARCHAR(255),
	Lng				DECIMAL(28,10),
	Lat				DECIMAL(28,10),
	Zoom			DECIMAL(28,10),
	Height			DECIMAL(28,10)
);
GO
