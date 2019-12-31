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
    public partial class UserLogin : MetroForm
    {
        public UserLogin()
        {
            InitializeComponent();
        }

       
        /*  Placeholder for Username and Password Textboxes.*/
        private void tbUserEmail_Enter(object sender, EventArgs e)
        {
            if (tbLoginUsername.Text == "Username")
            {
                tbLoginUsername.Text = "";
                tbLoginUsername.ForeColor = Color.Black;
            }
        }
        private void tbUserEmail_Leave(object sender, EventArgs e)
        {
            if (tbLoginUsername.Text == "")
            {
                tbLoginUsername.Text = "Username";
                tbLoginUsername.ForeColor = Color.Silver;
            }
        }
        private void tbUserPassword_Enter(object sender, EventArgs e)
        {
            if (tbLoginPassword.Text == "Password")
            {
                tbLoginPassword.Text = "";
                tbLoginPassword.ForeColor = Color.Black;
            }
        }
        private void tbUserPassword_Leave(object sender, EventArgs e)
        {
            if (tbLoginPassword.Text == "")
            {
                tbLoginPassword.Text = "Password";
                tbLoginPassword.ForeColor = Color.Silver;
            }
        }




        /*  Login Buttons   */
        public void btnLoginLogin_Click(object sender, EventArgs e)
        {

            string username = tbLoginUsername.Text;
            string password = tbLoginPassword.Text;

            Customer customer = DatabaseHandler.GetInstance().GetCustomer(username, password);

            if (customer.Id == -1)
                MessageBox.Show("Username or Password is wrong!");
            else
            {
                MessageBox.Show("Welcome " + username);
                ShowCustomerPanelForm();
            }
        }

        private void btnLoginSignUp_Click(object sender, EventArgs e)
        {
            ShowSignUpForm();
        }

        private void ShowSignUpForm()
        {
            this.Hide();
            Form UserSignUpForm = new UserSignUp();

            UserSignUpForm.Show();
        }
        private void ShowCustomerPanelForm()
        {
            this.Hide();
            Form CustomerPanelForm = new CustomerPanel();

            CustomerPanelForm.Show();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            tbLoginUsername.Focus();
        }

        private void UserLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void llMainLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainLogin mainLogin = new MainLogin();
            mainLogin.Show();
            this.Hide();
        }
    }
}
