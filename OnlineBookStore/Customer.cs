using System;
using System.Data;              //  DataSet
using System.Data.SqlClient;
using System.Drawing;           //  Image instance.
using System.Linq;              //  Any function()
using System.Windows.Forms;     //  MessageBox

/**
* @file Customer.cs
* @author Mehmet CELIKHAN
* @brief Customer class
*/

namespace OnlineBookStore
{
    /**
    *\brief A class for customer
    */
    class Customer
    {
        /**
        *\brief Id of the customer
        */
        private int id;

        /**
        *\brief Username of the customer
        */
        private string username;

        /**
        *\brief Password of the customer
        */
        private string password;

        /**
        *\brief Name of the customer
        */
        private string name;

        /**
        *\brief Address of the customer
        */
        private string address;

        /**
        *\brief Email of the customer
        */
        private string email;

        /**
        *\brief Gender of the customer
        */
        private string gender;

        /**
        *\brief Image of the customer
        */
        private Image image;

        /**
        *\brief An array that contains attributes of the customer
        */
        private static object[] ATTRIBUTES;


        /*  Singleton Design Pattern    */

        /**
        *\brief Instance customer for singleton design pattern
        */
        private static Customer instance;

        /**
        *\brief Default constructor of Customer class
        */
        private Customer() { id = -1; }

        /**
        *\brief A function to create Customer object by using singleton design pattern
        *\return The customer object
        */
        public static Customer GetInstance()
        {
            return (instance == null) ? instance = new Customer() : instance;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Customer id must be higher than zero!");
                else
                    id = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Username must be entered!");
                else
                    username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Password must be entered!");
                else if (value.Length < 6)
                    throw new ArgumentException("Password length must be at least 6 characters long.");
                else if (value.Contains(username))
                    throw new ArgumentException("Password cannot contain username!");
                else if (!value.Any(char.IsDigit))
                    throw new ArgumentException("Password must contains at least one number!");
                else
                    password = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Name must be entered!");
                else
                    name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Address must be entered!");
                else
                    address = value;
            }
        }
        
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                var addr = new System.Net.Mail.MailAddress(value);

                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Email must be entered!");
                else if (addr.Address == email)
                    throw new ArgumentException("Email address is not valid!");
                else
                    email = value;
            }
        }

        //  Below attributes can be null.
        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public Image Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
            }
        }



        /**
        *\brief A function to get select command for Customer class
        *\return The select command for Customer class 
        */
        public static SqlCommand GetSelectCommand()
        {
            string sqlSelectString = "SELECT * FROM tblCustomer";
            SqlCommand sqlSelectCommand = new SqlCommand(sqlSelectString, DatabaseHandler.SQL_CONNECTION);
            return sqlSelectCommand;
        }

        /**
        *\brief A function to get insert command for Customer class
        *\return The insert command for Customer class
        */
        public static SqlCommand GetInsertCommand()
        {
            string sqlInsertString = "INSERT INTO tblCustomer values(@username, @password, @name, @address, @email, @gender);";
            SqlCommand sqlInsertCommand = new SqlCommand(sqlInsertString, DatabaseHandler.SQL_CONNECTION);
            return sqlInsertCommand;
        }

        /**
        *\brief A function to get delete command for Customer class
        *\return The delete command for Customer class
        */
        public static SqlCommand GetDeleteCommand()
        {
            string sqlDeleteString = "DELETE FROM tblCustomer WHERE username=@username OR email=@email;";
            SqlCommand sqlDeleteCommand = new SqlCommand(sqlDeleteString, DatabaseHandler.SQL_CONNECTION);
            return sqlDeleteCommand;
        }

        /**
        *\brief A function to fill the attributes of customer
        *\param attributes: Attributes of the customer
        */
        public void Fill(object[] attributes)
        {
            ATTRIBUTES = attributes;

            instance.id          = (int)attributes[0];
            instance.username    = attributes[1].ToString();
            instance.password    = attributes[2].ToString();
            instance.name        = attributes[3].ToString();
            instance.address     = attributes[4].ToString();
            instance.email       = attributes[5].ToString();
            instance.gender      = attributes[6].ToString();
        }

        /**
        *\brief A function to get the attributes of customer
        *\return The attributes of customer 
        */
        public static object[] GetAttributes()
        {
            return ATTRIBUTES;
        }
    }
}