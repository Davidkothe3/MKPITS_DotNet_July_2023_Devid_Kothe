create table employee(empid int primary key,
                      empname varchar(50),
					  empmob bigint,
					  designation varchar(50),
					  salery bigint,
					  gender varchar(30),
					  hobbies varchar(30),
					  addresses varchar(1500)

);

insert into employee values(1,'david kothe',7030030823,'HR',50000,'male','outdoores games','chapru nagar chauk , nagpur'),
                           (2,'martand dhambare',8669775843,'QA',450000,'male','khokho','kondhali')

						   select * from employee