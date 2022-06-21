Create Database OneStore;
use OneStore;

Create table Employee
(Emp_ID varchar(5)primary key constraint EEmp_ID check(Emp_ID like'E%'),
Emp_First_Name Varchar(25)not null,Emp_Second_Name Varchar(25)not null,
Emp_Address varchar(50)not null,Emp_DOB date not null,
Age int not null,Emp_TP int,
Emp_Position Varchar(8)not null constraint EEmp_Position check(Emp_Position IN('Admin','Seller')),
FingerPrint_ID int not null,Emp_UserName varchar(20) not null,Emp_Password varchar(15)not null);

select * from Employee;

create table Employee_records
(record_ID  int IDENTITY primary key,Emp_ID varchar(5)not null,Emp_First_Name varchar(25)not null,Emp_Second_Name varchar(25)not null,
Pc_Name varchar(50)not null,Operation varchar(10)not null,DateTime datetime default getdate());

select * from Employee_records;

create table Product
(Pro_ID varchar(5) primary key constraint PPro_ID check(Pro_ID like 'P%'),
Pro_Name varchar(20) not null,Brand varchar(25)not null,Category varchar(15) not null,
Barcode  varchar(50) not null,Price int not null,
Pro_Image Image not null);

select * from Product;

create table Customer
(Cus_ID varchar(5)Primary key constraint CCus_ID check(Cus_ID like 'C%'),
Cus_Name varchar(20)not null,NIC varchar(20),Cus_Tel varchar(25) not null,
Loyalty_Card_No varchar(50)not null,Points int);

select * from Customer;

create table Database_records
(record_ID  int IDENTITY primary key,Emp_ID varchar(5)not null,Emp_First_Name varchar(25)not null,Emp_Second_Name varchar(25)not null,
Pc_Name varchar(50)not null,Operation varchar(10)not null,TableName varchar(20)not null, DateTime datetime default getdate());

select * from Database_records;


create table Sales_records
(record_ID int IDENTITY primary key,Bill_No int not null,
Pro_ID varchar(5)not null,Pro_Name varchar(20),
Price int not null,Quantity int,Total_Bill int not null,
Seller_ID varchar(5)not null,Seller_Name varchar(20) not null,
Pc_Name varchar(50) not null,DateTime datetime default getdate());

select * from Sales_records;

insert into Employee values
('E01','Yasiru','Ravishan','Rathmalana','2000-04-02',21,0710131423,'Admin',1,'yas@admin','12345'),
('E02','Ravishan','Yasiru','Rathmalana','2000-04-02',21,0710131423,'Seller',2,'rav@seller','12345'),
('E03','Pasan','Dewmal','Bandaragama','2000-05-05',21,0712355676,'Admin',3,'pas@admin','12345'),
('E04','Dewmal','Pasan','Bandaragama','2000-05-05',21,0712355676,'Seller',4,'dew@seller','12345'),
('E05','Chathuranga','Weerasinghe','Polgasowita','1996-04-02',24,0710001423,'Admin',5,'cha@admin','12345'),
('E06','Weerasinghe','Chathuranga','Polgasowita','1996-04-02',24,0710001423,'Seller',6,'wee@seller','12345'),
('E07','Chamith','Eranda','Panadura','2000-05-02',21,0710131400,'Admin',7,'cha@admin','12345'),
('E08','Eranda','Chamith','Panadura','2000-05-02',21,0710131400,'Seller',8,'era@seller','12345'),
('E09','Oshan','Madushanka','Borella','2000-04-29',21,0710136723,'Admin',9,'osh@admin','12345'),
('E10','Madushanka','Oshan','Borella','2000-04-29',21,0710136723,'Seller',10,'mad@seller','12345');
select * from Employee;
