--sp_tables;
SET NOCOUNT ON;

TRUNCATE TABLE Bridges;
GO

DECLARE @i	int = 1;
DECLARE @commentDate DATETIME;

WHILE (@i <= 62)
BEGIN

	INSERT INTO Bridges([Name], [Description], [Filename], FileBytes, Lat, Lng,  Zoom, Height)
	SELECT 																			
		'Bridge ' + CONVERT(VARCHAR(255),@i), 
		'Bridge1 description ' + CONVERT(VARCHAR(255),@i), 
		'Image' + CONVERT(VARCHAR(255),@i) + '.jpg', 
		NULL,
		51.111111,
		-1.155555,
		1222,
		14.25
	
	SELECT @i = @i+1;
END
GO

--select * from Bridges;
