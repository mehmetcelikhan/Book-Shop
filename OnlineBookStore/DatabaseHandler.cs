using System;
using System.Data.SqlClient;        //  SqlConnection
using System.Net;                   //  WebClient
using System.Windows.Forms;         //  MessageBox
using System.Data;                  //  DataSet

/**
* @file DatabaseHandler.cs
* @author Mehmet CELIKHAN
* @brief DatabaseHandler class
*/

namespace OnlineBookStore
{
    /**
    *\brief A class for database operations
    */
    class DatabaseHandler
    {
        /**
        *\brief Server
        */
        private static string SERVER    = "den1.mssql5.gear.host";

        /**
        *\brief Database
        */
        private static string DATABASE  = "oop2";

        /**
        *\brief User Id
        */
        private static string USER_ID   = "oop2";

        /**
        *\brief Password
        */
        private static string PASSWORD  = "Lk9L3n51Bx~~";


        //  https://stackoverflow.com/questions/11141062/load-all-tables-of-a-database-in-a-single-dataset

        /**
        *\brief Dataset
        */
        DataSet ONLINE_BOOK_STORE_DATABASE              = new DataSet();

        /**
        *\brief Connection string
        */
        public static string CONNECTION_STRING          = "Data Source=" + SERVER + "; Initial Catalog=" + DATABASE + "; User Id=" + USER_ID + "; Password=" + PASSWORD + ";";

        /**
        *\brief An object for database connection
        */
        public static SqlConnection SQL_CONNECTION      = new SqlConnection(CONNECTION_STRING);


        /*  Singleton Design Pattern   */

        /**
        *\brief An object for singleton design pattern
        */
        private static DatabaseHandler instance;

        /**
        *\brief Default constructor of DatabaseHandler class
        */
        private DatabaseHandler() { }

        /**
        *\brief A function to get instance
        *\return DatabaseHandler object
        */
        public static DatabaseHandler GetInstance()
        {
            return (instance == null) ? (instance = new DatabaseHandler()) : instance;
        }



        /*****  CUSTOMER         CUSTOMER         CUSTOMER         CUSTOMER         CUSTOMER         CUSTOMER         CUSTOMER         CUSTOMER      *****/

        /**
        *\brief A function to check if the customer exists
        *\param username: Username of the user
        *\param email: Email of the user
        *\return True if the user exists, false otherwise
        */
        public bool IsCustomerAlreadyExist(string username, string email)
        {
            return HasUsernameAlreadyTaken(username) && HasEmailAlreadyTaken(email);
        }

        /**
        *\brief A function to check if the email address has already taken
        *\param email: An email address
        *\return True if the email address has already taken, false otherwise
        */
        public bool HasEmailAlreadyTaken(string email)
        {
            SqlCommand sqlCommand = Customer.GetSelectCommand();
            sqlCommand.CommandText += " WHERE email = @email";
            sqlCommand.Parameters.AddWithValue("@email", email);

            try
            {
                SQL_CONNECTION.Open();
                object obj = sqlCommand.ExecuteScalar();
                SQL_CONNECTION.Close();

                return (obj != null);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return false;
            }
        }

        /**
        *\brief A function to check if the username has already taken
        *\param username: An username
        *\return True if the username has already taken, false otherwise
        */
        public bool HasUsernameAlreadyTaken(string username)
        {
            SqlCommand sqlCommand = Customer.GetSelectCommand();
            sqlCommand.CommandText += " WHERE username = @username";
            sqlCommand.Parameters.AddWithValue("@username", username);

            try
            {
                SQL_CONNECTION.Open();
                object obj = sqlCommand.ExecuteScalar();       //  Sonuç tablosunun ilk satırını döndürür.
                SQL_CONNECTION.Close();

                return (obj != null);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return false;
            }
        }

        /**
        *\brief A function to get the customer
        *\param username: Username of the customer
        *\param password: Password of the customer
        *\return The customer
        */
        public Customer GetCustomer(string username, string password)
        {
            SqlCommand sqlCommand = Customer.GetSelectCommand();
            sqlCommand.CommandText += " WHERE username = @username AND password = @password";
            sqlCommand.Parameters.AddWithValue("@username", username);
            sqlCommand.Parameters.AddWithValue("@password", password);
            Customer customer = Customer.GetInstance();

            try
            {
                SQL_CONNECTION.Open();
                
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if( reader.HasRows && reader.Read() )
                {
                    
                    object[] attributesOfCustomer = new object[7];
                    reader.GetValues(attributesOfCustomer);
                    
                    customer.Fill(attributesOfCustomer);
                }

                SQL_CONNECTION.Close();
  
                return customer;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return customer;
            }
        }


        /*  CUSTOMER SQL COMMANDS   */

        /**
        *\brief A function to insert a customer to the database
        *\param customer: A customer to insert to the database
        *\return True or false, depends on errors
        */
        public bool InsertCustomer(Customer customer)
        {
            SqlCommand sqlCommand = Customer.GetInsertCommand();

            sqlCommand.Parameters.AddWithValue("@username", customer.Username);
            sqlCommand.Parameters.AddWithValue("@password", customer.Password);
            sqlCommand.Parameters.AddWithValue("@name", customer.Name);
            sqlCommand.Parameters.AddWithValue("@address", customer.Address);
            sqlCommand.Parameters.AddWithValue("@email", customer.Email);
            sqlCommand.Parameters.AddWithValue("@gender", customer.Gender);

            try
            {
                SQL_CONNECTION.Open();
                int numberOfAffectedRows = sqlCommand.ExecuteNonQuery();       //  Etkilenen satır sayısını döndürür.
                SQL_CONNECTION.Close();

                return numberOfAffectedRows == 1;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return false;
            }
        }

        /**
        *\brief A function to delete a customer from the database
        *\param username: Username of the customer
        *\param email: Email of the customer
        *\return True or false, depends on errors
        */
        public bool DeleteCustomer(string username, string email)
        {
            SqlCommand sqlCommand = Customer.GetDeleteCommand();
            sqlCommand.Parameters.AddWithValue("@username", username);
            sqlCommand.Parameters.AddWithValue("@email", email);

            try
            {
                SQL_CONNECTION.Open();
                //Factory.GetDataAdapterFor("tblCustomer").DeleteCommand = sqlCommand;
                int numberOfAffectedRows = sqlCommand.ExecuteNonQuery();       //  Etkilenen satır sayısını döndürür.
                SQL_CONNECTION.Close();

                return numberOfAffectedRows == 1;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return false;
            }
        }



        /**
        *\brief A function to check for internet connection
        *\return True if there is a internet connection, false otherwise
        */
        private bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                    return true;
            }
            catch (Exception)
            {
                MessageBox.Show("There is no internet connection!");
                return false;
            }
        }
    }
}
