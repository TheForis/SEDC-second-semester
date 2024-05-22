--alter view vv_CustomerOrders
--as
--Select c.Id, c.Name, sum(TotalPrice) as TotalPrice
--from Orders o
--inner join Customers c
--on o.CustomerId = c.Id
--group by c.Id, c.Name

--select * from vv_CustomerOrders
----order by TotalPrice desc
--create view vv_EmployeeOrders
--as
--select e.Id as EmployeeId, e.FirstName, e.LastName , p.Id as ProductId , p.Name, SUM(od.Quantity) as TotalQuantitySold
--From Orders o
--inner join Employees e on e.Id = o.EmployeeId
--inner join OrderDetails od on od.OrderId = o.Id
--inner join Products p on od.ProductId = p.Id
--group by e.Id, e.FirstName, e.LastName , p.Id , p.Name

--select e.Id as EmployeeId, e.FirstName, e.LastName , p.Id as ProductId , p.Name, SUM(od.Quantity) as TotalQuantitySold
--From Orders o
--inner join Employees e on e.Id = o.EmployeeId
--inner join OrderDetails od on od.OrderId = o.Id
--inner join Products p on od.ProductId = p.Id
--inner join BusinessEntities be on o.BusinessEntityId = be.Id
--where be.Region = 'Skopski'
--group by e.Id, e.FirstName, e.LastName , p.Id , p.Name

select * from vv_EmployeeOrders
