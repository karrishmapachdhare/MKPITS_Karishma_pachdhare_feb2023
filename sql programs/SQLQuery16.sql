------------ DROP a DEFAULT Constraint :----------------------

create table sample(id int,age int constraint df default 10)
insert into sample(id) values(11)

select*from sample