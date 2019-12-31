using System;
using System.Data.SqlClient;    //  SqlDataAdapter
using System.Windows.Forms;     //  MessageBox
using System.Drawing;

/**
* @file Magazine.cs
* @author Mehmet CELIKHAN
* @brief Magazine class
*/

namespace OnlineBookStore
{
    /**
    *\brief Enum for the types of magazine
    */
    public enum magazineType { Undefined, Actual, News, Sport, Computer, Technology }

    /**
    *\brief A class for magazines, derived from abstract class Product
    */
    class Magazine : Product
    {
        /**
        *\brief Issue of the magazine
        */
        private string issue;

        /**
        *\brief Type of the magazine
        */
        private magazineType type;

        /**
        *\brief Constructor of Magazine class with base parameters
        *\param id: Id of the magazine
        *\param name: Name of the magazine
        *\param price: Price of the magazine
        */
        public Magazine(int id, string name, double price) : base(id, name, price)
        {
        }

        /**
        *\brief Constructor of Magazine class
        *\param id: Id of the magazine
        *\param name: Name of the magazine
        *\param price: Price of the magazine
        *\param issue: Issue of the magazine
        *\param type: Type of the magazine
        */
        public Magazine(int id, string name, double price, string issue, magazineType type) 
            : base(id, name, price)
        {
            Issue = issue;
            Type = type;
        }

        /**
        *\brief A function to get the type of magazine as enum from given string
        *\param type: Type of the magazine as string
        *\return Type of the magazine as enum   
        */
        private magazineType GetType(string type)
        {
            if (type == "Actual")
                return magazineType.Actual;

            if (type == "News")
                return magazineType.News;

            if (type == "Sport")
                return magazineType.Sport;

            if (type == "Computer")
                return magazineType.Computer;

            if (type == "Technology")
                return magazineType.Technology;

            return magazineType.Undefined;
        }

        public string Issue
        {
            get
            {
                return issue;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Issue must be entered!");
                else
                    issue = value;
            }
        }

        public magazineType Type
        {
            get
            {
                return type;
            }

            set
            {
                if (!Enum.IsDefined(typeof(magazineType), value))
                    throw new ArgumentException("Enter a valid magazine type!");
                else
                    type = value;
            }
        }

        /**
        *\brief A function to print properties of the magazine
        */
        public override void PrintProperties()
        {
            string properties = "Name: " + Name + Environment.NewLine + "ID: " + Id + Environment.NewLine +
                "Price: " + Price + Environment.NewLine + "Issue: " + Issue + Environment.NewLine + "Type: " + Type;

            MessageBox.Show(properties, "Properties", MessageBoxButtons.OK);
        }

        /**
        *\brief A function to get select command for magazine
        *\return The select command for magazine
        */
        public static SqlCommand GetSelectCommand()
        {
            string sqlSelectString = "SELECT * FROM tblMagazine";
            SqlCommand sqlSelectCommand = new SqlCommand(sqlSelectString, DatabaseHandler.SQL_CONNECTION);
            return sqlSelectCommand;
        }

        /**
        *\brief A function to get insert command for magazine
        *\return The insert command for magazine
        */
        public static SqlCommand GetInsertCommand()
        {
            string sqlInsertString = "INSERT INTO tblMagazine values(@id, @name, @price, @issue, @type);";
            SqlCommand sqlInsertCommand = new SqlCommand(sqlInsertString, DatabaseHandler.SQL_CONNECTION);
            return sqlInsertCommand;
        }

        /**
        *\brief A function to fill the attributes of magazine
        *\param attributes: Attributes of the magazine
        */
        public void Fill(object[] attributes)
        {
            Id = (int)attributes[0];
            Name = attributes[1].ToString();
            Price = (double)attributes[2];
            Issue = attributes[3].ToString();
            Type = GetType(attributes[4].ToString());
        }
    }
}