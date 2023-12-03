use CMPT291_MovieRentalSystem;

drop table Customer;

create table Customer (
accountNo int primary key,
lastName varchar(50),
firstName varchar(50),
streetNo varchar(10),
streetName varchar(50),
aptNo varchar(10),
city varchar(50),
postalCode varchar(7),
phoneNumber varchar(13),
email varchar(50),
creditCard varChar(19),
rating int);