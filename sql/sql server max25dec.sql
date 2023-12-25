create table departments2(id int,
                           region varchar(50),
						   product varchar(50),
						   years int,
						   quantity int,
						   price bigint
                    
);

insert into departments2(id,region,product,years,quantity,price)
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

		  select * from departments2


		  select quantity,product,price
		   
		    from departments2
			where quantity =(
			   select max(quantity)AS "maximum quality"
			   from departments2
			);


			
    SELECT Product, MAX(Quantity) AS "Maximum Quantity"   
    FROM departments2  
    GROUP BY Product  
    ORDER BY Product;  

