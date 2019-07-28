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
    public partial class frmReportExpenses : Form
    {
        public frmReportExpenses()
        {
            InitializeComponent();
        }

        private void FrmReportExpenses_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bills.Bill' table. You can move, or remove it, as needed.
            //this.billTableAdapter1.Fill(this.bills.Bill);
            // TODO: This line of code loads data into the 'vendor._Vendor' table. You can move, or remove it, as needed.
            //this.vendorTableAdapter.Fill(this.vendor._Vendor);
            // TODO: This line of code loads data into the 'PBCSDataSet12.Bill' table. You can move, or remove it, as needed.
            //this.BillTableAdapter.Fill(this.PBCSDataSet12.Bill);

            this.reportViewer1.RefreshReport();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
