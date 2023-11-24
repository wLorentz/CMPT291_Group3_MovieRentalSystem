using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CMPT
{
    public partial class Form1 : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Form1()
        {
            InitializeComponent();

            /*Starting the connection*/
            SqlConnection myConnection = new SqlConnection("user id = admin;" + // Username  ***Need to update your users in SQL SERVER MANAGEMENT and then adjust this to your username***
                 "password = admin;" + // password 
                 "server = localhost;" + //IP for the server
                 "Trusted_Connection = yes;" +
                 "database = CMPT291_MovieRentalSystem; " + //Database to connect to ***Change this to whatever your DB is named***
                 "connection timeout = 30"); //timeout in seconds

            //SqlConnection myConnection = new SqlConnection(connectionString); //Timeout in seconds

            try
            {
                myConnection.Open(); //Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

        /**
         * Opens the login screen
         */
        private void Login()
        {

            LoginScreen loginScreen = new LoginScreen(myCommand.Connection);
            loginScreen.Show();

            //Displays all movies upon loading of the forms
            myCommand.CommandText = "select * from Movies";
            try
            {
                //MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                movies.Rows.Clear();
                while (myReader.Read())
                {
                    movies.Rows.Add(myReader["movieID"].ToString(), myReader["movieName"].ToString(), myReader["genre"].ToString(), myReader["price"].ToString(), myReader["copies"].ToString(), myReader["rating"].ToString());
                }

                myReader.Close();
                movies.Rows.Add();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
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
            myCommand.CommandText = "select * from Movies";
            //Finding the movie using the pattern search
            if (!(string.IsNullOrEmpty(searchMoviebox.Text)))
            {
                myCommand.CommandText += " where movieName LIKE '%" + searchMoviebox.Text + "%'";
            }

            try
            {
                //MessageBox.Show(myCommand.CommandText);
                //Displays the movies
                myReader = myCommand.ExecuteReader();

                movies.Rows.Clear();
                while (myReader.Read())
                {
                    movies.Rows.Add(myReader["movieID"].ToString(), myReader["movieName"].ToString(), myReader["genre"].ToString(), myReader["price"].ToString(), myReader["copies"].ToString(), myReader["rating"].ToString());
                }

                myReader.Close();
                movies.Rows.Add();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }

        private void updateMoviesbutton_Click(object sender, EventArgs e)
        {
            //Loops through the rows and updates all of the movies
            for (int item = 0; item <= movies.Rows.Count - 2; item++)
            {
                string movieID = movies.Rows[item].Cells[0].Value.ToString();
                string movieName = movies.Rows[item].Cells[1].Value.ToString();
                string movieGenre = movies.Rows[item].Cells[2].Value.ToString();
                string moviePrice = movies.Rows[item].Cells[3].Value.ToString();
                string movieCopies = movies.Rows[item].Cells[4].Value.ToString();
                string movieRating = movies.Rows[item].Cells[5].Value.ToString();
                myCommand.CommandText = "Update Movies SET movieName='" + movieName + "',genre='" + movieGenre + "',price=" + moviePrice + ",copies=" + movieCopies + ",rating=" + movieRating + " where movieID=" + movieID + ";";
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
            //Instead of updating, this is for adding a new movie
            //Getting the last row index, which is where the user will input the new movies' information
            int lastRowidx = movies.Rows.Count - 1;
            //Check if its not null
            if (!((movies.Rows[lastRowidx].Cells[0].Value == null)))
            {
                //Try to get all of the needed information, if some are null it will go to the catch
                try
                {
                    string movieID = movies.Rows[lastRowidx].Cells[0].Value.ToString();
                    string movieName = movies.Rows[lastRowidx].Cells[1].Value.ToString();
                    string movieGenre = movies.Rows[lastRowidx].Cells[2].Value.ToString();
                    string moviePrice = movies.Rows[lastRowidx].Cells[3].Value.ToString();
                    string movieCopies = movies.Rows[lastRowidx].Cells[4].Value.ToString();
                    string movieRating = movies.Rows[lastRowidx].Cells[5].Value.ToString();
                    myCommand.CommandText = "insert into Movies values(" + movieID + ", '" + movieName + "','" + movieGenre + "'," + moviePrice + "," + movieCopies + "," + movieRating + ");";
                    //Tries to add the movie. Will fail if ID is not unique or the data type is not compatible
                    try
                    {
                        MessageBox.Show(myCommand.CommandText);
                        myReader = myCommand.ExecuteReader();

                        myReader.Close();
                        movies.Rows.Add();


                    }
                    catch (Exception e5)
                    {
                        MessageBox.Show("Movie ID already used (Must be unique) or wrong data type entered", "Error");
                    }
                }
                catch (Exception e6)
                {
                    MessageBox.Show("Not all cells filled", "Error");
                }
            }
        }

        private void movieDeletebutton_Click(object sender, EventArgs e)
        {

            try
            {
                //Gets the current row index the user is clicked on
                int rowIdx = movies.CurrentCell.RowIndex;
                //Gets the movieID from the row
                string movieID = movies.Rows[rowIdx].Cells[0].Value.ToString();
                //SQL to delete
                myCommand.CommandText = "DELETE FROM Movies where movieID=" + movieID;
                //MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                MessageBox.Show("Deleted movie with movie ID: " + movieID);


                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show("Invalid row to be deleted. Please pick another row.");
            }
        }

        private void runReport_Click(object sender, EventArgs e)
        {
            reportOutputText.Clear();

            String report = reports.GetItemText(reports.SelectedItem);
            string output = "";

            MessageBox.Show(report);

            switch (report)
            {
                case "Report 1":

                    myCommand.CommandText = "select * from Movies";
                    myReader = myCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        output += Convert.ToString((myReader["movieID"], myReader["movieName"], myReader["genre"], myReader["price"], myReader["copies"], myReader["rating"]));
                        output += "\n";
                    }

                    reportOutputText.Text = output;
                    myReader.Close();
                    break;

                case "Report 2":

                    myReader.Close();
                    break;

                case "Report 3":

                    myReader.Close();
                    break;

                case "Report 4":

                    myReader.Close();
                    break;

                case "Report 5":

                    myReader.Close();
                    break;
            }

        }
    }
}
