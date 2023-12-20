CREATE TABLE stores (
	store_id INT IDENTITY (1, 1) PRIMARY KEY,
	store_name VARCHAR (255) NOT NULL,
	phone VARCHAR (25),
	email VARCHAR (255),
	street VARCHAR (255),
	city VARCHAR (255),
	state VARCHAR (10),
	zip_code VARCHAR (5)
);

insert into stores(store_name,phone,email,street,city,state,zip_code) values ('mana','1234567890','mana@gmail.com','sadar','nagpur','maharastra','4400')
select * from stores
insert into stores(store_name,phone,email,street,city,state,zip_code) values ('dhanush','2234567890','d@gmail.com','sadar','nagpur','maharastra','4400')
insert into stores(phone,email) values('3222','ab@gmail.com')
insert into stores(store_name,phone,email) values('radha','3222','ab@gmail.com')


----------------------------------------------------


CREATE TABLE staffs (
	staff_id INT IDENTITY (1, 1) PRIMARY KEY,
	first_name VARCHAR (50) NOT NULL,
	last_name VARCHAR (50) NOT NULL,
	email VARCHAR (255) NOT NULL UNIQUE,
	phone VARCHAR (25),
	active tinyint NOT NULL,
	store_id INT NOT NULL,
	manager_id INT,
	FOREIGN KEY (store_id) 
        REFERENCES stores (store_id) 
        ON DELETE CASCADE ON UPDATE CASCADE
);

insert into staffs(first_name,last_name,email,phone,active,store_id,manager_id)
    values('sunny','singh','ssingh@gmail.com','9933445633',1,1,420)

insert into staffs(first_name,last_name,email,phone,active,store_id,manager_id)
   values('mani','pal','mpal@gmial.com','3304405500',0,2,120)


	select * from staffs

	---------------------------------


	create table categories (
	     	category_id INT IDENTITY (1, 1) PRIMARY KEY,
	category_name VARCHAR (255) NOT NULL

	);

	insert into categories(category_name)
	   values('children bicycles'),
	         ('comfort bicycles'),
			 ('electric bikes')

	   select * from categories

	   -----------------------------------------------

	   create table brand(
	           brand_id INT IDENTITY (1, 1) PRIMARY KEY,
	           brand_name VARCHAR (255) NOT NULL

	   );

	   insert into brand(brand_name)
	      values('Electra'),
		        ('Haro'),
				('Heller')

				select * from brand

	---------------------------------------

	create table productaa(product_id int identity (1,1) primary key,
	                      product_name varchar(50) not null,
						  brand_id int not null,
						  category_id int not null,
						  modal_year int not null,
						  list_price dec (10,2)
						  FOREIGN KEY (category_id) 
                          REFERENCES categories (category_id) 
                          ON DELETE CASCADE ON UPDATE CASCADE,
	                      FOREIGN KEY (brand_id) 
                          REFERENCES brand (brand_id) 
                          ON DELETE CASCADE ON UPDATE CASCADE
);

	insert into productaa(product_name,brand_id,category_id,modal_year,list_price)
	      values('cycle',1,1,1990,10000),
		     ('hero',1,1,1030,300000),
			 ('electric',1,1,2019,100000)

			 select * from productaa

	drop table productaa

	----------------------------------

	create table sales_customers (customers_id int identity primary key,
	                              first_name varchar(50)not null,
								  last_name varchar(50)not null,
								  phone bigint not null,
								  email varchar(49) not null,
								  street varchar(60),
								  city varchar(40)not null,
								  state varchar(60) not null,
								  zip_code int

	);

	insert into sales_customers(first_name,last_name,phone,email,street,city,state,zip_code)
	          values('sarang','prajapati',9493959595,'sprajapati@gmail.com','indora','nagpur','maharastra',441434)

			  insert into sales_customers values('devid','kothe',7030030823,'devidk@gmail.com','milan chauk','rewral','maharastra',441401)

			  select * from sales_customers

			  ----------------------------

 Create Table sale_orders(
			       order_id INT IDENTITY (1, 1) PRIMARY KEY,
	               customer_id INT,
	               order_status tinyint NOT NULL,
                	-- Order status: 1 = Pending; 2 = Processing; 3 = Rejected; 4 = Completed
	               order_date DATE NOT NULL,
	               required_date DATE NOT NULL,
	               shipped_date DATE,
	               store_id INT NOT NULL,
	               staff_id INT NOT NULL,
                	FOREIGN KEY (customer_id) 
                    REFERENCES sales_customers (customers_id) 
                    ON DELETE CASCADE ON UPDATE CASCADE,
	                FOREIGN KEY (store_id) 
                    REFERENCES stores (store_id) 
                    ON DELETE CASCADE ON UPDATE CASCADE,
	                FOREIGN KEY (staff_id) 
                    REFERENCES staffs (staff_id) 
                   ON DELETE NO ACTION ON UPDATE NO ACTION

			  );

			  insert into sale_orders()