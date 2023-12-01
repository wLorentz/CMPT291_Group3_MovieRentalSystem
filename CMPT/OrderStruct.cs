using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPT
{
    public struct OrderStruct
    {
        public int id;
        public DateTime date;
        public string status;
        public DateTime fromDate;
        public DateTime toDate;
        public string employeeID;
        public string copyID;
        public string movieID;
        public string accountNo;

        public OrderStruct(int orderId)
        {
            this.id = orderId;
        }
    }
}
