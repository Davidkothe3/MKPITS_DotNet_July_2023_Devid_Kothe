create table studentses12(rollno int ,
                           name varchar(50),
						   email varchar(50),
						   city varchar(30),
						   courseid varchar(50)
)


create table fees12( rollno int,
                      feesid varchar(30),
					 feesdate date, 
					 amount bigint,
					 courseid varchar(50)
)


insert into studentses12 values (1,'maru','maru@gmail.com','nagpur','java'),
                                 (2,'sunny','sunny@gmail.com','nagpur','php'),
								 (3,'raj','raj@gmail.com','nagpur','dotnet'),

								 (4,'mira','mira@gmail.com','mumbai','java'),
								 (5,'radha','radha@gmail.com','mumbai','php'),
								 (6,'mona','mona@gmail.com','mumbai','dotnet'),

								 (7,'sarang','sarang@gmail.com','dehli','java'),
								 (8,'aakash','aakash@gmail.com','dehli','php'),
								 (9,'aswin','aswin@gmail.com','dehli','dotnet')

								


 insert into fees12 values (1,'fees1','2023-12-1',15000,'java'),
                            (2,'fees2','2023-12-1',20000,'php'),
							(3,'fees3','2023-12-1',25000,'dotnet'),

							(4,'fees4','2023-12-1',15000,'java'),
							(5,'fees5','2023-12-1',20000,'php'),
							(6,'fees6','2023-12-1',25000,'dotnet'),

							(7,'fees7','2023-12-1',15000,'java'),
							(8,'fees8','2023-12-1',20000,'php'),
							 (9,'fees9','2023-12-1',25000,'dotnet')


							  select * from studentses12
							  select *from fees12

 drop table fees12
 drop table studentses12


