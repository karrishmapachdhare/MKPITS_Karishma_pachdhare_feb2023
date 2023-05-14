create table employees(empid int primary key,emp_name varchar(20))
create table emplog(logid int identity(1,1) not null,empid int not null,
operation nvarchar(10) not null,
updatedDate datetime not null)

insert into employees values(1,'kari')
insert into employees values(2,'tanu')
insert into employees values(3,'mona')
insert into employees values(4,'tinu')
insert into employees values(5,'dikshu')
insert into employees values(6,'siddhu')
insert into employees values(7,'anjali')
insert into employees values(8,'sakshi')
 
 create trigger empt
on employees
for insert
as
insert into EmpLog(EmpID,Operation,UpdatedDate)
select empid,'insert',GETDATE() from inserted;

insert into employees values(11,'karishma')
select * from employees
select * from emplog
insert into employees values(10,'shahil')
insert into employees values(13,'yasmin')
insert into employees values(14,'jayesh')
insert into employees values(15,'tanmay')
insert into employees values(16,'aashish')
insert into employees values(17,'shreya')
insert into employees values(18,'mahima')
select*from employees
select*from emplog


--------------------------------trigger-------------------

create trigger trgemployeeinsert on employees for insert as
insert into emplog(empid,operation,updatedDate)
SELECT EmpID ,'INSERT',GETDATE() FROM INSERTED; 
select*from employees

select*from emplog

-----------------------------------------insert data copy----------
 create table employee(firstnaasme varchar(20) ,lastname varchar(25),email nvarchar(30),phone int,hiredate int ,managerid int,salary int)