CREATE TABLE Student(
    id int PRIMARY KEY IDENTITY (1, 1),
    name VARCHAR(40) not null,
    lastName VARCHAR(40) not null,
    studentNo int NOT NULL,
    email VARCHAR(255),
    phoneNumber VARCHAR(max),
    birthDate DATE not NULL,
    departmentID int not null
)

CREATE table Academician(
    id int PRIMARY KEY IDENTITY(1, 1),
    name VARCHAR(40),
    lastName VARCHAR(40)
)

CREATE TABLE Department(
    id int PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(1000),
    establishmentDate DATE not null,
    facultyID int not null
)

create table Faculty(
    id int PRIMARY KEY IDENTITY(1,1),
    name varchar(1000)
)

create table AcademicianDepartment(
    AcademicianID int not NULL,
    departmentID int not NULL
)


-- Öğrenci Ad, Soyad, Bölüm Ad, Fakülte Ad
select s.name, s.lastName, (d.name) ['Department Name'], (f.name) ['Faculty Name'] from Student  s
inner join Department d on d.id  = s.departmentID
inner join Faculty f on f.id = d.facultyID


-- Eğitmen Ad, Bölüm Ad
select a.name, a.lastName, (d.name) ['Department Name] from AcademicianDepartment ad
inner join Academician a on a.id = ad.AcademicianID
inner join Department d on d.id = ad.departmentID


-- Fen Fakültesindeki EĞİTMENLERİ LİSTELE
select a.name, a.lastName  from AcademicianDepartment ad
inner join Academician a on a.id = ad.academicianID
inner join Department d on d.id = ad.departmentID
inner join Faculty f on f.id = d.facultyID WHERE d.facultyID = 1



