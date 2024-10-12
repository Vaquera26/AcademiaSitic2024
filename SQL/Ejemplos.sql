DECLARE @StudentId INT
EXECUTE [Students].[Insert] 'JUAN VAQUERA 2', '19490602', 'juan2.tec@outlook.com', @StudentId OUTPUT

SELECT @StudentId

DECLARE @CourseId INT
EXECUTE [Courses].[Insert] 'Automatas', '5', @CourseId OUTPUT

SELECT @CourseId

DECLARE @EnrollmentId INT
EXECUTE Enrollments.[Insert] '1', '1', '20240510' ,@EnrollmentId OUTPUT

SELECT @EnrollmentId

SELECT * FROM Students
SELECT * FROM Courses
SELECT * FROM Enrollments