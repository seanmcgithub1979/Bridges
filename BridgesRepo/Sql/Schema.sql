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
	DistanceToMouthKm		FLOAT,
	DistanceFromSourceKm	FLOAT,
	Zoom					FLOAT,
	Height					FLOAT,
	DateCreated				DATETIME NOT NULL DEFAULT GETDATE(),
	LastModified			DATETIME NOT NULL DEFAULT GETDATE());
GO

IF EXISTS (SELECT 1 FROM sys.tables WHERE name = 'Comments') 
	DROP TABLE Comments;
GO

CREATE TABLE Comments
(
	[Id]			INT IDENTITY (1, 1)	PRIMARY KEY,
	CommentContent	VARCHAR(MAX),
	CommentDate		DATETIME NOT NULL DEFAULT GETDATE(),
	[From]			VARCHAR(255),
	EmailAddress	VARCHAR(255)
);
GO
