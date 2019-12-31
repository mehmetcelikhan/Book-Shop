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
    public partial class MainLogin : MetroForm
    {
        public MainLogin()
        {
            InitializeComponent();
        }

        private void btnMainLoginUser_Click(object sender, EventArgs e)
        {
            ShowUserLoginForm();
        }

        private void ShowUserLoginForm()
        {
            this.Hide();

            Form UserLoginForm = new UserLogin();
            UserLoginForm.Show();
        }



        private void btnMainLoginAdmin_Click(object sender, EventArgs e)
        {
            ShowAdminLoginForm();
        }
        private void ShowAdminLoginForm()
        {
            this.Hide();

            Form AdminLoginForm = new AdminLogin();
            AdminLoginForm.Show();
        }

        private void MainLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void MainLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
