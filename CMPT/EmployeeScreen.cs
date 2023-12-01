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
        public EmployeeScreen(Form1 mainForm)
        {
            this.mainForm = mainForm;

            InitializeComponent();
        }

        private void PopulateEmployeeGridView(Employee[] employees)
        {
            foreach (Employee employee in employees)
            {
                EmployeeDataGrid.Rows.Add(employee.EmployeeID, employee.Ssn); // keep filling in fields
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

        }

        public void SaveEmployee(Employee employee)
        {

        }

        private void EmployeeScreen_Load(object sender, EventArgs e)
        {

        }

        public DatabaseFile GetDatabase()
        {
            return mainForm.GetDatabase();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }
    }
}
