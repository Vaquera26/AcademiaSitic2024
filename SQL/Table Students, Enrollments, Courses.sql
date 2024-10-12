CREATE DATABASE Excersises;

USE Excersises;

--CREATE TABLE [User] (
	--UserId INT PRIMARY KEY IDENTITY(1,1),
	--Username VARCHAR (50) NOT NULL,
	--Password VARCHAR (50) NOT NULL
--)

IF NOT EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Students]')
and OBJECTPROPERTY (id, N'isUserTable') = 1 )
BEGIN
CREATE TABLE [dbo].[Students] (
	StudentId INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Name VARCHAR(150) NOT NULL,
	DateOfBirth DATE NOT NULL,
	Email VARCHAR(100)
)
END

IF NOT EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Courses]')
and OBJECTPROPERTY (id, N'isUserTable') = 1 )
BEGIN
CREATE TABLE Courses (
	CourseId INT PRIMARY KEY IDENTITY (1,1),
	Name VARCHAR(100),
	Credits INT
)
END

IF NOT EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Enrollments]')
and OBJECTPROPERTY (id, N'isUserTable') = 1 )
BEGIN
CREATE TABLE Enrollments 
(
	EnrollmentID INT PRIMARY KEY IDENTITY(1,1),
	StudentId INT,
	CourseId INT,
	EnrollmentDate DATE NOT NULL,
	FOREIGN KEY (StudentId) REFERENCES Students(StudentId),
	FOREIGN KEY (CourseId) REFERENCES Courses(CourseId)
)
END

SELECT * FROM Students
SELECT * FROM Courses
SELECT * FROM Enrollments


