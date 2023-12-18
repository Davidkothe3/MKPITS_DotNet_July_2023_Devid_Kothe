create table abc(salesperson_id int ,
                   first_name varchar(60),
				   last_name varchar(50)
);

create table address(address_id int ,
                      salesperson_id int,
					  city	varchar(40),
					  state varchar(40),
					  country varchar(40)
);

insert into abc values (1,'ram','wani')
 insert into abc values (2,'sham','yadav')
 insert into abc values (3,'madhav','warma')
 insert into abc values(4,'laxman','wani')

   insert into address values(1,2,'banaras','bihar','india')


 select * from abc

 drop table abc