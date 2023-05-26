create table TableNation(NationId int primary key,NationName varchar(500))
insert into TableNation values(1,'India')
insert into TableNation values(2,'United-state')
insert into TableNation values(3,'Nepal')
insert into TableNation values(4,'Shrilanka')


create table TableState(StateId int primary key,NationId int constraint c1 foreign key(NationID) references TableNation(NationID),StateName varchar(500))

insert into TableState values (101,1,'Andhra Pradesh')
insert into TableState values(102,2,'Punjab')
insert into TableState values(103,2,'California')
insert into TableState values(104,2,'Florida')
insert into TableState values(105,3,'Koshi')
insert into TableState values(106,3,'Bagmata')
insert into TableState values(107,4,'Colombo')
insert into TableState values(108,4,'Ratnapura')


create table TableCity(CityId int primary key,StateId int constraint c2 foreign key(StateId)references TableState(StateId),CityName varchar(500))

insert into TableCity values (1001,101,'Visakhapatnam')
insert into TableCity values (1002,101,'Vijayawada')
insert into TableCity values(1003,101,'Guntur')
insert into TableCity values(1004,102,'Amritsar')
insert into TableCity values(1005,102,'Jalandhar')
insert into TableCity values(1006,102,'Chandigarh')
insert into TableCity values(1007,103,'Los Angeles')
insert into TableCity values(1008,103,'San Jose')
insert into TableCity values(1009,103,'San Diego')
insert into TableCity values(1010,104,'Jacksonville')
insert into TableCity values(1011,104,'Miami')
insert into TableCity values(1012,104,'Tampa')
insert into TableCity values(1013,105,'damak')
insert into TableCity values(1014,105,'Dharan')
insert into TableCity values(1015,105,'Biratnagar')
insert into TableCity values(1016,106,'Banepa')
insert into TableCity values(1017,106,'Bharatpur')
insert into TableCity values(1018,106,'Hetauda')
insert into TableCity values(1019,107,'Grandpass')
insert into TableCity values(1020,107,'Borella')
insert into TableCity values(1021,107,'Pettah')
insert into TableCity values(1022,108,'Balangoda')
insert into TableCity values(1023,108,'Kolonna')




create table TableCourseRegDetail(CourseRegId int primary key,CategoryInd int,FullName varchar(1500)
,GenderInd int)


insert into TableCourseRegDetail values (4,1,'mk',1)
insert into TableCourseRegDetail values(5,2,'mk2',2)
insert into TableCourseRegDetail values(6,1,'ravi',1)
insert into TableCourseRegDetail values(7,1,'anand',1)
insert into TableCourseRegDetail values(8,1,'gaurav',1)
insert into TableCourseRegDetail values(9,1,'Pranjali',2)
insert into TableCourseRegDetail values(10,1,'mk3',1)
insert into TableCourseRegDetail values(11,1,'mk4',1)
insert into TableCourseRegDetail values(12,1,'mk4',1)
insert into TableCourseRegDetail values(13,1,'mk6',1)
insert into TableCourseRegDetail values(14,2,'dhananjay',1)
insert into TableCourseRegDetail values(15,1,'m khan',1)
insert into TableCourseRegDetail values(16,2,'ananya',2)

create table TableRegAddress(RegAddressId int,CourseRegId int constraint c15 foreign key(CourseRegId)references TableCourseRegdetail(CourseRegId),NationId int constraint c16 foreign key
(NationId)references TableNation(NationID),
StateID int constraint c17 foreign key(StateId)references TableState(StateId),CityId int constraint c18 foreign key(CityId)references TableCity(CityId))

insert into TableRegAddress values (1,4,4,102,1003)
insert into TableRegAddress values (2,6,4,104,1009)
insert into TableRegAddress values (3,6,4,102,1003)
insert into TableRegAddress values (4,4,4,104,1012)
insert into TableRegAddress values (5,8,2,104,1009)
insert into TableRegAddress values (6,8,2,104,1009)
insert into TableRegAddress values (7,9,2,103,1009)
insert into TableRegAddress values (8,9,2,103,1007)
insert into TableRegAddress values (9,12,1,102,1006)
insert into TableRegAddress values (10,13,1,101,1001)
insert into TableRegAddress values(11,14,4,107,1021)
insert into TableRegAddress values(12,15,2,104,1012)
insert into TableRegAddress values(13,16,1,101,1002)




create table TableFeeDetail(FeeID int primary key ,CourseRegId int constraint c6 foreign key(CourseRegId)references TableCourseRegDetail(CourseRegId),TotalAmount int,MinPer decimal,
PaidAmount decimal,BalanceAmount decimal,PaidDate datetime)


insert into TableFeeDetail values (1,4,100,0,500,500,'2023-04-10 00:00:00:001')
insert into TableFeeDetail values (14,4,1000,0,500,500,'2023-04-04 00:00:00:001')
insert into TableFeeDetail values(2,4,3000,0,20,2980,'2023-04-04 00:00:00:000')
insert into TableFeeDetail values(3,4,1000,0,200,800,'2023-04-10 00:00:00:000')
insert into TableFeeDetail values(4,4,1000,0,500,500,'2023-04-10 00:00:00:000')
insert into TableFeeDetail values(5,4,1000,0,500,500,'2023-04-10 00:00:00:000')
insert into TableFeeDetail values(6,4,1000,0,500,500,'2023-04-10 00:00:00:000')
insert into TableFeeDetail values(7,4,1000,0,500,500,'2023-04-10 00:00:00:000')
insert into TableFeeDetail values(8,4,1000,0,500,500,'2023-04-10 00:00:00:000')
insert into TableFeeDetail values(9,12,1000,0,600,400,'2023-04-10 00:00:00:000')
insert into TableFeeDetail values(10,13,1000,500,600,400,'2023-04-10 00:00:00:000')
insert into TableFeeDetail values(11,14,3000,2400,2400,600,'2023-04-10 00:00:00:000')
insert into TableFeeDetail values(12,15,1000,500,500,500,'2023-04-10  00:00:00:000')
insert into TableFeeDetail values(13,16,3000,2400,2500,500,'2023-04-10 00:00:00:000')

select*from TableNation
0
select*from TableCity
select*from TableCourseRegDetail
select*from TableRegAddress
select*from TableFeeDetail
