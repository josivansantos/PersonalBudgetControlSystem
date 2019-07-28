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
    public partial class cmbUserID : Form
    {
        public cmbUserID()
        {
            InitializeComponent();
        }

        private void DomainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void FrmEditUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pBCSDataSet9.UserType' table. You can move, or remove it, as needed.
            this.userTypeTableAdapter.Fill(this.pBCSDataSet9.UserType);
            // TODO: This line of code loads data into the 'users._Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter1.Fill(this.users._Users);
            // TODO: This line of code loads data into the 'pBCSDataSet1.TypeUser' table. You can move, or remove it, as needed.
            //this.typeUserTableAdapter.Fill(this.pBCSDataSet1.UserType);
            // TODO: This line of code loads data into the 'pBCSDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.pBCSDataSet.Users);

        }

        private void BtnExitSetup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Are you sure that you would like to close the form ? ", "System message ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnBackSertup_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSetup form = new frmSetup();
            form.Show();
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {

            //Server=NOTE-ASUS\SQLEXPRESS;Database=PBCS;User id=josivan;Password=josivan; " ;                        

           
                SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");
                sqlcon.Open();
            try
            {
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from PBCS.Users where UserId = '" + cmbUserId1.Text + "'";
                cmd.ExecuteNonQuery();

                sqlcon.Close();
                disp_data();

                cmbUserId1.SelectedIndex = -1;
                cmbUserNam.SelectedIndex = -1;
                cmbUserPassword.SelectedIndex = -1;
                cmbUserEmail.SelectedIndex = -1;
                cmbUserType.SelectedIndex = -1;

                cmbUserId1.Enabled = true;
                cmbUserNam.Enabled = true;
                cmbUserPassword.Enabled = true;
                cmbUserEmail.Enabled = true;
                cmbUserType.Enabled = true;

                btnCancel.Enabled = false;
                btnEditUser.Enabled = true;
                btnSave.Enabled = false;
                btnDeleteUser.Enabled = false;
                btnExitSetup.Enabled = true;
                btnBackSetup.Enabled = true;

                MessageBox.Show("Record deleted successfull", "System message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            catch
            {

            }

            finally
            { }
            if (1 == 1)
            {
                sqlcon.Close();
            }
        }
        

        public void disp_data()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from PBCS.Users";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            sqlcon.Close();
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            disp_data();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            if (cmbUserId1.SelectedIndex == -1)
            {
                MessageBox.Show("Please, select an Id", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else

            cmbUserId1.Enabled      = false;
            cmbUserNam.Enabled      = true;
            cmbUserPassword.Enabled = true;
            cmbUserEmail.Enabled    = true;
            cmbUserType.Enabled     = true;

            btnExitSetup.Enabled    = false;
            btnCancel.Enabled = true;
            btnBackSetup.Enabled    = false;            
            btnEditUser.Enabled     = false;
            btnDeleteUser.Enabled   = true;
            btnSave.Enabled         = true;            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (cmbUserId1.Text == string.Empty)
            {
                MessageBox.Show("Please, select an ID!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update PBCS.Users set UserName = '" + cmbUserNam.Text + "', UserPassword = " + "'" + cmbUserPassword.SelectedItem + "', UserEmail = + '" + cmbUserEmail.Text + "',  TypeUserId = + '" + cmbUserType.Text + "'  WHERE UserId =  '" + cmbUserType.SelectedValue + "' ";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
            disp_data();   

            MessageBox.Show("Record updated successfully", "System message", MessageBoxButtons.OK, MessageBoxIcon.Information);           
            
            cmbUserId1.SelectedIndex = -1;
            cmbUserId1.Enabled      = true;
            cmbUserNam.Enabled      = false;
            cmbUserPassword.Enabled = false;
            cmbUserEmail.Enabled    = false;
            cmbUserType.Enabled     = false;

            cmbUserId1.SelectedItem = -1;
            cmbUserNam.SelectedIndex = -1;
            cmbUserPassword.SelectedIndex = -1;            
            cmbUserEmail.SelectedIndex = -1;
            cmbUserType.SelectedIndex = -1;

            btnExitSetup.Enabled    = true;
            btnBackSetup.Enabled    = true;
            btnEditUser.Enabled     = true;
            btnDeleteUser.Enabled   = false;
            btnSave.Enabled         = false;
        }

        private void FillBy4ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.typeUserTableAdapter.FillBy4(this.pBCSDataSet1.TypeUser);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void CmbUserId1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            cmbUserId1.Enabled = true;
            cmbUserId1.SelectedIndex = -1;
            cmbUserNam.SelectedIndex = -1;
            cmbUserPassword.SelectedIndex = -1;
            cmbUserEmail.SelectedIndex = -1;            
            cmbUserType.SelectedIndex = -1;

            btnEditUser.Enabled = true;
        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CmbUserType_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataTable ndt;

            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");
            sqlcon.Open();

            da = new SqlDataAdapter("select UserTypeId, UserTypeName from PBCS.UserType order by UserTypeName desc", sqlcon);
            ndt = new DataTable();
            da.Fill(ndt);
            cmbUserType.DataSource = ndt;
            cmbUserType.DisplayMember = "UserTypeName";
            cmbUserType.ValueMember = "UserTypeId";
            sqlcon.Close();
        }
    }
}
   