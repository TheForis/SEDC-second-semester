------------• Declare scalar variable for storing FirstName values
--DECLARE @FirstName NVARCHAR(100)

------------• Assign value ‘Antonio’ to the FirstName variable
--SELECT @FirstName = 'Antonio'

------------• Find all Students having FirstName same as the variable
--SELECT *
--FROM Student
--WHERE FirstName = @FirstName

----------• Declare table variable that will contain StudentId, StudentName and DateOfBirth
----------• Fill the table variable with all Female students
--DECLARE @FemaleStudentList TABLE (
--	StudentId INT
--	,StudentName NVARCHAR(100)
--	,DateOfBirth DATE
--	)

--INSERT INTO @FemaleStudentList
--SELECT ID
--	,FirstName
--	,DateOfBirth
--FROM Student
--WHERE Gender = 'F'


----------• Declare temp table that will contain LastName and EnrolledDate columns
----------• Fill the temp table with all Male students having First Name starting with ‘A’
--CREATE TABLE #MaleStudentsStartWithA (
--	LastName NVARCHAR(150)
--	,EnrolledDate DATE
--	)

--INSERT INTO #MaleStudentsStartWithA
--SELECT LastName
--	,EnrolledDate
--FROM Student
--WHERE Gender = 'M'
--	AND Left(FirstName, 1) = 'A'
--SELECT *
--FROM #MaleStudentsStartWithA

------------• Retrieve the students from the table which last name is with 7 characters
--SELECT *
--FROM #MaleStudentsStartWithA
--WHERE Len(LastName) = 7


----------• Find all teachers whose FirstName length is less than 5 and
----------• the first 3 characters of their FirstName and LastName are the same
SELECT *
FROM Teacher
WHERE len(FirstName) < 5
	AND LEFT(FirstName, 3) = LEFT(LastName, 3)

