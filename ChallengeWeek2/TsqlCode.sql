
drop table Products;
CREATE TABLE Products (
	ID INT NOT NULL PRIMARY KEY IDENTITY,
    Name VARCHAR(50),
	Price NUMERIC NOT NULL
);

drop table Customers;
CREATE TABLE Customers (
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	Firstname varchar(50) NOT NULL ,
	Lastname varchar(50) NOT NULL ,
    CardNumber VARCHAR(16)
);

drop table Orders;
CREATE TABLE Orders (
	ID INT NOT NULL,
	ProductID INT NOT NULL FOREIGN KEY REFERENCES Products(ID),
    CustomerID INT NOT NULL FOREIGN KEY REFERENCES Customers(ID)
);
INSERT INTO Products (Name, Price) VALUES
	('Laptop', 4000.00), ('Desktop', 700.50), ('Monitor', 200.00);
select *
from Products;

INSERT INTO Customers (Firstname, Lastname) VALUES
    ('Stacey', 'Joseph'), ('Derrell', 'Brown'), ('Demon', 'Stration');
select *
from Customers;
	
INSERT INTO Orders (ID, ProductID, CustomerID) VALUES
	(111, 1, 1), (222, 2, 1), (333, 3, 3);



INSERT INTO Products (Name, Price) VALUES
	('iPhone', 200.00);

INSERT INTO Customers (Firstname, Lastname) VALUES
    ('Tina', 'Smith');

SELECT *
FROM Orders AS o
WHERE ID = (Select ID FROM Customers AS c WHERE Firstname = 'Tina' AND Lastname = 'Smith');

SELECT SUM(Price) 
FROM Products 
WHERE Name = 'iPhone';

UPDATE Products 
SET Price = 250.00 
WHERE Name = 'iPhone';
select *
from Products;