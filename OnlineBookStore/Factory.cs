using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;           //  Color
using System.Windows.Forms;     //  Group Box

/**
* @file Factory.cs
* @author Mehmet CELIKHAN
* @brief Factory class
*/

namespace OnlineBookStore
{
    /**
    *\brief A class to get items by using factory design pattern
    */
    abstract class Factory
    {
        /*  GetBox  */

        /**
        *\brief A function to get a group box to display a product
        *\return A group box to display a product
        */
        private static GroupBox GetBox()
        {
            GroupBox ItemGroupBox = new GroupBox();
            ItemGroupBox.BackColor = Color.Pink;
            ItemGroupBox.Size = new Size(200, 300);

            PictureBox ItemPicture = new PictureBox();
            ItemPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ItemPicture.Location = new Point(25, 25);
            ItemPicture.Size = new Size(150, 150);
            ItemPicture.Click += CustomerPanel.ItemPicture_Click;

            Label ItemName = new Label();
            ItemName.Text = "Name";
            ItemName.Location = new Point(70, 190);

            Label ItemPrice = new Label();
            ItemPrice.Text = "Price";
            ItemPrice.Font = new Font("Helvetica", 16, FontStyle.Bold);
            ItemPrice.Location = new Point(70, 220);

            Button ItemAddToCart = new Button();
            ItemAddToCart.BackColor = Color.LightGray;
            ItemAddToCart.Text = "Add To Cart";
            ItemAddToCart.Location = new Point(10, 260);
            ItemAddToCart.Size = new Size(180, 30);
            ItemAddToCart.Click += ShoppingCart.ItemAddToCart_Click;

            ItemGroupBox.Controls.Add(ItemPicture);
            ItemGroupBox.Controls.Add(ItemName);
            ItemGroupBox.Controls.Add(ItemPrice);
            ItemGroupBox.Controls.Add(ItemAddToCart);

            return ItemGroupBox;
        }



        /*  DATA ADAPTER    &&      DATA SET    */

        /**
        *\brief A function to get the SQL data adapter for the given table name
        *\param sourceTableName: Name of the source table
        *\return The SQL data adapter
        */
        public static SqlDataAdapter GetDataAdapterFor(string sourceTableName)
        {
            if ( sourceTableName == "tblCustomer")
                return new SqlDataAdapter( Customer.GetSelectCommand().CommandText, DatabaseHandler.CONNECTION_STRING);

            if (sourceTableName == "tblBook")
                return new SqlDataAdapter(Book.GetSelectCommand().CommandText, DatabaseHandler.CONNECTION_STRING);

            if ( sourceTableName == "tblMagazine")
                return new SqlDataAdapter(Magazine.GetSelectCommand().CommandText, DatabaseHandler.CONNECTION_STRING);

            if ( sourceTableName == "tblMusicCD")
                return new SqlDataAdapter(MusicCD.GetSelectCommand().CommandText, DatabaseHandler.CONNECTION_STRING);

            return null;
        }

        /**
        *\brief A function to get the data set for the given table name
        *\param sourceTableName: Name of the source table
        *\return The dataset
        */
        public static DataSet GetDataSetFor(string sourceTableName)
        {
            DataSet dataSet = new DataSet();

            GetDataAdapterFor(sourceTableName).Fill(dataSet, sourceTableName);

            return dataSet;
        }


        /*  BOOK    */

        /**
        *\brief A function to get a group box for a book
        *\param book: A book
        *\return A group box for the book
        */
        public static GroupBox GetBoxFor(Book book)
        {
            GroupBox BookBox = GetBox();

            string BookImagePath = @"..\..\..\ProductPictures\Book\img_" + book.Name + ".jpg";
            try
            {
                Image itemImage = Image.FromFile(BookImagePath);
                ((PictureBox)BookBox.Controls[0]).Image = Image.FromFile(BookImagePath);

            }
            catch (Exception)
            {
                ((PictureBox)BookBox.Controls[0]).Image = Image.FromFile(@"..\..\..\ProductPictures\img_Error.png");
            }
            
            ((Label)BookBox.Controls[1]).Text = book.Name;
            ((Label)BookBox.Controls[2]).Text = book.Price.ToString() + " ₺";

            return BookBox;
        }

        /**
        *\brief A function to get the book list
        *\return The book list
        */
        public static List<Book> GetBookList()
        {
            SqlCommand sqlSelectCommand = Book.GetSelectCommand();
            List<Book> BookList = new List<Book>();

            try
            {
                DatabaseHandler.SQL_CONNECTION.Open();

                SqlDataReader reader = sqlSelectCommand.ExecuteReader();
                while (reader.HasRows && reader.Read())
                {
                    object[] attributesOfBook = new object[7];      //  Book class has 7 attributes.
                    reader.GetValues(attributesOfBook);             //  Get the first row.

                    Book newBook = new Book(0, "a", 0);
                    newBook.Fill(attributesOfBook);
                    BookList.Add(newBook);
                }

                DatabaseHandler.SQL_CONNECTION.Close();

                return BookList;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return null;
            }
        }

        /**
        *\brief A function to get book
        *\param name: Name of the book
        *\return The book
        */
        public static Book GetBook(string name)
        {
            List<Book> BookList = GetBookList();

            int bookExist = -1;
            for (int i = 0; i < BookList.Count; i++)
            {
                if (BookList[i].Name == name)
                {
                    bookExist = i;
                    break;
                }
            }

            return (bookExist != -1) ? BookList[bookExist] : null;
        }



        /*  MAGAZINE    */

        /**
        *\brief A function to get a group box for a magazine
        *\param magazine: A magazine
        *\return A group box for the magazine
        */
        public static GroupBox GetBoxFor(Magazine magazine)
        {
            GroupBox MagazineBox = GetBox();

            string MagazineImagePath = @"..\..\..\ProductPictures\Magazine\img_" + magazine.Name + ".jpg";
            try
            {
                Image itemImage = Image.FromFile(MagazineImagePath);
                ((PictureBox)MagazineBox.Controls[0]).Image = Image.FromFile(MagazineImagePath);

            }
            catch (Exception)
            {
                ((PictureBox)MagazineBox.Controls[0]).Image = Image.FromFile(@"..\..\..\ProductPictures\img_Error.png");
            }

            ((Label)MagazineBox.Controls[1]).Text = magazine.Name;
            ((Label)MagazineBox.Controls[2]).Text = magazine.Price.ToString() + " ₺";

            return MagazineBox;
        }

        /**
        *\brief A function get the magazine list
        *\return The magazine list
        */
        public static List<Magazine> GetMagazineList()
        {
            SqlCommand sqlSelectCommand = Magazine.GetSelectCommand();
            List<Magazine> MagazineList = new List<Magazine>();

            try
            {
                DatabaseHandler.SQL_CONNECTION.Open();

                SqlDataReader reader = sqlSelectCommand.ExecuteReader();
                while (reader.HasRows && reader.Read())
                {
                    object[] attributesOfMagazine = new object[5];      //  Magazine class has 5 attributes.
                    reader.GetValues(attributesOfMagazine);             //  Get the first row.

                    Magazine newMagazine = new Magazine(0, "a", 0);
                    newMagazine.Fill(attributesOfMagazine);
                    MagazineList.Add(newMagazine);
                }

                DatabaseHandler.SQL_CONNECTION.Close();

                return MagazineList;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return null;
            }
        }

        /**
        *\brief A function to get magazine
        *\param name: Name of the magazine
        *\return The magazine
        */
        public static Magazine GetMagazine(string name)
        {
            List<Magazine> MagazineList = GetMagazineList();

            int magazineExist = -1;
            for (int i = 0; i < MagazineList.Count; i++)
            {
                if (MagazineList[i].Name == name)
                {
                    magazineExist = i;
                    break;
                }
            }

            return (magazineExist != -1) ? MagazineList[magazineExist] : null;
        }



        /*  MUSIC CD    */

        /**
        *\brief A function to get a group box for a music CD
        *\param musicCD: A music CD
        *\return A group box for a music CD
        */
        public static GroupBox GetBoxFor(MusicCD musicCD)
        {
            GroupBox MusicCDBox = GetBox();

            string MusicCDImagePath = @"..\..\..\ProductPictures\MusicCD\img_" + musicCD.Name + ".jpg";
            try
            {
                Image itemImage = Image.FromFile(MusicCDImagePath);
                ((PictureBox)MusicCDBox.Controls[0]).Image = Image.FromFile(MusicCDImagePath);

            }
            catch (Exception)
            {
                ((PictureBox)MusicCDBox.Controls[0]).Image = Image.FromFile(@"..\..\..\ProductPictures\img_Error.png");
            }
            

            ((Label)MusicCDBox.Controls[1]).Text = musicCD.Name;
            ((Label)MusicCDBox.Controls[2]).Text = musicCD.Price.ToString() + " ₺";

            return MusicCDBox;
        }

        /**
        *\brief A function to get the music CD list
        *\return The music CD list
        */
        public static List<MusicCD> GetMusicCDList()
        {
            SqlCommand sqlSelectCommand = MusicCD.GetSelectCommand();
            List<MusicCD> MusicCDList = new List<MusicCD>();

            try
            {
                DatabaseHandler.SQL_CONNECTION.Open();

                SqlDataReader reader = sqlSelectCommand.ExecuteReader();
                while (reader.HasRows && reader.Read())
                {
                    object[] attributesOfMagazine = new object[5];      //  MusicCD class has 5 attributes.
                    reader.GetValues(attributesOfMagazine);             //  Get the first row.

                    MusicCD newMusicCD = new MusicCD(0, "a", 0);
                    newMusicCD.Fill(attributesOfMagazine);
                    MusicCDList.Add(newMusicCD);
                }

                DatabaseHandler.SQL_CONNECTION.Close();

                return MusicCDList;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return null;
            }
        }

        /**
        *\brief A function to get music CD
        *\param name: Name of the music CD
        *\return The music CD
        */
        public static MusicCD GetMusicCD(string name)
        {
            List<MusicCD> MusicCDList = GetMusicCDList();

            int musicCDExist = -1;
            for (int i = 0; i < MusicCDList.Count; i++)
            {
                if (MusicCDList[i].Name == name)
                {
                    musicCDExist = i;
                    break;
                }
            }

            return (musicCDExist != -1) ? MusicCDList[musicCDExist] : null;
        }
    }
}
