
  ---- create table order111(oederid int,custid int , orderdate date,productname varchar(40),qty int ); 

   exec sp_help order11

create table order11 (orderid int , custid int, orderdate date,
productname varchar(20),qty int)

insert into order11 values(1,1,'2022-2-2','mouse',5)
insert into order11 values(1,1,'2022-2-2','keyboard',5)
insert into order11 values(2,2,'2022-2-2','desktop',5)
insert into order11 values(2,2,'2022-2-2','ram',5)
insert into order11 values(3,3,'2022-2-2','laptop',5)
insert into order11 values(4,3,'2022-1-2','mouse',5)
insert into order11 values(5,4,'2022-2-2','mouse',5)
insert into order11 values(6,4,'2022-2-2','ram',5)
insert into order11 values(7,5,'2022-2-2','desktop',5)
insert into order11 values(7,5,'2022-2-2','ram',5)

select * from order11;

