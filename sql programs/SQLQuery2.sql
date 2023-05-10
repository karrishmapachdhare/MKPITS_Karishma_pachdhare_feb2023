create table sample1 (id int identity primary key,name varchar(20),qty int)
insert  into sample1 values('mouse',2)
insert into sample1 values('keyboard',4)
insert into sample1 values('laptop',5)
insert into sample1 values('computer',8)
insert into sample1 values('usb cable',9)
insert into sample1 values('printer',2)
insert into sample1 values('cpu',3)
insert into sample1 values('mic',6)
insert into sample1 values('headphone',7)
select * from sample1

delete from sample1
select * from sample1

insert into sample1 values('mouse')

insert into sample1 values('keyboard')
select * from sample1

--truncate will delete the record and when you insert new records it will start from one
truncate table sample1
select * from sample1
insert into sample1 values('mouse')
insert into sample1 values('keyboard')
select * from sample1