using System.Data.SqlClient;

namespace CMPT
{
    public partial class CustomerScreen : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        private String username;
        private String database;
        private String timeout;

        public CustomerScreen(String username= "DESKTOP-R38BQ2M", String database = "CMPT291_MovieRentalSystem", String timeout = "30")
        {
            InitializeComponent();
            /*Starting the connection*/
            SqlConnection myConnection = new SqlConnection
                ("user id = " + username + // Username  
                 "password = admin" + // password 
                 "server = localhost" + // IP for the server
                 "Trusted_Connection = yes" +
                 "database = " + database + // Database to connect to: CMPT291_MovieRentalSystem
                 "connection timeout = " + timeout); // timeout in seconds

            // SqlConnection newConnection = new SqlConnection(); // Timeout in seconds

            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }

            this.username = username;
            this.database = database;
            this.timeout = timeout;
        }

        private void CustomerScreen_Load(object sender, EventArgs e)
        {
            //Displays all customers upon loading the forms
            myCommand.CommandText = "select * from Customers";
            try
            {
                //MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                Customers.Rows.Clear();
                while (myReader.Read())
                {
                    Customers.Rows.Add(myReader["accountNo"].ToString(), myReader["accountType"].ToString(),
                                             myReader["lastName"].ToString(), myReader["firstName"].ToString(),
                                             myReader["streetNumber"].ToString(), myReader["streetName"].ToString(),
                                             myReader["aptNumber"].ToString(), myReader["city"].ToString(),
                                             myReader["postalCode"].ToString(), myReader["phoneNumber"].ToString(),
                                             myReader["email"].ToString(), myReader["creditCard"].ToString(),
                                             myReader["rating"].ToString());
                }

                myReader.Close();
                Customers.Rows.Add();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }

        }

        private void CustomerDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Gets the current index of the row the user clicked on
                int rowIdx = Customers.CurrentCell.RowIndex;
                //Gets the account number from the row
                string accountNo = Customers.Rows[rowIdx].Cells[0].Value.ToString();
                //SQL to delete
                myCommand.CommandText = "DELETE FROM Customers where accountNo=" + accountNo;
                //MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();
                MessageBox.Show("Deleted customer with account number: " + accountNo);


                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show("Invalid row to be deleted. Please pick another row.");
            }
        }

        private void UpdateCustomersButton_Click(object sender, EventArgs e)
        {
            //Loops through the rows and updates all of the customers
            for (int item = 0; item <= Customers.Rows.Count - 2; item++)
            {
                string accountNo = Customers.Rows[item].Cells[0].Value.ToString();
                string lastName = Customers.Rows[item].Cells[1].Value.ToString();
                string firstName = Customers.Rows[item].Cells[2].Value.ToString();
                string streetNo = Customers.Rows[item].Cells[3].Value.ToString();
                string streetName = Customers.Rows[item].Cells[4].Value.ToString();
                string aptNumber = Customers.Rows[item].Cells[5].Value.ToString();
                string city = Customers.Rows[item].Cells[6].Value.ToString();
                string postalCode = Customers.Rows[item].Cells[7].Value.ToString();
                string phoneNumber = Customers.Rows[item].Cells[8].Value.ToString();
                string email = Customers.Rows[item].Cells[9].Value.ToString();
                string creditCard = Customers.Rows[item].Cells[10].Value.ToString();
                string rating = Customers.Rows[item].Cells[11].Value.ToString();
                myCommand.CommandText = "Update Customers SET lastName='" +
                    lastName + "',firstName='" + firstName +
                    "',streetNo=" + streetNo + ",streetName=" + streetName + ",aptNumber=" + aptNumber +
                    ",city=" + city + ",postalCode=" + postalCode +
                    ",phoneNumber=" + phoneNumber + ",email=" + email +
                    ",creditCard=" + creditCard + ",rating=" + rating +
                    " where accountNo=" + accountNo + ";";
                try
                {
                    //MessageBox.Show(myCommand.CommandText);
                    myReader = myCommand.ExecuteReader();

                    myReader.Close();

                }
                catch (Exception e3)
                {
                    MessageBox.Show(e3.ToString(), "Error");
                }

            } 
            // Instead of updating, this is for adding a new customer
            // Getting the last row index, which is where the user will input the new customer's information
            int lastRowidx = Customers.Rows.Count - 1;
            // Check if it's not null
            if (!((Customers.Rows[lastRowidx].Cells[0].Value == null)))
            {
                // Try to get all of the necessary information, if some are null it will go to the catch
                try
                {
                    string accountNo = Customers.Rows[lastRowidx].Cells[0].Value.ToString();
                    string lastName = Customers.Rows[lastRowidx].Cells[1].Value.ToString();
                    string firstName = Customers.Rows[lastRowidx].Cells[2].Value.ToString();
                    string streetNo = Customers.Rows[lastRowidx].Cells[3].Value.ToString();
                    string streetName = Customers.Rows[lastRowidx].Cells[4].Value.ToString();
                    string aptNumber = Customers.Rows[lastRowidx].Cells[5].Value.ToString();
                    string city = Customers.Rows[lastRowidx].Cells[6].Value.ToString();
                    string postalCode = Customers.Rows[lastRowidx].Cells[7].Value.ToString();
                    string phoneNumber = Customers.Rows[lastRowidx].Cells[8].Value.ToString();
                    string email = Customers.Rows[lastRowidx].Cells[9].Value.ToString();
                    string creditCard = Customers.Rows[lastRowidx].Cells[10].Value.ToString();
                    string rating = Customers.Rows[lastRowidx].Cells[11].Value.ToString();

                    myCommand.CommandText = "insert into Customers values" +
                        "(" + accountNo + ", '" + lastName + "','" + firstName + "'," +
                        streetNo + "," + streetName + "," + aptNumber + "'," + city + "'," + postalCode + "'," +
                        phoneNumber + "'," + email + "'," + creditCard + "'," + rating + ");";
                    // Tries to add a customer. Will fail if account number is not unique or the data type is not compatible.
                    try
                    {
                        MessageBox.Show(myCommand.CommandText);
                        myReader = myCommand.ExecuteReader();

                        myReader.Close();
                        Customers.Rows.Add();


                    }
                    catch (Exception e5)
                    {
                        MessageBox.Show("Account number already used (Must be unique) or wrong data type entered", "Error");
                    }
                }
                catch (Exception e6)
                {
                    MessageBox.Show("Not all cells filled", "Error");
                }
            }
        }

        private void SearchCustomerButton_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from Customers";
            // Find customer using pattern search
            if (!(string.IsNullOrEmpty(SearchCustomerBox.Text)))
            {
                myCommand.CommandText += " where accountNo LIKE '%" + SearchCustomerBox.Text + "%'";
            }

            try
            {
                //MessageBox.Show(myCommand.CommandText);
                //Displays the customers
                myReader = myCommand.ExecuteReader();

                Customers.Rows.Clear();
                while (myReader.Read())
                {
                    Customers.Rows.Add(myReader["accountNo"].ToString(), myReader["accountType"].ToString(),
                                                 myReader["lastName"].ToString(), myReader["firstName"].ToString(),
                                                 myReader["streetNumber"].ToString(), myReader["streetName"].ToString(),
                                                 myReader["aptNumber"].ToString(), myReader["city"].ToString(),
                                                 myReader["postalCode"].ToString(), myReader["phoneNumber"].ToString(),
                                                 myReader["email"].ToString(), myReader["creditCard"].ToString(),
                                                 myReader["rating"].ToString());
                }

                myReader.Close();
                Customers.Rows.Add();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }
    }
}
