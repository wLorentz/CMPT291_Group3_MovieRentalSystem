use CMPT291_MovieRentalSystem;

create table MovieOrder (
orderID int,
orderTime time,
fromDate date,
toDate date,
employeeID int,
[copyID, movieID] int,
accountNo int
);