create table abc(id int ,
                 f_name varchar(20),
				 l_name varchar(20),
				 email varchar(20),
				 phone bigint
);

create table abclog(logid int identity,
                     id int,
					 f_name varchar(30) not null,
					 l_name varchar(30)not null,
					 email varchar(20) not null,
					 phone bigint not null,
					 operation varchar(20),
					 datetimes datetime
					 );

create trigger t13
on abc
for insert 
as 
insert into abclog(id,f_name,l_name,email,phone,operation,datetimes)
select id,f_name,l_name,email,phone,'insert',GETDATE()
from inserted;

insert into abclog(id,f_name,l_name,email,phone,operation,datetimes) values(1,'abc','bbbc','ab',333,'ins','2000-12-12')

insert into abc(id,f_name,l_name,email,phone)
    values(1,'david','kothe','dk@gamil.com',7030030823),
	    (2,'sarang','prajapati','sp@gmail.com',9885858586)

		select * from abc;
		select * from abclog;


		drop table abc;
		drop table abclog;