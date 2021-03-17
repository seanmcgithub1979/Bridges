SET NOCOUNT ON;
TRUNCATE TABLE Comments;
GO

DECLARE @i	int = 1;
DECLARE @commentDate DATETIME;

SELECT @commentDate = DATEADD(d, -50, SYSDATETIME());

WHILE (@i <= 20)
BEGIN

	INSERT INTO Comments(CommentContent, CommentDate, [From], EmailAddress)
	SELECT 
		'Comment ' + CONVERT(VARCHAR(255),@i), 
		DATEADD(d, @i, @commentDate), 
		'Sys Admin',
		'mail' + CONVERT(VARCHAR(255), @i) + '@gmail.com'
	
	SELECT @i = @i+1;
END
GO
--SELECT * FROM Comments;
