create table products001(product_id int identity primary key,
                       product_name varchar(40) not null,
					   unit_price dec(10,2),
					   discounted_price dec(10,2),
					   check(unit_price > 0),
					   check(discounted_price > 0),
					   check (discounted_price < unit_price)
---- ( we can write also )  CHECK(discounted_price > 0 AND discounted_price > unit_price) ----
-----      CONSTRAINT valid_prices CHECK(discounted_price > unit_price)
-----

);

insert into products001 values('laptop',50000,5000)

select * from products001;

drop table products001