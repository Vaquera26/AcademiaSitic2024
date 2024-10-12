IF EXISTS(SELECT 1 FROM	sys.objects
WHERE object_id = OBJECT_ID(N'[Enrollments].[Insert]') AND type in (N'P', N'PC'))
BEGIN
	DROP PROCEDURE [Enrollments].[Insert]
END
GO
CREATE PROCEDURE [Enrollments].[Insert]

	@StudentId			INT,
	@CourseId			INT, 
	@EnrollmentDate		DATE,
	@EnrollmentId		INT OUTPUT
--WITH ENCRYPTION
AS
BEGIN
	INSERT INTO Enrollments(StudentId, CourseId, EnrollmentDate)
	VALUES (@StudentId, @CourseId, @EnrollmentDate)
	SET @EnrollmentId = SCOPE_IDENTITY()
END
GO
EXEC sp_recompile N'[Enrollments].[Insert]'

--/////////////////////////////////////////////////////////////////////////////////
--//////////////////////////////////UPDATE/////////////////////////////////////////

IF EXISTS(SELECT 1 FROM	sys.objects
WHERE object_id = OBJECT_ID(N'[Enrollments].[Update]') AND type in (N'P', N'PC'))
BEGIN
	DROP PROCEDURE [Enrollments].[Update]
END
GO
CREATE PROCEDURE [Enrollments].[Update]

	@StudentId			INT,
	@CourseId			INT, 
	@EnrollmentDate		DATE,
	@EnrollmentId		INT

--WITH ENCRYPTION
AS
BEGIN
	UPDATE Enrollments

	SET StudentId  = @StudentId,
		CourseId = @CourseId,
		EnrollmentDate = @EnrollmentDate

	WHERE @EnrollmentId=EnrollmentId
END
GO
EXEC sp_recompile N'[Enrollments].[Update]'

--/////////////////////////////////////////////////////////////////////////////////
--//////////////////////////////////DELETE/////////////////////////////////////////

IF EXISTS(SELECT 1 FROM	sys.objects
WHERE object_id = OBJECT_ID(N'[Enrollments].[Delete]') AND type in (N'P', N'PC'))
BEGIN
	DROP PROCEDURE [Enrollments].[Delete]
END
GO
CREATE PROCEDURE [Enrollments].[Delete]
	@EnrollmentId		INT
--WITH ENCRYPTION
AS
BEGIN
	DELETE Enrollments
	WHERE EnrollmentId = @EnrollmentId
END
GO
EXEC sp_recompile N'[Enrollments].[Delete]'

--/////////////////////////////////////////////////////////////////////////////////
--//////////////////////////////////GET////////////////////////////////////////////

IF EXISTS(SELECT 1 FROM	sys.objects
WHERE object_id = OBJECT_ID(N'[Enrollments].[Get]') AND type in (N'P', N'PC'))
BEGIN
	DROP PROCEDURE [Enrollments].[Get]
END
GO
CREATE PROCEDURE [Enrollments].[Get]
	@EnrollmentId		INT
--WITH ENCRYPTION
AS
BEGIN
	SELECT 	StudentId ,CourseId	, EnrollmentDate,EnrollmentId
	FROM Enrollments
	WHERE EnrollmentId = @EnrollmentId
END
GO
EXEC sp_recompile N'[Enrollments].[Get]'

EXEC [Enrollments].[GeT]  1

--/////////////////////////////////////////////////////////////////////////////////
--///////////////////////////////GET ALL///////////////////////////////////////////

IF EXISTS(SELECT 1 FROM	sys.objects
WHERE object_id = OBJECT_ID(N'[Enrollments].[GetAll]') AND type in (N'P', N'PC'))
BEGIN
	DROP PROCEDURE [Enrollments].[GetAll]
END
GO
CREATE PROCEDURE [Enrollments].[GetAll]
	
--WITH ENCRYPTION
AS
BEGIN
	SELECT 	StudentId ,CourseId	, EnrollmentDate,EnrollmentId
	FROM Enrollments


END
GO
EXEC sp_recompile N'[Enrollments].[GetAll]'

EXEC [Enrollments].[GetAll]




