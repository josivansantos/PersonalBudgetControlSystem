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
    public partial class frmUserCreate : Form
    {         
        public frmUserCreate()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }

        private void BtnExitUserCreation_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Are you sure that you would like to close the form ? ", "System message ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void CmbTypeUserCreation_SelectedIndexChanged(object sender, EventArgs e)
        {

            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            MessageBox.Show("Connection Open  !");

            cnn.Close();
        }

        private void FrmCreateUser_Load(object sender, EventArgs e)
        {
            this.userTypeTableAdapter.Fill(this.pBCSDataSet5.UserType);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (txtNameUserCreation.Text == string.Empty)
            {
                MessageBox.Show("Please, type a name!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtEmailUserCreation.Text == string.Empty)
            {
                MessageBox.Show("Please, type an email!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtPasswordUserCreation.Text == string.Empty)
            {
                MessageBox.Show("Please, type a password!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cmbUserTypeCreation.Text == string.Empty)
            {
                MessageBox.Show("Please, select a user type!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into PBCS.Users values ('" + txtNameUserCreation.Text + "','" + txtPasswordUserCreation.Text + "','" + txtEmailUserCreation.Text + "','" + cmbUserTypeCreation.SelectedValue + "')";
            cmd.ExecuteNonQuery();
            sqlcon.Close();            

            txtNameUserCreation.Clear();
            txtEmailUserCreation.Clear();
            txtPasswordUserCreation.Clear();           
            cmbUserTypeCreation.SelectedIndex = -1;

            MessageBox.Show("User created successfully", "System message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            frmSetup form = new frmSetup();
            form.Show();

        }

        private void TxtNameUserCreation_TextChanged(object sender, EventArgs e)
        {

        }

        private void FolderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void BtnExitUserCreation_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Are you sure that you would like to close the form ? ", "System message ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            txtNameUserCreation.Clear();
            txtEmailUserCreation.Clear();
            txtPasswordUserCreation.Clear();
            cmbUserTypeCreation.SelectedIndex = -1;
        }

        private void BtnBackUserCreation_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmSetup form = new frmSetup();
            form.Show();
        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.typeUserTableAdapter.FillBy(this.pBCSDataSet1.TypeUser);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.typeUserTableAdapter.FillBy1(this.pBCSDataSet1.TypeUser);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.typeUserTableAdapter.FillBy2(this.pBCSDataSet1.TypeUser);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.typeUserTableAdapter.FillBy3(this.pBCSDataSet1.TypeUser);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void CmbUserTypeCreation_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataTable ndt;

            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");
            sqlcon.Open();

            da = new SqlDataAdapter("select UserTypeId, UserTypeName from PBCS.UserType order by UserTypeName desc", sqlcon);
            ndt = new DataTable();
            da.Fill(ndt);
            cmbUserTypeCreation.DataSource = ndt;
            cmbUserTypeCreation.DisplayMember = "UserTypeName";
            cmbUserTypeCreation.ValueMember = "UserTypeId";
            sqlcon.Close();
        }

        private void TxtNameUserCreation_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
