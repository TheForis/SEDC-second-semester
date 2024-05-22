--Declare @Name Nvarchar(100)
--Set @Name = 'Aleksandar'

--Select *
--From Employees
--Where FirstName = @Name

--Declare @FemaleEmployees Table (EmployeeId int, DateOfBirth date)
--insert into @FemaleEmployees
--Select Id, DateOfBirth
--From Employees
--where Gender = 'F'


--select * from @FemaleEmployees


Create table #TempEmployeeTable (LastName nvarchar(100), HireDate Date)
insert into #TempEmployeeTable
Select LastName, HireDate 
from Employees
where Left (FirstName,1) = 'A'  and Gender = 'M'

select * from #TempEmployeeTable

drop table #TempEmployeeTable

