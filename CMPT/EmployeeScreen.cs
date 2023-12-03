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
            //Employee[] employees = mainForm.GetDatabase()
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
            if(!isReturn)
            {
                mainForm.Close();
            }
        }
    }
}
