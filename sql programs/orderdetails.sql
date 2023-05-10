create table stud3 (rno int primary key,name varchar(20),email varchar(20),city varchar(15),courseid int)
insert into stud3 values(12,'kari','kari@.com','nagpur',124)
insert into stud3 values(13,'mona','mona@.com','saoner',234)
insert into stud3 values(14,'kaju','kaju@.com','mumbai',334)
insert into stud3 values(15,'yogi','yogi@.com','bhopal',434)
insert into stud3 values(16,'tinu','tinu@.com','pune',453)


create table fees3(fees3id int,rno int constraint h1 foreign key(rno)references stud3(rno),fees3date int ,amount int,courseid varchar(20));
insert into fees3 values(16,12,12-2-2021,20000,234)
insert into fees3 values(17,13,14-1-2021,15000,344)
insert into fees3 values(18,14,19-2-2021,32000,414)
insert into fees3 values(19,15,21-2-2021,35000,504)
insert into fees3 values(20,16,24-3-2021,26000,614)

select*from stud3
select*from fees3

select fees3id,rno,fees3date,amount,courseid from fees3 where rno in(select rno from stud3 where city='nagpur')
select fees3id,rno,fees3date,amount,courseid from fees3 where rno in(select rno from stud3 where city='saoner')
select fees3id,rno,fees3date,amount,courseid from fees3 where rno in(select rno from stud3 where city='mumbai')
select fees3id,rno,fees3date,amount,courseid from fees3 where rno in(select rno from stud3 where city='bhopal')
select fees3id,rno,fees3date,amount,courseid from fees3 where rno in(select rno from stud3 where city='pune')

-----------------------order----------------------------


create table order2(custid int,orderid int,orderdate date,productname varchar(20),qty int)
insert into order2 values(1,1,'2022-2-2','mouse',5)
insert into order2 values(2,2,'2022-2-2','keyboard',3)
insert into order2 values(3,3,'2022-2-2','desktop',6)
insert into order2 values(4,4,'2022-2-2','ram',8)
insert into order2 values(5,5,'2022-2-2','laptop',9)
insert into order2 values(6,6,'2022-1-2','tv',1)
insert into order2 values(7,7,'2022-2-2','fan',3)
insert into order2 values(8,8,'2022-2-2','computer',7)
insert into order2 values(9,9,'2022-2-2','cpu',1)
insert into order2 values(10,10,'2022-2-2','mic',8)

select*from order2 
 
