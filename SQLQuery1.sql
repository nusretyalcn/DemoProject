CREATE TABLE Colors(

     Id int PRIMARY KEY IDENTITY(1,1),
     ColorName nvarchar(10),

)

CREATE TABLE Brands(

    Id int PRIMARY KEY IDENTITY(1,1),
    BrandName nvarchar(20)

)

CREATE TABLE Cars(

    CarId int PRIMARY KEY IDENTITY(1,1),
    BrandId int,
    ColorId int,
    ModelYear nvarchar (10),
    DailyPrice decimal,
    Descriptions nvarchar(200),
    FOREIGN KEY (ColorId) REFERENCES Colors(Id),
    FOREIGN KEY (BrandId) REFERENCES Brands(Id),

)

INSERT INTO Cars(BrandId,ColorId,ModelYear,DailyPrice,Descriptions) VALUES

(1,1,'2005',270,'Temiz Kiralık Araç'),
(1,1,'2016',480,'Temiz Kiralık Araç'),
(1,1,'2013',600,'Temiz Kiralık Araç'),
(1,1,'2015',510,'Temiz Kiralık Araç');

INSERT INTO Colors(ColorName) VALUES ('Gri'),('Beyaz'),('Siyah'),('Beyaz');
INSERT INTO Brands(BrandName) VALUES ('Wolksvagen'),('Audi'),('Bmw'),('Mercedes');





