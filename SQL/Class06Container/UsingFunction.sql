--Select dbo.fn_FormatProductName(18) as ProductName


select * , dbo.fn_FormatProductName(Id) as ProductFunctionName
from Products
where Price <= 100