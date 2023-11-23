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
        private SqlDataReader sqlDataReader;
        private SqlCommand sqlCommand;

        public LoginScreen(SqlConnection connection)
        {
            try
            {
                sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }

            InitializeComponent();
        }

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

        private void passwordText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ValidateLogin();
            }
        }

        private void ValidateLogin()
        {
            string userID = "\'" + userId.Text + "\'";
            string password = passwordText.Text;
            string salt = "";
            string passHash = "";

            sqlCommand.CommandText = "select passHash, salt from Login where userID = " + userID;

            try
            {
                sqlDataReader = sqlCommand.ExecuteReader();

                sqlDataReader.Read();

                salt = sqlDataReader["salt"].ToString().Trim();
                passHash = sqlDataReader["passHash"].ToString().Trim();

                sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

            string hashedPass = ComputeSha256Hash(password + salt);

            if (hashedPass != passHash)
            {
                MessageBox.Show("Invalid Password!", "Invalid Password", MessageBoxButtons.OK);
            }
            else
            {
                var result = MessageBox.Show("Success!", "Successful Login", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        
    }
}
