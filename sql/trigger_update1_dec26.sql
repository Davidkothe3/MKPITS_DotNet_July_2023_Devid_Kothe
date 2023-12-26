create table Student1(Id int , Firstname varchar(20),Lastname varchar(20))

create table Studentlog(Logid int identity (1,1),Id int, Firstname varchar(20),Lastname varchar(20),Operation varchar(20),Updatetime datetime)
drop table Studentlog
Create Trigger T4 on Student1 for insert as insert into Studentlog(Id,Firstname,Lastname,Operation,Updatetime) 
select Id,Firstname,Lastname,'Update',GETDATE() from inserted;

insert into Student1 values(1,'Akash','Gautam')
insert into Student1 values(2,'David','Kothe')
insert into Student1 values(1,'Sarang','Praja')
select * from Student1
select * from Studentlog
