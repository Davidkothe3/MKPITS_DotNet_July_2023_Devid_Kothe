create table Databases

create table TableProductGSTDetail(Product_gst_ID int primary key,
                                   gst_detail_Name varchar(1500),
								   cgst decimal,
								   sgst decimal,
								   igst decimal
);


sp_help TableproductGSTDetail
select * from TableProductGSTDetail
insert into TableProductGSTDetail values(1,'p1',5,5,5),
                                        (2,'p2',3,3,3),
										(3,'p3',2,2,2),
										(4,'p4',5,5,5),
										(5,'p5',7,7,7)

            select *from TableProductGSTDetail
			----------------------------------------------------------------------

			create table TableProductCategory (Product_category_id int ,
			                                   Product_type_name varchar(500),
											   Product_gst_ID int,
            foreign key(Product_gst_ID) references TableProductGSTDetail (Product_gst_ID)

			);

			insert into TableProductCategory values(01,'pt1',1),
			                                       (02,'pt2',2),
												   (03,'pt3',3),
												   (04,'pt4',4),
												   (05,'pt5',5)

            select * from TableProductCategory

			----------------------------------------------

			create table TableProduct(productid int,
			                          productTypeID	int,
									  product_name varchar(500)
			
			);

			insert into TableProduct values(10,001,'book'),
			                               (20,002,'pen'),
										   (30,003,'paper'),
										   (40,004,'pad'),
										   (50,005,'sharpnar')

										   select * from TableProduct

       ------------------------------------------------------------

	   create table TableInvoiceDetails(invoice_Detail_id int,
	                                    Customer_name varchar(500),
										Customer_Contact varchar(15),
										Product_category_id int ,
				 foreign key(Product_category_id) references TableProductGSTDetail (TableProductCategory),
                                      	productid int,
	     	 foreign key(productid) references TableProduct (productid),

										Residential_Type_id int,
										Invoice_Date DateTime,
										Quantity decimal,
										price decimal,
										cgst decimal,
										sgst decimal,
										igst decimal,
										cgst_value decimal,
										sgst_value decimal,
										igst_value decimal,
										total_amount decimal
	);
	 insert into TableInvoiceDetails values(5,'sarang','9696969696',9,01,10,'2023-12-12',50,500,6,6,6,67,67,67,600),
	                                       (4,'devid','9696969696',9,02,20,'2023-12-12',50,500,6,6,6,67,67,67,600),
										   (3,'chetan','9696569696',9,03,30,'2023-12-12',50,500,6,6,6,67,67,67,600),
										   (2,'lucky','9696929696',9,04,40,'2023-12-12',50,500,6,6,6,67,67,67,600),
								           (1,'akash','9996969696',9,05,50,'2023-12-12',50,500,6,6,6,67,67,67,600)


										   select * from TableInvoiceDetails