create table emp_table1(id int identity primary key,
                       names varchar(10),
					   phone bigint
);
insert into emp_table1(names,phone)
    values('ram',904565456),
		  ('sham',909809080),
		  ('laxman',9656565656),
		  ('sarang',4455667788),
		  ('sunny',555666778),
		  ('vipul',3344556676),
		  ('oshan',3456765455)

		  select names from emp_table1
		  