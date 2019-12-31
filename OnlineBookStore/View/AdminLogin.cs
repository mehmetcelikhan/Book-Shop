using System;
using System.IO;                //  StreamReader
using System.Windows.Forms;
using MetroFramework.Forms;
namespace OnlineBookStore
{
    public partial class AdminLogin : MetroForm
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private string  ADMIN_USERNAME = "";
        private string  ADMIN_PASSWORD = "";
        private int     WRONG_LOGIN_ATTEMPT = 1;

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            if (ControlAdminInformation())
                ShowAdminPanelForm();
        }


        private void ShowAdminPanelForm()
        {
            this.Hide();

            Form AdminPanelForm = new AdminPanel();
            AdminPanelForm.Show();
        }
        private void ReadAdminInformation()
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(@"C:\OnlineBookStore\AdminInformation.txt"))
                {
                    String line = sr.ReadToEnd();
                    string[] AdminInformation = line.Split(',');
                    ADMIN_USERNAME = AdminInformation[0];
                    ADMIN_PASSWORD = AdminInformation[1];
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private bool ControlAdminInformation()
        {
            ReadAdminInformation();

            if (tbLoginAdminUsername.Text == ADMIN_USERNAME &&
                tbLoginAdminPassword.Text == ADMIN_PASSWORD)
                return true;


            if (WRONG_LOGIN_ATTEMPT < 3)
            {
                MessageBox.Show("You entered "+ WRONG_LOGIN_ATTEMPT +" times wrong information!");
                WRONG_LOGIN_ATTEMPT++;
                return false;
            }


            MessageBox.Show("You entered " + WRONG_LOGIN_ATTEMPT + " times wrong information! Application will be closed!");
            Application.Exit();
            return false;
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void AdminLogin_FormClosed(object sender, FormClosedEventArgs e)
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
