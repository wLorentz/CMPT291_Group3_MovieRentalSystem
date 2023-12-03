using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace CMPT
{
    public partial class LoginScreen : Form
    {
        private Form1 mainForm;
        private bool loginSuccess;

        /**
         * Constructor for the LoginScreen class
         * 
         * Parameters:
         *      connect:    an SqlConnection to the database to be used
         *      mainFrom:   The main form from which the login screen from is opened
         */
        public LoginScreen(Form1 mainForm)
        {
            this.mainForm = mainForm;
            loginSuccess = false;

            InitializeComponent();
        }

        /**
         * Calculates the hash value of a given string
         * 
         * Param:
         *      password: A string whose hash value is to be calculated
         * 
         * Returns:
         *      Returns a 64 character Sha256 hash string
         */
        static string ComputeSha256Hash(string password)
        {
            // Create a SHA256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidateLogin();
        }

        /**
         * Calls the ValidateLogin function if the enter key is pressed
         */
        private void passwordText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ValidateLogin();
            }
        }

        /**
         * Validates the values in the User ID and Password text fields with the data in the Login table
         */
        private void ValidateLogin()
        {
            string userIDText = userId.Text;
            string password = passwordText.Text;
            string salt = "";
            string passHash = "";
            int userID = 0;
            if(userIDText != "admin")
            {
                int.TryParse(userIDText, out userID);
            }

            string[] loginInfo = mainForm.GetDatabase().getLoginInfo(userID);

            salt = loginInfo[0];
            passHash = loginInfo[1].ToLower();

            string hashedPass = ComputeSha256Hash(password + salt).ToLower();

            if (hashedPass != passHash || (userID == 0 && userIDText != "admin"))
            {
                MessageBox.Show("Invalid Login Information", "Invalid Login", MessageBoxButtons.OK);
            }
            else
            {
                loginSuccess = true;
                var result = MessageBox.Show("Success!", "Successful Login", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    this.mainForm.SuccessfulLogin(userID);
                    this.Close();
                }
            }
        }

        private void LoginScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!loginSuccess)
            {
                this.mainForm.Close();
            }
        }
    }
}
