

create table Category(
    id int PRIMARY KEY IDENTITY(1,1),
    categoryName NVARCHAR(max),
    ownerCategoryId int
)



select c.categoryName, sc.categoryName from Category c
inner join Category sc on sc.ownerCategoryId = sc.id


