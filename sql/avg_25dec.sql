create table employee_info(employee_id int identity  primary key ,
                           names varchar(60),
						   occupation varchar(40),
						   working_date date,
						   working_hour varchar(40),
						   salary bigint
);

insert into employee_info(names,occupation,working_date,working_hour,salary)
     values('sarang','hr','2023-12-12',9,50000),
	       ('akash','hr','2023-12-12',9,56000),
		   ('lucky','hr','2023-12-12',8,50000),
		   ('sujit','cto','2023-12-12',8,45000),
		   ('ashwin','cto','2023-12-12',9,67000),
		   ('chetan','cto','2023-12-12',9,45000),
		   ('huzefa','tpo','2023-12-12',9,45000),
		   ('sahil','tpo','2023-12-12',7,45000),
		   ('anu','tpo','2023-12-12',9,45000),
		   ('adi','ceo','2023-12-12',8,45000)


		   select * from employee_info
   

          SELECT AVG(working_hour) AS "Average Working Hours"   
    FROM employee_info  
    WHERE occupation = 'tpo';   


	   drop table employee_info
