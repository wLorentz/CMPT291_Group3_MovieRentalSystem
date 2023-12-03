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

        private void PopulateEmployeeGridView(Employee[] employees)
        {
            foreach (Employee employee in employees)
            {
                if (employee.EmployeeID != 0)
                {
                    EmployeeDataGrid.Rows.Add(employee.EmployeeID, employee.Ssn, employee.LastName, employee.FirstName, employee.StreetNo, employee.StreetName, employee.AptNo, employee.City, employee.Province, employee.PostalCode, employee.PhoneNumber, employee.StartDate.ToString("yyyy-MM-dd"));
                }
            }
        }

        private void UpdateDataGrid(Employee employee)
        {
            foreach(DataGridViewRow row in EmployeeDataGrid.Rows)
            {
                if (row.Cells[0].Value.ToString() == employee.EmployeeID.ToString())
                {
                    row.SetValues(employee.EmployeeID, employee.Ssn, employee.LastName, employee.FirstName, employee.StreetNo, employee.StreetName, employee.AptNo, employee.City, employee.Province, employee.PostalCode, employee.PhoneNumber, employee.StartDate.ToString("yyyy-MM-dd"));
                }
            }
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            int employeeID = mainForm.GetDatabase().GetLowestAvailableEmployeeID();

            ModifyEmployeeForm modifyEmployeeForm = new(this, true, employeeID);
            modifyEmployeeForm.Show();
        }

        public void AddEmployee(Employee employee)
        {
            mainForm.AddEmployee(employee);
            EmployeeDataGrid.Rows.Add(employee.EmployeeID, employee.Ssn, employee.LastName, employee.FirstName, employee.StreetNo, employee.StreetName, employee.AptNo, employee.City, employee.Province, employee.PostalCode, employee.PhoneNumber, employee.StartDate.ToString("yyyy-MM-dd"));
        }

        public void SaveEmployee(Employee employee)
        {
            UpdateDataGrid(employee);
            mainForm.SaveEmployee(employee);
        }

        private void EmployeeScreen_Load(object sender, EventArgs e)
        {
            Employee[] employees = mainForm.GetDatabase().GetAllEmployees();
            PopulateEmployeeGridView(employees);
        }

        public DatabaseFile GetDatabase()
        {
            return mainForm.GetDatabase();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isReturn = true;
            mainForm.Show();
            this.Close();
        }

        private void EmployeeScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isReturn)
            {
                mainForm.Close();
            }
        }

        private void EmployeeDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (int.TryParse(EmployeeDataGrid.Rows[rowIndex].Cells[0].Value.ToString(), out int employeeID))
            {
                ModifyEmployeeForm modifyEmployeeForm = new(this, false, employeeID);
                modifyEmployeeForm.Show();
            }
        }
    }
}
