using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CMPT
{
    public class DatabaseFile
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public DatabaseFile(string userName, string password, string database)
        {
            string connectionString = "user id = " + userName + ";" + // Username  
                "password = " + password + ";" +// password 
                "server = localhost" + ";" +// IP for the server
                "Trusted_Connection = yes" + ";" +
                "database = " + database + ";" +// Database to connect to: CMPT291_MovieRentalSystem
                "connection timeout = " + "30";

            myConnection = new SqlConnection(connectionString); // timeout in seconds
            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public string[] getLoginInfo(string userID)
        {
            string salt = "";
            string passHash = "";
            
            myCommand.CommandText = "select passHash, salt from Login where userID = " + "\'" + userID + "\'";

            try
            {
                myReader = myCommand.ExecuteReader();

                myReader.Read();

                salt = myReader["salt"].ToString().Trim();
                passHash = myReader["passHash"].ToString().Trim();

                myReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
            var returnList = new List<string>();
            returnList.Add(salt);
            returnList.Add(passHash);

            return returnList.ToArray();
        }

        public Movie[] getAllMovies()
        {
            var movieList = new List<Movie>();
            myCommand.CommandText = "select * from Movies";
            try
            {
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    MovieStruct movieStruct = new(myReader["movieID"].ToString());

                    movieStruct.price = myReader["price"].ToString();
                    movieStruct.genre = myReader["genre"].ToString();
                    movieStruct.rating = myReader["rating"].ToString();
                    movieStruct.copies = myReader["copies"].ToString();
                    movieStruct.name = myReader["movieName"].ToString();

                    movieList.Add(new Movie(movieStruct));
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                throw new Exception(e3.Message);
            }

            return movieList.ToArray();
        }

        public Movie[] GetMovies(string movieName)
        {
            var movieList = new List<Movie>();
            myCommand.CommandText = "select * from Movies where movieName LIKE '%" + movieName + "%';";

            try
            {
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    MovieStruct movieStruct = new(myReader["movieID"].ToString());

                    movieStruct.price = myReader["price"].ToString();
                    movieStruct.genre = myReader["genre"].ToString();
                    movieStruct.rating = myReader["rating"].ToString();
                    movieStruct.copies = myReader["copies"].ToString();
                    movieStruct.name = myReader["movieName"].ToString();

                    movieList.Add(new Movie(movieStruct));
                }

                myReader.Close();
            }
            catch (Exception e3)
            {
                throw new Exception(e3.Message);
            }

            return movieList.ToArray();
        }

        public void SaveMovies(Movie[] movieArray)
        {
            foreach (Movie movie in movieArray)
            {
                myCommand.CommandText = "Update Movies SET movieName='" + movie.getName() + "',genre='" + movie.getGenre() + "',price=" + movie.getPrice() + ",copies=" + movie.getCopies()+ ",rating=" + movie.getRating() + " where movieID=" + movie.getId() + ";";

                try
                {
                    myReader = myCommand.ExecuteReader();

                    myReader.Close();

                }
                catch (Exception e3)
                {
                    throw new Exception(e3.Message);
                }
            }
        }

        public void DeleteMovie(string movieId)
        {
            myCommand.CommandText = "DELETE FROM Movies where movieID=" + movieId;
            try
            {
                myReader = myCommand.ExecuteReader();
                myReader.Close();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Customer[] GetAllCustomers()
        {
            myCommand.CommandText = "select * from Customer";

            var customerList = new List<Customer>();
            try
            {
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    CustomerStruct customerStruct = new CustomerStruct(Int32.Parse(myReader["accountNo"].ToString()));

                    customerStruct.firstName = myReader["firstName"].ToString();
                    customerStruct.lastName = myReader["lastName"].ToString();
                    customerStruct.phoneNumber = myReader["phoneNumber"].ToString();
                    customerStruct.email = myReader["email"].ToString();
                    customerStruct.streetNo = myReader["streetNo"].ToString();
                    customerStruct.streetName = myReader["streetName"].ToString();
                    customerStruct.aptNo = myReader["aptNo"].ToString();
                    customerStruct.city = myReader["city"].ToString();
                    customerStruct.creditCard = myReader["creditCard"].ToString();
                    customerStruct.rating = myReader["rating"].ToString();

                    Customer customer = new(customerStruct);
                    customerList.Add(customer);
                }

                myReader.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return customerList.ToArray();
        }

        public Customer[] GetCustomers(string customerName)
        {
            myCommand.CommandText = "select * from Customer where firstName='" ;

            var customerList = new List<Customer>();
            try
            {
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    CustomerStruct customerStruct = new CustomerStruct(Int32.Parse(myReader["accountNo"].ToString()));

                    customerStruct.firstName = myReader["firstName"].ToString();
                    customerStruct.lastName = myReader["lastName"].ToString();
                    customerStruct.phoneNumber = myReader["phoneNumber"].ToString();
                    customerStruct.email = myReader["email"].ToString();
                    customerStruct.streetNo = myReader["streetNo"].ToString();
                    customerStruct.streetName = myReader["streetName"].ToString();
                    customerStruct.aptNo = myReader["aptNo"].ToString();
                    customerStruct.city = myReader["city"].ToString();
                    customerStruct.creditCard = myReader["creditCard"].ToString();
                    customerStruct.rating = myReader["rating"].ToString();

                    Customer customer = new(customerStruct);
                    customerList.Add(customer);
                }

                myReader.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return customerList.ToArray();
        }

        public void RemoveCustomer(int accountNo)
        {
            myCommand.CommandText = "DELETE FROM Customers where accountNo=" + accountNo;
            //MessageBox.Show(myCommand.CommandText);
            myReader = myCommand.ExecuteReader();
            myReader.Close();
        }

        public void SaveCustomers(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                myCommand.CommandText = string.Format("Update Customer SET firstName='{0}',lastname='{1}',streetNo='{2}',streetName='{3}',aptNo='{4}',city='{5}',postalCode='{6}',phoneNumber='{7}',email='{8}',rating='{9}'",
                    customer.FirstName, customer.LastName, customer.StreetNo, customer.StreetName, customer.AptNo, customer.City, customer.PostalCode, customer.PhoneNumber, customer.Email, customer.Rating);

                try
                {
                    myReader = myCommand.ExecuteReader();

                    myReader.Close();
                } 
                catch (Exception ex) 
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public void SaveCustomer( Customer customer)
        {
            myCommand.CommandText = string.Format("Update Customer SET firstName='{0}',lastname='{1}',streetNo='{2}',streetName='{3}',aptNo='{4}',city='{5}',postalCode='{6}',phoneNumber='{7}',email='{8}',creditCard='{9}',rating='{10}' where accountNo='{11}'",
                    customer.FirstName, customer.LastName, customer.StreetNo, customer.StreetName, customer.AptNo, customer.City, customer.PostalCode, customer.PhoneNumber, customer.Email, customer.CreditCard, customer.Rating, customer.AccountNo);

            try
            {
                myReader = myCommand.ExecuteReader();

                myReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Customer GetCustomerByAccountNumber(int accountNo)
        {
            Customer customer = null;

            myCommand.CommandText = "select * from Customer where accountNo = " + accountNo;

            try
            {
                myReader = myCommand.ExecuteReader();

                myReader.Read();

                CustomerStruct customerStruct = new(accountNo);

                customerStruct.firstName = myReader["firstName"].ToString();
                customerStruct.lastName = myReader["lastName"].ToString();
                customerStruct.phoneNumber = myReader["phoneNumber"].ToString();
                customerStruct.email = myReader["email"].ToString();
                customerStruct.streetNo = myReader["streetNo"].ToString();
                customerStruct.streetName = myReader["streetName"].ToString();
                customerStruct.aptNo = myReader["aptNo"].ToString();
                customerStruct.city = myReader["city"].ToString();
                customerStruct.creditCard = myReader["creditCard"].ToString();
                customerStruct.rating = myReader["rating"].ToString();

                customer = new Customer(customerStruct);

                myReader.Close();
            } 
            catch (Exception ex)
            {
                throw new Exception (ex.Message);
            }

            return customer;
        }

        public void RunCustomQuery(string query)
        {
            myCommand.CommandText = query;

            try
            {
                myReader = myCommand.ExecuteReader();

                myReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int GetLatestAccountNumber()
        {
            myCommand.CommandText = "select MAX(accountNo) as latestAccount from Customer";
            try
            {
                myReader = myCommand.ExecuteReader();
                if(myReader.Read())
                {
                    int accountNumber = 0;

                    int.TryParse(myReader["latestAccount"].ToString(), out accountNumber);

                    myReader.Close();

                    return accountNumber;
                }
            } 
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return 0;
        }

        public void AddCustomer(Customer customer)
        {
            myCommand.CommandText = string.Format("insert into Customer values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}');",
                customer.AccountNo, customer.LastName, customer.FirstName, customer.StreetNo, customer.StreetName, customer.AptNo, customer.City, customer.PostalCode, customer.PhoneNumber, customer.Email, customer.CreditCard, customer.Rating);

            try
            {
                myReader = myCommand.ExecuteReader();

                myReader.Close();
            } 
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
