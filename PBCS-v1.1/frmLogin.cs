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
using System.IO;

namespace PBCS_v1._1
{
    public partial class frmLogin : Form
    {
        public string uType;
        public string user;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection(@"Data Source=NOTE-ASUS\SQLEXPRESS;Initial Catalog=PBCS;User ID=josivan;Password=josivan");
            string query = "Select * from PBCS.Users where UserName = '" + txtUserLogin.Text.Trim() + "' and UserPassword = '" + txtPasswordLogin.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);

            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (txtUserLogin.Text == string.Empty)
            {
                MessageBox.Show("Please, type your name!", "PBCS - System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtPasswordLogin.Text == string.Empty)
            {
                MessageBox.Show("Please, type your password!", "PBSC - System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dtbl.Rows.Count == 1)
            {
                MessageBox.Show("Welcome " + txtUserLogin.Text + " you are loged", "PBSC - System message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                uType = dtbl.Rows[0][4].ToString();

                frmMenu objFrmMenu = new frmMenu();
                objFrmMenu.txtLogedUSer.Text = txtUserLogin.Text;
                objFrmMenu.txtUserType.Text = uType;

                this.Hide();
                objFrmMenu.Show();

                //++++++++++++ BEGIN OF LOG MODULE +++++++++++++++++++++++++++++++++++
                try
                {
                    FileStream aFile = new FileStream(@"C:\Users\Admin2\OneDrive\2019 - IBT COLLEGE\01-Subjects\D_\BudgetControl\Log\LogLogin.txt", FileMode.Append);
                    StreamWriter sw = new StreamWriter(aFile);

                    string user = txtUserLogin.Text;

                    sw.WriteLine("Date: {0} - User: {1}", DateTime.Now.ToUniversalTime(), user);
                    sw.Close();
                }
                catch (IOException ioMessage)
                {
                    Console.WriteLine("An IO exception has been thrown!");
                    Console.WriteLine(ioMessage.ToString());
                    Console.ReadLine(); return;
                }

                //++++++++++++ END OF LOG MODULE +++++++++++++++++++++++++++++++++++
            }

            else
            {
                MessageBox.Show("Check user name and password!", "PBCS - System message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Are you sure that you would like to close the form ? ", "System message ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cmbUserID objFrmMenu = new cmbUserID();
            this.Hide();
            objFrmMenu.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmExpense form = new frmExpense();
            form.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserCreate form = new frmUserCreate();
            form.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAccountEditor form = new frmAccountEditor();
            form.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmExpensiveIncomeStatusEditor form = new frmExpensiveIncomeStatusEditor();
            form.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu form = new frmMenu();
            form.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSetup form = new frmSetup();
            form.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {            
            frmVendor form = new frmVendor();
            form.Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            frmClient form = new frmClient();
            form.Show();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            frmIncome form = new frmIncome();
            form.Show();
        }
    }
}
