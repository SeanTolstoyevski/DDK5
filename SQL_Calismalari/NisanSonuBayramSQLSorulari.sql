-- 1. urunleri ada gore sirala:
select * from Products order by ProductName

-- 2. urunleri ada gore tersten sirala:
select * from Products order by ProductName desc

-- 3. urun fiyati 20'den buyuk ve kageri id'si 3 ulanlari sirala:
select * from Products  where UnitPrice > 20 and CategoryID = 3

-- 4. en pahali 5 urunu getir:
select top 5 * from Products order by UnitPrice desc

-- 5. en pahali urunun fiyati
select top 1 UnitPrice from Products order by UnitPrice desc

-- 6. en ucuz urunun fiyati:
select top 1 UnitPrice from Products order by UnitPrice

-- 7. en ucuz urunun kdv'li fiyati:
select top 1 UnitPrice * 1.18  from Products order by UnitPrice

-- 8. 1996 yilindaki siparisleri getir:
select * from Orders where year(OrderDate) = 1996

-- 9. 1997 mart ayi siparislerini getir:
select * from Orders where year(OrderDate) = 1996 and Month(OrderDate) = 3

-- 10. 1997 yilinda Londra'ya kac siparis gitti:
select count(*) from Orders where year(OrderDate) = 1996 and lower(ShipCity) = 'london'

-- 11. ProductID'si 5 olan ürünün kategori adi nedir:
select CategoryName from Products  as p inner join Categories as c  on c.ID = p.CategoryID where p.ProductID = 5

-- 12. urün adý ve ürünün kategorisinin adý:
select ProductName, CategoryName from Products  as p inner join Categories as c  on c.ID = p.CategoryID

-- 13. urünün adý, kategorisinin adý ve tedarikçisinin adý:
select ProductName, CategoryName, CompanyName from Products  as p inner join Categories as c   on c.ID = p.CategoryID inner join Suppliers as s   on s.SupplierID = p.SupplierID

-- 14. siparisi alan personelin adi, soyadi, siparis tarihi (siralama):
select Firstname, LastName, OrderDate from Orders inner join Employees as em on em.EmployeeID = Orders.EmployeeID order by OrderDate 

-- 15. son 5 siparisin ort. fiyati nedir:
select top 5 avg(UnitPrice * Quantity) from Orders as o inner join [Order Details] as od on o.OrderID = od.OrderID group by o.OrderID order by o.OrderID desc

-- 16. Ocak ayýnda satýlan ürünlerimin adý ve kategorisinin adý ve toplam satýþ miktarý nedir:
select p.ProductName, c.CategoryName, od.Quantity * od.UnitPrice from Orders  o inner join [Order Details] od on od.OrderID = o.OrderID inner join Products p on p.ProductID = od.ProductID inner join Categories c on c.ID = p.CategoryID where month(o.OrderDate) = 1

-- 17. Hangi personelim hangi personelime rapor veriyor:
select em.EmployeeID ,  e.FirstName, e.LastName  from Employees	e inner join Employees em on e.EmployeeID = em.ReportsTo

-- 18. hangi ulkeden kac musterim var:
select city, count(*) from Customers group by City

-- 19. ortalama satis fiyatimin ustundeki urunler:
select * from [Order Details] where  Quantity > (select  avg(Quantity) from  [Order Details])

-- 20. en cok satilan urunumun adi, kategori adi ve tedarikcisinin adi:
select top 1 ProductName, CategoryName, ContactName from Products p  inner join [Order Details] od on od.ProductID = p.ProductID  inner join Categories c on c.CategoryID = p.CategoryID  inner join Suppliers s on s.SupplierID = p.SupplierID order by od.Quantity desc

-- 21. 10248  numaralý sipariþi alan çalýþanýn adý ve soyadý ve orderid'si:
select e.FirstName, e.LastName ,o.OrderID from Employees e  inner join orders o on o.EmployeeID = e.EmployeeID where o.OrderID = 10248

