using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CMPT
{
    public partial class ModifyCustomerForm : Form
    {
        Form1 mainFrom;
        bool isNew;
        int accountNumber;

        Color errorColor = Color.LightCoral;

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

        private bool ValidateEmail()
        {
            bool hasOneAmprisand = emailTextBox.Text.IndexOf('@') != -1 && emailTextBox.Text.Count(f => f == '@') == 1;
            bool hasDomain = (emailTextBox.Text.LastIndexOf('.') > emailTextBox.Text.IndexOf('@')) && emailTextBox.Text.LastIndexOf('.') != emailTextBox.Text.Length - 1;

            bool validEmail = (hasDomain && hasOneAmprisand && !emailTextBox.Text.StartsWith('.') && !emailTextBox.Text.StartsWith('@')) || emailTextBox.Text.Length == 0;

            if (validEmail)
            {
                emailTextBox.BackColor = Color.White;
            }
            else
            {
                emailTextBox.BackColor = errorColor;
            }

            return validEmail;
        }

        private bool ValidatePhoneNumber()
        {
            bool validPhoneNumber = phoneNumberTextBox.Text.Length % 13 == 0;

            if (validPhoneNumber)
            {
                phoneNumberTextBox.BackColor = Color.White;
            }
            else
            {
                phoneNumberTextBox.BackColor = errorColor;
            }

            return validPhoneNumber;
        }

        private bool ValidatePostalCode()
        {
            bool validPostalCode = postalCodeTextBox.Text.Length % 7 == 0;

            if (validPostalCode)
            {
                postalCodeTextBox.BackColor = Color.White;
            }
            else
            {
                postalCodeTextBox.BackColor = errorColor;
            }

            return validPostalCode;
        }

        private bool ValidateCreditCard()
        {
            bool validCreditCardNumber = creditCardTextBox.Text.Length % 19 == 0;

            if (validCreditCardNumber)
            {
                creditCardTextBox.BackColor = Color.White;
            }
            else
            {
                creditCardTextBox.BackColor = errorColor;
            }

            return validCreditCardNumber;
        }

        private bool ValidateFields()
        {
            bool validPhone = ValidatePhoneNumber();
            bool validCreditCard = ValidateCreditCard();
            bool validEmail = ValidateEmail();
            bool validPostalCode = ValidatePostalCode();

            return validPhone && validCreditCard && validEmail && validPostalCode;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
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
            else
            {
                MessageBox.Show("Some Fields are Invalid!", "Error");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
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
            else
            {
                MessageBox.Show("Some Fields are Invalid!", "Error");
            }
        }

        private void phoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || (phoneNumberTextBox.Text.Length == 13 && e.KeyChar != '\b'))
            {
                e.Handled = true;
                return;
            }

            string text = phoneNumberTextBox.Text;

            if (text.Length == 0)
            {
                phoneNumberTextBox.Text = "(" + text;
            }
            else if (text.Length == 2 && e.KeyChar == '\b')
            {
                phoneNumberTextBox.Text = "";
            }
            else if (text.Length == 4 && e.KeyChar != '\b')
            {
                phoneNumberTextBox.Text = text + ")";
            }
            else if (text.Length == 6 && e.KeyChar == '\b')
            {
                phoneNumberTextBox.Text = phoneNumberTextBox.Text.Remove(5);
            }
            else if (text.Length == 8 && e.KeyChar != '\b')
            {
                phoneNumberTextBox.Text = text + "-";
            }
            else if (text.Length == 10 && e.KeyChar == '\b')
            {
                phoneNumberTextBox.Text = phoneNumberTextBox.Text.Remove(9);
            }

            phoneNumberTextBox.SelectionStart = phoneNumberTextBox.Text.Length;
        }

        private void creditCardTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || (creditCardTextBox.Text.Length == 19 && e.KeyChar != '\b'))
            {
                e.Handled = true;
                return;
            }

            string text = creditCardTextBox.Text;

            for (int i = 0; i <= 2; i++)
            {
                int addIndex = 4 + i * 5;
                int removeIndex = 6 + i * 5;
                if (text.Length == addIndex && e.KeyChar != '\b')
                {
                    creditCardTextBox.Text = text + "-";

                    creditCardTextBox.SelectionStart = creditCardTextBox.Text.Length;

                    break;
                }
                else if (text.Length == removeIndex && e.KeyChar == '\b')
                {
                    creditCardTextBox.Text = creditCardTextBox.Text.Remove(removeIndex - 1);

                    creditCardTextBox.SelectionStart = creditCardTextBox.Text.Length;

                    break;
                }

            }

        }

        private void postalCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = postalCodeTextBox.Text;

            if (text.Length == 0 || text.Length == 2 || text.Length == 5)
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    return;
                }
            }
            else if (text.Length == 1 || text.Length == 3 || text.Length == 6)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    return;
                }
            }

            if (e.KeyChar != '\b')
            {
                if(text.Length == 3)
                {
                    postalCodeTextBox.Text = text + ' ';
                    postalCodeTextBox.SelectionStart = postalCodeTextBox.Text.Length;
                }
                else if (text.Length == 7)
                {
                    e.Handled = true;
                    return;
                }
            }
        }
    }
}
