using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace OnlineBookStore
{
    public partial class Cart : MetroForm
    {
        public Cart()
        {
            InitializeComponent();
        }

        string productName;
        string quantity;
        string price;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        double totalPrice = 0;
      
    
        private void Cart_Load(object sender, EventArgs e)
        { // Assign an image to the button.
            //SetMyButtonIcon(btnOrder, "True");
            //SetMyButtonIcon(btnBack, "Back");
          



            lvShoppingCartDetails.Columns.Add("Product Name:", 100);
            lvShoppingCartDetails.Columns.Add("Quantity", 100);
            lvShoppingCartDetails.Columns.Add("Price", 130);
            for (int i = 0; i < ShoppingCart.ListOfItemsToPurchase.Count; i++)
            {
                productName = (((ItemToPurchase)(ShoppingCart.ListOfItemsToPurchase[i])).Product.Name);
                quantity = (((ItemToPurchase)(ShoppingCart.ListOfItemsToPurchase[i])).Quantity).ToString();
                price = (((ItemToPurchase)(ShoppingCart.ListOfItemsToPurchase[i])).Product.Price).ToString();
                string[] Information = { productName, quantity, price };
                lvShoppingCartDetails.Items.Add(new ListViewItem(Information));
                totalPrice += (((ItemToPurchase)(ShoppingCart.ListOfItemsToPurchase[i])).Quantity) * (((ItemToPurchase)(ShoppingCart.ListOfItemsToPurchase[i])).Product.Price);

            }


            btnOrder.Text = "PLACE ORDER:" + totalPrice + "₺";




        }

        private void lvShoppingCartDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { // Assign an image to the button.
           
           
            ShoppingCart Order = new ShoppingCart();
                
               // MessageBox.Show("The amount you need to pay is " + totalPrice + "₺");
           
            if(totalPrice<=0)
            {
                MessageBox.Show("Your cart is empty!");
                return;
            }

            string creditCardNumber = "";

            if(rdbCash.Checked)
            {
                Order.PlaceOrder(creditCardNumber);
            }

            else if (rdbCredit.Checked)
            {
                creditCardNumber = tbCreditCard.Text;

                if(creditCardNumber == "")
                {
                    MessageBox.Show("Enter a card number!");
                    return;
                }

                Order.PlaceOrder(creditCardNumber);
            }

            Form CustomerForm = new CustomerPanel();

            this.Hide();
            CustomerForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form CustomerForm = new CustomerPanel();

            this.Hide();
            CustomerForm.Show();
        }
        ShoppingCart NCart = new ShoppingCart();
        String text;
        private void button1_Click_1(object sender, EventArgs e)
        {
          

            if (lvShoppingCartDetails.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = lvShoppingCartDetails.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                 text = lvShoppingCartDetails.Items[intselectedindex].Text;

            }
            for (int i = 0; i < ShoppingCart.ListOfItemsToPurchase.Count; i++)
                {
                    productName = (((ItemToPurchase)(ShoppingCart.ListOfItemsToPurchase[i])).Product.Name);
                    if (text == productName) {
                        NCart.RemoveProduct((ItemToPurchase)(ShoppingCart.ListOfItemsToPurchase[i]));
                }
            }
            lvShoppingCartDetails.Items.Clear();
            totalPrice = 0;
            for (int i = 0; i < ShoppingCart.ListOfItemsToPurchase.Count; i++)
                {
                    productName = (((ItemToPurchase)(ShoppingCart.ListOfItemsToPurchase[i])).Product.Name);
                    quantity = (((ItemToPurchase)(ShoppingCart.ListOfItemsToPurchase[i])).Quantity).ToString();
                    price = (((ItemToPurchase)(ShoppingCart.ListOfItemsToPurchase[i])).Product.Price).ToString();
                    string[] Information = { productName, quantity, price };
                    lvShoppingCartDetails.Items.Add(new ListViewItem(Information));

                totalPrice += (((ItemToPurchase)(ShoppingCart.ListOfItemsToPurchase[i])).Quantity) * (((ItemToPurchase)(ShoppingCart.ListOfItemsToPurchase[i])).Product.Price);

            }

         btnOrder.Text = "PLACE ORDER:" + totalPrice + "₺";
           
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            lvShoppingCartDetails.Items.Clear();
            totalPrice = 0;
            ShoppingCart.ListOfItemsToPurchase.Clear();
            btnOrder.Text = "PLACE ORDER:" + totalPrice + "₺";
        }

        private void Cart_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void rdbCash_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCash.Checked)
            {
                tbCreditCard.Enabled = false;
            }

            else if (rdbCredit.Checked)
            {
                tbCreditCard.Enabled = true;
            }
        }

        private void rdbCredit_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCash.Checked)
            {
                tbCreditCard.Enabled = false;
            }

            else if (rdbCredit.Checked)
            {
                tbCreditCard.Enabled = true;
            }
        }

        //private void SetMyButtonIcon(Button btn, string iconName)
        //{
        //    // Assign an image to the button.
        //    btn.Image = Image.FromFile(@"C:\Users\Mehmet CELIKHAN\Desktop\Lectures(2017-2018Bahar)\OBJECT ORIENTED PROGRAMMING II\Nesne_Proje_2\OOP2-safak\OOP2-safak\Icons\icon_" + iconName + ".png");
        //    // Align the image and text on the button.
        //    btn.TextImageRelation = TextImageRelation.ImageAboveText;
        //    btn.ImageAlign = ContentAlignment.MiddleRight;
        //    btn.TextAlign = ContentAlignment.MiddleLeft;

        //    btn.BackgroundImageLayout = ImageLayout.Stretch;
        //}
    }
    }
    
