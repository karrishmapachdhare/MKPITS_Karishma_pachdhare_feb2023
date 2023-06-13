create database TrustDB
use TrustDB
--------------------------[TABLE Item_Master]-------------------------------------


create table Item_master(Item_id  int primary key ,Item_name varchar(50) not null,Category int,Rate int,Balance_quantity int not null)


create table Department_mast(Department_id int primary key identity,Department_name varchar(500) not null)


create table Vendor_mast(Vendor_id int primary key identity,Vendor_name varchar(500) not null)


create table Transaction_details(Transaction_id int primary key identity,Item_id int constraint c1 foreign key(Item_id) references
Item_master(Item_id),TransactionDate DateTime not null ,
Department_id int constraint c2 foreign key(Department_id) references
Department_mast(Department_id),Vendor_id int constraint c3 foreign key(Vendor_id)references Vendor_mast(Vendor_id),Quantity int not null)







