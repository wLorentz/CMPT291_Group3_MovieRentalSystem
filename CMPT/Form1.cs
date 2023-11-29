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

        //private Customer[] customers;
        //private Movie[] movieList;

        public Form1()
        {
            InitializeComponent();

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

            Movie[] movieList = getMovies();

            populateMovieList(movieList);

            populateMovieDropdown(movieList);

            Customer[] customerList = getCustomerList();

            populateCustomerDropdown(customerList);

            populateCustomerList(customerList);
        }

        public Movie[] getMovies()
        {
            Movie[] movies = new List<Movie>().ToArray();

            try
            {
                movies = database.getAllMovies();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }

            return movies;
        }

        public void populateMovieList(Movie[] movieList)
        {
            movies.Rows.Clear();

            foreach (Movie movie in movieList)
            {
                movies.Rows.Add(movie.getId(), movie.getName(), movie.getGenre(), movie.getPrice(), movie.getCopies(), movie.getRating());
            }
        }

        public void populateMovieDropdown(Movie[] movieList)
        {
            movieDropdown.Items.Clear();

            foreach (Movie movie in movieList)
            {
                movieDropdown.Items.Add(movie.getName());
            }
        }

        public Customer[] getCustomerList()
        {
            Customer[] customerList = new List<Customer>().ToArray(); ;
            try
            {
                customerList = database.GetAllCustomers();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }

            return customerList;
        }

        private void populateCustomerDropdown(Customer[] customerList)
        {
            customerDropdown.Items.Clear();

            foreach (Customer customer in customerList)
            {
                customerDropdown.Items.Add(customer.AccountNo);
            }
        }

        private void populateCustomerList(Customer[] customerList)
        {
            CustomersGridView.Rows.Clear();

            foreach (Customer customer in customerList)
            {
                CustomersGridView.Rows.Add(customer.AccountNo, customer.LastName, customer.FirstName, customer.StreetNo, customer.StreetName, customer.AptNo, customer.City, customer.PostalCode, customer.PhoneNumber, customer.Email, customer.CreditCard, customer.Rating);
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
                Movie[] movieList = database.getAllMovies();
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
            //database.SaveMovies(movieList);

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
                //customers.Append(customer);
                CustomersGridView.Rows.Add(customer.AccountNo, customer.LastName, customer.FirstName, customer.StreetNo, customer.StreetName, customer.AptNo, customer.City, customer.PostalCode, customer.PhoneNumber, customer.Email, customer.CreditCard, customer.Rating);

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
            foreach (DataGridViewRow row in CustomersGridView.Rows)
            {
                if (row.Cells[0].Value.ToString() == customer.AccountNo.ToString())
                {
                    row.Cells[0].Value = customer.AccountNo;
                    row.Cells[1].Value = customer.LastName;
                    row.Cells[2].Value = customer.FirstName;
                    row.Cells[3].Value = customer.StreetNo;
                    row.Cells[4].Value = customer.StreetName;
                    row.Cells[5].Value = customer.AptNo;
                    row.Cells[6].Value = customer.City;
                    row.Cells[7].Value = customer.PostalCode;
                    row.Cells[8].Value = customer.PhoneNumber;
                    row.Cells[9].Value = customer.Email;
                    row.Cells[10].Value = customer.CreditCard;
                    row.Cells[11].Value = customer.Rating;

                    break;
                }
            }
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
            //try
            //{
            //    database.AddMovie(addMoviebox.Text);
            //    movies.Rows.Add(addMoviebox.Text);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
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

        private void Customers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (int.TryParse(CustomersGridView.Rows[rowIndex].Cells[0].Value.ToString(), out int accountNumber))
            {
                ModifyCustomerForm addCustomerForm = new(this, false, accountNumber);
                addCustomerForm.Show();
            }
        }

        private void CustomerDeleteButton_Click(object sender, EventArgs e)
        {
            int rowIdx = CustomersGridView.CurrentCell.RowIndex;

            if(int.TryParse(CustomersGridView.Rows[rowIdx].Cells[0].Value.ToString(), out int accountNo))
            {
                try
                {
                    database.RemoveCustomer(accountNo);
                    CustomersGridView.Rows.RemoveAt(rowIdx);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }

            customerDropdown.Items.Remove(accountNo);
        }
    }
}
