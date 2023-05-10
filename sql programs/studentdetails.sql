create table course(courseid int primary key,coursename varchar(20))
insert into course values(1,'dotnet')
insert into course values(2,'java')

create table student(studentid int primary key,studentname varchar(20),courseid int constraint c1 foreign key(courseid) references  course(courseid));
insert into student values(223,'akash',1)
insert into student values(431,'tanu',1)
insert into student values(312,'mona',2)
insert into student values(112,'anjali',2)
insert into student values(445,'shreya',2)

select*from course
select*from student


select s1.courseid ,c1.coursename,s1.studentname from course c1 inner join student s1 on c1.courseid=s1.courseid where c1.coursename='dotnet';

select s1.courseid ,c1.coursename,s1.studentname from course c1 inner join student s1 on c1.courseid=s1.courseid where c1.coursename='java';
 

 select s1.studentname from course c1 inner join student s1 on c1.courseid=s1.courseid where c1.coursename='dotnet';
select s1.studentname from course c1 inner join student s1 on c1.courseid=s1.courseid where c1.coursename='java';

select co.coursename from course co 
inner join student s1 on co.courseid=s1.studentid where s1.studentname='akash'

select co.coursename from course co 
inner join student s1 on co.courseid=s1.studentid where s1.studentname='tanu'

select co.coursename from course co 
inner join student s1 on co.courseid=s1.studentid where s1.studentname='mona'

select co.coursename from course co 
inner join student s1 on co.courseid=s1.studentid where s1.studentname='anjali'

select co.coursename from course co 
inner join student s1 on co.courseid=s1.studentid where s1.studentname='shreya'


select studentname from student where courseid=(select courseid from course where coursename='dotnet');
select studentname from student where courseid=(select courseid from course where coursename='java');


select coursename from course where courseid=(select studentid from student where studentname='akash');
select coursename from course where courseid=(select studentid from student where studentname='java');





