create table TableNation1(NationID int primary key,
                          NationName varchar(500) 
);

insert into TableNation1 values(1,'india'),
                               (2,'dubai'),
							   (3,'shrilanka'),
							   (4,'nepal'),
							   (5,'china')

							   select * from TableNation1

							   


create table Tablestate1(Stateid int primary key,
                         NationID int
						 constraint fk foreign key(NationID) references TableNation1 (NationID),
						 StateName varchar(500)
);

insert into Tablestate1 values(11,1,'Maha'),
                              (12,2,'Doha'),
							  (13,3,'rampur'),
							  (14,4,'Janakpur'),
							  (15,5,'Biging')

							  select * from Tablestate1;
 

create table Tablecity1(cityID int primary key,
                        StateID int
	 constraint fk1 foreign key(StateID) references Tablestate1 (StateID),
                    	City_Name varchar(500)
);
insert into Tablecity1 values(31,11,'Nagpur'),
                            (32,12,'pune'),
							(33,13,'shrinagar'),
							(34,14,'chita'),
							(35,15,'rrttee')
	 select * from Tablecity1
	 

create table TableCourceRegDetails(
                      CourseRegID int primary key,
					  CategoryInd int,
					  FullName varchar(1500),
					  GenderInd int
);
insert into TableCourceRegDetails values(01,001,'David kothe',1),
                                        (02,002,'sarang prajapati',1),
										(03,003,'sujit kangar',1),
										(04,004,'ranu mandal',0),
										(05,005,'mrunal thakur',0)     
     select * from TableCourceRegDetails


create table TableRegDetail(
                                 RegAddressID int,
								 CourseRegID int 
      constraint fk2 foreign key(CourseRegID) references TableCourceRegDetails (CourseRegID),
								 NationID int
    constraint fk3 foreign key(NationID) references TableNation1 (NationID),
 
								 StateID int
  constraint fk4 foreign key(StateID) references Tablestate1 (StateID),

								 CityID int
  constraint fk5 foreign key(CityID) references Tablecity1 (CityID),

);

insert into TableRegDetail values(101,01,1,11,31),
(102,02,2,12,32),
(103,03,3,13,33),
(104,04,4,14,34),
(105,05,5,15,35)

select * from TableRegDetail

create table TableFeeDetail(
                     FeeID int,
					 CourseRegID int,
  constraint fk6 foreign key(CourseRegID) references TableCourceRegDetails (CourseRegID),
                     TotalAmount Decimal,
					 MinPer Decimal,
					 PaidAmount decimal,
					 BalenceAmount Decimal,
					 PaidDate DateTime

);

insert into TableFeeDetail values(9,01,4000,560,2000,6000,'2023-12-12'),
                                 (8,02,4000,460,2000,6000,'2023-12-12'),
								 (7,03,4000,450,6000,7000,'2023-12-12'),
								 (6,04,7000,560,8000,6000,'2023-12-12'),
								 (5,05,6000,780,6000,7000,'2023-12-12')

								 select * from TableFeeDetail

select * from TableFeeDetail


insert into TableFeeDetail

