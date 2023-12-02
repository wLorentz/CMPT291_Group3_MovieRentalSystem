CREATE TABLE "Order" (
    orderID int NOT NULL,
    "date" datetime,
    "status" varchar (50),
    fromDate datetime,
    toDate datetime,
    employeeID varchar(50),
    copyID int,
    movieID int,
    accountNo int,
    PRIMARY KEY (orderID),
    FOREIGN KEY (employeeID) REFERENCES employee (employeeID),
    FOREIGN KEY (copyID, movieID) REFERENCES "copy" (copyID, movieID),
    FOREIGN KEY (accountNo) REFERENCES customer (accountNo)
	);