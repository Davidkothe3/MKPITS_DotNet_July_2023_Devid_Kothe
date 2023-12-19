create table products(product_id int identity primary key,
                      product_name varchar(30) not null,
					  unit_price dec(10,2) check (unit_price > 0),
					  discounted_price dec(10,2) check (discounted_price > 0),
					      CHECK(discounted_price < unit_price)

);

insert into products values('aam',300,30)
insert into products values('aam',230,100)

select * from products

drop table products