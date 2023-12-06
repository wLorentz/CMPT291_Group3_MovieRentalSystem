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

        int employeeID;

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

            employeeID = -1;
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

        public void SuccessfulLogin(int userID)
        {
            employeeID = userID;

            EmployeesButton.Enabled = false;
            EmployeesButton.Visible = false;

            if (userID == 0)
            {
                EmployeesButton.Enabled = true;
                EmployeesButton.Visible = true;
            }

            Employee employee = database.GetEmployeeByID(userID);

            UserIDLabel.Text = employee.FirstName;

            this.Show();

            Movie[] movieList = getMovies();

            populateMovieList(movieList);

            populateMovieDropdown(movieList);

            Customer[] customerList = getCustomerList();

            populateCustomerDropdown(customerList);

            populateCustomerList(customerList);

            populateCustomerSearchDropdown();
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

        private void populateCustomerSearchDropdown()
        {
            foreach (DataGridViewTextBoxColumn column in CustomersGridView.Columns)
            {
                SearchByComboBox.Items.Add(column.HeaderText);
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
            var movieList = new List<Movie>();

            foreach (DataGridViewRow row in movies.Rows)
            {
                MovieStruct movieStruct = new MovieStruct(row.Cells[0].Value.ToString())
                {
                    name = row.Cells[1].Value.ToString(),
                    genre = row.Cells[2].Value.ToString(),
                    price = row.Cells[3].Value.ToString(),
                    copies = row.Cells[4].Value.ToString(),
                    rating = row.Cells[5].Value.ToString()
                };

                movieList.Add(new Movie(movieStruct));
            }

            try
            {
                database.SaveMovies(movieList.ToArray());
                MessageBox.Show("Movies saved successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void RunReportQuery(string query)
        {
            MessageBox.Show(query);

            string output = "";

            try
            {
                string[][] result = database.RunCustomQuery(query);

                for (int i = 0; i < result.Length; i++)
                {
                    for (int j = 0; j < result[i].Length; j++)
                    {
                        output += result[i][j] + ' ';

                    }
                    output += "\n";
                }

                reportOutputText.Text = output;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void runReport_Click(object sender, EventArgs e)
        {
            reportOutputText.Clear();

            String report = reports.GetItemText(reports.SelectedItem);

            string query = "";

            switch (report)
            {
                case "Report 1":

                    query = "Select * from Movies";
                    
                    break;

                case "Report 2":

                    query = "Select * from Movies";

                    break;

                case "Report 3":

                    query = "Select * from Movies";

                    break;

                case "Report 4":

                    query = "Select * from Movies";

                    break;

                case "Report 5":

                    query = "Select * from Movies";

                    break;
            }

            RunReportQuery(query);

        }

        public void AddMovie(Movie movie)
        {
            try
            {
                database.AddMovie(movie);

                movieDropdown.Items.Add(movie.getName());

                movies.Rows.Add(
                    movie.getId(),
                    movie.getName(),
                    movie.getGenre(),
                    movie.getPrice(),
                    movie.getCopies(),
                    movie.getRating()
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
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
                int newAccountNumber = database.GetLowestAvailableAccountNumber();
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
            try
            {
                database.SaveCustomer(customer);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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

        private void addMoviebutton_Click(object sender, EventArgs e)
        {
            try
            {
                int newMovieID = database.GetLowestAvailableMovieID();
                AddMovieForm addMovieForm = new(this, newMovieID);

                addMovieForm.Show();
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

            if (int.TryParse(CustomersGridView.Rows[rowIdx].Cells[0].Value.ToString(), out int accountNo))
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

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            UserIDLabel.Text = "ID";

            this.Hide();

            LoginScreen loginScreen = new(this);
            loginScreen.Show();

        }

        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeScreen employeeScreen = new(this);
            employeeScreen.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string customerID;
            string movie;
            int movieID;
            DateTime fromDate;
            DateTime toDate;
            int[] copies;
            int[] bookedCopies;

            try
            {
                customerID = customerDropdown.SelectedItem.ToString();
                movie = movieDropdown.SelectedItem.ToString();
                fromDate = retalDatePicker.Value;
                toDate = dueDatePicker.Value;
                copies = database.getMovieCopies(movie);
                movieID = database.convertMovieTitleToID(movie);
                bookedCopies = database.getBookedCopies(movieID, fromDate, toDate);
                var freeCopies = copies.Except(bookedCopies);

                if (freeCopies.Count() == 0)
                {
                    MessageBox.Show("No available movie copies in this date range.");
                    return;
                }
                else
                {
                    int orderID = database.GetLatestOrderNumber() + 1;

                    OrderStruct orderStruct = new(orderID);

                    orderStruct.date = DateTime.Now;
                    orderStruct.status = "Confirmed";
                    orderStruct.fromDate = fromDate;
                    orderStruct.toDate = toDate;
                    orderStruct.employeeID = employeeID.ToString();
                    orderStruct.copyID = freeCopies.ElementAt(0).ToString();
                    orderStruct.movieID = movieID.ToString();
                    orderStruct.accountNo = customerID;

                    database.AddOrder(new Order(orderStruct));

                    MessageBox.Show("Order Created.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
