create table product(
                  product_id int identity primary key,
				  product_name varchar(50) not null,
				  unit_price dec(10,2) check(unit_price > 0) 
);

 insert into product values('mouse',100)
 insert into product values('keybord',120)  --// error--

 select * from product

 ------------------------------------------------

   create table result(roll int primary key,
         marks int check(marks > 0)
   );
  insert into result values(1,2)
  insert into result values(2,99)


select * from result;
-----------------------------------

create table products01(product_id int identity primary key,

                      product_name varchar(200) not null,

					  unit_price dec(10,2) constraint ck1 check(unit_price > 0)
);

insert into products01(product_name,unit_price)
       values('awesome Free BIKE',50)
     insert into products01   
		values('hunter',100)


	   select * from products01;

  drop table products01