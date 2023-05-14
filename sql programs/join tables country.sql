create database budget
use budget

create table Country(COUNTRY_ID varchar(5)  primary key, COUNTRY_NAME varchar(20), REGION_ID int)
insert into Country values	('AR', 'Argentina', 2)
insert into Country values	('AU', 'Australia', 3)
insert into Country values	('BE', 'Belgium', 1)
insert into Country values	('BR', 'Brazil', 2)
insert into Country values	('CA', 'Canada', 2)
insert into Country values	('CH', 'Switzerland', 1)
insert into Country values	('CN', 'China', 3)
insert into Country values	('DE', 'Germany', 1)
insert into Country values	('DK', 'Denmark', 1)
insert into Country values	('EG', 'Egypt', 4)
insert into Country values	('FR', 'France', 1)
insert into Country values	('IL', 'Israel', 4)
insert into Country values	('IN', 'India', 3)
insert into Country values	('IT', 'Italy', 1)
insert into Country values	('JP', 'Japan', 3)
insert into Country values	('KW', 'Kuwait', 4)
insert into Country values	('ML', 'Malaysia', 3)
insert into Country values	('MX', 'Mexico', 2)
insert into Country values	('NG', 'Nigeria', 4)
insert into Country values	('NL', 'Netherlands', 1)
insert into Country values	('SG', 'Singapore', 3)
insert into Country values	('UK', 'United Kingdom', 1)
insert into Country values	('US', 'USA', 2)
insert into Country values	('ZM', 'Zambia', 4)
insert into Country values	('ZW', 'Zimbabwe', 4)
select*from Country

------------------------job table-----------------------------------------
create table jobs(JOB_ID varchar(15) primary key, JOB_TITLE varchar (30),MIN_SALARY int,MAX_SALARY int)
insert into jobs values 	('AD_PRES','President',20080,40000)
insert into jobs values 	('AD_VP','Administration Vice President',15000,30000)
insert into jobs values 	('AD_ASST','Administration Assistant',3000,6000)
insert into jobs values 	('FI_MGR','Finance Manager',8200,16000)
insert into jobs values 	('FI_ACCOUNT','Accountant',4200,9000)
insert into jobs values 	('AC_MGR','Accounting Manager',8200,16000)
insert into jobs values 	('AC_ACCOUNT','Public Accountant',4200,9000)
insert into jobs values 	('SA_MAN','Sales Manager',10000,20080)
insert into jobs values 	('SA_REP','Sales Representative',6000,12008)
insert into jobs values 	('PU_MAN','Purchasing Manager',8000,15000)
insert into jobs values 	('PU_CLERK','Purchasing Clerk',2500,5500)
insert into jobs values 	('ST_MAN','Stock Manager',5500,8500)
insert into jobs values 	('ST_CLERK','Stock Clerk',2008,5000)
insert into jobs values 	('SH_CLERK','Shipping Clerk',2500,5500)
insert into jobs values 	('IT_PROG','Programmer',4000,10000)
insert into jobs values 	('MK_MAN','Marketing Manager',9000,15000)
insert into jobs values 	('MK_REP','Marketing Representative',4000,9000)
insert into jobs values 	('HR_REP','Human Resources Representative',4000,9000)
insert into jobs values 	('PR_REP','Public Relations Representative',4500,10500)
select*from jobs

----------------------job grade------------------------------------

create table job_grade(GRADE_LEVEL varchar(5) primary key,  LOWEST_SAL int, HIGHEST_SAL int)
insert into job_grade values 	('A',1000,2999)
insert into job_grade values 	('B',3000,5999)
insert into job_grade values 	('C',6000,9999)
insert into job_grade values 	('D',10000,14999)
insert into job_grade values 	('E',15000,24999)
insert into job_grade values 	('F',25000,40000)
select*from job_grade

--------------location table-------------------------

create table LOCATIONS(LOCATION_ID int primary key, STREET_ADDRESS  varchar(50),POSTAL_CODE int, CITY varchar(30),
STATE_PROVINCE varchar(30) ,COUNTRY_ID varchar(5),
constraint q1 foreign key (COUNTRY_ID) references Country(Country_ID))
 
insert into LOCATIONS values 	(1000,'1297 Via Cola di Rie',989,'Roma','    ','IT')
insert into LOCATIONS values 	(1100,'93091 Calle della Testa',10934,'Venice','    ','IT')
insert into LOCATIONS values 	(1200,'2017 Shinjuku-ku',1689,'Tokyo','Tokyo Prefecture','JP')
insert into LOCATIONS values 	(1300,'9450 Kamiya-cho',6823,'Hiroshima','   ','JP')
insert into LOCATIONS values 	(1400,'2014 Jabberwocky Rd',26192,'Southlake','Texas','US')
insert into LOCATIONS values 	(1500,'2011 Interiors Blvd',99236,'South San Francisco','California','US')
insert into LOCATIONS values 	(1600,'2007 Zagora St',50090,'South Brunswick',  'New Jersey','US')
insert into LOCATIONS values 	(1700,'2004 Charade Rd',98199,'Seattle','Washington','US')
insert into LOCATIONS values 	(1800,'147 Spadina Ave',34523,'Toronto','Ontario','CA')
insert into LOCATIONS values 	(1900,'6092 Boxwood St',2365263,'Whitehorse','Yukon','CA')
insert into LOCATIONS values 	(2000,'40-5-12 Laogianggen',190518,'Beijing','    ','CN')
insert into LOCATIONS values 	(2100,'1298 Vileparle (E)',490231,'Bombay','Maharashtra','IN')
insert into LOCATIONS values 	(2200,'12-98 Victoria Street',2901,'Sydney',    'New South Wales','AU')
insert into LOCATIONS values 	(2300,'198 Clementi North',540198,'Singapore','   ','SG')
insert into LOCATIONS values 	(2400,'8204 Arthur St',43554,'London','   ','UK')
insert into LOCATIONS values 	(2500,'Magdalen Centre, The Oxford Science Park',90910,'Oxford','Oxford','UK')
insert into LOCATIONS values 	(2600,'9702 Chester Road',9650293,'Stretford','Manchester','UK')
insert into LOCATIONS values 	(2700,'Schwanthalerstr. 7031',80925,'Munich','Bavaria','DE')
insert into LOCATIONS values 	(2800,'Rua Frei Caneca 1360',1307002,'Sao Paulo','    ','BR')
insert into LOCATIONS values 	(2900,'20 Rue des Corps-Saints',1730,'Geneva','    ','CH')
insert into LOCATIONS values 	(3000,'Murtenstrasse 921',3095,'Bern','BE','CH')
insert into LOCATIONS values 	(3100,'Pieter Breughelstraat 837',3029,'Utrecht','Utrecht','NL')
insert into LOCATIONS values 	(3200,'Mariano Escobedo 9991',11932,'Mexico City',  'Distrito Federal','MX')
select *from LOCATIONS
		
--------------------------------departments table---------------------

create table Department1(DEPARTMENT_ID int primary key,DEPARTMENT_NAME  varchar(20), 
MANAGER_ID int, LOCATION_ID int,
constraint f2 foreign key (LOCATION_ID) references LOCATIONS(LOCATION_ID))
insert into Department1 values(20,'Marketing',201,1800)
insert into Department1 values(30,'Purchasing',114,1700)
insert into Department1 values(40,'Human Resources',203,2400)
insert into Department1 values(50,'Shipping',121,1500)
insert into Department1 values(60,'IT',103,1400)
insert into Department1 values(70,'Public Relations',204,2700)
insert into Department1 values(80,'Sales',145,2500)
insert into Department1 values	(90,'Executive',100,1700)
insert into Department1 values(100,'Finance',108,1700)
insert into Department1 values(110,'Accounting',205,1700)
insert into Department1 values(120,'Treasury',0,1700)
insert into Department1 values(130,'Corporate Tax',0,1700)
insert into Department1 values(140,'Control And Credit',0,1700)
insert into Department1 values(150,'Shareholder Services',0,1700)
insert into Department1 values(160,'Benefits',0,1700)
insert into Department1 values(170,'Manufacturing',0,1700)
insert into Department1 values	(180,'Construction',0,1700)
insert into Department1 values(190,'Contracting',0,1700)
insert into Department1 values(200,'Operations',0,1700)
insert into Department1 values(210,'IT Support',0,1700)
insert into Department1 values(220,'NOC',0,1700)
insert into Department1 values(230,'IT Helpdesk',0,1700)
insert into Department1 values	(240,'Government Sales',0,1700)
insert into Department1 values(250,'Retail Sales',0,1700)
insert into Department1 values(260,'Recruiting',0,1700)
insert into Department1 values(270,'Payroll',0,1700)
select*from Department1

---------------------------employees table--------------------------------

create table employees (EMPLOYEE_ID int primary key,FIRST_NAME varchar (20), LAST_NAME varchar (20),
EMAIL varchar(20),PHONE_NUMBER bigint,HIRE_DATE date,JOB_ID varchar(15),
constraint q3 foreign key (JOB_ID) references Jobs(JOB_ID),
SALARY int,COMMISSION_PCT dec(10,2),MANAGER_ID int,DEPARTMENT_ID int,
constraint q4 foreign key (DEPARTMENT_ID) references Department1(DEPARTMENT_ID))
insert into employees values(100,'steven','king','SKING',5151234567,'6/17/2003','AD_PRES',24000,0,0,90),
insert into employees values(101,'neena','kochhar','NKOCHHAR',5151234568,'9/21/2005','AD_VP',17000,17000,17000,90),
insert into employees values(102,'lex','de haan','LDEHAAN',5151234569,'1/13/2001','AD_VP',17000,17000,17000,90),
insert into employees values(103,'alexander','hunold','AHUNOLD',5904234567,'1/3/2006','IT_PROG',9000,9000,9000,60),
insert into employees values(104,'bruce','ernst','BERNST',5904234568,'5/21/2007','IT_PROG',6000,6000,6000,60),
insert into employees values(105,'david','austin','DAUSTIN',5904234569,'6/25/2005','IT_PROG',4800,4800,4800,60),
insert into employees values(106,'valli','pataballa','VPATABAL',5904234560,'2/5/2006','IT_PROG',4800,4800,4800,60),
insert into employees values(107,'diana','lorentz','DLORENTZ',5904235567,'2/7/2007','IT_PROG',4200,4200,4200,60),
insert into employees values(108,'nancy','greenberg','NGREENBE',5151244569,'8/17/2002','FI_MGR',12008,12008,12008,100),
insert into employees values(109,'daniel','faviet','DFAVIET',5151244169,'8/16/2002','FI_ACCOUNT',9000,9000,9000,100),
insert into employees values(110,'john','chen','JCHEN',5151244269,'9/28/2005','FI_ACCOUNT',8200,8200,8200,100),
insert into employees values(111,'ismael','sciarra','ISCIARRA',5151244369,'9/30/2005','FI_ACCOUNT',7700,7700,7700,100),
insert into employees values(112,'jose manuel','urman','JMURMAN',5151244469,'3/7/2006','FI_ACCOUNT',7800,7800,7800,100),
insert into employees values(113,'luis','popp','LPOPP',5151244567,'12/7/2007','FI_ACCOUNT',6900,6900,6900,100),
insert into employees values(114,'den','raphaely','DRAPHEAL',5151274561,'12/7/2002','PU_MAN',11000,11000,11000,30),
insert into employees values(115,'alexander','khoo','AKHOO',5151274562,'5/18/2003','PU_CLERK',3100,3100,3100,30),
insert into employees values(116,'shelli','baida','SBAIDA',5151274563,'12/24/2005','PU_CLERK',2900,2900,2900,30),
insert into employees values(117,'sigal','tobias','STOBIAS',5151274564,'7/24/2005','PU_CLERK',2800,2800,2800,30),
insert into employees values(118,'guy','himuro','GHIMURO',5151274565,'11/15/2006','PU_CLERK',2600,2600,2600,30),
insert into employees values(119,'karen','colmenares','KCOLMENA',5151274566,'8/10/2007','PU_CLERK',2500,2500,2500,30),
insert into employees values(120,'matthew','weiss','MWEISS',6501231234,'7/18/2004','ST_MAN',8000,8000,8000,50),
insert into employees values(121,'adam','fripp','AFRIPP',6501232234,'4/10/2005','ST_MAN',8200,8200,8200,50),
insert into employees values(122,'payam','kaufling','PKAUFLIN',6501233234,'5/1/2003','ST_MAN',7900,7900,7900,50),
insert into employees values(123,'shanta','vollman','SVOLLMAN',6501234234,'10/10/2005','ST_MAN',6500,6500,6500,50),
insert into employees values(124,'kevin','mourgos','KMOURGOS',6501235234,'11/16/2007','ST_MAN',5800,5800,5800,50),
insert into employees values(125,'julia','nayer','JNAYER',6501241214,'7/16/2005','ST_CLERK',3200,3200,3200,50),
insert into employees values(126,'irene','mikkilineni','IMIKKILI',6501241224,'9/28/2006','ST_CLERK',2700,2700,2700,50),
insert into employees values(127,'james','landry','JLANDRY',6501241334,'1/14/2007','ST_CLERK',2400,2400,2400,50),
insert into employees values(128,'steven','markle','SMARKLE',6501241434,'3/8/2008','ST_CLERK',2200,2200,2200,50),
insert into employees values(129,'laura','bissot','LBISSOT',6501245234,'8/20/2005','ST_CLERK',3300,3300,3300,50),
insert into employees values(130,'mozhe','atkinson','MATKINSO',6501246234,'10/30/2005','ST_CLERK',2800,2800,2800,50),
insert into employees values(131,'james','marlow','JAMRLOW',6501247234,'2/16/2005','ST_CLERK',2500,2500,2500,50),
insert into employees values(132,'tj','olson','TJOLSON',6501248234,'4/10/2007','ST_CLERK',2100,2100,2100,50),
insert into employees values(133,'jason','mallin','JMALLIN',6501271934,'6/14/2004','ST_CLERK',3300,3300,3300,50),
insert into employees values(134,'michael','rogers','MROGERS',6501271834,'8/26/2006','ST_CLERK',2900,2900,2900,50),
insert into employees values(135,'ki','gee','KGEE',6501271734,'12/12/2007','ST_CLERK',2400,2400,2400,50),
insert into employees values(136,'hazel','philtanker','HPHILTAN',6501271634,'2/6/2008','ST_CLERK',2200,2200,2200,50),
insert into employees values(137,'renske','ladwig','RLADWIG',6501211234,'7/14/2003','ST_CLERK',3600,3600,3600,50),
insert into employees values(138,'stephen','stiles','SSTILES',6501212034,'10/26/2005','ST_CLERK',3200,3200,3200,50),
insert into employees values(139,'john','seo','JSEO',6501212019,'2/12/2006','ST_CLERK',2700,2700,2700,50),
insert into employees values(140,'joshua','patel','JPATEL',6501211834,'4/6/2006','ST_CLERK',2500,2500,2500,50),
insert into employees values(141,'trenna','rajs','TRAJS',6501218009,'10/17/2003','ST_CLERK',3500,3500,3500,50),
insert into employees values(142,'curtis','davies','CDAVIES',6501212994,'1/29/2005','ST_CLERK',3100,3100,3100,50),
insert into employees values(143,'randall','matos','RMATOS',6501212874,'3/15/2006','ST_CLERK',2600,2600,2600,50),
insert into employees values(144,'peter','vargas','PVARGAS',6501212004,'7/9/2006','ST_CLERK',2500,2500,2500,50),
insert into employees values(145,'john','russell','JRUSSEL',11441344429268,'10/1/2004','SA_MAN',14000,14000,14000,80),
insert into employees values(146,'karen','partners','KPARTNER',11441344467268,'1/5/2005','SA_MAN',13500,13500,13500,80),
insert into employees values(147,'alberto','errazuriz','AERRAZUR',11441344429278,'3/10/2005','SA_MAN',12000,12000,12000,80),
insert into employees values(148,'gerald','cambrault','GCAMBRAU',11441344619268,'10/15/2007','SA_MAN',11000,11000,11000,80),
insert into employees values(149,'eleni','zlotkey','EZLOTKEY',11441344429018,'1/29/2008','SA_MAN',10500,10500,10500,80)
insert into employees values(150,'peter','tucker','PTUCKER',11441344129268,'1/30/2005','SA_REP',10000,10000,10000,80),
insert into employees values(151,'david','bernstein','DBERNSTE',11441344345268,'3/24/2005','SA_REP',9500,9500,9500,80),
insert into employees values(152,'peter','hall','PHALL',11441344478968,'8/20/2005','SA_REP',9000,9000,9000,80),
insert into employees values(153,'christopher','olsen','COLSEN',11441344498718,'3/30/2006','SA_REP',8000,8000,8000,80),
insert into employees values(154,'nanette','cambrault','NCAMBRAU',11441344987668,'12/9/2006','SA_REP',7500,7500,7500,80),
insert into employees values155,'oliver','tuvault','OTUVAULT',11441344486508,'11/23/2007','SA_REP',7000,7000,7000,80),
insert into employees values(156,'janette','king','JKING',11441345429268,'1/30/2004','SA_REP',10000,10000,10000,80),
insert into employees values(157,'patrick','sully','PSULLY',11441345929268,'3/4/2004','SA_REP',9500,9500,9500,80),
										insert into employees values158,'allan','mcewen','AMCEWEN',11441345829268,'8/1/2004','SA_REP',9000,9000,9000,80),
										insert into employees values159,'lindsey','smith','LSMITH',11441345729268,'3/10/2005','SA_REP',8000,8000,8000,80),
										insert into employees values160,'louise','doran','LDORAN',11441345629268,'12/15/2005','SA_REP',7500,7500,7500,80),
										insert into employees values161,'sarath','sewall','SSEWALL',11441345529268,'11/3/2006','SA_REP',7000,7000,7000,80),
										insert into employees values162,'clara','vishney','CVISHNEY',11441346129268,'11/11/2005','SA_REP',10500,10500,10500,80),
										insert into employees values(163,'danielle','greene','DGREENE',11441346229268,'3/19/2007','SA_REP',9500,9500,9500,80),
										insert into employees values164,'mattea','marvins','MMARVINS',11441346329268,'1/24/2008','SA_REP',7200,7200,7200,80),
										insert into employees values(165,'david','lee','DLEE',11441346529268,'2/23/2008','SA_REP',6800,6800,6800,80),
										insert into employees values166,'sundar','ande','SANDE',11441346629268,'3/24/2008','SA_REP',6400,6400,6400,80),
										insert into employees values167,'amit','banda','ABANDA',11441346729268,'4/21/2008','SA_REP',6200,6200,6200,80),
insert into employees values(168,'lisa','ozer','LOZER',11441343929268,'3/11/2005','SA_REP',11500,11500,11500,80),
insert into employees values(169,'harrison','bloom','HBLOOM',11441343829268,'3/23/2006','SA_REP',10000,10000,10000,80),
										insert into employees values170,'tayler','fox','TFOX',11441343729268,'1/24/2006','SA_REP',9600,9600,9600,80),
										insert into employees values171,'william','smith','WSMITH',11441343629268,'2/23/2007','SA_REP',7400,7400,7400,80),
										insert into employees values172,'elizabeth','bates','EBATES',11441343529268,'3/24/2007','SA_REP',7300,7300,7300,80),
insert into employees values(173,'sundita','kumar','SKUMAR',11441343329268,'4/21/2008','SA_REP',6100,6100,6100,80),
insert into employees values(174,'ellen','abel','EABEL',11441644429267,'5/11/2004','SA_REP',11000,11000,11000,80)