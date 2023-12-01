using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPT
{

    public class Customer
    {
        private int accountNo;
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

        public int AccountNo { get { return accountNo; } }
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }
        public string StreetNo { get { return streetNo; } }
        public string StreetName { get { return streetName; } }
        public string AptNo { get { return aptNo; } }
        public string City { get { return city; } } 
        public string PostalCode { get { return postalCode; } }
        public string PhoneNumber { get { return phoneNumber; } }
        public string Email { get { return email; } }
        public string CreditCard { get {  return creditCard; } }
        public string Rating { get { return rating; } }
    }
}
