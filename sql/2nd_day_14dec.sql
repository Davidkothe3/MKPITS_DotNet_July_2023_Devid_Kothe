 create table mkpits ( id  int primary key,
 name varchar(50),
 batch varchar(50),
 payment_mode varchar(50),
 payement_date DATE
 );


 insert into mkpits(id,name,batch,payment_mode,payement_date)
 values (1,'ram','DOTNET','online','2023-12-12'),
 (2,'sham','JAVA','CASH','2023-12-11' )
 

 select * from mkpits

 insert into mkpits values(4,'bharat','dotnet','cash','2023-12-12')
 
 insert into mkpits values(3,'laxman','java','cash','2023-12-11')
 insert into mkpits values(5,'aman','dotnet','online','2023-12-10')
 insert into mkpits values(6,'amar','php','cash','2023-12-09')
 insert into mkpits values(7,'akash','php','cash','2023-12-2')
 insert into mkpits values(8,'bhola','php','online','2023-12-6')


 select * from mkpits  select payement_mode='online';
