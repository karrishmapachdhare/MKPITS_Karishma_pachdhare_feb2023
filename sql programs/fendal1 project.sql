create table TableNation(NationID int primary key,NationName varchar(500))
insert into  TableNation values(1,'India')
insert into  TableNation values(2,'United-nation')
insert into  TableNation values(3,'Nepal')
insert into  TableNation values(4,'Shreelanka')




create table TableState(StateId int primary key,NationId int constraint c1 foreign key(NationID) references TableNation(NationID),StateName varchar(500))


insert into TableState values(101,'Andhra Pradesh',1)
insert into TableState values(102,,'Punjab',1)
insert into TableState values(103,'Calfonia',2)
insert into TableState values(104,'Florida',2)
insert into TableState values(105,'Koshi',3)
insert into TableState values(106,'Bagmati',3)
insert into TableState values(107,'Colombo,4')
insert into TableState values(108,'Ratanapur',4)



create table TableCity(CityId int primary key,StateId int constraint c2 foreign key(StateId)references TableState(StateId),CityName varchar(500))
insert into TableCity values(1001,'Visakhapatnam',101)
insert into TableCity values(1002,'Vijayawada',101)
insert into TableCity values(1003,'Guntur',101)
insert into TableCity values(1004,'Amritsar',102)
insert into TableCity values(1005,'Jalandhar',102)
insert into TableCity values(1006,'Chandigarh',103)
insert into TableCity values(1007,'Los Angeles',103)
insert into TableCity values(1008,'San Jose',103)
insert into TableCity values(1009,'Jacksonville',104)
insert into TableCity values(1010,'Milami',104)
insert into TableCity values(1011,'Tampa',104)
insert into TableCity values(1012,'Damak',105)
insert into TableCity values(1013,'Dhran',105)
insert into TableCity values(1014,,'Biratpur',105)
insert into TableCity values(1015,'Banepa',105)
insert into TableCity values(1016,'Bharatpur',106)
insert into TableCity values(1017,'Balaghat',106)
insert into TableCity values(1018,'Hetauda',106)
insert into TableCity values(1019,'Grandpass',107)
insert into TableCity values(1020,'Borella',107)
insert into TableCity values(1021,'Pettah',107)
insert into TableCity values(1022,'Balangoda',108)
insert into TableCity values(1023,'Kolanna',108)



create table TableCourseRegDetails(CourseRegId int primary key,CategoryInd int,FullName varchar(1500)
,GenderInd int)

insert into TableCourseRegDetails values(4,1,'Mk',1)
insert into TableCourseRegDetails values(5,2,'Mk2',2)
insert into TableCourseRegDetails values(6,1,'Ravi',1)
insert into TableCourseRegDetails values(7,1,'Anand',1)
insert into TableCourseRegDetails values(8,1,'Gaurav',1)
insert into TableCourseRegDetails values(9,1,'Pramjali',2)
insert into TableCourseRegDetails values(10,1,'Mk3',1)
insert into TableCourseRegDetails values(11,1,'Mk4',1)
insert into TableCourseRegDetails values(12,1,'Mk5',1)
insert into TableCourseRegDetails values(13,1,'Mk6',1)
insert into TableCourseRegDetails values(14,2,'Dhanajay',1)
insert into TableCourseRegDetails values(15,1,'M khan',1)
insert into TableCourseRegDetails values(16,2,'Ananya',2)



create table TableRegAddress(RegAddressId int,CourseRegId int constraint c3 foreign key(CourseRegId)references TableCourseRegdetails(CourseRegId),NationId int constraint c4 foreign key
(NationId)references TableNation(NationID),
StateID int constraint c4 foreign key(StateId)references TableState(StateId),CityId int constraint c5 foreign key(CityId)references TableCity(CityId))

insert into TableRegAddress values(1,1,4,102,1003)
insert into TableRegAddress values(2,1,4,104,1009)
insert into TableRegAddress values(3,1,4,102,1003)
insert into TableRegAddress values(4,1,4,104,1012)
insert into TableRegAddress values(5,1,2,104,1009)
insert into TableRegAddress values(6,1,2,104,1009)
insert into TableRegAddress values(7,1,2,103,1009)
insert into TableRegAddress values(8,1,2,103,1007)
insert into TableRegAddress values(9,1,1,102,1006)
insert into TableRegAddress values(10,12,1,101,1001)
insert into TableRegAddress values(11,13,4,107,1021)
insert into TableRegAddress values(12,14,2,104,1012)
insert into TableRegAddress values(13,15,1,101,1002)



create table TableFeeDetail(FeeID INT primary key identity,CourseRegId int constraint c6 foreign key(CourseRegId)references TableCourseRegDetails(CourseRegId),TotalAmount int,MinPer decimal,
PaidAmount decimal,BalanceAmount decimal,PaidDate datetime)

insert into TableFeeDetails values(1,1,1000,0,500,500,2023-04-10 00:00:00:000)
insert into TableFeeDetails values(2,1,3000,0,20,2980)
insert into TableFeeDetails values(3,1)
insert into TableFeeDetails values(4,1)
insert into TableFeeDetails values(5,1)
insert into TableFeeDetails values(6,1)
insert into TableFeeDetails values(7)
insert into TableFeeDetails values(8)
insert into TableFeeDetails values(9)
insert into TableFeeDetails values(10)
insert into TableFeeDetails values(11)
insert into TableFeeDetails values(12)
insert into TableFeeDetails values(13,)