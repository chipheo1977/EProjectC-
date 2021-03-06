create database jwellery
go
use jwellery
go

create table AdminloginMst
(
	userName varchar(50) primary key,
	Password varchar(50) not null 
)
go
insert into AdminloginMst values('admin', '1234')

create table BrandMst
(
	Brand_ID varchar(10) primary key,
	Brand_Type varchar(50) not null 
)
go

create table CatMst
(
	Cat_ID varchar(10) primary key,
	Cat_Name varchar(50) not null
)
go

Create table CertifyMst
(
	Certify_ID varchar(10) primary key,
	Certify varchar(50) not null
)
go

create table DimQltyMst
(
	DimQly_ID varchar(10) primary key,
	DimQly varchar(10) not null
)
go

create table DimQlySubMst
(
	DimSubType_ID varchar(10) primary key,
	DimQlty varchar(50) not null
)
go

create table ProdMst
(
	Prod_ID varchar(10) primary key,
	Prod_Type varchar(50) not null
)
go

create table GoldKrtMst
(
	GoldType_ID varchar(10) primary key,
	Gold_Crt varchar(50) not null
)
go

create table ItemMst
(
	Style_Code varchar(50) primary key,
	Pairs Numeric(3,0) not null,
	Brand_Id varchar(10) not null,
	Quantity Numeric(18, 0) not null,
	Cat_Id varchar(10),
	Prod_Quality varchar(50) not null,
	Certify_ID varchar(10),
	Prod_ID varchar(10),
	GoldType_ID varchar(10),
	Gold_Wt numeric(10, 3) not null,
	Stone_Wt numeric(10, 2) not null,
	Net_Gold numeric(10, 3) not null,
	Wstg_Per numeric(10, 3) not null,
	Wstg numeric(10, 3) not null,
	Tot_Gross_Wt numeric(10, 3) not null,
	Gold_Rate numeric(10, 2) not null,
	Gold_Amt numeric(10, 2) not null,
	Gold_Making numeric(10, 2) not null,
	Stone_Making numeric(10, 2) not null,
	Other_Making numeric(10, 2) not null,
	Tot_Making numeric(10, 2) not null,
	MRP numeric(10, 2) not null,

	foreign key(Brand_Id) references BrandMst(Brand_Id),
	foreign key(Cat_Id) references CatMst(Cat_Id),
	foreign key(Certify_ID) references CertifyMst(Certify_ID),
	foreign key(Prod_ID) references ProdMst(Prod_ID),
	foreign key(GoldType_ID) references GoldKrtMst(GoldType_ID),
)
go

create table DimMst
(
	Style_Code varchar(50),
	DimQlty_ID varchar(10),
	DimSubType_ID varchar(10),
	Dim_Crt numeric(10, 2) not null,
	Dim_Pcs numeric(10, 2) not null,
	Dim_Gm numeric(10, 2) not null,
	Dim_Size numeric(10, 2) not null,
	Dim_Rate numeric(10, 2) not null,
	Dim_Amt numeric(10, 2) not null,

	foreign key(Style_Code) references ItemMst(Style_Code),
	foreign key(DimQlty_ID) references DimQltyMst(DimQly_ID),
	foreign key(DimSubType_ID) references DimQlySubMst(DimSubType_ID),
)
go

create table StoneQltyMst
(
	StoneQlty_ID varchar(10) primary key,
	StoneQlty varchar(50) not null
)
go

create table StoneMst
(
	Style_Code varchar(50),
	StoneQlty_ID varchar(10),
	Stone_Gm numeric(10,2) not null,
	Stone_Pcs numeric(10,2) not null,
	Stone_Crt numeric(10,2) not null,
	Stone_Rate numeric(10,2) not null,
	Stone_Amt numeric(10,2) not null,

	foreign key(Style_Code) references ItemMst(Style_Code),
	foreign key(StoneQlty_ID) references StoneQltyMst(StoneQlty_ID),
)
go

create table UserRegMst
(
	userID varchar(10) primary key,
	userFname text not null,
	userLname text not null,
	address varchar(max) not null,
	city varchar(50) not null,
	state varchar(50) not null,
	mobNo text not null,
	emailID text not null,
	dob nvarchar(50) not null,
	cdate nvarchar(50) not null,
	password varchar(50) not null,
)
go

create table DimInfoMst
(
	DimID varchar(10) primary key,
	DimType varchar(50) not null,
	DimCrt varchar(50) not null,
	DimPrice varchar(50) not null,
	DimImg varchar(50) not null,
)
go

create table Inquiry
(
	ID varchar(10) primary key,
	Name varchar(50) not null,
	City varchar(50) not null,
	Contact varchar(10) not null,
	EmailID varchar(50) not null,
	Comment varchar(max) not null,
	Cdate date not null
)
go

create table JewelTypeMst
(
	ID nchar(10) primary key,
	Jewellery_Type varchar(50) not null
)
go

create table CartList
(
	ID varchar(10) primary key,
	Product_Name varchar(50) not null,
	MRP numeric(10,2) not null
)
go

