﻿use AdventureWorks2016

--**********************************************************************************************
-- En az 4 tane tabloyu joinleyerek sorguyu getir.
select * from Production.Product as product
inner join Production.ProductModel as modal on product.ProductModelID = modal.ProductModelID
inner join Production.ProductCostHistory as pHistory on product.ProductID = pHistory.ProductID
inner join Production.TransactionHistory ptranHis on product.ProductID = ptranHis.ProductID
inner join Production.ProductInventory pInven on product.ProductID = pInven.ProductID
--**********************************************************************************************

--**********************************************************************************************
-- Fiyatı en pahalı olan ilk 3 fiyatlı ürünler
select Name, ListPrice from Production.Product
where ListPrice in
(select distinct top 3 ListPrice from Production.Product order by ListPrice desc)
--**********************************************************************************************


--**********************************************************************************************
--begin##Left, Right, Full, Cross joinlerin herbiriyle birer örnek yap.

-- left:
select * from Production.Product p 
left join Production.ProductInventory i on p.ProductID = i.ProductID

-- right
select * from Person.Person p 
right join Person.EmailAddress e on p.BusinessEntityID = e.BusinessEntityID

-- full
select * from Person.BusinessEntity b 
full join Sales.Store s on b.BusinessEntityID = s.BusinessEntityID

-- cross
select * from Sales.SalesTerritory st
cross join Sales.SalesTerritoryHistory sth   

--End##
--**********************************************************************************************


--**********************************************************************************************
--hiç sipariş vermemiş müşteriler kimler en az 3 farklı yöntemle yaz

-- left join kullanarak
select * from Sales.Customer c left join
Sales.SalesOrderHeader s on s.CustomerID = c.CustomerID
where s.CustomerID is null


-- not exist
SELECT * FROM Sales.Customer c
where not exists (
select * from Sales.SalesOrderHeader soh
where c.CustomerID = soh.CustomerID
)



-- right
select * from Sales.SalesOrderHeader s  left join
Sales.Customer c on s.CustomerID = c.CustomerID
where s.CustomerID is null


-- full from inner
select *
from Sales.Customer c full join Sales.SalesOrderHeader h 
on c.CustomerID = h.CustomerID
where c.CustomerID not in 
(
select c.CustomerID from Sales.Customer c
inner join Sales.SalesOrderHeader h on c.CustomerID = h.CustomerID
)
--**********************************************************************************************

--Self join nedir araştır! Mantığını araştır








--**********************************************************************************************
--fiyatı en pahalı olan ürünün rengindeki bütün ürünler MAX ile

select distinct Color,ListPrice from Production.Product 
where ListPrice in( 
select  max(ListPrice) from Production.Product group by Color
)
order by ListPrice desc
--**********************************************************************************************