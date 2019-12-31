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

namespace OnlineBookStore
{
    public partial class ChangeCustomerInfo : Form
    {
        public ChangeCustomerInfo()
        {
            InitializeComponent();
        }

        Customer customer = Customer.GetInstance();

        private void ChangeCustomerInfo_Load(object sender, EventArgs e)
        {
            tbNameChange.Text = customer.Name;
            tbPasswordChange.Text = customer.Password;
            tbAddressChange.Text = customer.Address;
            tbEmailChange.Text = customer.Email;

            if(customer.Gender.ToUpper() == "MALE")
            {
                rbMale.Checked = true;
            }

            else
            {
                rbFemale.Checked = true;
            }
        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            if(tbCurrentPassword.Text != customer.Password)
            {
                MessageBox.Show("Password is wrong!", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            int id = customer.Id;
            string name = tbNameChange.Text;
            string password = tbPasswordChange.Text;
            string address = tbAddressChange.Text;
            string email = tbEmailChange.Text;
            string gender = "Male";

            if(rbFemale.Checked)
                gender = "Female"; 

          
            // Yeni girilen veriler ile veritabanı güncellenecek

        }

        private void btnCancelChange_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
