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
    public partial class frmExpense : Form
    {
        public frmExpense()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CalDueDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateDueDate.Format = DateTimePickerFormat.Custom;
            dateDueDate.CustomFormat = "yyyy-MM-dd";
        }

        private void BtnExitUserCreation_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Are you sure you want exit ? ", "System message ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnBackUserCreation_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu form = new frmMenu();
            form.Show();
        }

        private void ComboBox2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataTable ndt;

            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");
            sqlcon.Open();

            da = new SqlDataAdapter("select VendorName from PBCS.Vendor order by VendorName desc", sqlcon);
            ndt = new DataTable();
            da.Fill(ndt);
            cmbVendor.DataSource = ndt;
            cmbVendor.ValueMember = "VendorName";
            cmbVendor.DisplayMember = "VendorName";

            sqlcon.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");

            if (cmbVendor.Text == string.Empty)
            {
                MessageBox.Show("Please, select a vendor!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            if (cmbAccount.Text == string.Empty)
            {
                MessageBox.Show("Please, select an account!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtBillValue.Text == string.Empty)
            {
                MessageBox.Show("Please, type a value!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dateDueDate.Text == " ")
            {
                MessageBox.Show("Please, select a due date!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (datePayDate.Text == " ")
            {                
                if (chkBoxPaid.Checked == true)
                { MessageBox.Show("Please, select a pay date!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return;
                }      
            }

            if (cmbStatus.Text == string.Empty)
            {
                MessageBox.Show("Please, select a status!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtObs.Text == string.Empty)
            {
                MessageBox.Show("Please, type an observation!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            else
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;                
                cmd.CommandText = "Insert into PBCS.bill values ( '" + dateDueDate.Text + "' , '" + datePayDate.Text + "' , '" + txtBillValue.Text + "' , '" + cmbStatus.Text + "' , '" + cmbVendor.Text + "' , '" + cmbAccount.Text + "' , '" + txtObs.Text + "')";
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                MessageBox.Show("Record inserted successfully!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbVendor.SelectedIndex = -1;
                cmbAccount.SelectedIndex = -1;
                cmbStatus.SelectedIndex = -1;

                chkBoxPaid.Checked = false;

                txtBillValue.Clear();
                txtObs.Clear();

                datePayDate.Format = DateTimePickerFormat.Custom;
                datePayDate.CustomFormat = " ";

                dateDueDate.Format = DateTimePickerFormat.Custom;
                dateDueDate.CustomFormat = " ";

                loadDataGrid();
            }
        }

        private void FrmExpenseCreate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pBCSDataSet13.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.pBCSDataSet13.Bill);
            // TODO: This line of code loads data into the 'vendor._Vendor' table. You can move, or remove it, as needed.
            this.vendorTableAdapter1.Fill(this.vendor._Vendor);
            // TODO: This line of code loads data into the 'billStatus.AccountStatus' table. You can move, or remove it, as needed.
            this.accountStatusTableAdapter.Fill(this.billStatus.AccountStatus);
            // TODO: This line of code loads data into the 'account._Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter1.Fill(this.account._Account);

            datePayDate.Format = DateTimePickerFormat.Custom;
            datePayDate.CustomFormat = " ";

            dateDueDate.Format = DateTimePickerFormat.Custom;
            dateDueDate.CustomFormat = " ";

            lblPayDate.Visible = false; 
        }

        public void loadDataGrid()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from PBCS.bill order by BillId Asc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            sqlcon.Close();
        }

        private void CmbVendor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbAccount_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataTable ndt;

            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");
            sqlcon.Open();

            da = new SqlDataAdapter("select AccountName from PBCS.Account order by AccountName desc", sqlcon);
            ndt = new DataTable();
            da.Fill(ndt);
            cmbAccount.DataSource = ndt;
            cmbAccount.ValueMember = "AccountName";
            cmbAccount.DisplayMember = "AccountName";

            sqlcon.Close();
        }

        private void CmbStatus_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataTable ndt;

            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");
            sqlcon.Open();

            da = new SqlDataAdapter("select AccountStatusName from PBCS.AccountStatus order by AccountStatusName desc", sqlcon);
            ndt = new DataTable();
            da.Fill(ndt);
            cmbStatus.DataSource = ndt;
            cmbStatus.ValueMember = "AccountStatusName";
            cmbStatus.DisplayMember = "AccountStatusName";

            sqlcon.Close();      
        }

        private void CmbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DatePayDate_ValueChanged(object sender, EventArgs e)
        {
            datePayDate.Format = DateTimePickerFormat.Custom;
            datePayDate.CustomFormat = "yyyy-MM-dd";
        }

        private void CmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {            
            if (chkBoxPaid.Checked == true)
            {
                datePayDate.Visible = true;
                lblPayDate.Visible = true;
            }
            else
            {
                datePayDate.Visible = false;
                lblPayDate.Visible = false;
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmSetup form = new frmSetup();
            form.Show();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {            
            cmbVendor.SelectedIndex = -1;
            cmbAccount.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;

            chkBoxPaid.Checked = false;

            txtBillValue.Clear();
            txtObs.Clear();

            datePayDate.Format = DateTimePickerFormat.Custom;
            datePayDate.CustomFormat = " ";

            dateDueDate.Format = DateTimePickerFormat.Custom;
            dateDueDate.CustomFormat = " ";
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
