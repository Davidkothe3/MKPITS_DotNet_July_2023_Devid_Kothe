create table sales_order( cust_id int,order_id int ,
						  order_status varchar(40),
						  order_date date not null,
						  required_date date not null,
						  shipping_date date,
						  store_id varchar(40),
						  staff_id varchar(40) not null
		    
			);

    	insert into sales_order(cust_id , order_id , order_status , shipping_date,required_date , order_date , store_id , staff_id)
	 values(11,1212,'1','2023-12-12','2023-12-11','2023-12-14','store1','staff1')
	    
		insert into sales_order values(12,1213,'1','2023-12-12','2023-12-11','2023-12-14','store2','staff2')
		insert into sales_order values(13,1214,'1','2023-12-12','2023-12-11','2023-12-14','store3','staff3')
		insert into sales_order values(14,1223,'1','2023-12-12','2023-12-11','2023-12-14','store4','staff4')
		insert into sales_order values(15,1332,'1','2023-12-11','2023-12-14','2023-12-14','store6','staff6')


	 select * from sales_order

	 --------------------------------------------

	 create table sales_cust1(cust_id int ,
	                         first_name varchar(40),
							 last_name varchar(50),
							 phone bigint,
							 email varchar(50),
							 street varchar(50),
							 city varchar(40),
							 state varchar(40),
							 zip_code bigint
	  );

	  
	  select * from sales_cust1

	  insert into sales_cust1(cust_id,first_name,last_name,phone,email,street,city,state,zip_code)
	             values(11,'ram','charan',9034343434,'rcharan@gmail.com','goa','panji','goa',44553322)

				  insert into sales_cust1(cust_id,first_name,last_name,phone,email,street,city,state,zip_code)
				  values(12,'chaman','bhopali',5566778899,'chaman@gmail.com','wardhaman nagar','nagpur','maha',441313)
				 
				   insert into sales_cust1(cust_id,first_name,last_name,phone,email,street,city,state,zip_code)
				  values(13,'sham','sundar',3445667775,'sm@gmail.com','teliphone exchange','nagpur','maha',223344)
				 
				    insert into sales_cust1(cust_id,first_name,last_name,phone,email,street,city,state,zip_code)
				  values(14,'radha','rani',3344556677,'rani@gmail.com','sita buldi','nagpur','maha',344556)
				  
				    insert into sales_cust1(cust_id,first_name,last_name,phone,email,street,city,state,zip_code)
				  values(15,'sham','mohan',7766554444,'sham@gmail.com','ram mandir','nagpur','maha',554433) 

				   


				  select * from sales_cust1
				  select * from sales_order

				  select 
				  order_id,order_date,cust_id

				  from  sales_order

				  where cust_id in(
				  select 
				  cust_id

				  from
				  sales_cust1

				  where city = 'nagpur'
				  )

	  drop table sales_order
	 drop table sales_cust1