 create table students ( rno int , name varchar(20))


 select * from students 
 insert into students values ( 1 ,'sujit')
 insert into students values(2,'lucky')
 insert into students values(3,'sarang')
 insert into students values (4,'chetan')
 insert into students values (5,'devid')

 select * from students

 ---------------------------------------

 create table producta(id int ,product varchar(40), price int , quantity int )

 select * from producta

 insert into producta values(1,'sabun',15,5)
 insert into producta values(2,'musted oil',350,1)
 insert into producta values(3,'lux',10,4)

  ---------------------------------------

create table customer1 (custid int primary key,custname 
varchar(20))

select * from customer1
 
 insert into customer1 values (1 , 'devid')
  insert into customer1 values (2 , 'devid')


  -----------------------------------------

  -- create a databse mkpits1--

  create table product2( rno int primary key, name varchar(40),address varchar(60),mobile int ) 

  select * From product2

  insert into product2 values (1,'sarang','indora',11009976)
  insert into product2 values (2,'lucky','pachpauli',55667785)
  insert into product2 values(3,'chetan','metro station',112233)
  insert into product2 values(4,'sujit','bhandara',00998877)
  insert into product2 values(5,'huzefa','gondia',55667789)
  insert into product2 values(6,'akash','wanadongri',1223445)
  insert into product2 values (7,'aswin','ramanamaruti',44556678)
  insert into product2 values(8,'rajat','rewral',7758058753)


  -----------------------------

  create table user1 (userid int,user_name varchar(18),password varchar(50),email varchar(30),
  gender varchar(20),city varchar(50),state varchar(40),country varchar(50))

  select * from user1

  insert into user1 values(1,'david','pass1234','khotedevid@gmail.com','male',
  'chapru nagar nagpur','Maharastra','India')

  insert into user1 values(2,'pranay','pass1232','pranaykothe@gmail.com','male',
  'rewral','maha','india')