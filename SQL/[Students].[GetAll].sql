IF EXISTS(SELECT 1 FROM	sys.objects
WHERE object_id = OBJECT_ID(N'[Students].[GetAll]') AND type in (N'P', N'PC'))
BEGIN
	DROP PROCEDURE [Students].[GeAll]
END
GO
CREATE PROCEDURE [Students].[GetAll]
	@StudentId		INT = NULL
--WITH ENCRYPTION
AS
BEGIN
	SELECT StudentId, Name, DateOfBirth
	FROM Students
END
GO
EXEC sp_recompile N'[Students].[GetAll]'

EXEC [Students].[GetAll]


