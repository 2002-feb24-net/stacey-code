CREATE TABLE Products (
	ID INT NOT NULL PRIMARY KEY IDENTITY,
    Name VARCHAR(50),
	Price NUMERIC NOT NULL
);

CREATE TABLE Orders (
	ID INT NOT NULL,
	ProductID INT NOT NULL FOREIGN KEY REFERENCES Products(ID),
    CustomerID INT NOT NULL FOREIGN KEY REFERENCES Customers(ID)
)

CREATE TABLE Customers (
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	Firstname INT NOT NULL FOREIGN KEY REFERENCES Student (Id),
	Lastname INT NOT NULL FOREIGN KEY REFERENCES Class (Id),
    CardNumber VARCHAR(16)
);

INSERT INTO Products (Name, Price) VALUES
	('Laptop', 4000.00), ('Desktop', 700.50), ('Monitor', 200.00);
	
INSERT INTO Orders (ID) VALUES
	(111), (222), (333);

INSERT INTO Customers (Firstname, Lastname) VALUES
    ('Stacey', 'Joseph'), ('Derrell', 'Brown'), ('Demon', 'Stration');

INSERT INTO Products (Name, Price) VALUES
	('iPhone', 200.00);

INSERT INTO Customers (Firstname, Lastname) VALUES
    ('Tina', 'Smith');

SELECT *
FROM Orders AS o
WHERE ID = (Select ID FROM Customers AS c WHERE Firstname = 'Tina' AND Lastname = 'Smith');

SELECT SUM(Price) FROM Products WHERE Name = 'iPhone';

UPDATE Products 
SET Price = 250.00 
WHERE Name = 'iPhone';