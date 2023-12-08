using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPT
{
    public struct CustomerStruct
    {
        public int accountNo;
        public string firstName;
        public string lastName;
        public string streetNo;
        public string streetName;
        public string aptNo;
        public string city;
        public string postalCode;
        public string phoneNumber;
        public string email;
        public string creditCard;
        public string rating;

        public CustomerStruct(int accountNo) 
        {
            this.accountNo = accountNo;
        }
    }
}
