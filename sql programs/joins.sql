create table student1(id int primary key identity,admission_no varchar(45) not null,first_name varchar(45)not null,last_name varchar(45)not null,age int,city varchar(25)not null); 


 insert into student1 values(1234,'karishma','pachdhare',15,'texas')
    insert into student1 values(5678, 'yogesh', 'pachdhare', 15, 'Alaska')     
   insert into student1 values(9012, 'tanu', 'meshram', 14, 'California')    
   insert into student1 values (3456,'mona', 'mohatkar', 17, 'New York')       
    insert into student1 values (7890, 'anjali', 'pathekar', 16, 'Florida')
    insert into student1 values(1357, 'jayesh', 'deshmukh', 15, 'Arizona')
    insert into student1 values(8013,'siddhi', 'rahate', 14, 'New York')      
    insert into student1 values(8345, 'payal', 'kupale', 13, 'California') 

create table fee(admission_no varchar(45) not null,course varchar(45) not null,amount_paid int);
      
      
    insert into fee VALUES (3354,'Java', 20000)      
   insert into fee values (7555, 'Android', 22000)       
    insert into fee values(4321, 'Python', 18000)    
    insert into fee values(8345,'SQL', 15000)      
   insert into fee values (5112, 'Machine Learning', 30000)

	SELECT Student1.admission_no, student1.first_name, student1.last_name, Fee.course, Fee.amount_paid  
    FROM student1  
    INNER JOIN Fee  
    ON student1.admission_no = Fee.admission_no;  

	---------------left outer join----------------------------
    SELECT Student1.admission_no, student1	.first_name, student1.last_name, Fee.course, Fee.amount_paid  
    FROM student1  
    LEFT OUTER JOIN Fee  
    ON student1.admission_no = Fee.admission_no;  

	---------------right outer join-----------------------------------
	    SELECT student1.admission_no, student1.first_name, student1.last_name, Fee.course, Fee.amount_paid  
    FROM student1  
    RIGHT OUTER JOIN Fee  
    ON student1.admission_no = Fee.admission_no;  

	----------------full outer join----------------------------
    SELECT student1.admission_no, student1.first_name, student1.last_name, Fee.course, Fee.amount_paid  
    FROM student1  
    FULL OUTER JOIN Fee  
    ON student1.admission_no = Fee.admission_no;  

	---------------cross join--------------------------------
	SELECT student1.admission_no, student1.first_name, 
    student1.last_name, Fee.course, Fee.amount_paid  
    FROM student1  
    CROSS JOIN Fee  




