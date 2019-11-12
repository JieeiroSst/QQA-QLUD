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
	UserId int,

	Primary key(EmployeeID)
)
create table Customers(
	CustomerID int not null IDENTITY(1,1),
	Name nvarchar(50),
	Address nvarchar(50),
	Phone nvarchar(13),
	UserID int,

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
create table _User(
	UserID int not null IDENTITY(1,1),
	UserName varchar(20),
	Password varchar(50),
	RoleId int
)
create table RoleForm(
	RoleFormID int not null IDENTITY(1,1),
	RoleId int,
	FormId int,
	Access bit,
	_Insert bit,
	_Delete bit,
	_Update bit,
	_Print bit,
	Import bit,
	Export int
)
insert Roles values( 'Quản trị', 'ADMIN')
insert Roles values( 'Nhân viên', 'EMPLOYEE')
insert Roles values( 'Khách hàng', 'USER')

insert _User values('quang123', '123456', '1')
/*
Tự thêm vào tài khoản
insert _User values('quang123', '123456', '1')
insert _User values('quang123', '123456', '1')
*/

insert into Suppliers(SupplierName, Address, Phone) 
values()


insert into Categories(CategoryName, Description)
values(N'Điện gia dụng', N'Vật dụng điện dùng trong gia đình')
insert into Categories(CategoryName, Description)
values(N'Thiết bị số - Phụ kiện số', N'Phụ kiện cho thiết bị điện tử')
insert into Categories(CategoryName, Description)
values(N'Điện tử - Điện lạnh', N'Điện tử - Điện lạnh')
insert into Categories(CategoryName, Description)
values(N'Nhà cửa - Đời sông', N'đồ gia dụng, và các vật dụng cho gia đình')
insert into Categories(CategoryName, Description)
values(N'Hàng tiêu dùng - Thực phẩm', N'Hàng tiêu dùng - Thực phẩm')
insert into Categories(CategoryName, Description)
values(N'Máy ảnh - Máy quay phim', N'Máy ảnh - Máy quay phim')
/*
insert into Products( ProductName,QuantitysPerUnit, Price, UnitsInStock, UnitsInOrder, Img, Description, CategoryID, SupplierID, Phone ) 
values()*/

