create table order_details1(orderid int,productid int,quntity int primary key(orderid,productid))

insert into order_details1 values(1,11,2);
insert into order_details1 values(2,12,3);
insert into order_details1 values(3,13,4);
insert into order_details1 values(4,14,5);
insert into order_details1 values(5,15,6);
insert into order_details1 values(6,16,7);
insert into order_details1 values(7,17,8);
insert into order_details1 values(8,18,9);
insert into order_details1 values(9,19,10);
insert into order_details1 values(10,20,11);
insert into order_details1 values(11,21,12);
insert into order_details1 values(12,22,13);


select*from order_details1

------------------------unique key--------------------------

create table samples(id int unique,name varchar(20))
insert into samples(name)values('mona')

select *from samples

------------------------------unique key-----------------

create table emp(empid int primary key,empname varchar(20),mobno int unique ,dlno int unique)
insert into emp values(23,'kari',4767,09856)
insert into emp values(24,'tina',2954,0972)
select*from emp

