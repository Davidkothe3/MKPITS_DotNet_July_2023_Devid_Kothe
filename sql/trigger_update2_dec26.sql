create table abc2(id int,
                  f_name varchar(20),
				  l_name varchar(20),
				  email varchar(20),
				  phone bigint
);

create table abclog1(logid int identity,
                     id int ,
					 f_name varchar(20),
					 l_name varchar(20),
					 email varchar(20),
					 phone bigint,
					 operation varchar(20),
					 datetimes date

);

create trigger t01
on abc2
after update
 as
 insert into abclog1(id,f_name,l_name,email,phone,operation,datetimes)
 select id,f_name,l_name,email,phone,'update',GETDATE()
 from deleted;

 insert into abc2 values(1,'ram','raghuwanshi','ram@gmail.com',9090909090),
                        (2,'sham','yadav','sham@gmail.com',5695695695)


						select * from abc2;
						select * from abclog1;
update abc2 set f_name='devid' where id=1