using System;
using System.Data;                  //  DataSet
using System.Data.SqlClient;
using System.Drawing;               //  Image
using System.Windows.Forms;         //  MessageBox

/**
* @file Book.cs
* @author Mehmet CELIKHAN
* @brief Book class
*/

namespace OnlineBookStore
{
    /**
	*\brief A class for books, derived from abstract class Product
	*/
    class Book : Product
    {
        /**
	    *\brief International Standard Book Number
	    */
        private string isbn;

        /**
	    *\brief Author of the book
	    */
        private string author;

        /**
	    *\brief Publisher of the book
	    */
        private string publisher;

        /**
	    *\brief Number of pages in the book
	    */
        private int page;

        /**
	    *\brief Constructor of Book class with base parameters
	    *\param id: Id of the book
	    *\param name: Name of the book
        *\param price: Price of the book
	    */
        public Book(int id, string name, double price):base(id, name, price)
        {
        }

        /**
	    *\brief Constructor of Book class
	    *\param id: Id of the book
	    *\param name: Name of the book
        *\param price: Price of the book
        *\param isbn: International Standard Book Number
        *\param author: Author of the book
        *\param publisher: Publisher of the book
        *\param page: Number of pages in the book
	    */
        public Book(int id, string name, double price, string isbn, string author, string publisher, int page)
            : base(id, name, price)
        {
            Isbn = isbn;
            Author = author;
            Publisher = publisher;
            Page = page;
        }

        public string Isbn
        {
            get
            {
                return isbn;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("ISBN must be entered!");
                else
                    isbn = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Author must be entered!");
                else
                    author = value;
            }
        }

        public string Publisher
        {
            get
            {
                return publisher;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Publisher must be entered!");
                else
                    publisher = value;
            }
        }

        public int Page
        {
            get
            {
                return page;
            }

            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Page number must be higher than zero!");
                else
                    page = value;
            }
        }

        /**
        *\brief A function to print properties of the book
        */
        public override void PrintProperties()
        {
            string properties = "Name: " + Name + Environment.NewLine +
                                "Price: " + Price + Environment.NewLine + 
                                "ISBN Number: " + Isbn + Environment.NewLine + 
                                "Author: " + Author + Environment.NewLine + 
                                "Publisher: " + Publisher + Environment.NewLine + 
                                "Page Number: " + Page;

            MessageBox.Show(properties, "Properties", MessageBoxButtons.OK);
        }

        /**
        *\brief A function to get select command for the book
        *\return The select command for book
        */
        public static SqlCommand GetSelectCommand()
        {
            string sqlSelectString = "SELECT * FROM tblBook";
            SqlCommand sqlSelectCommand = new SqlCommand(sqlSelectString, DatabaseHandler.SQL_CONNECTION);
            return sqlSelectCommand;
        }

        /**
        *\brief A function to get insert command for the book
        *\return The insert command for book
        */
        public static SqlCommand GetInsertCommand()
        {
            string sqlInsertString = "INSERT INTO tblBook values(@id, @name, @price, @isbn, @author, @publisher, @page);";
            SqlCommand sqlInsertCommand = new SqlCommand(sqlInsertString, DatabaseHandler.SQL_CONNECTION);
            return sqlInsertCommand;
        }

        /**
        *\brief A function to fill the attributes of book
        *\param attributes: Attributes of the book
        */
        public void Fill(object[] attributes)
        {
            Id = (int)attributes[0];
            Name = attributes[1].ToString();
            Price = (double)attributes[2];
            Isbn = attributes[3].ToString();
            Author = attributes[4].ToString();
            Publisher = attributes[5].ToString();
            Page = (int)attributes[6];
        }
    }
}