create table prd2(prdid int identity primary key,prdname varchar(20),price int,discount int,check(price>0),check(discount<price))
insert into prd2 values(null,50,12)
insert into prd2 values('power',50,12)
select *from prd2

-----------------------------Alter---------------------------------
create table prd5(prdid int identity primary key,prdname varchar(20),price int not null)
insert into prd5 values(null,51,13)
alter table prd5 add mobno varchar(20)
select*from prd5
----------------------drop------------------------------------
create table prd6(prdid int identity primary key,prdname varchar(20),price int not null)
insert into prd6 values(null ,15,12) 
select *from prd6
alter table prd6
drop column prdname;