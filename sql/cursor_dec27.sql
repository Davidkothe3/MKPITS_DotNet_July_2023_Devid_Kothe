create table production_product(product_id int ,
                                product_name varchar(40),
								brand_id int,
								category_id int,
								modal_year int,
								list_price bigint
);

insert into production_product values(1,'computer',1212,1,2023,56000),
                                     (2,'mouse',1121,2,2023,300),
									 (3,'printer',1211,3,2023,10000),
									 (4,'keybord',1122,4,2023,400),
									 (5,'speaker',1221,5,2023,700),
									 (6,'projector',2332,6,4554,9000)

									 select * from production_product

									 declare
									 @product_name varchar(max),
									 @list_price bigint;

									 declare cursor_product cursor
									 for select
									  product_name,
									  list_price
                            from
							    production_product;

								open
								 cursor_product;

								 fetch next from cursor_product into 
								 @product_name,
								 @list_price;

								 print @product_name +cast(@list_price as varchar);

								 while @@FETCH_STATUS=0

								 begin

			
          PRINT @product_name + CAST(@list_price AS varchar);
		    FETCH NEXT FROM cursor_product  INTO 
		
            @product_name, 
            @list_price;
    END;


	close cursor_product1;
	deallocate cusor_product1;



				 	         