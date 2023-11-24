using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPT
{

    internal class Customer
    {
        private string accountNo;
        private string firstName;
        private string lastName;
        private string streetNo;
        private string streetName;
        private string aptNo;
        private string city;
        private string postalCode;
        private string phoneNumber;
        private string email;
        private string creditCard;
        private string rating;


        public Customer(CustomerStruct customerStruct) 
        {
            this.accountNo = customerStruct.accountNo;
            this.firstName = customerStruct.firstName;
            this.lastName = customerStruct.lastName;
            this.streetNo = customerStruct.streetNo;
            this.streetName = customerStruct.streetName;
            this.aptNo = customerStruct.aptNo;
            this.city = customerStruct.city;
            this.postalCode = customerStruct.postalCode;
            this.phoneNumber = customerStruct.phoneNumber;
            this.email = customerStruct.email;
            this.creditCard = customerStruct.creditCard;
            this.rating = customerStruct.rating;
        }

        public string AccountNo { get { return accountNo; } }
    }
}
