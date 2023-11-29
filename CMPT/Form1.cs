using System;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Windows.Forms;

namespace CMPT
{
    public partial class Form1 : Form
    {
        private DatabaseFile database;

        private Customer[] customers;
        private Movie[] movieList;

        public Form1()
        {
            InitializeComponent();

            /*Starting the connection*/
            //SqlConnection myConnection = new SqlConnection("user id = admin;" + // Username  ***Need to update your users in SQL SERVER MANAGEMENT and then adjust this to your username***
            //     "password = admin;" + // password 
            //     "server = localhost;" + //IP for the server
            //     "Trusted_Connection = yes;" +
            //     "database = CMPT291_MovieRentalSystem; " + //Database to connect to ***Change this to whatever your DB is named***
            //     "connection timeout = 30"); //timeout in seconds

            //SqlConnection myConnection = new SqlConnection(connectionString); //Timeout in seconds
            try
            {
                database = new("admin", "admin", "CMPT291_MovieRentalSystem");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(), "Error");
                this.Close();
            }
        }

        public DatabaseFile GetDatabase()
        {
            return this.database;
        }

        /**
         * Opens the login screen
         */
        private void Login()
        {
            this.Hide();
            LoginScreen loginScreen = new LoginScreen(this);
            loginScreen.Show();
        }

        public void SuccessfulLogin(string userID)
        {
            this.Show();

            getMovies();

            populateCustomerDropdown();
        }

        public void getMovies()
        {
            try
            {
                movieList = database.getAllMovies();
                movies.Rows.Clear();

                foreach (Movie movie in movieList)
                {
                    movies.Rows.Add(movie.getId(), movie.getName(), movie.getGenre(), movie.getPrice(), movie.getCopies(), movie.getRating());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }

        public Customer[] getCustomerList()
        {
            if (customers == null)
            {
                try
                {
                    customers = database.GetAllCustomers();
                    return customers;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error");
                    Customer[] emptyCustomerList = new List<Customer>().ToArray();

                    return emptyCustomerList;
                }
            }
            else
            {
                return customers;
            }
        }

        private void populateCustomerDropdown()
        {
            customerDropdown.Items.Clear();

            Customer[] customerList = getCustomerList();

            foreach (Customer customer in customerList)
            {
                customerDropdown.Items.Add(customer.AccountNo);
            }
        }

        /**
         * Ensures the login screen is only opened once the form is loaded. This prevents the main screen from 
         * covering the login screen in case the login screen is displayed before the main screen gets displayed
         */
        private void Form1_Shown(object sender, EventArgs e)
        {
            Login();
        }

        private void searchMoviebutton_Click(object sender, EventArgs e)
        {
            //Finding the movie using the pattern search
            if (!(string.IsNullOrEmpty(searchMoviebox.Text)))
            {
                Movie[] movieArray = database.GetMovies(searchMoviebox.Text);

                movies.Rows.Clear();

                foreach (Movie movie in movieArray)
                {
                    movies.Rows.Add(movie.getId(), movie.getName(), movie.getGenre(), movie.getPrice(), movie.getCopies(), movie.getRating());
                }

            }
            //If the search text box is empty show all movies in database
            else
            {
                movieList = database.getAllMovies();
                movies.Rows.Clear();

                foreach (Movie movie in movieList)
                {
                    movies.Rows.Add(movie.getId(), movie.getName(), movie.getGenre(), movie.getPrice(), movie.getCopies(), movie.getRating());
                }
            }
        }

        private void updateMoviesbutton_Click(object sender, EventArgs e)
        {
            //Loops through the rows and updates all of the movies
            database.SaveMovies(movieList);

            //}
            ////Instead of updating, this is for adding a new movie
            ////Getting the last row index, which is where the user will input the new movies' information
            //int lastRowidx = movies.Rows.Count - 1;
            ////Check if its not null
            //if (!((movies.Rows[lastRowidx].Cells[0].Value == null)))
            //{
            //    //Try to get all of the needed information, if some are null it will go to the catch
            //    try
            //    {
            //        string movieID = movies.Rows[lastRowidx].Cells[0].Value.ToString();
            //        string movieName = movies.Rows[lastRowidx].Cells[1].Value.ToString();
            //        string movieGenre = movies.Rows[lastRowidx].Cells[2].Value.ToString();
            //        string moviePrice = movies.Rows[lastRowidx].Cells[3].Value.ToString();
            //        string movieCopies = movies.Rows[lastRowidx].Cells[4].Value.ToString();
            //        string movieRating = movies.Rows[lastRowidx].Cells[5].Value.ToString();
            //        myCommand.CommandText = "insert into Movies values(" + movieID + ", '" + movieName + "','" + movieGenre + "'," + moviePrice + "," + movieCopies + "," + movieRating + ");";
            //        //Tries to add the movie. Will fail if ID is not unique or the data type is not compatible
            //        try
            //        {
            //            MessageBox.Show(myCommand.CommandText);
            //            myReader = myCommand.ExecuteReader();

            //            myReader.Close();
            //            movies.Rows.Add();


            //        }
            //        catch (Exception e5)
            //        {
            //            MessageBox.Show("Movie ID already used (Must be unique) or wrong data type entered", "Error");
            //        }
            //    }
            //    catch (Exception e6)
            //    {
            //        MessageBox.Show("Not all cells filled", "Error");
            //    }
            //}
        }

        private void movieDeletebutton_Click(object sender, EventArgs e)
        {
            int rowIdx = movies.CurrentCell.RowIndex;

            string movieID = movies.Rows[rowIdx].Cells[0].Value.ToString();

            try
            {
                database.DeleteMovie(movieID);
                movies.Rows.RemoveAt(rowIdx);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void runReport_Click(object sender, EventArgs e)
        {
            //reportOutputText.Clear();

            //String report = reports.GetItemText(reports.SelectedItem);
            //string output = "";

            //MessageBox.Show(report);

            //switch (report)
            //{
            //    case "Report 1":

            //        myCommand.CommandText = "select * from Movies";
            //        myReader = myCommand.ExecuteReader();

            //        while (myReader.Read())
            //        {
            //            output += Convert.ToString((myReader["movieID"], myReader["movieName"], myReader["genre"], myReader["price"], myReader["copies"], myReader["rating"]));
            //            output += "\n";
            //        }

            //        reportOutputText.Text = output;
            //        myReader.Close();
            //        break;

            //    case "Report 2":

            //        myReader.Close();
            //        break;

            //    case "Report 3":

            //        myReader.Close();
            //        break;

            //    case "Report 4":

            //        myReader.Close();
            //        break;

            //    case "Report 5":

            //        myReader.Close();
            //        break;
            //}

        }

        private void customerDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            editCustomerButton.Visible = false;

            if (customerDropdown.SelectedIndex != -1)
            {
                editCustomerButton.Visible = true;
            }

        }

        private void customerDropdown_KeyUp(object sender, KeyEventArgs e)
        {
            if (customers.Length == 0)
            {
                this.getCustomerList();
            }

            string str = customerDropdown.Text;

            if (customerDropdown.Items.Contains(str))
            {
                editCustomerButton.Visible = true;
            }
            else
            {
                editCustomerButton.Visible = false;
            }
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                int newAccountNumber = database.GetLatestAccountNumber() + 1;
                ModifyCustomerForm addCustomerForm = new(this, true, newAccountNumber);
                addCustomerForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddCustomer(Customer customer)
        {
            try
            {
                database.AddCustomer(customer);
                customerDropdown.Items.Add(customer.AccountNo);
                customers.Append(customer);

                customerDropdown.SelectedIndex = customerDropdown.Items.Count - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void saveCustomer(Customer customer)
        {
            database.SaveCustomer(customer);
        }

        private void editCustomerButton_Click(object sender, EventArgs e)
        {
            string str = customerDropdown.Text;
            int.TryParse(customerDropdown.Text, out int accountNumber);

            ModifyCustomerForm addCustomerForm = new(this, false, accountNumber);
            addCustomerForm.Show();
        }

        private void addMoviebox_Click(object sender, EventArgs e)
        {
            addMoviebox.Text = string.Empty;

        }

        private void addMoviebutton_Click(object sender, EventArgs e)
        {
            try
            {
                database.AddMovie(addMoviebox.Text);
                movies.Rows.Add(addMoviebox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void assignActorbox_Click(object sender, EventArgs e)
        {
            assignActorbox.Text = string.Empty;
        }

        private void assignActorbutton_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIdx = movies.CurrentCell.RowIndex;
                string movieID = movies.Rows[rowIdx].Cells[0].Value.ToString();
                database.AssignActor(assignActorbox.Text, movieID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
