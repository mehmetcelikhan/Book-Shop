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
    public partial class UserSignUp : MetroForm
    {
        public UserSignUp()
        {
            InitializeComponent();
        }

        private void UserSignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnSignupSignup_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = Customer.GetInstance();
                customer.Username = tbSignupUsername.Text;
                customer.Password = tbSignupPassword.Text;
                customer.Name = tbSignupName.Text;
                customer.Address = tbSignupAddress.Text;
                customer.Email = tbSignupEmail.Text;
                customer.Gender = tbSignupGender.Text;

                if (DatabaseHandler.GetInstance().IsCustomerAlreadyExist(customer.Username, customer.Email))
                    MessageBox.Show("This user has already exist. Please try again with different username or email!");
                else
                {
                    DatabaseHandler.GetInstance().InsertCustomer(customer);
                    MessageBox.Show("Registration Successful.");
                    UserLogin userLogin = new UserLogin();
                    this.Hide();
                    userLogin.Show();
                }
            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void llUserLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            this.Hide();
            userLogin.Show();
        }

        private void tbSignupUsername_Click(object sender, EventArgs e)
        {
           
        }

        private void tbSignupUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserSignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
