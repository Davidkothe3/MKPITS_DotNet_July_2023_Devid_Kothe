
create table customerese(cust_id int primary key identity(1,1),
                      cust_name varchar(50),
					  cust_tel bigint
);

create table orderses(order_id int not null,
                     order_date date not null,
					 cust_id int,
					 prod_name varchar(50) not null,
					 quy int not null ,
					 rate bigint not null
);

insert into customerese values
                   ('ramanjan',9192939495),
			       ('aacharya',9293949392),
				   ('lakhan',7766554434),
				   ('krishana',8877665568),
				   ('balram',7766889976),
				   ('sudama',2323232323),
				   ('karna',9090909090),
				   ('arjun',8989898989)

				  

insert into orderses values(1122,'2023-12-21',1,'watch',3,50000),
		                   (2211,'2023-12-21',2,'buds',2,10000),
				           (2323,'2023-12-21',5,'laptop',1,60000),
				           (1313,'2023-12-21',4,'tv',2,80000),
				           (9090,'2023-12-21',7,'fride',1,24000)

select * from customerese
select * from orderses

select customerese.cust_id,customerese.cust_name,customerese.cust_tel , orderses.order_id,orderses.order_date,orderses.prod_name,orderses.quy,orderses.rate

from customerese inner join orderses
on customerese.cust_id = orderses.cust_id
