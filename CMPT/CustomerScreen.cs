using System.Data.SqlClient;

namespace CMPT
{
    public partial class CustomerScreen : Form
    {
        
        private Form1 mainForm;

        public CustomerScreen(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void CustomerScreen_Load(object sender, EventArgs e)
        {
            //Displays all customers upon loading the forms
            Customer[] customers = mainForm.getCustomerList();

            Customers.Rows.Clear();
            
            foreach (Customer customer in customers)
            {
                Customers.Rows.Add(customer.AccountNo, customer.LastName, customer.FirstName, customer.StreetNo, customer.StreetName, customer.AptNo, customer.City, customer.PostalCode, customer.PhoneNumber, customer.Email, customer.Rating);
            }

        }

        private void CustomerDeleteButton_Click(object sender, EventArgs e)
        {
                //Gets the current index of the row the user clicked on
                int rowIdx = Customers.CurrentCell.RowIndex;
                //Gets the account number from the row
                int accountNo = Int32.Parse(Customers.Rows[rowIdx].Cells[0].Value.ToString());
            try
            {
                mainForm.GetDatabase().RemoveCustomer(accountNo);
               
                MessageBox.Show("Deleted customer with account number: " + accountNo);
            }
            catch (Exception e3)
            {
                MessageBox.Show("Invalid row to be deleted. Please pick another row.");
            }
        }

        private void UpdateCustomersButton_Click(object sender, EventArgs e)
        {
            mainForm.GetDatabase().SaveCustomers(mainForm.getCustomerList());
        }

        private void SearchCustomerButton_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(SearchCustomerBox.Text)))
            {
                try
                {
                    Customer[] customerArray = mainForm.GetDatabase().GetCustomers(SearchCustomerBox.Text);

                    Customers.Rows.Clear();

                    foreach (Customer customer in customerArray)
                    {
                        Customers.Rows.Add(customer.AccountNo, customer.LastName, customer.FirstName, customer.StreetNo, customer.StreetName, customer.AptNo, customer.City, customer.PostalCode, customer.PhoneNumber, customer.Email, customer.Rating);
                    }

                } 
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
