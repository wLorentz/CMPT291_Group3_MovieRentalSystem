use CMPT291_MovieRentalSystem;

drop table Copy;

create table Copy (
copyID int not null,
movieID int not null,
constraint pk_copy primary key (copyID, movieID));