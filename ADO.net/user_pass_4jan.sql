create table users01(id int identity primary key,
                     username varchar(30),
					 passwords varchar(40)
);
insert into users01 values('ram','pass123'),
                           ('sham','sham123'),
						   ('raghav','raghav123'),
						   ('raja','raja123')

						   select * from users01