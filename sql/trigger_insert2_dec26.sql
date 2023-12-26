

create table semployee(empid int primary key,names varchar(50));

create table EmpLog(logid int identity primary key,
                     empid int not null,
					 operaion nvarchar(50)not null,
					 updatedate datetime not null

);

drop table semployee

create trigger empt
on semployee
for insert
as
insert into EmpLog(EmpID,operaion,updatedate)
select empid,'insert',GETDATE() from inserted; 


 insert into semployee values(1,'ram')

 select * from semployee;
 select * from emplog;

 insert into semployee values(2,'sham')
 select * from semployee;
 select * from emplog;