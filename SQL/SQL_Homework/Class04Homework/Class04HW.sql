--------● Calculate the count of all grades per Teacher in the system
--SELECT t.ID
--	,t.FirstName
--	,t.LastName
--	,COUNT(g.Grade) AS GradeCount
--FROM Grade g
--INNER JOIN Teacher t ON g.TeacherID = t.ID
--GROUP BY t.ID
--	,t.FirstName
--	,t.LastName
--ORDER BY COUNT(g.Grade) DESC


------● Calculate the count of all grades per Teacher in the system for first 100
------Students (ID < 100)
--SELECT t.FirstName
--	,t.LastName
--	,COUNT(g.Grade) AS GradeCount
--FROM Grade g
--INNER JOIN Teacher t ON g.TeacherID = t.ID
--INNER JOIN Student s ON g.StudentID = s.ID
--WHERE s.ID < 100
--GROUP BY t.FirstName
--	,t.LastName
--ORDER BY COUNT(g.Grade) DESC


------● Find the Maximal Grade, and the Average Grade per Student on all grades in
------the system
--SELECT s.ID
--	,s.FirstName
--	,s.LastName
--	,max(g.Grade) AS HighestGrade
--	,AVG(g.Grade) AS AverageGrade
--FROM Grade g
--INNER JOIN Student s ON g.StudentID = s.ID
--GROUP BY s.ID
--	,s.FirstName
--	,s.LastName


------● Calculate the count of all grades per Teacher in the system and filter only
------grade count greater then 200
--SELECT t.ID
--	,t.FirstName
--	,t.LastName
--	,COUNT(g.Grade) as GradeCount
--FROM Grade g
--INNER JOIN Teacher t ON g.TeacherID = t.ID
--GROUP BY t.ID
--	,t.FirstName
--	,t.LastName
--	having COUNT(g.Grade) > 200


	------● Find the Grade Count, Maximal Grade, and the Average Grade per Student on
	------all grades in the system. Filter only records where Maximal Grade is equal to
	------Average Grade

--SELECT s.ID
--	,s.FirstName
--	,s.LastName
--	,max(g.Grade) AS HighestGrade
--	,AVG(g.Grade) AS AverageGrade
--	,COUNT(g.Grade) AS GradeCount
--FROM Grade g
--INNER JOIN Student s ON g.StudentID = s.ID
--GROUP BY s.ID
--	,s.FirstName
--	,s.LastName
--HAVING max(g.Grade) = AVG(g.Grade)

	------● List Student First Name and Last Name next to the other details from previous
	------query  ALREADY DONE!!

	------● Create new view (vv_StudentGrades) that will List all StudentIds and count of
	------Grades per student
--CREATE VIEW vv_StudentGrades
--AS
--SELECT s.ID
--	,COUNT(g.Grade) AS GradeCount
--FROM Grade g
--INNER JOIN Student s ON g.StudentID = s.ID
--GROUP BY s.ID


	------● Change the view to show Student First and Last Names instead of StudentID

--ALTER VIEW vv_StudentGrades
--AS
--SELECT s.FirstName
--	,s.LastName
--	,COUNT(g.Grade) AS GradeCount
--FROM Grade g
--INNER JOIN Student s ON g.StudentID = s.ID
--GROUP BY s.ID
--	,s.FirstName
--	,s.LastName

	------● List all rows from view ordered by biggest Grade Count

--	SELECT *
--FROM vv_StudentGrades
--ORDER BY GradeCount DESC

