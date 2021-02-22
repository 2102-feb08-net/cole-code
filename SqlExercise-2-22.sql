--Create Schema and tables for Exercise

CREATE SCHEMA Exercise;
GO

-- Code Below Creates Various Tables

create table Exercise.Product (

	Id int not null Identity(1,1) Primary Key,

	Name nvarchar(50) not null,

	Price money not null,


)

drop table Exercise.Orders

create table Exercise.Orders (

	Id int not null Identity(1,1) Primary Key,

	ProductId int not null,

	CustomerId int not null,


)


create table Exercise.Customer(

	Id int not null Identity(1,1) Primary Key,

	FirstName nvarchar(50) not null,

	LastName nvarchar(50) not null,

	CardNumber nvarchar(25) not null,


)

--Add Foreign Key Constraints 

ALTER TABLE Exercise.Orders
ADD FOREIGN KEY (ProductId) REFERENCES Exercise.Product(Id)

ALTER TABLE Exercise.Orders
ADD FOREIGN KEY (CustomerId) REFERENCES Excercise.Customer(Id)

-- Inserting three values into each table.

Insert into Exercise.Customer (FirstName,LastName,CardNumber) 
Values
('Brent','Trimmer','104110341021020'),
('Rick','Ash','20411042521020'),
('Al','Wopton','23451043451021020'),
('Mary','oLeery','104248410213425020'),
('Trent','Shack','102435213452345020'),
('Carl','Tron','10423402190798020')

Insert into Exercise.Product (Name, Price) 
Values
('iPhone',200),
('Hat',10.00),
('Nike Hoodie',20.25),
('T-Shirt',15.25),
('Ugly Christmas Sweater',50)

Insert into Exercise.Orders (ProductId,CustomerId) 
Values
 (5,7),
 (1,2),
 (2,1),
 (3,1),
 (3,2),
 (3,3)

 Insert into Exercise.Orders (ProductId,CustomerId) 
Values
 (1,7),
 (2,7),
 (4,7)



Insert into Exercise.Customer(FirstName,LastName,CardNumber) values
('Tina','Smith','190938401284802')

--Commadn to find orders by Tina Smith

SELECT *
FROM Exercise.Orders as o
INNER JOIN Exercise.Customer as c
ON o.CustomerId = c.id
Where c.FirstName = 'Tina' And c.LAstName = 'Smith'

--Change the price of the product

UPDATE Exercise.Product
SET Price = 250
WHERE Name = 'iPhone'

--Revenue generated from Iphone

SELECT * 
FROM Exercise.Orders as o
INNER JOIN Exercise.Product as p 
ON o.CustomerId = p.id
Where p.Name = 'iPhone'