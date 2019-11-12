if db_id('ShopOnline') is not null
drop  database ShopOnline
go
create database ShopOnline
go
use ShopOnline
create table Locations(
	LocationId int not null IDENTITY(1,1),
	LocationName nvarchar(50),
	Phone nvarchar(13),
	Address nvarchar(50),
)
create table Suppliers(
	SupplierID int not null IDENTITY(1,1),
	SupplierName nvarchar(50),
	Address nvarchar(50),
	Phone nvarchar(13),
	
	Primary key(SupplierID) 
)
create table Categories(
	CategoryID int not null IDENTITY(1,1),
	CategoryName nvarchar(50),
	Description nvarchar(255),
	Img varchar(100),
	primary key(CategoryID)
)

create table Products(
	ProductID int not null IDENTITY(1,1),
	ProductName nvarchar(50),
	QuantitysPerUnit nvarchar(50),
	Price float,
	UnitsInStock int,
	UnitsInOrder int,
	Img varchar(100),
	Description nvarchar(255),
	CategoryID int,
	SupplierID int,
	Phone nvarchar(13),

	primary key(ProductID),
)
create table Roles(
	RoleID int not null IDENTITY(1,1),
	RoleName nvarchar(50),
	RoleCode nvarchar(20),

	primary key(RoleID)
)
create table Employees(
	EmployeeID int not null IDENTITY(1,1),
	Name nvarchar(50),
	Address nvarchar(50),
	Phone nvarchar(13),
	RoleID int,

	Primary key(EmployeeID),
)
create table Customers(
	CustomerID int not null IDENTITY(1,1),
	Name nvarchar(50),
	Address nvarchar(50),
	Phone nvarchar(13),

	Primary key(CustomerID)
)
create table Carts(
	CartID int not null IDENTITY(1,1),
	Subtotal float,
	Vat float,
	Discount float,
	CreatedDate datetime,
	EmployeeID int,
	CustomerID int,
	Description nvarchar(255),

	primary key(CartID),
)
create table CartDetails(
	ProductID int,
	CartID int, 
	Quantity int,
	Description nvarchar(255),

	Primary key(ProductID, CartID),
)
create table Orders(
	OrderID int not null IDENTITY(1,1),
	GrandTotal float,
	Description nvarchar(255),
)