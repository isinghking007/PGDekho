--Below Query is used to create Database
Create database PGDekho_com

--Post Execution of above query , execute the below ones 
--Script of Registration of both User and Property Owner
create table Register(
UserId int identity(1,1) primary key,
FirstName varchar(100),
LastName varchar(100),
Email varchar(100),
Password varchar(10),
Phone varchar(10),
City varchar(50),
CreatedDate Datetime2(7),
PropertyOwner varchar(5)
)

