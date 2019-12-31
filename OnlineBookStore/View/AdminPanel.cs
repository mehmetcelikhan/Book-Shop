using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public partial class AdminPanel : Form
    {
        Button PRESENT_TAB;

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            PRESENT_TAB = btnCustomer;
        }


        //  sourceTableName DataGridView'de gösterilecek ve PRESENT_TAB güncellenecek.
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            ShowTable("tblCustomer");
            UpdatePresentTab(this.btnCustomer);
            BlockIdEditing();
        }
        private void btnBook_Click(object sender, EventArgs e)
        {
            ShowTable("tblBook");
            UpdatePresentTab(this.btnBook);
            BlockIdEditing();
        }
        private void btnMagazine_Click(object sender, EventArgs e)
        {
            ShowTable("tblMagazine");
            UpdatePresentTab(this.btnMagazine);
            BlockIdEditing();
        }
        private void btnMusicCD_Click(object sender, EventArgs e)
        {
            ShowTable("tblMusicCD");
            UpdatePresentTab(this.btnMusicCD);
            BlockIdEditing();
        }


        private void ShowTable(string sourceTableName)
        {
            if (sourceTableName == "tblCustomer")
            {
                dgvTable.DataSource = Factory.GetDataSetFor(sourceTableName);
                dgvTable.DataMember = sourceTableName;
            }
            else if (sourceTableName == "tblBook")
            {
                dgvTable.DataSource = Factory.GetDataSetFor(sourceTableName);
                dgvTable.DataMember = sourceTableName;
            }
            else if (sourceTableName == "tblMagazine")
            {
                dgvTable.DataSource = Factory.GetDataSetFor(sourceTableName);
                dgvTable.DataMember = sourceTableName;
            }
            else if (sourceTableName == "tblMusicCD")
            {
                dgvTable.DataSource = Factory.GetDataSetFor(sourceTableName);
                dgvTable.DataMember = sourceTableName;
            }
            else
                MessageBox.Show("Wrong table name!");
        }
        private void UpdatePresentTab(Button btn)
        {
            PRESENT_TAB.BackColor = Color.LightGray;
            PRESENT_TAB = btn;
            PRESENT_TAB.BackColor = Color.Beige;
        }
        private string PresentTableName()
        {
            return "tbl" + PRESENT_TAB.Name.Substring(3);
        }
        private SqlDataAdapter PresentTableDataAdapter()
        {
            return Factory.GetDataAdapterFor(PresentTableName());
        }
        private bool UpdateGridviewAndDatabase()
        {
            try
            {
                SqlDataAdapter adapter = PresentTableDataAdapter();
                DataSet dataSet = (DataSet)dgvTable.DataSource;
                string sourceTableName = PresentTableName();

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Update(dataSet, sourceTableName);
                ShowTable(sourceTableName);

                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return false;
            }
        }


        /*  BUTTONS     ADD & DELETE & UPDATE     BUTTONS */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataSet set = (DataSet)dgvTable.DataSource;
            DataTable table = set.Tables[0];

            DataRow row = table.NewRow();
            table.Rows.Add(row);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = PresentTableDataAdapter();
            DataSet dataSet = (DataSet)dgvTable.DataSource;
            string sourceTableName = PresentTableName();

            string sqlString = "DELETE FROM " + sourceTableName + " WHERE id = @id";

            foreach (DataGridViewRow row in dgvTable.SelectedRows)
            {
                string idCellValue = row.Cells[0].Value.ToString();
                int id = int.Parse(idCellValue);

                SqlCommand sqlDeleteCommand = new SqlCommand(sqlString, DatabaseHandler.SQL_CONNECTION);
                sqlDeleteCommand.Parameters.AddWithValue("@id", id);
                adapter.DeleteCommand = sqlDeleteCommand;

                try
                {
                    DatabaseHandler.SQL_CONNECTION.Open();
                    int numberOfRowsAffected = adapter.DeleteCommand.ExecuteNonQuery();
                    DatabaseHandler.SQL_CONNECTION.Close();

                    if (numberOfRowsAffected == 1)
                        MessageBox.Show("Row is deleted!");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

                dataSet.Tables[0].Rows.RemoveAt(row.Index);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateGridviewAndDatabase();
        }

        private void BlockIdEditing()
        {
            dgvTable.Columns[0].ReadOnly = true;
            dgvTable.Columns[0].DefaultCellStyle.BackColor = Color.Red;
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbSearch.Text != null && tbSearch.Text.Length > 2)
            {
                DataView dv = Factory.GetDataSetFor(PresentTableName()).Tables[0].DefaultView;
                dv.RowFilter = string.Format("name like '%{0}%'", tbSearch.Text);

                dgvTable.DataSource = dv.ToTable();

            }
            else
            {
                DataView dv = Factory.GetDataSetFor(PresentTableName()).Tables[0].DefaultView;

                dgvTable.DataSource = dv.ToTable();
            }
        }

        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}