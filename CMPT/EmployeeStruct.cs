using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPT
{
    public struct EmployeeStruct
    {
        public int id;
        public string ssn;
        public string lastName;
        public string firstName;
        public string streetNo;
        public string streetName;
        public string aptNo;
        public string city;
        public ProvinceEnum province;
        public string postalCode;
        public string phoneNumber;
        public DateTime startDate;

        public EmployeeStruct (int id)
        {
            this.id = id;
        }
    }
}
