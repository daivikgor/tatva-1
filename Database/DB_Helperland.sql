create database Helperland

create table tblCustomer(
Customer_Id int Not NULL IDENTITY(1,1) PRIMARY KEY,
Customer_Firstname NCHAR(20) NOT NULL,
Customer_LastName NCHAR(20) NOT NULL,
Customer_Email NCHAR(20) NOT NULL,
Customer_Mobile int NOT NULL,
Customer_Password NCHAR(60) NOT NULL,
Customer_Terms_Condition bit NOT NULL,
Customer_Privacy_Policy bit NOT NULL
)

create table tblServiceProvider(
Provider_Id int Not NULL IDENTITY(1,1) PRIMARY KEY,
Provider_Firstname NCHAR(20) NOT NULL,
Provider_LastName NCHAR(20) NOT NULL,
Provider_Email NCHAR(20) NOT NULL,
Provider_Mobile int NOT NULL,
Provider_Password NCHAR(60) NOT NULL,
Provider_Gender NCHAR(20) NOT NULL,
Provider_Birthdate Date NOT NULL,
Provider_Nationality NCHAR(20) NOT NULL,
Provider_Avatar NCHAR(20) NOT NULL,
Provider_Terms_Condition bit NOT NULL,
Provider_Privacy_Policy bit NOT NULL,
)

create table tblAdmin(
Admin_Id int Not NULL IDENTITY(1,1) PRIMARY KEY,
Admin_Firstname NCHAR(20) NOT NULL,
Admin_LastName NCHAR(20) NOT NULL,
Admin_Email NCHAR(20) NOT NULL,
Admin_Password NCHAR(60) NOT NULL
)

create table Address(
Address_id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
House_Number NCHAR(20) NOT NULL,
Street_Number NCHAR(20) NOT NULL,
Postal_Code int NOT NULL,
City NCHAR(20) NOT NULL,
Mobile_Number int NULL
)

create table tblContact_Us(
Contact_id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
C_Firstname NCHAR(20) NOT NULL,
C_LastName NCHAR(20) NOT NULL,
C_Email NCHAR(20) NOT NULL,
C_Mobile int NOT NULL,
C_Purpose NCHAR(100) NOT NULL,
C_Message NCHAR(500) NOT NULL,
C_File_Attachment VARCHAR(MAX) NULL,
C_Privacy_Policy bit NOT NULL 
)

create table tblService_Request(
Service_id int NOT NULL IDENTITY(1000,1) PRIMARY KEY,
Service_Date Date NOT NULL ,
Service_Time Time NOT NULL,
Customer_Id int NOT NULL,
Provider_Id int NOT NULL,
Service_Pincode int Not NULL,
Service_Status NCHAR(50) NOT NULL,
Total_Hours int Not NULL,
Extra_Service Nchar(50) NOT NULL,
Amount int NOT NULL,
pets bit,
Constraint FK_CustomerID_service Foreign key(Customer_Id) References tblCustomer(Customer_Id),
Constraint FK_ProviderID_service Foreign key(Provider_Id) References tblServiceProvider(Provider_Id)
)
create table Service_List(
Service_id int NOT NULL,
Provider_Id int NOT NULL,
Customer_Id int NOT NULL,
Constraint FK_Serviceid_service_List Foreign key(Service_id) References tblService_Request(Service_id),
Constraint FK_CustomerID_service_List Foreign key(Customer_Id) References tblCustomer(Customer_Id),
Constraint FK_ProviderID_service_List Foreign key(Provider_Id) References tblServiceProvider(Provider_Id)
)

create table tbl_PaymentDetails(
Payment_Id int NOT NULL IDENTITY(1000,1) PRIMARY KEY,
Customer_Id int NOT NULL,
CardNumber int Not NULL,
Promo_Code NCHAR(20) NULL,
Constraint FK_CustomerID_PaymentDetails Foreign key(Customer_Id) References tblCustomer(Customer_Id)
)

create table tbl_Service_Feedback(
Service_id int NOT NULL,
Provider_Id int NOT NULL,
Customer_Id int NOT NULL,
Ontime_Arrival bit Not NULL,
Feedback VARCHAR,
Friendly Bit NOt NULL,
Constraint FK_Serviceid_service_Feedback Foreign key(Service_id) References tblService_Request(Service_id),
Constraint FK_CustomerID_service_Feedback Foreign key(Customer_Id) References tblCustomer(Customer_Id),
Constraint FK_ProviderID_service_Feedback Foreign key(Provider_Id) References tblServiceProvider(Provider_Id)
)



