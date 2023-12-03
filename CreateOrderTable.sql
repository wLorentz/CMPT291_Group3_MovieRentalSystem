use CMPT291_MovieRentalSystem;

drop table "Order";

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