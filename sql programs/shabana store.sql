create table stores(store_id int primary key,store_name varchar(20),phone int,email varchar(20),street varchar(20),
city varchar(20),state varchar(20),zipcode int)
insert into stores values(2345,'shabana',6789,'shabana@gmail.com','chaoni road','Nagpur','Maharashtra',440029)

create table categories(category_id int primary key,category_name varchar(20))
insert into categories values(4343,'sweet')



create table brands(brand_id int primary key,brand_name varchar(20))
insert into brands values(1001,'shabana')

create table product1(product_id int primary key,product_name varchar(20),brand_id int,category_id int,
model_year int,list_price int,constraint p1 foreign key(brand_id) references brands(brand_id),
constraint p2 foreign key(category_id) references categories(category_id))
insert into product1 values(19,'rashmalai',1001,4343,2022,500)


create table stocks(store_id int,product_id int,quantity int,constraint c3 foreign key(store_id) references
stores(store_id),constraint c4 foreign key(product_id) references product1(product_id))
insert into stocks values(2345,19,7)


create table customers(customer_id int primary key,first_name varchar(20),last_name varchar(20),phone int,email varchar(20),
city varchar(20),state varchar(20),zip_code int)
insert into customers values(2468,'karishma','pachdhare',1234,'kari@com','nagpur','Maharashtra',440030)

create table staff(staff_id int primary key,first_name varchar(20),last_name varchar(20),email varchar(20),
phone int,active varchar(20),store_id int,manager_id int,constraint t1 foreign key(store_id)references stores(store_id))
insert into staff values(33,'amit','kuhikar','amitk@gmail.com',56784,'present',2345,51)

create table orders(order_id int primary key,customer_id int,order_status varchar(20),order_date int,required_date int,shipped_date
int,store_id int,staff_id int,constraint or1 foreign key(customer_id)references  customers(customer_id),constraint
o4 foreign key(store_id)references stores(store_id),constraint o5 foreign key(staff_id)references staff(staff_id))
insert into orders values(99,2468,'done',10-3-23,17-3-23,18-3-23,2345,33)

create table oder_items(order_id int,item_id int,product_id int,quantity int,lait_price int,discount float,
constraint i1 foreign key(order_id)references orders(order_id),constraint i2 foreign key(product_id)references product1(product_id))
insert into oder_items values(99,34,19,3,800,0.20)

select *  from oder_items
select * from  orders
select * from staff
select*from brands
select*from categories
select* from customers
select* from product1
select* from stocks
select* from stores



