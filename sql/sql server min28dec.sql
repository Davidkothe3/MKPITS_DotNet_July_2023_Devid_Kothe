create table departments1(id int,
                           region varchar(50),
						   product varchar(50),
						   years int,
						   quantity int,
						   price bigint
                    
);

insert into departments1(id,region,product,years,quantity,price)
    values(1,'east','computer',2020,130,50000),
	      (2,'south','computer',2020,450,35000),
		  (3,'north','computer',2020,250,40000),
		  (4,'east','hard disk',2020,190,5500),
		  (5,'west','computer',2021,250,45000),
		  (6,'south','hard disk',2021,550,4400),
		  (7,'west','hard disk',2021,650,7500),
		  (8,'east','pan drive',2021,120,800),
		  (9,'north','mouse',2019,160,1500),
		  (10,'south','pan drive',2019,270,750),
		  (11,'east','mouse',2019,2000,1200),
		  (12,'west','pan drive',2019,190,650)


		  select * from departments1;

		  select product,quantity,price

		  from departments1

		  where quantity =(
		     select MIN (quantity)AS "Minimum Quantity"
			 from departments1
		  );

		  select product,MIN(quantity)AS "minimun quantity"
		  from departments1
		  group by product;

		  select product,MIN(quantity)AS "minimum quantity"
		  from departments1
		  group by product
		  having MIN(quantity)>100;


drop table departments1