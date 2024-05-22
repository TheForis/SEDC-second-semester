--select *
--from Orders o
--right outer join Employees e
--on o.CustomerId = e.Id
--where o.Id is null

--Select *
--from Employees e
--left outer join Orders o
--on o.CustomerId = e.Id

Select e.Id,e.FirstName,e.LastName, AVG(o.TotalPrice) as 'Average Sale',Count(o.Id) as [Count]
from Orders o
inner join Employees e
on o.EmployeeId = e.Id
group by e.Id, e.FirstName, e.LastName
Having AVG(o.TotalPrice) >= 2000 And Count(o.Id) >= 50



