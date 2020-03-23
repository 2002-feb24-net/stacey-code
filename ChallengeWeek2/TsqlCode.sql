
/*Stacey Joseph
Revature Training
coding challenge for week 2 
T-SQL file /c/Revature/ChallengeWeek2/TsqlCode.sql
*/


--create or re-creat the Products table
DROP table Products;
CREATE TABLE Products (
	ID INT NOT NULL PRIMARY KEY IDENTITY,
    Name VARCHAR(50),
	Price NUMERIC NOT NULL
);

--create or recreate the Customers table
DROP TABLE Customers;
CREATE TABLE Customers (
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	Firstname varchar(50) NOT NULL ,
	Lastname varchar(50) NOT NULL ,
    CardNumber VARCHAR(16)
);

--create or re-create the Orders table
DROP TABLE Orders;
CREATE TABLE Orders (
	ID INT NOT NULL,
	ProductID INT NOT NULL FOREIGN KEY REFERENCES Products(ID),
    CustomerID INT NOT NULL FOREIGN KEY REFERENCES Customers(ID)
);

--populate the Products, Customers, and Orders Table respectively. 
--Note: Orders depend on ProductID and CustomerID
--shows all columns of each table after insertion
INSERT INTO Products (Name, Price) VALUES
	('Laptop', 4000.00), ('Desktop', 700.50), ('Monitor', 200.00);
SELECT *
FROM Products;
----------------------------------------------------------------------
INSERT INTO Customers (Firstname, Lastname) VALUES
    ('Stacey', 'Joseph'), ('Derrell', 'Brown'), ('Demon', 'Stration');
SELECT *
FROM Customers;
----------------------------------------------------------------------	
INSERT INTO Orders (ID, ProductID, CustomerID) VALUES
	(111, 1, 1), (222, 2, 1), (333, 3, 3);
SELECT *
FROM Orders;
-----------------------------------------------------------------------

--add product iPhone priced at $200
INSERT INTO Products (Name, Price) VALUES
	('iPhone', 200.00);

--added customer Tina Smith
INSERT INTO Customers (Firstname, Lastname) VALUES
    ('Tina', 'Smith');

--report all orders by Tina Smith
SELECT *
FROM Orders AS o
WHERE ID = (Select ID FROM Customers AS c WHERE Firstname = 'Tina' AND Lastname = 'Smith');


--report all revenue generated by sales of iPhone
SELECT SUM(Price) 
FROM Products 
WHERE Name = 'iPhone';

--increase the price of iPhone to $250 and show all products after increase.
UPDATE Products 
SET Price = 250.00 
WHERE Name = 'iPhone';
SELECT *
FROM Products;