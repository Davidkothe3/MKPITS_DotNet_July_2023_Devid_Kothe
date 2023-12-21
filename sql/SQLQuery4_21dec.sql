create table student(id int identity primary key,
                      add_no varchar(50),
					  first_name varchar(50) not null,
					   last_name varchar(50) not null,
					   age int,
					   city varchar(30) not null
);

create table fees(add_no varchar(30),
              course varchar(30),
			  amt_paid bigint
   );

   insert into student(add_no,first_name,last_name,age,city)
     values('add1','veer','yadav',21,'waranasi'),
	       ('add2','sameer','gayakwad',21,'bhopal'),
		   ('add3','om','jadhav',23,'pusad'),
		   ('add4','shan','dongre',21,'nagpur'),
		   ('add5','vipul','somulwar',23,'kapil nagar'),
		   ('add6','aryan','varma',23,'kamti'),
		   ('add7','ashwin','nigam',23,'mominpura'),
		   ('add','david','kothe',23,'rewral')

		  

		   insert into fees(add_no,course,amt_paid)
		   values ('add5','java',60000),
		          ('add4','php',50000),
				  ('add6','dotnet',75000),
				  ('add7','dotnet',75000),
				  ('add8','java',60000)

				   select *from student
				  select * from fees

    select student.add_no , student.first_name , student.last_name , fees.course ,fees.amt_paid
	from student inner join fees
	on student.add_no = fees.add_no

	drop table student
	drop table fees
