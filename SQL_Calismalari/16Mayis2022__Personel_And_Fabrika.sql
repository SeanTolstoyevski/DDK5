

create table Fabrika(
    id int PRIMARY KEY IDENTITY(1,1),
    name nvarchar(max),
    location NVARCHAR(max)
)


create table Personel(
    id int PRIMARY key IDENTITY(1,1),
    firstName NVARCHAR(max),
    lastName NVARCHAR(max),
)

create table PersonelLog(
    id int PRIMARY KEY IDENTITY(1,1),
    personelId int,
    inDate DATETIME,
    outDate DATETIME,
    fabrikaId INT
)

