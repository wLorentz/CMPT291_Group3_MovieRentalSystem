use CMPT291_MovieRentalSystem;

drop table Employees;

create table Employees (
employeeID int primary key,
ssn	varchar(11),
lastName varchar(20),
firstName varchar(20),
streetNo varchar(10),
streetName varchar (20),
aptNo varchar(10),
city varchar(20),
province int,
postalcode varchar(10),
phoneNumber varchar(15),
startDate date);

insert into Employees values (0, 0, 'Admin', 'Admin', '', '', '', '', 0, '', '', '1970-01-01');