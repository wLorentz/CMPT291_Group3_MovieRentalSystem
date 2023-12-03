use CMPT291_MovieRentalSystem;

drop table Movies

create table Movies(
movieID int primary key,
movieName varchar(50),
genre varchar(20),
price float,
copies int,
rating float);