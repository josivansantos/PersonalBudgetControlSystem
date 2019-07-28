using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBCS_v1._1
{
    public partial class frmMenu : Form
    {
        public string uType;
        public string checkUser;

        public frmMenu()
        {
            InitializeComponent();            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            frmIncome objFrmMenu = new frmIncome();
            this.Hide();
            objFrmMenu.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            checkUser = txtUserType.Text.ToString();

            if (checkUser == "2")
            {
                btnSetup.Enabled = true;
            }
            else
            {
                btnSetup.Enabled = false;
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {            
            frmSetup form = new frmSetup();
            form.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Are you sure that you would like to close the system ? ", "System message ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmExpense form = new frmExpense();
            form.Show();
        }

        private void TxtLogedUser_Click(object sender, EventArgs e)
        {

        }

        private void LblLogedUser_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            btnSetup.Enabled = true;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            btnSetup.Enabled = false;

        }

        private void TxtUserType_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            frmSetup form = new frmSetup();
            form.Show();
        }

        private void Button5_Click_3(object sender, EventArgs e)
        {
            frmSetup form = new frmSetup();
            form.Show();
        }

        private void TxtLogedUSer_Click_1(object sender, EventArgs e)
        {

        }

        private void BntReport_Click(object sender, EventArgs e)
        {
            frmReportExpenses form = new frmReportExpenses();
            form.Show();
        }

        private void Button7_Click_1(object sender, EventArgs e)
        {
            frmReportExpenses form = new frmReportExpenses();
            form.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmHelp form = new frmHelp();
            form.Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
    }

