using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Linq;  //  Lambda Expressions
namespace OnlineBookStore
{
    public partial class CustomerPanel : MetroForm
    {
        public CustomerPanel()
        {
            InitializeComponent();
        }

        public static Button PRESENT_TAB = new Button();



        /*  BUTTONS     */
        private void btnCustomerPanelBook_Click(object sender, EventArgs e)
        {
            PRESENT_TAB = btnCustomerPanelBook;
            panelMenu.Controls.Clear();
            List<Book> BookList = Factory.GetBookList();
            
            foreach (Book book in BookList)   
                panelMenu.Controls.Add( Factory.GetBoxFor(book) );
        }

        private void btnCustomerPanelMagazine_Click(object sender, EventArgs e)
        {
            PRESENT_TAB = btnCustomerPanelMagazine;
            panelMenu.Controls.Clear();
            List<Magazine> MagazineList = Factory.GetMagazineList();

            foreach (Magazine magazine in MagazineList)
                panelMenu.Controls.Add(Factory.GetBoxFor(magazine));
        }

        private void btnCustomerPanelMusicCD_Click(object sender, EventArgs e)
        {
            PRESENT_TAB = btnCustomerPanelMusicCD;
            panelMenu.Controls.Clear();
            List<MusicCD> MusicCDList = Factory.GetMusicCDList();

            foreach (MusicCD musicCD in MusicCDList)
                panelMenu.Controls.Add(Factory.GetBoxFor(musicCD));
        }






        private void CustomerPanel_Load(object sender, EventArgs e)
        {
            lbLoggedAs.Text = "Welcome to Online Book Store! You're logged as " + Customer.GetInstance().Name;

            PRESENT_TAB = btnCustomerPanelBook;
            panelMenu.Controls.Clear();
            List<Book> BookList = Factory.GetBookList();

            foreach (Book book in BookList)
                panelMenu.Controls.Add(Factory.GetBoxFor(book));
        }

        private void btnCustomerPanelAccount_Click(object sender, EventArgs e)
        {
            Form ChangeCustomerInfoForm = new ChangeCustomerInfo();

            this.Hide();
            ChangeCustomerInfoForm.Show();
        }

        private void btnCustomerPanelCart_Click(object sender, EventArgs e)
        {
            Form CartForm = new Cart();

            this.Hide();
            CartForm.Show();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tbItemSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            string itemName = tbItemSearch.Text;
            string sourceTableName = PresentTabTableName();

            if (tbItemSearch.Text != null && tbItemSearch.Text.Length > 2)
            {
               if (sourceTableName == "tblBook")
                {
                    List<Book> BookList = Factory.GetBookList();

                    List<Book> MatchedBookList = new List<Book>();
                    foreach (Book book in BookList)
                        if( book.Name.StartsWith(itemName) )
                            MatchedBookList.Add(book);

                    if( MatchedBookList.Count != 0 )
                    {
                        panelMenu.Controls.Clear();
                        foreach (Book book in MatchedBookList)
                            panelMenu.Controls.Add(Factory.GetBoxFor(book));
                    }
                }
               else if ( sourceTableName == "tblMagazine")
                {
                    List<Magazine> MagazineList = Factory.GetMagazineList();

                    List<Magazine> MatchedMagazineList = new List<Magazine>();
                    foreach (Magazine magazine in MagazineList)
                        if (magazine.Name.StartsWith(itemName))
                            MatchedMagazineList.Add(magazine);

                    if (MatchedMagazineList.Count != 0)
                    {
                        panelMenu.Controls.Clear();
                        foreach (Magazine magazine in MatchedMagazineList)
                            panelMenu.Controls.Add(Factory.GetBoxFor(magazine));
                    }
                }
               else if ( sourceTableName == "tblMusicCD")
                {
                    List<MusicCD> MusicCDList = Factory.GetMusicCDList();

                    List<MusicCD> MatchedMusicCDList = new List<MusicCD>();
                    foreach (MusicCD cd in MusicCDList)
                        if (cd.Name.StartsWith(itemName))
                            MatchedMusicCDList.Add(cd);

                    if (MatchedMusicCDList.Count != 0)
                    {
                        panelMenu.Controls.Clear();
                        foreach (MusicCD cd in MatchedMusicCDList)
                            panelMenu.Controls.Add(Factory.GetBoxFor(cd));
                    }
                }
            }
            else
            {
                panelMenu.Controls.Clear();

                if( sourceTableName == "tblBook" )
                {
                    List<Book> BookList = Factory.GetBookList();

                    foreach (Book book in BookList)
                        panelMenu.Controls.Add(Factory.GetBoxFor(book));
                }
                else if ( sourceTableName == "tblMagazine")
                {
                    List<Magazine> MagazineList = Factory.GetMagazineList();

                    foreach (Magazine magazine in MagazineList)
                        panelMenu.Controls.Add(Factory.GetBoxFor(magazine));
                }
                else if ( sourceTableName == "tblMusicCD")
                {
                    List<MusicCD> MusicCDList = Factory.GetMusicCDList();

                    foreach (MusicCD cd in MusicCDList)
                        panelMenu.Controls.Add(Factory.GetBoxFor(cd));
                }
            }
        }

        private static string PresentTabTableName()
        {
            int index = PRESENT_TAB.Name.IndexOf("l");  //  btnCustomerPanel 'deki l harfi.
            string sourceTableName = "tbl" + PRESENT_TAB.Name.Substring(index+1);

            return sourceTableName;
        }


        public static void ItemPicture_Click(object sender, EventArgs e)
        {
            PictureBox item = (PictureBox)sender;
            GroupBox gb = (GroupBox)item.Parent;

            string itemName = gb.Controls[1].Text;
            string sourceTableName = PresentTabTableName();

            if( sourceTableName == "tblBook")
            {
                List<Book> BookList = Factory.GetBookList();
                Book clickedBook = BookList.First(book => book.Name == itemName);
                clickedBook.PrintProperties();
            }
            else if ( sourceTableName == "tblMagazine")
            {
                List<Magazine> MagazineList = Factory.GetMagazineList();
                Magazine clickedMagazine = MagazineList.First(magazine => magazine.Name == itemName);
                clickedMagazine.PrintProperties();
            }
            else if ( sourceTableName == "tblMusicCD")
            {
                List<MusicCD> MusicCDList = Factory.GetMusicCDList();
                MusicCD clickedMusicCD = MusicCDList.First(magazine => magazine.Name == itemName);
                clickedMusicCD.PrintProperties();
            }

        }
    }
}
