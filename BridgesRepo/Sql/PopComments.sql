SET NOCOUNT ON;
TRUNCATE TABLE Comments;
GO
DECLARE @i	int = 1;
WHILE (@i <= 20)
BEGIN

	INSERT INTO Comments(CommentContent, CommentDate, [From], EmailAddress)
	SELECT 'Comment ' + CONVERT(VARCHAR(255),@i), 
	SYSDATETIME(), 
	'From Sys Admin' + CONVERT(VARCHAR(255), @i), 
	'Email Address ' + CONVERT(VARCHAR(255), @i)
	SELECT @i = @i+1;
END
GO
--SELECT * FROM Comments;
