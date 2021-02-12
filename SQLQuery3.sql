select ProductName, SUM( od.Quantity*od.UnitPrice) as KazanılanToplamMiktar from Products as p 
inner join [Order Details] as od
on p.ProductID=od.ProductID
inner join orders as o
on o.OrderID=od.OrderID
group by ProductName 