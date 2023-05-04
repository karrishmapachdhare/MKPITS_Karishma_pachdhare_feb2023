create table stores(store_id int,store_name varchar(20),phone int,email varchar(20),street varchar(20),city varchar(20),state varchar(20),zipcode int)
insert into stores values(4769,'shabana',1678,'shabana@gmail.com','nagpur','mah',8456)

create table category(categoryid int primary key ,categoryname varchar(20))
insert into category values(4537,'pestry')

create table brands(brandid int primary key,brandname varchar(30))
insert into brands values(2345,'shabana')

create table products(productid int primary key,productname varchar(30),brandid int,categoryid int,modelyear int,listprice int ,constraint p1 foreign key(brandid) references brands(brandid ),constraint p2 foreign key(categoryid)references category(categroyid))
insert into products values(1679,'rasmalai',23456,987655,2023,780000) 

create table stock(store_id int,
constraint p3 foreign key(store_id) references store1(store_id),
productid int,
constraint p4 foreign key (productid) references products(productid))
insert into stock values(145,6757,8)

create table customer(coustomer_id int,firstname varchar(20),lastname varchar(20),phone int,email varchar(20),shreet varchar(20),city varchar(20), state varchar(20), zipcode int)
insert into customer values(2356,'karishma','pachdhare',89543256,'karishma@gmail.com','ringroad','nagpur','mah',5677)

create table storeid(storename varchar(20),phone int,email varchar(20),street varchar(20),city varchar(20),state varchar(20),zipcode int)
insert into storeid values('dilliwale',98544,'kari@gmail.com','ring road','nagpur','mah',5678)


create table orderid(itemid int,productid int,quntity int,list_price int,discount int)