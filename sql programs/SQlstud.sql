create table stud1 (first_name varchar(20),last_name varchar(20),course varchar(20),id int ,marks int,city varchar(20),state varchar(25));
insert into stud1 values('karishma','pachdhare','dotnet',23,450,'nagpur','mah');
insert into stud1 values('kajal','pachdhare','java',350,45,'nagpur','mah');
insert into stud1 values('anjali','pathak','dotnet',250,56,'kuhi','mah');
insert into stud1 values('shreya','dha','sql',300,14,'saoner','mah');
insert into stud1 values('mayuri','may','html',330,55,'nagpur','mah');
insert into stud1 values('rupali','rup','c++',230,10,'paratwada','mah');
insert into stud1 values('yasmin','sheik','css',240,35,'ballarsha','mah');
insert into stud1 values('aakansha','ak','bustrap',170,20,'itpark','mah');
insert into stud1 values('aashish','lilhare','javascript',150,22,'tirodi','mah');
insert into stud1 values('jayesh','deshmukh','c',340,24,'amrawati','mah');
insert into stud1 values('shahil','kaware','ract',429,65,'nagpur','mah');
insert into stud1 values('tanmay','patil','jqurry',427,18,'nagpur','mah');

select*  from stud1
select * from stud1
order by first_name
select*from stud1
order by first_name desc
select * from stud1 where id=16
select * from stud1 where id>19
select * from stud1 where first_name='jayesh'
select * from stud1 where city='nagpur'
select * from stud1 where id in (1,3,5)
qurry to display those records whose id
is not 1 , 3 and 5
select * from stud1 where id not in
(1,3,5)
The following example uses the IN operator to find stud1 whose list price is 299.99 or 466.99 or
