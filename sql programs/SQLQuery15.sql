create table order_details2(orderid
int,productid int,
quantity int,primary key(orderid,productid))

insert into order_details1 values(3,11,2);
insert into order_details1 values(1,12,2);
insert into order_details1 values(1,13,3);
insert into order_details1 values(2,14,2);
select*from order_details1


create table employee(empid int primary
key,empname varchar(20),
passportno int,drivinglicenceno int,
constraint e1
unique(passportno,drivinglicenceno))
insert into employee
values(1,'jayesh',12345,98989)
insert into employee
values(3,'jayesh',22345,9899)

select * from employee


create table emp2(empid int primary key,empname
varchar(20),
pno int unique,dlno int unique)

insert into emp values(1,'anand',111,222)
insert into emp values(2,'anand',112,223)
select*from emp

create table customer2(custid int primary key
identity,
custname varchar(50))

insert into customer2 values('raj')
select * from customer2
insert into customer2 values('rajesh')
insert into customer2 values('karishma')
insert into customer2 values('rani')
insert into customer2 values('khushboo')
select * from customer2