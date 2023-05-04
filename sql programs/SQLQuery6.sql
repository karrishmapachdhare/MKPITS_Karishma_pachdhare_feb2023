create table teachers1(teacher_id int primary key, age int)
create table subjects1(teacher_id int, subject varchar(25),
constraint c1 foreign key(teacher_id)references teachers1 (teacher_id))

Insert into teachers1 values(1,30)
insert into subjects1 values(1,'chemistry')
insert into subjects1 values(1,'biology')


insert into teachers1 values(2,26)
insert into subjects1 values(2,'english')
insert into subjects1 values(2,'maths')

insert into teachers1 values(3,30)
insert into subjects1 values(3,'histroy')
insert into subjects1 values(3,'civies')

insert into teachers1 values(4,25)
insert into subjects1 values(4,'english')
insert into subjects1 values(4,'geography')

insert into teachers1 values(5,26)
insert into subjects1 values(5,'hindi')
insert into subjects1 values(5,'pt')


select*from teachers1
select *from subjects1

