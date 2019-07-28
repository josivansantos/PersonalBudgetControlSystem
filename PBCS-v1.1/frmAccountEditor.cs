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

namespace PBCS_v1._1
{
    public partial class frmAccountEditor : Form
    {
        public frmAccountEditor()
        {
            InitializeComponent();
        }

        public void FrmCreateAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pBCSDataSet2.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.pBCSDataSet2.Account);
        }

        public void loadDataGridAccount()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from PBCS.Account order by AccountNumber Asc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            sqlcon.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

            if (txtAccountNumber.Text == string.Empty)
            {
                MessageBox.Show("Please, type a number!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtAccountName.Text == string.Empty)
            {
                MessageBox.Show("Please, type a name!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into PBCS.Account values ('" + txtAccountNumber.Text + "','" + txtAccountName.Text + "')";
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                MessageBox.Show("Record inserted successfully!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtAccountId.Clear();
                txtAccountNumber.Clear();
                txtAccountName.Clear();

                loadDataGridAccount();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtAccountId.Clear();
            txtAccountName.Clear();
            txtAccountNumber.Clear();

            txtAccountId.Enabled = false;

            btnUpdate.Enabled = false;
            btnBack.Enabled = true;
            btnExit.Enabled = true;
            btnCancel.Enabled = true;
            btnEdit.Enabled = true;
            btnInsert.Enabled = true;
        }

        private void BtnBackUserCreation_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSetup form = new frmSetup();
            form.Show();
        }

        private void BtnExitUserCreation_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Are you sure you would like to close ? ", "System message ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");

            if (txtAccountId.Text == string.Empty)
            {
                MessageBox.Show("Please, type an Id!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtAccountNumber.Text == string.Empty)
            {
                MessageBox.Show("Please, type a Number!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtAccountName.Text == string.Empty)
            {
                MessageBox.Show("Please, type a Name!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;                

                cmd.CommandText = "Update PBCS.Account set AccountNumber = '" + txtAccountNumber.Text + "' , AccountName = '" + txtAccountName.Text + "'  WHERE AccountId =  '" + txtAccountId.Text + "' ";
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                txtAccountId.Enabled = false;

                txtAccountId.Clear();
                txtAccountNumber.Clear();
                txtAccountName.Clear();

                btnDelete.Enabled = false;
                btnBack.Enabled = true;
                btnUpdate.Enabled = false;
                btnExit.Enabled = true;
                btnCancel.Enabled = true;
                btnEdit.Enabled = true;
                btnInsert.Enabled = true;

                MessageBox.Show("Record updated successfully", "System message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadDataGridAccount();
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnBack.Enabled = false;
            btnExit.Enabled = false;
            btnInsert.Enabled = false;

            txtAccountId.Enabled = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtAccountId.Text == string.Empty)
            {
                MessageBox.Show("Please, type an Id!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else
            {
                if (MessageBox.Show(" Are you sure you would like to delete Account ID: " + txtAccountId.Text + " ?", "System message ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");
                    sqlcon.Open();
                    SqlCommand cmd = sqlcon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete from PBCS.Account where AccountId = '" + txtAccountId.Text + "'";
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();

                    loadDataGridAccount();

                    MessageBox.Show("Record deleted successfully", "System message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtAccountId.Enabled = false;

                    txtAccountId.Clear();
                    txtAccountNumber.Clear();
                    txtAccountName.Clear();

                    btnDelete.Enabled = false;
                    btnBack.Enabled = true;
                    btnUpdate.Enabled = false;
                    btnExit.Enabled = true;
                    btnCancel.Enabled = true;
                    btnEdit.Enabled = true;
                    btnInsert.Enabled = true;
                }
                else
                {
                    txtAccountId.Clear();
                    txtAccountNumber.Clear();
                    txtAccountName.Clear();
                }
            }
        }
    }
}
