
 create table Nation(Nation_ID int primary key,
                     Nation_Name varchar(60)
 );

 insert into Nation values(1,'India'),
                          (2,'United-Nation'),
						  (3,'Nepal'),
						  (4,'Sri Lanka')

					
 create table States(State_ID int primary key,
                  State_Name varchar(50), 
				   Nation_ID int
				   Foreign key(Nation_ID) references Nation(Nation_ID)
				  );
				

				  insert into States values(101,'Andhar Pradesh',1),
				                            (102,'Panjab',1),
											(103,'California',2),
											(104,'Floroda',2),
											(105,'Koshi',3),
											(106,'Bagmati',3),
											(107,'Colombo',4),
											(108,'Ratanpura',4)
   
       select * from States
	   	  select * from Nation

		  Create table City(City_ID int primary key,
		                    City_Name varchar(40),
							State_ID int
							Foreign key(State_ID) references States(State_ID) 
							);

							sp_help City
		insert into City values(1001,'Vishakhapattan',101),
		                       (1002,'Vijaywada',101),
							   (1003,'Guntue',101),
							   (1004,'Amritsar',102),
							   (1005,'Jalandar',102),
							   (1006,'Chandigadh',102),
							   (1007,'Los Anjeles',103),
							   (1008,'San Joes',103),
							   (1009,'S Diego',103),
							   (1010,'Jacksonville',104),
							   (1011,'Miami',104),
							   (1012,'Tanpa',104),
							   (1013,'damak',105),
							   (1014,'Biratnagar',105),
							   (1015,'Bamepa',105),
							   (1016,'Banepa',106),
							   (1017,'Bharatpur',106),
							   (1018,'Hetauda',106),
							   (1019,'Grandpass',107),
							   (1020,'Borella',107),
							   (1021,'Pettah',107),
							   (1022,'Balangada',108),
							   (1023,'Kolonna',108),
							   (1024,'Panamura',108);

							   select * from City

			create table TableCourseRegDetail (CourseRegID int primary key,
			                     CategoryInd int,
								 FullName varchar(1500),
								 GenderInd int
			 );

			
			 insert into TableCourseRegDetail values(1,1,'ram',1),
			                          (2,2,'radha',0)

									  select * from TableCourseRegDetail

       create table TableRegAddresses (RegAddressID int identity,
	                           CourseRegID int primary key  ,
							   foreign key(CourseRegID) references TableCourseRegDetail(CourseRegID),
		                       Nation_ID int 
							   foreign key(Nation_ID) references Nation(Nation_ID),
							   State_ID int
							   foreign key(State_ID) references States(State_ID),
							   City_ID int 
							   Foreign key(City_ID) references City (City_ID)
							   );
							   select * from TableRegAddresses


   insert into TableRegAddresses values(1,1,1,101,1001),
                               (2,2,2,102,1002)


  create table TableFeesDetail(feesID int,
                    CourseRegID int
					foreign key(CourseRegID) references TableRegAddresses(CourseRegID),
					TotalAmount Decimal,
					MinPerc decimal,
					PaidAmount decimal,
					BalAmount decimal,
					PaidDate Date
  );
