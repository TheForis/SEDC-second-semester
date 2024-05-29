CREATE PROCEDURE sp_CreateGrade (
	@StudentID INT
	,@CourseID INT
	,@TeacherID INT
	,@Grade INT
	,@Comment NVARCHAR(200)
	)
AS
BEGIN
	INSERT INTO [dbo].[Grade] (
		[StudentID]
		,[CourseID]
		,[TeacherID]
		,[Grade]
		,[Comment]
		,[CreatedDate]
		)
	VALUES (
		@StudentID
		,@CourseID
		,@TeacherID
		,@Grade
		,@Comment
		,GETDATE()
		)

	SELECT s.FirstName
		,s.LastName
		,COUNT(g.Grade) AS TotalGrades
	FROM Grade g
	INNER JOIN Student s ON g.StudentID = s.ID
	WHERE g.StudentID = @StudentID
	GROUP BY s.FirstName
		,s.LastName

	BEGIN
		WITH StudentGrades
		AS (
			SELECT s.FirstName AS StudentFirstName
				,s.LastName AS StudentLastName
				,MAX(g.Grade) AS StudentHighestGrade
			FROM Grade g
			INNER JOIN Student s ON g.StudentID = s.ID
			WHERE g.StudentID = @StudentID
			GROUP BY s.FirstName
				,s.LastName
			)
			,TeacherGrades
		AS (
			SELECT t.FirstName AS TeacherFirstName
				,t.LastName AS TeacherLastName
				,MAX(g.Grade) AS TeacherHighestGrade
			FROM Grade g
			INNER JOIN Teacher t ON g.TeacherID = t.ID
			WHERE g.TeacherID = @TeacherID
			GROUP BY t.FirstName
				,t.LastName
			)
		SELECT StudentFirstName
			,StudentLastName
			,StudentHighestGrade
			,TeacherFirstName AS TeacherFirstName
			,TeacherLastName AS TeacherLastName
			,TeacherHighestGrade AS TeacherHighestGrade
		FROM StudentGrades
			,TeacherGrades
	END
END
