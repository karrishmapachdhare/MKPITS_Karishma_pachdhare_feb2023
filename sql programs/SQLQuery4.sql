create table orderates(orderno int primary key,orderates varchar(35),custid int)
create table orders1(orderno int,prodid int,rate int,qty int,
constraint c1 foreign key(orderno)references orderates(orderno))

insert into orderates values(1,12/12/2020,212)
insert into orders1 values(1,123,200,2)
insert into orders1 values(1,124,500,1)

insert into orderates values(2,12/1/2023,213)
insert into orders1 values(2,123,600,221)

insert into orderates values(3,12/2/2013,214)
insert into orders1 values(3,124,600,123)
select *from orderates
select*from orders1