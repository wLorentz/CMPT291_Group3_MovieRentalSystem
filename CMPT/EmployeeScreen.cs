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
    public partial class EmployeeScreen : Form
    {
        Form1 mainForm;
        bool isReturn;
        public EmployeeScreen(Form1 mainForm)
        {
            this.mainForm = mainForm;
            isReturn = false;

            InitializeComponent();
        }

        /**
         * Populates the Employee data grid with a list of employees
         * 
         * Parameters:
         *      employees {Employee[]} A list of employees whose data will populate the data grid
         */
        private void PopulateEmployeeGridView(Employee[] employees)
        {
            EmployeeDataGrid.Rows.Clear();
            foreach (Employee employee in employees)
            {
                if (employee.EmployeeID != 0)
                {
                    EmployeeDataGrid.Rows.Add(employee.EmployeeID, employee.Ssn, employee.LastName, employee.FirstName, employee.StreetNo, employee.StreetName, employee.AptNo, employee.City, employee.Province, employee.PostalCode, employee.PhoneNumber, employee.StartDate.ToString("yyyy-MM-dd"));
                }
            }
        }

        /**
         * Updates the information in the data grid for the specified employee
         * 
         * Parameters:
         *      employee {Employee} The employee whose information is to be updated in the data grid
         */
        private void UpdateDataGridEmployee(Employee employee)
        {
            foreach (DataGridViewRow row in EmployeeDataGrid.Rows)
            {
                if (row.Cells[0].Value.ToString() == employee.EmployeeID.ToString())
                {
                    row.SetValues(employee.EmployeeID, employee.Ssn, employee.LastName, employee.FirstName, employee.StreetNo, employee.StreetName, employee.AptNo, employee.City, employee.Province, employee.PostalCode, employee.PhoneNumber, employee.StartDate.ToString("yyyy-MM-dd"));
                    break;
                }
            }
        }

        /**
         * Click handler for the Add button. Opens the form to add an employee
         */
        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            int employeeID = mainForm.GetDatabase().GetLowestAvailableEmployeeID();

            ModifyEmployeeForm modifyEmployeeForm = new(this, true, employeeID);
            modifyEmployeeForm.Show();
        }

        /**
         * Adds the specified employee to the database and the employee 
         */
        public void AddEmployee(Employee employee)
        {
            try
            {
                mainForm.GetDatabase().AddEmployee(employee);
                EmployeeDataGrid.Rows.Add(employee.EmployeeID, employee.Ssn, employee.LastName, employee.FirstName, employee.StreetNo, employee.StreetName, employee.AptNo, employee.City, employee.Province, employee.PostalCode, employee.PhoneNumber, employee.StartDate.ToString("yyyy-MM-dd"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /**
         * Modifies an employee in the database and in the data grid
         */
        public void SaveEmployee(Employee employee)
        {
            try
            {
                mainForm.GetDatabase().SaveEmployee(employee);
                UpdateDataGridEmployee(employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /**
         * Handler for when the form loads. Populates with grid view with the employees in the database
         */
        private void EmployeeScreen_Load(object sender, EventArgs e)
        {
            Employee[] employees = mainForm.GetDatabase().GetAllEmployees();
            PopulateEmployeeGridView(employees);
        }

        /**
         * Returns the database from the main form
         */
        public DatabaseFile GetDatabase()
        {
            return mainForm.GetDatabase();
        }

        /**
         * Handler for when the screen closes. Closes the main form if this screen isn't closed when from returning to the main form
         */
        private void EmployeeScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isReturn)
            {
                mainForm.Close();
            }
        }

        /**
         * Handler for double clicking on a data cell. Opens the screen for modifying the employee displayed in the row that was double clicked on
         */
        private void EmployeeDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (int.TryParse(EmployeeDataGrid.Rows[rowIndex].Cells[0].Value.ToString(), out int employeeID))
            {
                ModifyEmployeeForm modifyEmployeeForm = new(this, false, employeeID);
                modifyEmployeeForm.Show();
            }
        }

        /**
         * Handler for the Delete button. Removes the selected employee from the database and the data grid
         */
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int rowIndex = EmployeeDataGrid.CurrentCell.RowIndex;
            if (int.TryParse(EmployeeDataGrid.Rows[rowIndex].Cells[0].Value.ToString(), out int employeeID))
            {
                try
                {
                    mainForm.GetDatabase().DeleteEmployee(employeeID);
                    EmployeeDataGrid.Rows.RemoveAt(rowIndex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        /**
         * Handler for the Return button. Sets the isReturn field, opens the main form and closes this form
         */
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            isReturn = true;
            mainForm.Show();
            this.Close();
        }
    }
}
