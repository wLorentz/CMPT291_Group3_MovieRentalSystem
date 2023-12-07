use CMPT291_MovieRentalSystem;

drop table "Order";
drop table "Copy";
drop table Customer;
drop table Employees;
drop table "Login";
drop table "Cast";
drop table Movies;
drop table Actor;

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

create table "Login" (
	userID int primary key,
	passHash varchar(64),
	salt varchar(20)
	);

create table Movies(
	movieID int primary key,
	movieName varchar(50),
	genre varchar(20),
	price float,
	copies int,
	rating float);

create table "Copy" (
	copyID int not null,
	movieID int not null,
	constraint pk_copy primary key (copyID, movieID));

CREATE TABLE "Order" (
    orderID int NOT NULL,
    "date" datetime,
    "status" varchar (50),
    fromDate datetime,
    toDate datetime,
    employeeID int,
    copyID int,
    movieID int,
    accountNo int,
    PRIMARY KEY (orderID),
    FOREIGN KEY (employeeID) REFERENCES Employees (employeeID),
    FOREIGN KEY (copyID, movieID) REFERENCES "Copy" (copyID, movieID),
    FOREIGN KEY (accountNo) REFERENCES Customer (accountNo)
	);

create table Actor (
	actorID int primary key,
	lastName varchar(50),
	firstName varchar(50),
	gender varchar(1),
	dateOfBirth date,
	age int,
	rating int
	);

create table "Cast" (
	actorID int,
	movieID int,
	foreign key (actorID) references Actor (actorID),
	foreign key (movieID) references Movies (movieID),
	constraint pk_cast primary key (actorID, movieID)
	);

insert into Employees values (0, 0, 'Admin', 'Admin', '', '', '', '', 0, '', '', '1970-01-01');
insert into "Login" values (0, '0B34583876036EE38FEBF28092396EE713CDFF6408AD33637AE494A62B73465E', 'Group3');

insert into Employees values (1, '123-456-789', 'Quinn', 'Liam', '14', 'Road Street', '', 'Edmonton', 0, 'B0B 0B0', '(123)456-7890', '2023-12-06');
insert into "Login" values (1, '7872AC4F64F1218CD4E58610B8EA46776AD08ED446C79F579FB53CC847A93AD9', 'p1ruVdxY8B');

insert into Movies values (0, 'Sweeney Todd', 'Thriller', 4.99, 5, 5);

insert into "Copy" values (0, 0);
insert into "Copy" values (1, 0);
insert into "Copy" values (2, 0);
insert into "Copy" values (3, 0);
insert into "Copy" values (4, 0);

insert into Actor values (0, 'Depp', 'Johnny', 'M', '1963-7-9', 0, 5);
insert into Actor values (1, 'Bohnam Carter', 'Helena', 'F', '1966-05-26', 0, 5);

insert into "Cast" values (0, 0);
insert into "Cast" values (1, 0);