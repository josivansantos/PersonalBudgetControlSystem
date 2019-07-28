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
    public partial class frmIncome : Form
    {
        public frmIncome()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu form = new frmMenu();
            form.Show();
        }

        private void CmbVendor_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataTable ndt;

            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");
            sqlcon.Open();

            da = new SqlDataAdapter("select ClientId, ClientName from PBCS.Client order by ClientName desc", sqlcon);
            ndt = new DataTable();
            da.Fill(ndt);
            cmbClient.DataSource = ndt;
            cmbClient.ValueMember = "ClientId";
            cmbClient.DisplayMember = "ClientName";

            sqlcon.Close();
        }

        private void CmbAccount_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataTable ndt;

            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");
            sqlcon.Open();

            da = new SqlDataAdapter("select AccountId, AccountName from PBCS.Account order by AccountName desc", sqlcon);
            ndt = new DataTable();
            da.Fill(ndt);
            cmbAccount.DataSource = ndt;
            cmbAccount.ValueMember = "AccountId";
            cmbAccount.DisplayMember = "AccountName";

            sqlcon.Close();
        }

        private void CmbStatus_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataTable ndt;

            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");
            sqlcon.Open();

            da = new SqlDataAdapter("select AccountStatusId, AccountStatusName from PBCS.AccountStatus order by AccountStatusName desc", sqlcon);
            ndt = new DataTable();
            da.Fill(ndt);
            cmbStatus.DataSource = ndt;
            cmbStatus.ValueMember = "AccountStatusId";
            cmbStatus.DisplayMember = "AccountStatusName";

            sqlcon.Close();
        }

        private void ChkBoxPaid_CheckedChanged(object sender, EventArgs e)
        {
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
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSetup form = new frmSetup();
            form.Show();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            cmbClient.SelectedIndex = -1;
            cmbAccount.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;

            chkBoxPaid.Checked = false;

            txtIncValue.Clear();
            txtObs.Clear();

            datePayDate.Format = DateTimePickerFormat.Custom;
            datePayDate.CustomFormat = " ";

            dateDueDate.Format = DateTimePickerFormat.Custom;
            dateDueDate.CustomFormat = " ";
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");

            if (cmbClient.Text == string.Empty)
            {
                MessageBox.Show("Please, select a vendor!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cmbAccount.Text == string.Empty)
            {
                MessageBox.Show("Please, select an account!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtIncValue.Text == string.Empty)
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
                {
                    MessageBox.Show("Please, select a pay date!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                cmd.CommandText = "Insert into PBCS.Income values ( '" + dateDueDate.Text + "' , '" + datePayDate.Text + "' , '" + txtIncValue.Text + "' , " + cmbStatus.SelectedValue + " , '" + cmbClient.SelectedValue + "' , '" + cmbAccount.SelectedValue + "' , '" + txtObs.Text + "')";
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                MessageBox.Show("Record inserted successfully!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbClient.SelectedIndex = -1;
                cmbAccount.SelectedIndex = -1;
                cmbStatus.SelectedIndex = -1;

                chkBoxPaid.Checked = false;

                txtIncValue.Clear();
                txtObs.Clear();
            }
        }

        private void FrmIncome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pBCSDataSet14.Income' table. You can move, or remove it, as needed.
            this.incomeTableAdapter.Fill(this.pBCSDataSet14.Income);
            datePayDate.Format = DateTimePickerFormat.Custom;
            datePayDate.CustomFormat = " ";

            dateDueDate.Format = DateTimePickerFormat.Custom;
            dateDueDate.CustomFormat = " ";

            lblPayDate.Visible = false;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {

        }

        public void loadDataGrid()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from PBCS.income order by IncomeId Asc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            sqlcon.Close();
        }

        private void CmbClient_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataTable ndt;

            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");
            sqlcon.Open();

            da = new SqlDataAdapter("select ClientId, ClientName from PBCS.Client order by ClientName desc", sqlcon);
            ndt = new DataTable();
            da.Fill(ndt);
            cmbClient.DataSource = ndt;
            cmbClient.ValueMember = "ClientName";
            cmbClient.DisplayMember = "ClientName";

            sqlcon.Close();
        }

        private void CmbAccount_Click_1(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataTable ndt;

            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");
            sqlcon.Open();

            da = new SqlDataAdapter("select AccountId, AccountName from PBCS.Account order by AccountName desc", sqlcon);
            ndt = new DataTable();
            da.Fill(ndt);
            cmbAccount.DataSource = ndt;
            cmbAccount.ValueMember = "AccountName";
            cmbAccount.DisplayMember = "AccountName";

            sqlcon.Close();
        }

        private void CmbStatus_Click_1(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataTable ndt;

            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");
            sqlcon.Open();

            da = new SqlDataAdapter("select AccountStatusId, AccountStatusName from PBCS.AccountStatus order by AccountStatusName desc", sqlcon);
            ndt = new DataTable();
            da.Fill(ndt);
            cmbStatus.DataSource = ndt;
            cmbStatus.ValueMember = "AccountStatusName";
            cmbStatus.DisplayMember = "AccountStatusName";

            sqlcon.Close();
        }

        private void BtnInsert_Click_1(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");

            if (cmbClient.Text == string.Empty)
            {
                MessageBox.Show("Please, select a client!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cmbAccount.Text == string.Empty)
            {
                MessageBox.Show("Please, select an account!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtIncValue.Text == string.Empty)
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
                {
                    MessageBox.Show("Please, select a pay date!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                cmd.CommandText = "Insert into PBCS.Income values ( '" + dateDueDate.Text + "' , '" + datePayDate.Text + "' , '" + txtIncValue.Text + "', '" + txtObs.Text + "'  , '" + cmbAccount.SelectedValue + "' , '" + cmbStatus.SelectedValue + "' , '" + cmbClient.SelectedValue + "')";
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                MessageBox.Show("Record inserted successfully!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbClient.SelectedIndex = -1;
                cmbAccount.SelectedIndex = -1;
                cmbStatus.SelectedIndex = -1;

                chkBoxPaid.Checked = false;

                txtIncValue.Clear();
                txtObs.Clear();

                datePayDate.Format = DateTimePickerFormat.Custom;
                datePayDate.CustomFormat = " ";

                dateDueDate.Format = DateTimePickerFormat.Custom;
                dateDueDate.CustomFormat = " ";

                loadDataGrid();
            }
        }

        private void BtnCancel_Click_1(object sender, EventArgs e)
        {
            cmbClient.SelectedIndex = -1;
            cmbAccount.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;

            chkBoxPaid.Checked = false;

            txtIncValue.Clear();
            txtObs.Clear();

            datePayDate.Format = DateTimePickerFormat.Custom;
            datePayDate.CustomFormat = " ";

            dateDueDate.Format = DateTimePickerFormat.Custom;
            dateDueDate.CustomFormat = " ";
        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu form = new frmMenu();
            form.Show();
        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show(" Are you sure you want exit ? ", "System message ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmSetup form = new frmSetup();
            form.Show();
        }

        private void ChkBoxPaid_CheckedChanged_1(object sender, EventArgs e)
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

        private void DateDueDate_ValueChanged(object sender, EventArgs e)
        {
            dateDueDate.Format = DateTimePickerFormat.Custom;
            dateDueDate.CustomFormat = "yyyy-MM-dd";
        }

        private void DatePayDate_ValueChanged(object sender, EventArgs e)
        {
            datePayDate.Format = DateTimePickerFormat.Custom;
            datePayDate.CustomFormat = "yyyy-MM-dd";
        }
    }
}
