create table person(id int identity primary key,
                    first_name varchar(50) not null,
					last_name varchar(50) not null,
					email varchar(100) unique
);

insert into person values('sarang','prajapati','ksp@gmail.com')
insert into person values('david','kothe','dk@gmail.com')

select * from person