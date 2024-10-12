IF EXISTS(SELECT 1 FROM	sys.objects
WHERE object_id = OBJECT_ID(N'[Courses].[Insert]') AND type in (N'P', N'PC'))
BEGIN
	DROP PROCEDURE [Courses].[Insert]
END
GO
CREATE PROCEDURE [Courses].[Insert]

	@NAME			VARCHAR (150),
	@Credits		INT, 
	@CourseId		INT OUTPUT
--WITH ENCRYPTION
AS
BEGIN
	INSERT INTO Courses(Name, Credits)
	VALUES (@Name, @Credits)
	SET @CourseId = SCOPE_IDENTITY()
END
GO
EXEC sp_recompile N'[Courses].[Insert]'

--/////////////////////////////////////////////////////////////////////////////////
--//////////////////////////////////UPDATE/////////////////////////////////////////

IF EXISTS(SELECT 1 FROM	sys.objects
WHERE object_id = OBJECT_ID(N'[Courses].[Update]') AND type in (N'P', N'PC'))
BEGIN
	DROP PROCEDURE [Courses].[Update]
END
GO
CREATE PROCEDURE [Courses].[Update]

	@CourseId		INT,
	@NAME			VARCHAR (150),
	@Credits		INT

--WITH ENCRYPTION
AS
BEGIN
	UPDATE Courses
	SET Name = @NAME,
			Credits = @Credits
	WHERE CourseId = @CourseId
END
GO
EXEC sp_recompile N'[Courses].[Update]'

--/////////////////////////////////////////////////////////////////////////////////
--//////////////////////////////////DELETE/////////////////////////////////////////

IF EXISTS(SELECT 1 FROM	sys.objects
WHERE object_id = OBJECT_ID(N'[Courses].[Delete]') AND type in (N'P', N'PC'))
BEGIN
	DROP PROCEDURE [Courses].[Delete]
END
GO
CREATE PROCEDURE [Courses].[Delete]
	@CourseId		INT
--WITH ENCRYPTION
AS
BEGIN
	DELETE Courses
	WHERE CourseId = @CourseId
END
GO
EXEC sp_recompile N'[Courses].[Delete]'

--/////////////////////////////////////////////////////////////////////////////////
--//////////////////////////////////GET///////////////////////////////////////////

IF EXISTS(SELECT 1 FROM	sys.objects
WHERE object_id = OBJECT_ID(N'[Courses].[Get]') AND type in (N'P', N'PC'))
BEGIN
	DROP PROCEDURE [Courses].[Get]
END
GO
CREATE PROCEDURE [Courses].[Get]
	@CourseId		INT
--WITH ENCRYPTION
AS
BEGIN
	SELECT CourseId,Credits
	FROM Courses
	WHERE CourseId = @CourseId
END
GO
EXEC sp_recompile N'[Courses].[Get]'

EXEC [Courses].[GeT]  1

--/////////////////////////////////////////////////////////////////////////////////
--///////////////////////////////GET ALL///////////////////////////////////////////

IF EXISTS(SELECT 1 FROM	sys.objects
WHERE object_id = OBJECT_ID(N'[Courses].[GetAll]') AND type in (N'P', N'PC'))
BEGIN
	DROP PROCEDURE [Courses].[GetAll]
END
GO
CREATE PROCEDURE [Courses].[GetAll]
	
--WITH ENCRYPTION
AS
BEGIN
	SELECT CourseId,Credits
	FROM Courses

END
GO
EXEC sp_recompile N'[Courses].[GetAll]'

EXEC [Courses].[GetAll]





