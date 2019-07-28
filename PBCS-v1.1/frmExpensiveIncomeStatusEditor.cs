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
    public partial class frmExpensiveIncomeStatusEditor : Form
    {
        public frmExpensiveIncomeStatusEditor()
        {
            InitializeComponent();
        }

    private void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");

            if (txtAccountStatusName.Text == string.Empty)
            {
                MessageBox.Show("Please, type a name!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into PBCS.AccountStatus values ('" + txtAccountStatusName.Text + "')";
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                MessageBox.Show("Record inserted successfully!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtAccountStatusName.Clear();

                loadDataGrid();
            }
        }

        public void loadDataGrid()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from PBCS.AccountStatus";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            sqlcon.Close();
        }

        public void FmrCreateAccountStatus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pBCSDataSet10.AccountStatus' table. You can move, or remove it, as needed.
            this.accountStatusTableAdapter2.Fill(this.pBCSDataSet10.AccountStatus);
            // TODO: This line of code loads data into the 'pBCSDataSet7.AccountStatus' table. You can move, or remove it, as needed.
            this.accountStatusTableAdapter1.Fill(this.pBCSDataSet7.AccountStatus);
            // TODO: This line of code loads data into the 'pBCSDataSet6.AccountStatus' table. You can move, or remove it, as needed.
            this.accountStatusTableAdapter.Fill(this.pBCSDataSet6.AccountStatus);

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");

            if (txtAccountStatusId.Text == string.Empty)
            {
                MessageBox.Show("Please, type an Id!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtAccountStatusName.Text == string.Empty)
            {
                MessageBox.Show("Please, type a Name!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Update PBCS.AccountStatus set AccountStatusName = '" + txtAccountStatusName.Text + "'  WHERE AccountStatusId =  '" + txtAccountStatusId.Text + "' ";
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                txtAccountStatusId.Enabled = false;

                txtAccountStatusId.Clear();
                txtAccountStatusName.Clear();

                btnDelete.Enabled = false;
                btnBack.Enabled = true;
                btnUpdate.Enabled = false;
                btnExit.Enabled = true;
                btnCancel.Enabled = true;
                btnEdit.Enabled = true;
                btnInsert.Enabled = true;

                MessageBox.Show("Record updated successfully", "System message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadDataGrid();
            }
        }

        private void BtnBackUserCreation_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSetup form = new frmSetup();
            form.Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnBack.Enabled = false;
            btnExit.Enabled = false;
            btnInsert.Enabled = false;

            txtAccountStatusId.Enabled = true;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtAccountStatusId.Enabled = false;

            txtAccountStatusId.Clear();
            txtAccountStatusName.Clear();

            btnUpdate.Enabled = false;
            btnBack.Enabled = true;
            btnExit.Enabled = true;
            btnCancel.Enabled = true;
            btnEdit.Enabled = true;
            btnInsert.Enabled = true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Are you sure that you would like to close the form ? ", "System message ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (txtAccountStatusId.Text == string.Empty)
            {
                MessageBox.Show("Please, type an Id!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else
            {
                if (MessageBox.Show(" Are you sure you would like to delete status: " + txtAccountStatusId.Text + " ?", "System message ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");
                    sqlcon.Open();
                    SqlCommand cmd = sqlcon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete from PBCS.AccountStatus where AccountStatusId = '" + txtAccountStatusId.Text + "'";
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();

                    loadDataGrid();

                    MessageBox.Show("Record deleted successfully", "System message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtAccountStatusId.Enabled = false;

                    txtAccountStatusId.Clear();
                    txtAccountStatusName.Clear();

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
                    txtAccountStatusId.Clear();                    
                    txtAccountStatusName.Clear();
                }
            }
        }
    }
}
