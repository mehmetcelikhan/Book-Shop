using System;
using System.Collections.Generic;
using System.Data;                  //  DataSet
using System.Windows.Forms;         // MessageBox
using System.Net.Mail;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

/**
* @file ShoppingCart.cs
* @author Mehmet CELIKHAN
* @brief ShoppingCart class
*/

namespace OnlineBookStore
{
    /**
    *\brief An enum for the payment method
    */
    public enum paymentMethod { Cash, CreditCard }

    /**
    *\brief A class for shopping cart to add or remove products
    */
    class ShoppingCart
    {
        /**
        *\brief Id of the customer
        */
        public int customerId;

        /**
        *\brief List of items to be purchased
        */
        public static List<ItemToPurchase> ListOfItemsToPurchase = new List<ItemToPurchase>();

        /**
        *\brief Amount of the payment
        */
        private double paymentAmount;

        /**
        *\brief Method of the payment
        */
        private static paymentMethod paymentType;

        /**
        *\brief SQL adapter of the ShoppingCart class
        */
        private static SqlDataAdapter DATA_ADAPTER;

        /**
        *\brief A function to get the SQL data adapter for the ShoppingCart class
        *\return The SQL data adapter
        */
        public static SqlDataAdapter GetDataAdapter()
        {
            try
            {
                if (DATA_ADAPTER == null)
                    DATA_ADAPTER = new SqlDataAdapter(GetSelectCommand(), DatabaseHandler.CONNECTION_STRING);

                return DATA_ADAPTER;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return null;
            }
        }

        /**
        *\brief A function to get the customer data set for ShoppingCart class
        *\return The data set
        */
        public static DataSet GetDataSet()
        {
            DataSet tblCustomer = new DataSet();
            GetDataAdapter().Fill(tblCustomer, "tblCustomer");

            return tblCustomer;
        }

        public int CustomerId
        {
            get
            {
                return customerId;
            }

            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Customer id must be positive!");
                else
                    customerId = value;
            }
        }

        public double PaymentAmount
        {
            get
            {
                return paymentAmount;
            }

            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Payment amount can't be negative!");
                else
                    paymentAmount = value;
            }
        }

        public paymentMethod PaymentType
        {
            get
            {
                return paymentType;
            }
            set
            {
                if (!Enum.IsDefined(typeof(paymentMethod), value))
                    throw new ArgumentException("Enter a valid payment type!");
                else
                    paymentType = value;
            }
        }

        public static void ItemAddToCart_Click(object sender, EventArgs e)
        {
            
            string presentTabName = CustomerPanel.PRESENT_TAB.Text;

            Button AddToCartButton = (Button)sender;
            GroupBox GroupBoxOfAddToCartButton = (GroupBox)AddToCartButton.Parent;
            string itemName = GroupBoxOfAddToCartButton.Controls[1].Text;


            ItemToPurchase item = ListOfItemsToPurchase.Find(i => i.Product.Name == itemName);

            if (item != null)      //  Demek ki listede daha önce varmış, eklenmiş.
                item.Quantity++;

            else if (presentTabName == "Book")
                ListOfItemsToPurchase.Add(new ItemToPurchase(Factory.GetBook(itemName), 1));

            else if (presentTabName == "Magazine")
                ListOfItemsToPurchase.Add(new ItemToPurchase(Factory.GetMagazine(itemName), 1));

            else if (presentTabName == "MusicCD")
                ListOfItemsToPurchase.Add(new ItemToPurchase(Factory.GetMusicCD(itemName), 1));


            MessageBox.Show(itemName + " is added to the Cart!");


            string log = presentTabName + "\t" + itemName;
            Logger.logger(log);
        }

        /**
        *\brief A function to get the list of items in the cart
        *\return The list of items in the cart
        */
        public string ItemsInCart()
        {
            string items = "";
            string itemName;
            double price,amount, totalPrice = 0;
            int itemQuantity;

            for (int i = 0; i < ListOfItemsToPurchase.Count; i++)
            {
                itemName = ((ItemToPurchase)(ListOfItemsToPurchase[i])).Product.Name;
                itemQuantity = ((ItemToPurchase)(ListOfItemsToPurchase[i])).Quantity;
                price = itemQuantity * (((ItemToPurchase)(ListOfItemsToPurchase[i])).Product.Price);
                amount = (((ItemToPurchase)(ListOfItemsToPurchase[i])).Product.Price);
                items += "Name: " + itemName + Environment.NewLine +
                    "Quantity: " + itemQuantity + Environment.NewLine +
                    "Price: " + amount + Environment.NewLine + Environment.NewLine;

                totalPrice += price;
            }

            items += "Total Price: " + totalPrice;

            return items;
        }

        /**
        *\brief A function to print the list of items in the cart
        */
        public void PrintProducts()
        {
            string items = ItemsInCart();

            MessageBox.Show(items, "Items in the Cart", MessageBoxButtons.OK);
        }

        /**
        *\brief A function to add a product to the item list
        *\param item: An item to add to the item list
        */
        public void AddProduct(ItemToPurchase item)
        {
            ListOfItemsToPurchase.Add(item);
        }

        /**
        *\brief A function to remove a product from the item list
        *\param item: An item to remove from the item list
        */
        public void RemoveProduct(ItemToPurchase item)
        {
            ListOfItemsToPurchase.Remove(item);
        }

        /**
        *\brief A function to place order
        *\param cardNumber: Number of the card, empty default
        */
        public void PlaceOrder(string cardNumber = "")   // perform the payment for the items in the cart and send invoice to custumer’s email.
        {
            double totalPrice = 0;

            for (int i = 0; i < ListOfItemsToPurchase.Count; i++)
            {
                totalPrice += (((ItemToPurchase)(ListOfItemsToPurchase[i])).Quantity) * (((ItemToPurchase)(ListOfItemsToPurchase[i])).Product.Price);
            }

            SendInvoiceByEmail(CustomerId, ItemsInCart(), cardNumber);

            ListOfItemsToPurchase.Clear();
        }

        /**
        *\brief A function to cancel the order
        */
        public void CancelOrder()
        {
            if (ListOfItemsToPurchase.Count > 0)
            {

                DialogResult result = MessageBox.Show("Do you want to cancel your order?", "Order Cancellation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ListOfItemsToPurchase.Clear();
                    MessageBox.Show("Your order is cancelled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /**
        *\brief A function to send email
        *\param customerId: Id of the customer
        *\param message: Message to send
        *\param cardNumber: Number of the card, empty default 
        */
        private void SendInvoiceByEmail(int customerId, string message, string cardNumber = "")
        {
                DataSet ds = GetDataSet();
                string recipientEmail = (ds.Tables[0].Rows[0]["email"].ToString());
            try {
                if (TestEmailRegex(recipientEmail) == true)
                {

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("OnlineBookStore@gmail.com");
                    mail.To.Add(recipientEmail);
                    mail.Subject = "INVOICE";

                    if (cardNumber == "")
                    {
                        mail.Body = message + Environment.NewLine + Environment.NewLine + "Payment Method: Cash" +
                            Environment.NewLine + Environment.NewLine;
                    }

                    else
                    {
                        mail.Body = message + Environment.NewLine + Environment.NewLine + "Payment Method: Credit Card" + Environment.NewLine
                            + "Card Number: " + cardNumber + Environment.NewLine + Environment.NewLine;
                    }

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("OnlineBookStoreOOP@gmail.com", "bookstore26");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    MessageBox.Show("Your order is completed. A mail has been sent to the executives", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /**
        *\brief A function to get the select command of customer for ShoppingCart class
        *\return The select command
        */
        public static string GetSelectCommand()
        {
            Customer instance = Customer.GetInstance();
            return "SELECT email FROM tblCustomer where id='" +instance.Id+"' ";
        }

        /**
        *\brief A function to check an email address
        *\param emailAddress: An email address to check
        *\return True if the email address is valid, false otherwise
        */
        public bool TestEmailRegex(string emailAddress)
        {
            string patternStrict = @"^(([^<>()[\]\\.,;:\s@\""]+"
            + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
            + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"
            + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
            + @"[a-zA-Z]{2,}))$";
            Regex reStrict = new Regex(patternStrict);
            bool isStrictMatch = reStrict.IsMatch(emailAddress);
            return isStrictMatch;
        }



    }


}