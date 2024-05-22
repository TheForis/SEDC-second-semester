--Select be.Id, be.Name, sum(o.TotalPrice) 
--from Orders o
--inner join BusinessEntities be
--on o.BusinessEntityId = be.Id
--group by be.Id, be.Name, be.Region
--having sum(o.TotalPrice) >= 635558


--select BusinessEntityId ,be.Name , CustomerId,c.Name ,sum(o.TotalPrice)
--from Orders o
--inner join BusinessEntities be
--on o.BusinessEntityId = be.Id
--inner join Customers c
--on o.CustomerId = c.Id
--where CustomerId < 20
--group by BusinessEntityId ,be.Name, CustomerId, c.Name
--having sum(o.TotalPrice) < 100000



select be.Id, be.Name , max(o.TotalPrice), avg(o.TotalPrice)
from Orders o
inner join BusinessEntities be
on be.Id = o.BusinessEntityId
group by be.Id, be.Name
having sum(o.TotalPrice) > (4*avg(o.TotalPrice))

