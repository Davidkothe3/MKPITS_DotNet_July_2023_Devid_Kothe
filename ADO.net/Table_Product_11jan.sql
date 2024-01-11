
 create table Tableproduct(ProductID int primary key,
                          Product_Name varchar(1450),
						  Product_Category_ID int
						  Foreign key (Product_Category_ID) references TableProductCategory(Product_Category_ID),
						  Product_Price int
						  );

insert into Tableproduct values(210,'Apple',1002,40000),
                               (211,'Lenevo',1002,25000),
							   (212,'Samsung',1003,50000),
							   (213,'IFB',1004,20000),
							   (214,'LG',1004,30000),
							   (215,'Sony',1001,60000)
 
 create table ProductGSTDetail(Product_GST_ID int primary key,
                              GST_Detail_Name varchar(1400),
							  CGST decimal,
							  SGST decimal,
							  IGST	decimal
);
insert into ProductGSTDetail values(601,'AC And fridge',14,14,14),
                                   (602,'computers',9,9,9),
								   (603,'Printer',9,9,9),
								   (604,'Mobiles',6,6,6);

 create table TableProductCategory(Product_Category_ID int primary key,
                              Product_Type_Name Varchar(1500),
							  Product_Gst_ID int
		foreign key (Product_Gst_ID) references ProductGSTDetail (Product_Gst_ID)					  
 );

 insert into TableProductCategory values(1001,'Computer',602),
                                   (1002,'Mobile',604),
								   (1003,'Printer',603),
								   (1004,'AC And fridge',601)

								 




							  select * from ProductGSTDetail
								select * from TableProductCategory
							   select * from Tableproduct

							

create table invoiceDetail(Invoice_Detail_ID int,  
                           Customer_Name varchar(1400),
						   Customer_Contact bigint,
						   Product_Category_ID int
						   foreign key(Product_Category_ID) references TableProductCategory(Product_Category_ID),
						   ProductID int
						    foreign key(ProductID) references Tableproduct(ProductID),
						   Residential_Type_ID int,
						   Invoice_Date date,
						   Quantity int,
						   Price Bigint,
						   CGST int,
						   SGST int,
						   CGST_value int,
						   SGST_Value int,
						   IGST_Value int,
							TotalAmount int						   
);


