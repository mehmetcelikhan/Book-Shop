using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework.Forms;
namespace OnlineBookStore
{
    public partial class ChangeCustomerInfo : MetroForm
    {
        public ChangeCustomerInfo()
        {
            InitializeComponent();
        }

        void UpdateShownInformation()
        {
            lbShownUsername.Text = "Username: " + customer.Username;
            lbShownName.Text = "Name: " + customer.Name;
            lbShownAddress.Text = "Address: " + customer.Address;
            lbShownEmail.Text = "Email: " + customer.Email;
            lbShownGender.Text = "Gender: " + customer.Gender;
        }


        public SqlCommand GetUpdateNameCommand()
        {
            string sqlUpdateString = "UPDATE tblCustomer set name='" + customer.Name + "' where id=" + customer.Id + "";
            SqlCommand sqlUpdateCommand = new SqlCommand(sqlUpdateString, DatabaseHandler.SQL_CONNECTION);
            return sqlUpdateCommand;
        }

        public SqlCommand GetUpdateAddressCommand()
        {
            string sqlUpdateString = "UPDATE tblCustomer set address='" + customer.Address + "' where id=" + customer.Id + "";
            SqlCommand sqlUpdateCommand = new SqlCommand(sqlUpdateString, DatabaseHandler.SQL_CONNECTION);
            return sqlUpdateCommand;
        }

        public SqlCommand GetUpdateGenderCommand()
        {
            string sqlUpdateString = "UPDATE tblCustomer set gender='" + customer.Gender + "' where id=" + customer.Id + "";
            SqlCommand sqlUpdateCommand = new SqlCommand(sqlUpdateString, DatabaseHandler.SQL_CONNECTION);
            return sqlUpdateCommand;
        }

        public SqlCommand GetUpdatePasswordCommand()
        {
            string sqlUpdateString = "UPDATE tblCustomer set password='" + customer.Password + "' where id=" + customer.Id + "";
            SqlCommand sqlUpdateCommand = new SqlCommand(sqlUpdateString, DatabaseHandler.SQL_CONNECTION);
            return sqlUpdateCommand;
        }




        Customer customer = Customer.GetInstance();

        private void ChangeCustomerInfo_Load(object sender, EventArgs e)
        {
            UpdateShownInformation();

            if (customer.Gender.ToUpper() == "MALE")
            {
                rbMale.Checked = true;
            }

            else
            {
                rbFemale.Checked = true;
            }
        }


        private void btnCustomerPanel_Click(object sender, EventArgs e)
        {
            CustomerPanel customerPanel = new CustomerPanel();
            this.Hide();
            customerPanel.Show();
        }


        private void ChangeCustomerInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void tbPasswordChange_TextChanged(object sender, EventArgs e)
        {
            if (tbPasswordChange.Text == "" && tbRePasswordChange.Text == "")
            {
                lbValid.Text = " ";
            }

            else if (tbPasswordChange.Text == tbRePasswordChange.Text)
            {
                lbValid.Text = "Same password";
                lbValid.ForeColor = Color.Green;
            }

            else
            {
                lbValid.Text = "Passwords do not match ";
                lbValid.ForeColor = Color.Red;
            }
        }

        private void tbRePasswordChange_TextChanged(object sender, EventArgs e)
        {
            if (tbPasswordChange.Text == "" && tbRePasswordChange.Text == "")
            {
                lbValid.Text = "";
            }

            else if (tbPasswordChange.Text == tbRePasswordChange.Text)
            {
                lbValid.Text = "Same password";
                lbValid.ForeColor = Color.Green;
            }

            else
            {
                lbValid.Text = "Passwords do not match ";
                lbValid.ForeColor = Color.Red;
            }
        }



        private void btnChangeName_Click(object sender, EventArgs e)
        {
            try
            {
                if (customer.Name != tbNameChange.Text)
                {
                    customer.Name = tbNameChange.Text;

                    // Ad veritabanında güncellencek
                    DatabaseHandler.SQL_CONNECTION.Open();
                    GetUpdateNameCommand().ExecuteNonQuery();
                    MessageBox.Show("Your name is updated.");
                    DatabaseHandler.SQL_CONNECTION.Close();

                    UpdateShownInformation();
                    tbNameChange.Text = "";
                }

                else
                    MessageBox.Show("Your name is the same!");
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChangeAddress_Click(object sender, EventArgs e)
        {
            try
            {
                if (customer.Address != tbAddressChange.Text)
                {
                    customer.Address = tbAddressChange.Text;

                    // Adres veritabanında güncellencek
                    DatabaseHandler.SQL_CONNECTION.Open();
                    GetUpdateAddressCommand().ExecuteNonQuery();
                    MessageBox.Show("Your address information is updated.");
                    DatabaseHandler.SQL_CONNECTION.Close();

                    UpdateShownInformation();
                    tbAddressChange.Text = "";
                }

                else
                    MessageBox.Show("Your address is the same!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChangeGender_Click(object sender, EventArgs e)
        {
            if (rbMale.Checked)
                customer.Gender = "Male";

            else
                customer.Gender = "Female";

            // Cinsiyet veritabanında güncellencek
            DatabaseHandler.SQL_CONNECTION.Open();
            GetUpdateGenderCommand().ExecuteNonQuery();
            MessageBox.Show("Your gender information is updated.");
            DatabaseHandler.SQL_CONNECTION.Close();

            UpdateShownInformation();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (customer.Password != tbCurrentPassword.Text)
                {
                    MessageBox.Show("You entered your current password wrong!");
                    return;
                }

                if (customer.Password != tbPasswordChange.Text)
                {
                    customer.Password = tbPasswordChange.Text;

                    // Şifre veritabanında güncellencek
                    DatabaseHandler.SQL_CONNECTION.Open();
                    GetUpdatePasswordCommand().ExecuteNonQuery();
                    MessageBox.Show("Your password is updated.");
                    DatabaseHandler.SQL_CONNECTION.Close();

                    tbPasswordChange.Text = "";
                    tbRePasswordChange.Text = "";
                    tbCurrentPassword.Text = "";
                }

                else
                {
                    MessageBox.Show("Your password is the same!");
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
