--TASK 1
--SELECT *
--FROM Student
--WHERE FirstName LIKE 'antonio'
----TASK 2
--SELECT *
--FROM Student
--WHERE DateOfBirth > '1999-01-01'
----TASK 3
--SELECT *
--FROM Student
--WHERE LastName LIKE 'J%'
--	AND EnrolledDate >= '1999-01-01'
--	AND EnrolledDate <= '1999-01-31'
------TASK 4
--SELECT *
--FROM Student
--ORDER BY FirstName ASC
----TASK5
--SELECT LastName
--FROM Teacher
--UNION
--SELECT LastName
--FROM Student
--ORDER BY LastName
-------TASK 5
--SELECT t.FirstName,t.LastName,g.Grade
--FROM Teacher t
--LEFT OUTER JOIN Grade g ON t.ID = g.TeacherID
--WHERE g.Grade IS NULL
