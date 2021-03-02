--SELECT DB_NAME();

IF EXISTS (SELECT 1 FROM sys.tables WHERE name = 'Bridges') 
	DROP TABLE Bridges;
GO

CREATE TABLE Bridges
(
	[Id]					INT IDENTITY (1, 1)	PRIMARY KEY,
	[Name]					VARCHAR(255),
	[Description]			VARCHAR(MAX),
	[Filename]				VARCHAR(255),
	[FileBytes]				VARBINARY(MAX),
	Lng						FLOAT,
	Lat						FLOAT,
	Zoom					FLOAT,
	Height					FLOAT
);
GO

IF EXISTS (SELECT 1 FROM sys.tables WHERE name = 'Comments') 
	DROP TABLE Comments;
GO

CREATE TABLE Comments
(
	[Id]			INT IDENTITY (1, 1)	PRIMARY KEY,
	CommentContent	VARCHAR(MAX),
	CommentDate		DATETIME,
	[From]			VARCHAR(255),
	EmailAddress	VARCHAR(255)
);
GO
