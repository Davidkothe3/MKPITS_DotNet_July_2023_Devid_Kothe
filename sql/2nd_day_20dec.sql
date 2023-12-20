create table salesmans2(ord_no bigint,
      purch_amt varchar(50),
	  order_date date,
	  customer_id int,
	  salesman_id int
)

insert into salesmans2(order_date,salesman_id,ord_no,purch_amt)
   values('2023-12-2',5002,70001,'150.5'),
       ('2012-09-10',5005,70009,'270.65'),
	   ('2012-10-05',5001,70002,'65.26'),
	   ('2012-08-17',5003,70004,'110.5'),
	   ('2012-09-10',5002,70007,'948.5')

	   select * from salesmans2;