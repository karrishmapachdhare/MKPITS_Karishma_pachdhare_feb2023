create table product(pro_id int primary key,pro_name varchar(20),price int ,quntity int)
insert into product values(123,'keyboard',20000,6)
insert into product values(125,'mouse',25000,5)
insert into product values(127,'speaker',27900,4)
insert into product values(129,'laptop',85678,2)
insert into product values(131,'mic',3523,6)
insert into product values(134,'computer',78906,2)
insert into product values(136,'headphone',46450,8)
insert into product values(138,'cpu',89076,1)
insert into product values(140,'motherboard',100000,2)
insert into product values(142,'hard disk',136790,3)
insert into product values(143,'led',45789,7)
insert into product values(146,'IC',99990,3)
select*from product
begin transaction
insert into product values(147,'mobile',83456,5)
update product set price=2456 where pro_id = 2268
commit transaction

set implicit_transactions on
 -- Start a new transaction    
    BEGIN TRANSACTION  
    -- SQL Statements  
	  UPDATE Product SET Price = 345000 WHERE Pro_id = 124  
    DELETE FROM Product WHERE Pro_id = 126  
    --Undo Changes  
    ROLLBACK TRANSACTION  