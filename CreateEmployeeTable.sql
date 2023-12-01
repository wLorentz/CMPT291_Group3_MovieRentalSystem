use CMPT291_MovieRentalSystem;

drop table Employees;

create table Employees (
employeeID int,
ssn	int,
lastName varchar(20),
firstName varchar(20),
streetNo varchar(10),
streetName varchar (20),
aptNo varchar(10),
city varchar(20),
province varchar(20),
postalcode varchar(10),
phoneNumber varchar(15),
startDate date);