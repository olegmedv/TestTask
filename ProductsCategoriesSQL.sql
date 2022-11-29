IF EXISTS (select * from sys.databases where name = 'ProductsCategoriesDB')
BEGIN 
    DROP DATABASE ProductsCategoriesDB
    PRINT 'DROP DATABASE ProductsCategoriesDB'
END
    CREATE DATABASE ProductsCategoriesDB;
    PRINT 'CREATE DATABASE ProductsCategoriesDB'

GO
USE ProductsCategoriesDB

CREATE TABLE Products
(
	Id INT PRIMARY KEY IDENTITY,
	ProductName NVARCHAR(100)
)

CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY,
	CategoryName NVARCHAR(100)
)

CREATE TABLE ProductCategory
(
	Id INT PRIMARY KEY IDENTITY,
  ProductId INT,
  CategoryId INT,
  CONSTRAINT FK_Products_To_Categories FOREIGN KEY (ProductId)  REFERENCES Products (Id),
  CONSTRAINT FK_Categories_To_Products FOREIGN KEY (CategoryId)  REFERENCES Categories (Id)
)

INSERT INTO Products (ProductName) 
VALUES 
('product1'),
('product2'),
('product3'),
('product4')

INSERT INTO Categories (CategoryName) 
VALUES 
('category1'),
('category2'),
('category3'),
('category4')

INSERT INTO ProductCategory (ProductId, CategoryId) 
VALUES 
(1, 1),
(1, 2),
(1, 3),
(2, 1),
(2, 2),
(2, 3),
(4, 1),
(4, 2),
(4, 3)

SELECT
  Products.ProductName
 ,Categories.CategoryName
FROM dbo.Products
LEFT OUTER JOIN dbo.ProductCategory
  ON Products.Id = ProductCategory.ProductId
LEFT OUTER JOIN dbo.Categories
  ON ProductCategory.CategoryId = Categories.Id
