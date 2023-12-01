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
    public partial class ModifyEmployeeForm : Form
    {
        EmployeeScreen employeeForm;
        bool isNew;
        int employeeID;
        public ModifyEmployeeForm(EmployeeScreen employeeForm, bool isNew, int employeeID)
        {
            this.employeeForm = employeeForm;
            this.isNew = isNew;
            this.employeeID = employeeID;

            InitializeComponent();
        }

        private void PopulateFields(Employee employee)
        {
            SsnTextBox.Text = employee.Ssn;
            LastNameTextBox.Text = employee.LastName;
            FirstNameTextBox.Text = employee.FirstName;
            StreetNumberTextBox.Text = employee.StreetNo;
            StreetNameTextBox.Text = employee.StreetName;
            AptNumberTextBox.Text = employee.AptNo;
            CityTextBox.Text = employee.City;
            ProvinceComboBox.SelectedIndex = ProvinceComboBox.Items.IndexOf(employee.Province);
            PostalCodeTextBox.Text = employee.PostalCode;
            PhoneNumberTextBox.Text = employee.PhoneNumber;
            StartDatePicker.Text = employee.StartDate;
        }

        private void ModifyEmployeeForm_Load(object sender, EventArgs e)
        {
            SaveButton.Enabled = false;
            SaveButton.Visible = false;

            AddButton.Enabled = false;
            AddButton.Visible = false;

            EmployeeIDText.Text = employeeID.ToString();

            if (isNew)
            {
                SaveButton.Enabled = true;
                SaveButton.Visible = true;
            }
            else
            {
                AddButton.Enabled = true;
                AddButton.Visible = true;

                PopulateFields(employeeForm.GetDatabase().GetEmployeeByID(employeeID));
            }
        }

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
                province = (ProvinceEnum)ProvinceComboBox.SelectedIndex,
                postalCode = PostalCodeTextBox.Text.ToString(),
                startDate = StartDatePicker.Text.ToString(),
            };

            return employeeStruct;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        { 
            employeeForm.SaveEmployee(new Employee(CreateEmployeeStruct()));
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            employeeForm.SaveEmployee(new Employee(CreateEmployeeStruct()));
        }
    }
}
