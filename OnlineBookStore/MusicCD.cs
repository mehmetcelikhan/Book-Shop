using System;
using System.Data.SqlClient;        //  SqlDataAdapter
using System.Windows.Forms;         //MessageBox
using System.Drawing;

/**
* @file MusicCD.cs
* @author Mehmet CELIKHAN
* @brief MusicCD class
*/

namespace OnlineBookStore
{
    /**
    *\brief Enum for the types of music CD
    */
    public enum musicType { Undefined, Romance, HardRock, Country }

    /**
    *\brief A class for music CD, derived from abstract class Product
    */
    class MusicCD : Product
    {
        /**
        *\brief Name of the singer
        */
        private string singer;

        /**
        *\brief Type of the music
        */
        private musicType type;

        /**
        *\brief Constructor of MusicCD class with base parameters
        *\param id: Id of the music CD
        *\param name: Name of the music CD
        *\param price: Price of the music CD
        */
        public MusicCD(int id, string name, double price): base(id, name, price)
        {
        }

        /**
        *\brief Constructor of MusicCD class
        *\param id: Id of the music CD
        *\param name: Name of the music CD
        *\param price: Price of the music CD
        *\param singer: Name of the singer
        *\param type: Type of the music
        */
        public MusicCD(int id, string name, double price, string singer, musicType type)
            : base(id, name, price)
        {
            Singer = singer;
            Type = type;
        }

        public string Singer
        {
            get
            {
                return singer;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Singer must be entered!");
                else
                    singer = value;
            }
        }

        public musicType Type
        {
            get
            {
                return type;
            }

            set
            {
                if (!Enum.IsDefined(typeof(musicType), value))
                    throw new ArgumentException("Enter a valid music type!");
                else
                    type = value;
            }
        }

        /**
        *\brief A function to print properties of the music CD
        */
        public override void PrintProperties()
        {
            string properties = "Name: " + Name + Environment.NewLine + "ID: " + Id + Environment.NewLine +
                "Price: " + Price + Environment.NewLine + "Singer: " + Singer + Environment.NewLine + "Type: " + Type;

            MessageBox.Show(properties, "Properties", MessageBoxButtons.OK);
        }

        /**
        *\brief A function to get select command for music CD
        *\return The select command for music CD
        */
        public static SqlCommand GetSelectCommand()
        {
            string sqlSelectString = "SELECT * FROM tblMusicCD";
            SqlCommand sqlSelectCommand = new SqlCommand(sqlSelectString, DatabaseHandler.SQL_CONNECTION);
            return sqlSelectCommand;
        }

        /**
        *\brief A function to get insert command for music CD
        *\return The insert command for music CD
        */
        public static SqlCommand GetInsertCommand()
        {
            string sqlInsertString = "INSERT INTO tblMusicCD VALUES(@id, @name, @price, @singer, @type);";
            SqlCommand sqlInsertCommand = new SqlCommand(sqlInsertString, DatabaseHandler.SQL_CONNECTION);
            return sqlInsertCommand;
        }

        /**
        *\brief A function to fill the attributes of music CD
        *\param attributes: Attributes of the music CD
        */
        public void Fill(object[] attributes)
        {
            Id              = (int)attributes[0];
            Name            = attributes[1].ToString();
            Price           = (double)attributes[2];
            Singer          = attributes[3].ToString();
            Type            = GetType(attributes[4].ToString());
        }

        /**
        *\brief A function to get the type of music CD as enum from given string
        *\param type: Type of the music CD as string
        *\return Type of the music CD as enum   
        */
        private musicType GetType(string type)
        {
            if (type == "Romance")
                return musicType.Romance;

            if (type == "HardRock")
                return musicType.HardRock;

            if (type == "Country")
                return musicType.Country;

            return musicType.Undefined;
        }
    }
}