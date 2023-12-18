create table student111(id int primary key,
            name varchar(40),
			city varchar(40),
			mob bigint
 );

 insert into student111(id,name,city, mob)

   values(1,'ram','nagpur',9900887655)

  insert into student111 values ( 2 , 'manohar' ,'bhangar' , 9876543210)
  insert into student111 values(3,'sunny','manewada',9944556677)
  insert into student111 values(4,'mohit','ramnagar',9900445567)
  insert into student111 values(5,'amar','aaaa',112233455)
  insert into student111 values(6,'baba','wwerrt',7654567866)

select * from student111

select city from student111 order by city asc -----only assending orderd city---- 
select name from student111 order by name asc ----- name assending orderd -----
select name from student111 order by name desc----name dessinding orderd-----

drop table student111

