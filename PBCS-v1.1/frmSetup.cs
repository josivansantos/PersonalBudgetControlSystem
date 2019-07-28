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
    public partial class frmSetup : Form
    {
        public frmSetup()
        {
            InitializeComponent();
        }

        private void BtnCreateUser_Click(object sender, EventArgs e)
        {            
            frmUserCreate form = new frmUserCreate();
            form.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {            
            frmMenu form = new frmMenu();
            form.Show();
        }

        private void BtnExitSetup_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Are you sure that you would like to close the form ? ", "System message ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            cmbUserID objFrmMenu = new cmbUserID();          
            objFrmMenu.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {            
            frmExpense form = new frmExpense();
            form.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {           
            frmExpensiveIncomeStatusEditor objFrmMenu = new frmExpensiveIncomeStatusEditor();            
            objFrmMenu.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void FrmSetup_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {            
            frmMenu form = new frmMenu();
            form.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {           
            frmAccountEditor form = new frmAccountEditor();
            form.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            cmbUserID objFrmMenu = new cmbUserID();           
            objFrmMenu.Show();           
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            frmLogin objFrmMenu = new frmLogin();            
            objFrmMenu.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            frmIncome objFrmMenu = new frmIncome();            
            objFrmMenu.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            frmVendor objFrmMenu = new frmVendor();            
            objFrmMenu.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            frmClient objFrmMenu = new frmClient();            
            objFrmMenu.Show();
        }

        private void Button1_Click_3(object sender, EventArgs e)
        {
            frmReportExpenses objFrmMenu = new frmReportExpenses();            
            objFrmMenu.Show();
        }
    }
}
