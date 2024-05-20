--SELECT * FROM Employees
--where FirstName = 'Goran'

--Select * From [dbo].Employees
--where LastName LIKE 'S%'

--Select * from Employees
--where DateOfBirth > '1988-01-01'

--Select * from Employees
--where Gender = 'M'
----where Gender <> 'F'



--Select * from Employees
--where HireDate >= '1998-01-01' AND HireDate <= '1988-01-31'

--Select * from Employees
--Where HireDate >= '2019-01-01'
--	And HireDate <= '2019-01-31'
--	And LastName LIke 'A%'

--Select * from Employees
--where FirstName = 'Aleksandar'
--Order by LastName asc

--Select * from Employees
--Order by FirstName,LastName asc

--Select * from Employees
--Where Gender = 'M' 
--Order by HireDate desc  

--Select Region from BusinessEntities
--intersect
--Select RegionName from Customers where IsActive = 1

Select Region from BusinessEntities
union
Select RegionName from Customers where IsActive = 1
