using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT
{
    public partial class ModifyCustomerForm : Form
    {
        Form1 mainFrom;
        bool isNew;
        int accountNumber;
        public ModifyCustomerForm(Form1 mainForm, bool isNew, int accountNumber)
        {
            InitializeComponent();

            this.mainFrom = mainForm;
            this.isNew = isNew;
            this.accountNumber = accountNumber;
        }

        private void PopulateFields(Customer customer)
        {
            lastNameTextBox.Text = customer.LastName;
            firstNameTextBox.Text = customer.FirstName;
            streetNumberTextBox.Text = customer.StreetNo;
            streetNameTextBox.Text = customer.StreetName;
            aptNumberTextBox.Text = customer.AptNo;
            cityTextBox.Text = customer.City;
            postalCodeTextBox.Text = customer.PostalCode;
            phoneNumberTextBox.Text = customer.PhoneNumber;
            emailTextBox.Text = customer.Email;
            creditCardTextBox.Text = customer.CreditCard;
            ratingTextBox.Text = customer.Rating;
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            saveButton.Enabled = false;
            saveButton.Visible = false;

            addButton.Enabled = false;
            addButton.Visible = false;

            ratingTextBox.Enabled = false;
            ratingTextBox.Visible = false;

            ratingLabel.Enabled = false;
            ratingLabel.Visible = false;

            accountNumberText.Text = accountNumber.ToString();
            if (isNew)
            {
                addButton.Visible = true;
                addButton.Enabled = true;

                ratingTextBox.Text = "0";

            }
            else
            {
                saveButton.Enabled = true;
                saveButton.Visible = true;

                ratingTextBox.Enabled = true;
                ratingTextBox.Visible = true;

                ratingLabel.Enabled = true;
                ratingLabel.Visible = true;

                PopulateFields(mainFrom.GetDatabase().GetCustomerByAccountNumber(accountNumber));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerStruct customerStruct = new(accountNumber);

            customerStruct.lastName = lastNameTextBox.Text;
            customerStruct.firstName = firstNameTextBox.Text;
            customerStruct.streetNo = streetNumberTextBox.Text;
            customerStruct.streetName = streetNameTextBox.Text;
            customerStruct.aptNo = aptNumberTextBox.Text;
            customerStruct.city = cityTextBox.Text;
            customerStruct.postalCode = postalCodeTextBox.Text;
            customerStruct.phoneNumber = phoneNumberTextBox.Text;
            customerStruct.email = emailTextBox.Text;
            customerStruct.creditCard = creditCardTextBox.Text;
            customerStruct.rating = ratingTextBox.Text;

            mainFrom.AddCustomer(new Customer(customerStruct));

            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            CustomerStruct customerStruct = new(accountNumber);

            customerStruct.lastName = lastNameTextBox.Text;
            customerStruct.firstName = firstNameTextBox.Text;
            customerStruct.streetNo = streetNumberTextBox.Text;
            customerStruct.streetName = streetNameTextBox.Text;
            customerStruct.aptNo = aptNumberTextBox.Text;
            customerStruct.city = cityTextBox.Text;
            customerStruct.postalCode = postalCodeTextBox.Text;
            customerStruct.phoneNumber = phoneNumberTextBox.Text;
            customerStruct.email = emailTextBox.Text;
            customerStruct.creditCard = creditCardTextBox.Text;
            customerStruct.rating = ratingTextBox.Text;
            Customer customer = new Customer(customerStruct);
            mainFrom.saveCustomer(customer);

            this.Close();
        }
    }
}
