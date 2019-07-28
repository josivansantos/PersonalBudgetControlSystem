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
    public partial class frmVendor : Form
    {
        public frmVendor()
        {
            InitializeComponent();
            loadDataGridVendor();
        }

        public void loadDataGridVendor()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from PBCS.Vendor order by VendorName Asc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            sqlcon.Close();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Please, type a name!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtPhone.Text == string.Empty)
            {
                MessageBox.Show("Please, type a phone!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Please, type a e-mail!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtAddress.Text == string.Empty)
            {
                MessageBox.Show("Please, type a address!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into PBCS.Vendor values ('" + txtName.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "','" + txtAddress.Text + "')";
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                MessageBox.Show("Record inserted successfully!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtId.Clear();
                txtName.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
                txtAddress.Clear();

                loadDataGridVendor();
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Are you sure you would like to close ? ", "System message ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSetup form = new frmSetup();
            form.Show();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();

            txtId.Enabled = false;

            btnUpdate.Enabled = false;
            btnBack.Enabled = true;
            btnExit.Enabled = true;
            btnCancel.Enabled = true;
            btnEdit.Enabled = true;
            btnInsert.Enabled = true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnBack.Enabled = false;
            btnExit.Enabled = false;
            btnInsert.Enabled = false;

            txtId.Enabled = true;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");

            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("Please, type an Id!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Please, type a name!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtPhone.Text == string.Empty)
            {
                MessageBox.Show("Please, type a phone!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Please, type a e-mail!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtAddress.Text == string.Empty)
            {
                MessageBox.Show("Please, type a address!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "Update PBCS.Vendor set VendorName = '" + txtName.Text + "' , VendorPhone = '" + txtPhone.Text + "' , VendorEmail = '" + txtEmail.Text + "', VendorAddress = '" + txtAddress.Text + "'  WHERE VendorId =  '" + txtId.Text + "' ";
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                txtId.Enabled = false;

                txtId.Clear();
                txtName.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
                txtAddress.Clear();

                btnDelete.Enabled = false;
                btnBack.Enabled = true;
                btnUpdate.Enabled = false;
                btnExit.Enabled = true;
                btnCancel.Enabled = true;
                btnEdit.Enabled = true;
                btnInsert.Enabled = true;

                MessageBox.Show("Record updated successfully", "System message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadDataGridVendor();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                MessageBox.Show("Please, type an Id!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else
            {
                if (MessageBox.Show(" Are you sure you would like to delete VENDOR ID: " + txtId.Text + " ?", "System message ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");
                    sqlcon.Open();
                    SqlCommand cmd = sqlcon.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete from PBCS.Vendor where VendorId = '" + txtId.Text + "'";
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();

                    loadDataGridVendor();

                    MessageBox.Show("Record deleted successfully", "System message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtId.Enabled = false;

                    txtId.Clear();
                    txtName.Clear();
                    txtPhone.Clear();
                    txtEmail.Clear();
                    txtAddress.Clear();

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
                    txtId.Clear();
                    txtName.Clear();
                    txtPhone.Clear();
                    txtEmail.Clear();
                    txtAddress.Clear();
                }
            }
        }
    }
}
