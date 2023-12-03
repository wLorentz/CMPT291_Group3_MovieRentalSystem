using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CMPT
{
    public partial class ModifyEmployeeForm : Form
    {
        EmployeeScreen employeeForm;
        bool isNew;
        int employeeID;
        
        /**
         * Constructor for the ModifyEmployeeScreen
         * 
         * Parameters:
         *      employeeForm {EmployeeScreen} The screen from which this form is opened
         *      isNew {bool} Whether the screen is being opened to add a new employee
         *      employeeID {int} The id of the employee being modified
         */
        public ModifyEmployeeForm(EmployeeScreen employeeForm, bool isNew, int employeeID)
        {
            this.employeeForm = employeeForm;
            this.isNew = isNew;
            this.employeeID = employeeID;

            InitializeComponent();
        }

        /**
         * Populates the form fields with the information for the specified employee 
         */
        private void PopulateFields(Employee employee)
        {
            SsnTextBox.Text = employee.Ssn.ToString();
            LastNameTextBox.Text = employee.LastName;
            FirstNameTextBox.Text = employee.FirstName;
            StreetNumberTextBox.Text = employee.StreetNo;
            StreetNameTextBox.Text = employee.StreetName;
            AptNumberTextBox.Text = employee.AptNo;
            CityTextBox.Text = employee.City;
            ProvinceComboBox.SelectedIndex = (int)employee.Province;
            PostalCodeTextBox.Text = employee.PostalCode;
            PhoneNumberTextBox.Text = employee.PhoneNumber;
            StartDatePicker.Text = employee.StartDate.ToString();
        }

        /**
         * The handler for when the form loads.
         * Hides and shows the appropriate fields based on if an employee is being added or modified
         */
        private void ModifyEmployeeForm_Load(object sender, EventArgs e)
        {
            SaveButton.Enabled = false;
            SaveButton.Visible = false;

            AddButton.Enabled = false;
            AddButton.Visible = false;

            PasswordTextBox.Enabled = false;
            PasswordTextBox.Visible = false;

            PasswordLabel.Visible = false;

            ReEnterPasswordTextBox.Enabled = false;
            ReEnterPasswordTextBox.Visible = false;

            ReEnterPasswordLabel.Visible = false;

            UpdatePasswordButton.Enabled = false;
            UpdatePasswordButton.Visible = false;

            EmployeeIDText.Text = employeeID.ToString();

            if (isNew)
            {
                AddButton.Enabled = true;
                AddButton.Visible = true;

                PasswordTextBox.Enabled = true;
                PasswordTextBox.Visible = true;

                ReEnterPasswordTextBox.Enabled = true;
                ReEnterPasswordTextBox.Visible = true;

                PasswordLabel.Visible = true;

                ReEnterPasswordLabel.Visible = true;
            }
            else
            {
                SaveButton.Enabled = true;
                SaveButton.Visible = true;

                UpdatePasswordButton.Enabled = true;
                UpdatePasswordButton.Visible = true;

                PopulateFields(employeeForm.GetDatabase().GetEmployeeByID(employeeID));
            }
        }

        /**
         * Creates an EmployeeStruct from the data in the form fields
         */
        private EmployeeStruct CreateEmployeeStruct()
        {
            EmployeeStruct employeeStruct = new(employeeID)
            {
                ssn = SsnTextBox.Text.ToString(),
                lastName = LastNameTextBox.Text.ToString(),
                firstName = FirstNameTextBox.Text.ToString(),
                streetNo = StreetNumberTextBox.Text.ToString(),
                streetName = StreetNameTextBox.Text.ToString(),
                aptNo = AptNumberTextBox.Text.ToString(),
                city = CityTextBox.Text.ToString(),
                phoneNumber = PhoneNumberTextBox.Text.ToString(),
                province = (ProvinceEnum)ProvinceComboBox.SelectedIndex,
                postalCode = PostalCodeTextBox.Text.ToString(),
                startDate = DateTime.Parse(StartDatePicker.Text.ToString())
            };

            return employeeStruct;
        }

        /**
         * Creates a random alphanumeric string with a random length between 10 and 20 characters long
         */
        private string CreateSalt()
        {
            const string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            Random random = new();

            int length = random.Next(10, 21);

            StringBuilder stringBuilder = new();

            for (int i = 0; i < length; i++)
            {
                stringBuilder.Append(characters[random.Next(characters.Length)]);
            }

            return stringBuilder.ToString();
        }

        /**
         * Creates a hash from the provided string
         */
        private string CreatePassHash(string password)
        {
            // Create a SHA256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        /**
         * Handler for the Save button
         * Saves the employee
         */
        private void SaveButton_Click(object sender, EventArgs e)
        {
            employeeForm.SaveEmployee(new Employee(CreateEmployeeStruct()));

            this.Close();
        }

        /**
         * Handler for the Add button
         * Adds an employee to the system
         */
        private void AddButton_Click(object sender, EventArgs e)
        {
            string salt = CreateSalt();
            string passHash = CreatePassHash(PasswordTextBox.Text + salt);

            try
            {
                employeeForm.AddEmployee(new Employee(CreateEmployeeStruct()));
                employeeForm.GetDatabase().CreateUserLogin(int.Parse(EmployeeIDText.Text), passHash, salt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }

        /**
         * Handler for when the form is closed
         * Shows the from from which this screen was opened
         */
        private void ModifyEmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            employeeForm.Show();
        }

        /**
         * Handler for when the user pressed a key in the SSN textbox
         * Limits the input allowed in  the SSN text box and auto formats the user entered value
         */
        private void SsnTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = SsnTextBox.Text;

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) || (text.Length == 11 && e.KeyChar != '\b'))
            {
                e.Handled = true;
                return;
            }


            if ((text.Length == 3 || text.Length == 7) && e.KeyChar != '\b')
            {
                SsnTextBox.Text = text + ' ';
            }
            else if ((text.Length == 5 || text.Length == 9) && e.KeyChar == '\b')
            {
                SsnTextBox.Text = text.Remove(text.Length - 1);
            }

            SsnTextBox.SelectionStart = SsnTextBox.Text.Length;
        }

        /**
         * Handler for when the user pressed a key in the Phone Number textbox
         * Limits the allows input in the Phone Number textbox and autoformats the user input
         */
        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || (PhoneNumberTextBox.Text.Length == 13 && e.KeyChar != '\b'))
            {
                e.Handled = true;
                return;
            }

            string text = PhoneNumberTextBox.Text;

            if (text.Length == 0)
            {
                PhoneNumberTextBox.Text = "(" + text;
            }
            else if (text.Length == 2 && e.KeyChar == '\b')
            {
                PhoneNumberTextBox.Text = "";
            }
            else if (text.Length == 4 && e.KeyChar != '\b')
            {
                PhoneNumberTextBox.Text = text + ")";
            }
            else if (text.Length == 6 && e.KeyChar == '\b')
            {
                PhoneNumberTextBox.Text = PhoneNumberTextBox.Text.Remove(5);
            }
            else if (text.Length == 8 && e.KeyChar != '\b')
            {
                PhoneNumberTextBox.Text = text + "-";
            }
            else if (text.Length == 10 && e.KeyChar == '\b')
            {
                PhoneNumberTextBox.Text = PhoneNumberTextBox.Text.Remove(9);
            }

            PhoneNumberTextBox.SelectionStart = PhoneNumberTextBox.Text.Length;
        }

        /**
         * Handler for when the user pressed a key in the Postal Code textbox
         * Limits the allows input in the Postal Code text box and auto formats the user input
         */
        private void PostalCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = PostalCodeTextBox.Text;

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
                if (text.Length == 3)
                {
                    PostalCodeTextBox.Text = text + ' ';
                    PostalCodeTextBox.SelectionStart = PostalCodeTextBox.Text.Length;
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
