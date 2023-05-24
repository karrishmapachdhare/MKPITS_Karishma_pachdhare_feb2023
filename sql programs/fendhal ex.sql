create table ProductGstDetails(Product_Gst_Id int primary key,Gst_Detail_Name varchar(500),CGST decimal,SGST decimal,IGST decimal)
insert into ProductGstDetails values(601,'AC and Fridge',14,14,14)
insert into ProductGstDetails values(602,'Computer',9,9,9)
insert into ProductGstDetails values(603,'Printers',9,9,9)
insert into ProductGstDetails values(604,'Moblies',6,6,6)


create table ProductCategory(Product_Category_Id int primary key,Product_type_Name varchar(500),Product_Gst_id int constraint c1 foreign key(Product_Gst_Id)
references ProductGstDetails(Product_Gst_Id))
insert into ProductCategory values(1001,'Computers',602)
insert into ProductCategory values(1002,'Moblie',604)
insert into ProductCategory values(1003,'Printers',603)
insert into ProductCategory values(1004,'AC and Fridge',601)


create table Products(Product_Id int primary key,ProductTypeId int constraint c5 foreign key(ProductTypeId)references
ProductCategory(Product_Category_Id)
,Product_Name varchar(500),price int)
insert into products values(210,1002,'Apple',40000)
insert into products values(211,1002,'Lenevo',25000)
insert into products values(212,1003,'Samsang',50000)
insert into products values(213,1004,'IFB',20000)
insert into products values(214,1004,'LG',30000)
insert into products values(215,1001,'Sony',60000)


create table InvoiceDetails(Invoice_Detail_Id int primary key,Customer_Name varchar(500),Customer_Contact varchar(15),Product_Category_Id int constraint c3
foreign key(Product_Category_Id)references ProductCategory(Product_Category_Id),Product_Id int constraint c4 foreign key(Product_Id)references
Products(Product_Id),Residential_Type_Id int,Invoice_Date datetime,Quantity decimal,Price decimal,CGST decimal,SGST decimal,IGST decimal,
CGST_Value decimal,SGST_Value decimal,IGST_Value decimal,Total_Amount decimal)

insert into InvoiceDetails values (1,'Rahul','9185783214',1002,210,3001,'2023-04-04 00:00:00:000',1,50000,6,6,12,3000,3000,6000,56000)

insert into InvoiceDetails values(12,'Nikita','7841824986',1001,211,3002,'2023-04-08 00:00:00:000',1,65000,9,9,18,11700,5850,5850,76700)

insert into InvoiceDetails values(13,'Gopal','1234567890',1001,215,3003,'2023-04-12 00:00:00:000',1,60000,9,9,18,5400,5400,10800,70800)

insert into InvoiceDetails values(14,'Anand','7387872895',1002,210,3004,'2023-04-14 00:00:00:000',1,40000,6,6,6,2400,2400,2400,42400)


select*from ProductGstDetails
select*from  ProductCategory
select*from Products
select*from InvoiceDetails

create table InvoiceDetails1(Invoice_Detail_Id int primary key identity,Customer_Name varchar(500),
Customer_Contact varchar(15),Product_Category_Id int constraint l1
foreign key(Product_Category_Id)references ProductCategory(Product_Category_Id),
Product_Id int constraint l2 foreign key(Product_Id)references
Products(Product_Id),Residential_Type_Id int,Invoice_Date datetime,Quantity decimal,
Price decimal,CGST decimal,SGST decimal,IGST decimal,
CGST_Value decimal,SGST_Value decimal,IGST_Value decimal,Total_Amount decimal)

insert into InvoiceDetails1 values (1,'Rahul','9185783214',1002,210,3001,'2023-04-04 00:00:00:000',1,50000,6,6,12,3000,3000,6000,56000)

insert into InvoiceDetails1 values(12,'Nikita','7841824986',1001,211,3002,'2023-04-08 00:00:00:000',1,65000,9,9,18,11700,5850,5850,76700)

insert into InvoiceDetails1 values(13,'Gopal','1234567890',1001,215,3003,'2023-04-12 00:00:00:000',1,60000,9,9,18,5400,5400,10800,70800)

insert into InvoiceDetails1 values(14,'Anand','7387872895',1002,210,3004,'2023-04-14 00:00:00:000',1,40000,6,6,6,2400,2400,2400,42400)
select*from InvoiceDetails1
