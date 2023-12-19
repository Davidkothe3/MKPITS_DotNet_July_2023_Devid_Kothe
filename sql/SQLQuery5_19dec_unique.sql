create table persons(person_id int identity primary key,
                         first_name varchar(50),
						 last_name varchar(50),
						 email varchar(40),
						 constraint unique_email unique(email)
);

insert into persons values('ram','madhav','rm@gmail.com')
insert into persons values('sham','yadav','sy@gnail.com')
insert into persons values('arjun','aaryawanshi','aaryawanshia@gmail.com')

select * from persons