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
    fromDate date,
    toDate date,
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

insert into Customer values (0, 'Higgins', 'Bill', '12', 'Street Road', '5b', 'Edmonton', 'T0B 0B0', '(321)654-0987', 'bigbill@bill.bill', '1234-5678-9012-3456', 6);
insert into Customer values (1, 'Biggins', 'Hill', '21', 'Avenue Cres', '6b', 'Edmonton', 'T0B 0G0', '(420)694-4321', 'hillbig@hill.bill', '6543-2109-8765-4321', 9);

insert into Movies values (0, 'Sweeney Todd', 'Thriller', 4.99, 5, 5);
insert into Movies values (1, 'Blackhawk Down', 'Action', 5.99, 2, 9);

insert into "Copy" values (0, 0);
insert into "Copy" values (1, 0);
insert into "Copy" values (2, 0);
insert into "Copy" values (3, 0);
insert into "Copy" values (4, 0);
insert into "Copy" values (0, 1);
insert into "Copy" values (1, 1);

insert into Actor values (0, 'Depp', 'Johnny', 'M', '1963-07-09', 0, 5);
insert into Actor values (1, 'Bohnam Carter', 'Helena', 'F', '1966-05-26', 0, 5);
insert into Actor values (2, 'Bloom', 'Orlando', 'M', '1977-01-13', 0, 5); 

insert into "Cast" values (0, 0);
insert into "Cast" values (1, 0);
insert into "Cast" values (2, 1);

insert into "Order" values (0, '2023-01-12 12:12:12', '', '2023-01-13', '2023-01-20', 0, 0, 0, 0);
insert into "Order" values (1, '2023-05-25 12:12:12', '', '2023-05-26', '2023-07-08', 0, 0, 0, 1);
insert into "Order" values (2, '2023-05-24 12:12:12', '', '2023-12-15', '2023-12-27', 0, 0, 0, 1);
insert into "Order" values (5, '2023-12-12 12:12:12', '', '2023-12-13', '2023-12-20', 0, 0, 0, 0);
