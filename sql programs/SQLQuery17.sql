















reate table greeks(ID int NOT NULL,Name varchar(255),age int,location varchar(255)DEFAULT 'Noida');
insert into greeks values(4,'Mira',23,'Delhi');
insert into greeks(ID,Name,age)values(5,'Hema',27);
insert into greeks(ID,Name,age)values(6,'mona',24);

insert into greeks(ID,Name,age)values(7,'tanu',21);

insert into greeks(ID,Name,age)values(8,'anjali',24);

insert into greeks(ID,Name,age)values(9,'tina',17);

select*from greeks;



create table sample(id int,age int constraint df default 10)
insert  into sample(id) values(11)
select * from sample

alter table sample
drop constraint df
insert  into sample(id) values(12)
insert  into sample(id) values(13)
insert  into sample(id) values(14)
insert  into sample(id) values(15)
insert  into sample(id) values(16)
select * from sample


-------------------------------not null----------------------------
create table student(Id int not null,name varchar(10) not null,address varchar(20));
insert into student values(2,'tanu','kuhi')
insert into student values(4,'kari','mankapur')

insert into student values(6,'kaju','nagpur')

insert into student values(8,'yogi','ring road')

insert into student values(10,'mona','saoner')

insert into student values(12,'sonu','timki')

insert into student values(14,'anju','nagpur')

insert into student values(16,'akki','mankapur')

select*from student



----------------------unique--------------------------------

create table students (id int unique, name varchar(10));
insert into students(name) values('akash')
select*from students



create table student1(id int unique,rno int primary key,name varchar(10),);
insert into student1 values(1,11,'yogesh')
insert into student1(rno,name) values(12,'yogesh1')
insert into student1(name) values('yogesh1')
select*from student1
select*from students


create table student2(id int primary key,rno int unique,aadarno dec(20,0) unique,name varchar(10),);
insert into student2 values(1,11,1034456789,'akash')
insert into student2 values(2,12,1134456789,'aashu')
insert into student2 values(3,13,1234456789,'akki')
insert into student2 values(4,14,1335656789,'aashi')
insert into student2 values(5,15,1236096789,'kari')
insert into student2 values(6,16,12341246789,'yogii')
insert into student2 values(7,17,1939444589,'kaju')
insert into student2 values(8,18,203440174689,'deven')
insert into student2 values(9,19,21534456789,'kushu')
insert into student2 values(10,20,2234456789,'devansh')
insert into student2 values(11,21,2334456789,'akash')
select*from student2




create table vendor_groups(group_id int primary key,group_name varchar(100)not null);
create table vendors(vendor_id int primary key,vendor_name varchar(100) not null,group_id int default 100,
constraint fk555 foreign key (group_id)references vendor_groups(group_id)on update set default)
insert into vendor_groups values(1,'tcs1')
insert into vendors values(111,'mkpits',1)
insert into vendor_groups values(2,'tcs2')
insert into vendors values(112,'mkpits1',2)
update vendor_groups set group_id=22 where group_name='tcs1'
 select * from vendors
it will set the group_id =100 

        
        


