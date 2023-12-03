use CMPT291_MovieRentalSystem;

drop table Login;

create table Login (
userID int primary key,
passHash varchar(64),
salt varchar(20));

insert into Login values (0, '0b34583876036ee38febf28092396ee713cdff6408ad33637ae494a62b73465e', 'Group3');