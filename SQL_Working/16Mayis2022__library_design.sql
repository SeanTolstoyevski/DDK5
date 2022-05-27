--a Üyeler kütüphaneden belirlenen sayıda kitabı alabilecek, belirlenen zamanda kitabı bırakabilecek ve cezaya tabi tutulabilecek
--her üye 3 kitap alabilir. bir kitap 7 gün içerisinde teslim edilmeldir..

create table Uye
(
    ID int PRIMARY KEY IDENTITY (1, 1),
    Ad NVARCHAR(MAX),
    Soyad NVARCHAR(MAX),
)

CREATE table Kitap
(
    ID int PRIMARY KEY IDENTITY(1,1),
    Ad NVARCHAR(MAX),
    YayinlanmaTarih DATE
    AvailableStocks int, 
)



    CREATE table BookUser
    (
        userID int,
        BookID int
        deliveryDate DATE,
    lastDate DATE
    isReturn boolean
)
