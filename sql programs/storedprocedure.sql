create table product(productid int,productname varchar(20),price int,address varchar(20),qty int)
insert into product values(12,'keyboard',2500,'nagpur',3)
insert into product values(13,'mouse',3500,'mumbai',4)
insert into product values(14,'motherboard',5780,'pune',7)
insert into product values(15,'printer',7650,'bihar',9)
insert into product values(16,'mic',3500,'hydrabad',1)
insert into product values(17,'laptop',9590,'dilli',2)
insert into product values(18,'computer',5780,'kerla',4)
insert into product values(19,'cpu',8960,'mp',6)
insert into product values(10,'headphone',4500,'seoni',8)
insert into product values(11,'usb cable',5300,'umred',5)
select*from product
----------------------------------------
alter procedure prod
as
begin
select productname,price2 from product11
order by price2
end;
exec prod

--------------min&max---------------
create proc prod9 (@minprice as decimal)
as
begin 
select*from product
where price>@minprice order by price end;
exec prod9 120
exec prod9 220

----------------------------------
create proc pp1(@pn as varchar(20))
as
begin 
select*from product
where productname=@pn 
end

exec pp1 'mouse'
exec pp1 'keyboard'

------------------------fine product name--------------
create proc prod10(@pname as varchar(20))
as
begin
select*from product
where productname=@pname
order by productname
end;
exec prod10 'laptop'
exec prod10 'cpu'
----------------stored with 2 parameters----------------------

create proc prod11(@pname as varchar(20),@p as decimal)
as begin
select*from product
where productname=@pname
and price>=@p
order by productname
end;
exec prod11 'mic',3400
exec prod11 'computer',6800

