using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPT
{
    public class Order
    {
        private int id;
        private DateTime date;
        private string status;
        private DateTime fromDate;
        private DateTime toDate;
        private string employeeID;
        private string copyID;
        private string movieID;
        private string accountNo;

        public Order(OrderStruct orderStruct)
        {
            this.id = orderStruct.id;
            this.date = orderStruct.date;
            this.status = orderStruct.status;
            this.fromDate = orderStruct.fromDate;
            this.toDate = orderStruct.toDate;
            this.employeeID = orderStruct.employeeID;
            this.copyID = orderStruct.copyID;
            this.movieID = orderStruct.movieID;
            this.accountNo = orderStruct.accountNo;
        }

        public int OrderID { get { return id; } }

        public DateTime Date { get { return date; } }
        
        public string Status {  get { return status; } }

        public DateTime FromDate { get { return fromDate; } }

        public DateTime ToDate { get { return toDate; } }

        public string EmployeeID { get { return employeeID; } }

        public string CopyID { get { return copyID; } }

        public string MovieID { get { return movieID; } }

        public string AccountNo {  get { return accountNo; } }
    }
}
