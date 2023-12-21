create table student5(id int identity primary key,
                      add_no varchar(50),
					  first_name varchar(50) not null,
					   last_name varchar(50) not null,
					   age int,
					   city varchar(30) not null
);

create table fees1(add_no varchar(30),
              course varchar(30),
			  amt_paid bigint
   );

   insert into student5(add_no,first_name,last_name,age,city)
     values('add1','veer','yadav',21,'waranasi'),
	       ('add2','sameer','gayakwad',21,'bhopal'),
		   ('add3','om','jadhav',23,'pusad'),
		   ('add4','shan','dongre',21,'nagpur'),
		   ('add5','vipul','somulwar',23,'kapil nagar'),
		   ('add6','aryan','varma',23,'kamti'),
		   ('add7','ashwin','nigam',23,'mominpura'),
		   ('add','david','kothe',23,'rewral')

		  

		   insert into fees1(add_no,course,amt_paid)
		   values ('add5','java',60000),
		          ('add4','php',50000),
				  ('add6','dotnet',75000),
				  ('add7','dotnet',75000),
				  ('add8','java',60000)

				   select *from student5
				  select * from fees1

    select student5.add_no , student5.first_name , student5.last_name , fees1.course ,fees1.amt_paid
	from student5 cross join fees1
	

	

