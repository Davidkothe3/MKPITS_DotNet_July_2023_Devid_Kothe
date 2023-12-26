create table memployee1(id int ,
                        first_name varchar(30),
						last_name varchar(30),
						phone bigint
);

create table emplog22(logid int identity (1,1)  not null,
              id int,
			  first_name varchar(30),
			  last_name varchar(30),
			  operation varchar(10),
			  updatedate date
			  );

create trigger t12
on memployee1
for insert 
as 
insert into emplog22(id,first_name,last_name,operation,updatedate)
select id,first_name,last_name,'insert',GETDATE()
from inserted;

insert into memployee1 values(1,'sarang','prajapati',9495969798)
insert into memployee1 values(2,'david','kothe',7030030823)

select * from memployee1;
select * from emplog22;


drop table memployee1;
drop table emplog22;