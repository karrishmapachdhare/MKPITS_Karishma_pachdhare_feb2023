create table  salesman(salesman_id int primary key, name varchar(20),city varchar(20), commission decimal(10,2))
insert into salesman values(5001, 'James Hoog',' New York', 0.15)
insert into salesman values(5002, 'Nail Knite', 'Paris' ,0.13)
insert into salesman values(5003,'Pit Alex', 'London', 0.11)
insert into salesman values(5004, 'Mc Lyon',' Paris' ,0.14)
insert into salesman values(5005, 'Lauson',  'Jose', 0.12)
insert into salesman values(5006, 'Paul Adam', 'Rome', 0.13)
insert into salesman values(5007,'Joyel Rahate','USA',0.21)
insert into salesman values(5008,'Rut Rahate','Africa',0.15)
insert into salesman values(5009,'Joshap Bishop','Koria',0.18)
insert into salesman values(5010,'Fenny Daniyal','New Yoak',0.19)
select*from salesman

create table customer1(customer_id int primary key,cust_name varchar(20),city varchar(20), grade int,salesman_id int,
constraint f1 foreign key(salesman_id)references salesman (salesman_id) )
insert into customer1 values(3001,'Tanu Meshram','Barlin',100,5001)
insert into customer1 values(3002,'Kari Pachdhare','London',200,5002)
insert into customer1 values(3007 , 'Anjali Pathak', 'New York', 200, 5001)
insert into customer1 values(3006, 'Monu Mohatkar' ,'California' , 200, 5002)
insert into customer1 values(3005, 'Shreya Dhakole' ,'California' ,200, 5002)
insert into customer1 values(3008, 'Julian Green' ,'London' ,300 ,5002)
insert into customer1 values(3004, 'Fabian Johnson', 'Paris', 300 ,5006)
insert into customer1 values(3009, 'Geoff Cameron' ,'Berlin' ,100, 5003)
insert into customer1 values(3003, 'Jozy Altidor', 'Moscow', 200, 5007)
insert into customer1 values(30010, 'Brad Guzan', 'London' ,300 ,5005)
select* from customer1


 create table orders(ord_no int primary key, purch_amt decimal(10,2), ord_date date, 
 customer_id int,
 constraint f2 foreign key (customer_id) references customer1(customer_id),
 salesman_id int,
 constraint f3 foreign key (salesman_id) references salesman(salesman_id))

  insert into orders values(70001,150.5,'2012-10-05' ,3005, 5001)
 insert into orders values(70009, 270.65 ,'2012-09-10' ,3001, 5002)
 insert into orders values(70002 ,65.26 ,'12-10-05' ,3002 ,5001)
 insert into orders values(70004 ,110.5 ,'2012-08-17' ,3009 ,5002)
 insert into orders values(70007 ,948.5 ,'2012-09-10' ,3005 ,5002)
 insert into orders values(70005, 2400.6 ,'2012-07-27', 3007, 5002)
 insert into orders values(70008 ,5760 ,'2012-09-10' ,3002 ,5006)
 insert into orders values(70010 ,1983.43, '2012-10-10', 3004, 5003)
 insert into orders values(70003 ,2480.4 ,'2012-10-10 ',3009 ,50037)
 insert into orders values(70012 ,250.45 ,'2012-06-27' ,3008 ,5005)
 insert into orders values(70011 ,75.29 ,'2012-08-17 ',3003 ,5007)
 insert into orders values(70013 ,3045.6 ,'2012-04-25 ',3002 ,5001)
 select*from orders
 select*from salesman
 select*from customer1

 select*
 from orders 
 where salesman_id=
 (select salesman_id 
 from salesman where name='Paul Adam ')

 -------------2query---------------

 select*
 from orders
 where salesman_id in
 (select salesman_id
 from salesman 
 where city='London');

 ---------------3rd  query---------------------
 select*
 from orders
 where salesman_id=
 (select distinct salesman_id 
 from orders
 where customer_id=3007);
 --------------------4th query-----------

 select*from orders
 where purch_amt >
 (select AVG(purch_amt)from orders
 where ord_date='10/10/2012');

 5th query-----------------

 select * from orders
 where salesman_id In 
 (select salesman_id from salesman 
 where city='Paris');

 ----------------------6th query------------------
 select commission
 from salesman
 where salesman_id In
 (select salesman_id 
 from customer1
 where city='Paris');

 -----------------------7th query-----------------------
 select*from customer1
 where customer_id=
 (select salesman_id -2001
 from salesman
 where name='mc lyon');

 ----------------------8th query-----------------------
 select grade,COUNT(*)
 from customer1
 group by grade
 having grade>(select AVG(grade)
 from customer1
 where city='new york');

 ----------------9th query----------------------------
 SELECT ord_no, purch_amt, ord_date, salesman_id
FROM orders
WHERE salesman_id IN(
SELECT salesman_id

FROM salesman
Where commission = (
Select MAX(commission)
FROM salesman));

---------------10th query--------------
;



 
 
 
 
 
 
 
 
 
 
 select salesman_id,name
 from salesman a where 1<
 (select count(*) 
 from customer1 where salesman_id=a.salesman_id);


