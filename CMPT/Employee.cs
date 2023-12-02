using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPT
{
    public class Employee
    {
        private int id;
        private string ssn;
        private string lastName;
        private string firstName;
        private string streetNo;
        private string streetName;
        private string aptNo;
        private string city;
        private ProvinceEnum province;
        private string postalCode;
        private string phoneNumber;
        private string startDate;

        public Employee(EmployeeStruct employeeStruct) 
        {
            id = employeeStruct.id;
            ssn = employeeStruct.ssn;
            lastName = employeeStruct.lastName;
            firstName = employeeStruct.firstName;
            streetNo = employeeStruct.streetNo;
            streetName = employeeStruct.streetName;
            aptNo = employeeStruct.aptNo;
            city = employeeStruct.city;
            province = employeeStruct.province;
            postalCode = employeeStruct.postalCode;
            phoneNumber = employeeStruct.phoneNumber;
            startDate = employeeStruct.startDate;
        }

        public int EmployeeID {  get { return id; } }
        public string Ssn { get {  return ssn; } }
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName;} }
        public string StreetNo { get { return streetNo; } }
        public string StreetName { get { return streetName; } }
        public string AptNo {  get { return aptNo; } }
        public string City { get { return city; } }
        public ProvinceEnum Province { get { return province; } }
        public string PostalCode { get {  return postalCode; } }
        public string PhoneNumber { get {  return phoneNumber; } }
        public string StartDate {  get { return startDate; } }
    }
}
