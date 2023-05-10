create procedure prod4 as begin 
select*from productqty
end;
exec prod4
----------------------------store procedure----------
alter procedure prod6 
as 
begin 
select productname,price from product
order by price 
end;
exec prod6