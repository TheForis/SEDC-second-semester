--select * from Customers
--Select * from Orders

--Select* from Customers as C
--full outer join Orders as O


--Select * from Customers as c
--inner join Orders as o
--on c.Id = o.CustomerId

--Select * from Customers as c
--right join Orders as o
--on o.CustomerId = c.Id

--select c.Name, p.Name from Customers as c
--cross join Products as p
--order by c.Name

--select distinct be.Name
--from BusinessEntities as be
--inner join Orders as o
--on be.Id = o.BusinessEntityId

--select distinct be.Name
--from BusinessEntities as be
--left outer join Orders as o
--on be.Id = o.BusinessEntityId
--where o.id is null

--select c.* from Orders o
--right outer join Customers c 
--on c.Id = o.CustomerId
--where o.Id is null

--select Sum(o.TotalPrice) from Orders o

--select COUNT(*) from Customers

--select string_agg([Name], ',')
--From Customers

--Select be.Id, be.Name , Sum(o.TotalPrice)
--from Orders o 
--inner join BusinessEntities be
--on o.BusinessEntityId = be.Id
--group by be.Id , be.Name

--Select be.Id, be.Name , Sum(o.TotalPrice)
--from Orders o 
--inner join BusinessEntities be
--on o.BusinessEntityId = be.Id
--where be.Id <=20
--group by be.Id , be.Name

--select be.Id, be.Name, MAX(o.TotalPrice) as MaxPrice, AVG(o.TotalPrice) as AvgPrice
--from Orders o
--inner join BusinessEntities be
--on o.BusinessEntityId = be.Id
--group by be.Id,be.Name

Select c.Id, c.Name, STRING_AGG(e.FirstName + ' ' + e.LastName , ',')
from Orders o
inner join Customers c
on o.CustomerId = c.Id
inner join Employees e
on o.EmployeeId = e.Id
group by c.Id, c.Name
