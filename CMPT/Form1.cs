using System;
using System.Data.SqlClient;

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
        }

        /**
         * Ensures the login screen is only opened once the form is loaded. This prevents the main screen from 
         * covering the login screen in case the login screen is displayed before the main screen gets displayed
         */
        private void Form1_Shown(object sender, EventArgs e)
        {
            Login();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "select * from Movies";

            try
            {
                MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                movies.Rows.Clear();
                while (myReader.Read())
                {
                    movies.Rows.Add(myReader["Title"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }
    }
}
