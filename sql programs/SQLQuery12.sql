create table products1(product_id int identity primary key,product_name varchar(255) not null,unit_price dec(10,2)check(unit_price>0));
insert into products1 values('mouse',120)
select*from products1


create table result(rno int primary key,marks int check(marks>0))
insert into result values(3,9)
insert into result values(2,99)
select *from result


-----------------------constriant key----------------
create table products(product_id int identity primary key,productname varchar(25) not null,unit_price dec(10,2)constraint positive_price check(unit_price>0));
insert into products(productname, unit_price)vlues('Awesome Bike',12345667);

create table products3(product_id INT IDENTITY PRIMARY KEY,
product_name VARCHAR(255) NOT NULL,
unit_price DEC(10,2) CHECK(unit_price > 0),
discounted_price DEC(10,2) CHECK(discounted_price > 0),
CHECK(discounted_price < unit_price)
);

insert into products3 values('mouse',120,20)
insert into products3 values('mouse',110,10)
select*from products3
insert into products3 values('mouse',340,320)
