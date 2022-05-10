# 10 Mayis 2022 Sali - SQL Notlari

## `@@IDENTITY`

Son insert'in ID'sini donduren bir tsql sorgusu.  
global bir degisken gibi calisiyor.

- `delete` ile test edildi. herhangi bir degisiklik yok. yani herhangi bir deger dondurmuyor.
- oturuma ozel olabilir. herhangi bir degisiklik yapilmadiginda bos donuyor.

## `drop`

sql objelerini  siliyor. Procedure gibi.   
fakat `drop_xx` seklinde kullaniliyor. table, procedure gibi.



## Ornek procedure'ler

```tsql
create procedure sp_getProductsCountByPrice(@price money)
as
begin
return (select COUNT(*) from Products where UnitPrice > @price)
end

declare @productCount int
exec @productCount = sp_getProductsCountByPrice 20

select @productCount
```