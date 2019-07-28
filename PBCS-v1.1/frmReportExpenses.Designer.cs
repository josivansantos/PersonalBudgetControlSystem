namespace PBCS_v1._1
{
    partial class frmReportExpenses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PBCSDataSet12 = new PBCS_v1._1.PBCSDataSet12();
            this.account1 = new PBCS_v1._1.Account();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BillTableAdapter = new PBCS_v1._1.PBCSDataSet12TableAdapters.BillTableAdapter();
            this.account2 = new PBCS_v1._1.Account();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendor = new PBCS_v1._1.Vendor();
            this.vendorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vendorTableAdapter = new PBCS_v1._1.VendorTableAdapters.VendorTableAdapter();
            this.bills = new PBCS_v1._1.Bills();
            this.billBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.billTableAdapter1 = new PBCS_v1._1.BillsTableAdapters.BillTableAdapter();
            this.BillId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillPayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VendorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCSDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.account1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.account2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // BillBindingSource
            // 
            this.BillBindingSource.DataMember = "Bill";
            this.BillBindingSource.DataSource = this.PBCSDataSet12;
            // 
            // PBCSDataSet12
            // 
            this.PBCSDataSet12.DataSetName = "PBCSDataSet12";
            this.PBCSDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // account1
            // 
            this.account1.DataSetName = "Account";
            this.account1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource4.Name = "Expenses";
            reportDataSource4.Value = this.BillBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PBCS_v1._1.rptExpenses.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(983, 584);
            this.reportViewer1.TabIndex = 0;
            // 
            // BillTableAdapter
            // 
            this.BillTableAdapter.ClearBeforeFill = true;
            // 
            // account2
            // 
            this.account2.DataSetName = "Account";
            this.account2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillId,
            this.vendorNameDataGridViewTextBoxColumn,
            this.BillDueDate,
            this.BillPayDate,
            this.BillValue,
            this.AccountStatusName,
            this.VendorName,
            this.AccountName,
            this.BillObs});
            this.dataGridView1.DataSource = this.billBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(33, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(944, 492);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataSource = this.vendor;
            this.vendorBindingSource.Position = 0;
            // 
            // vendor
            // 
            this.vendor.DataSetName = "Vendor";
            this.vendor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorBindingSource1
            // 
            this.vendorBindingSource1.DataMember = "Vendor";
            this.vendorBindingSource1.DataSource = this.vendorBindingSource;
            // 
            // vendorTableAdapter
            // 
            this.vendorTableAdapter.ClearBeforeFill = true;
            // 
            // bills
            // 
            this.bills.DataSetName = "Bills";
            this.bills.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billBindingSource1
            // 
            this.billBindingSource1.DataMember = "Bill";
            this.billBindingSource1.DataSource = this.bills;
            // 
            // billTableAdapter1
            // 
            this.billTableAdapter1.ClearBeforeFill = true;
            // 
            // BillId
            // 
            this.BillId.DataPropertyName = "BillId";
            this.BillId.HeaderText = "BillId";
            this.BillId.Name = "BillId";
            this.BillId.ReadOnly = true;
            // 
            // vendorNameDataGridViewTextBoxColumn
            // 
            this.vendorNameDataGridViewTextBoxColumn.DataPropertyName = "VendorName";
            this.vendorNameDataGridViewTextBoxColumn.HeaderText = "VendorName";
            this.vendorNameDataGridViewTextBoxColumn.Name = "vendorNameDataGridViewTextBoxColumn";
            // 
            // BillDueDate
            // 
            this.BillDueDate.DataPropertyName = "BillDueDate";
            this.BillDueDate.HeaderText = "BillDueDate";
            this.BillDueDate.Name = "BillDueDate";
            // 
            // BillPayDate
            // 
            this.BillPayDate.DataPropertyName = "BillPayDate";
            this.BillPayDate.HeaderText = "BillPayDate";
            this.BillPayDate.Name = "BillPayDate";
            // 
            // BillValue
            // 
            this.BillValue.DataPropertyName = "BillValue";
            this.BillValue.HeaderText = "BillValue";
            this.BillValue.Name = "BillValue";
            // 
            // AccountStatusName
            // 
            this.AccountStatusName.DataPropertyName = "AccountStatusName";
            this.AccountStatusName.HeaderText = "AccountStatusName";
            this.AccountStatusName.Name = "AccountStatusName";
            // 
            // VendorName
            // 
            this.VendorName.DataPropertyName = "VendorName";
            this.VendorName.HeaderText = "VendorName";
            this.VendorName.Name = "VendorName";
            // 
            // AccountName
            // 
            this.AccountName.DataPropertyName = "AccountName";
            this.AccountName.HeaderText = "AccountName";
            this.AccountName.Name = "AccountName";
            // 
            // BillObs
            // 
            this.BillObs.DataPropertyName = "BillObs";
            this.BillObs.HeaderText = "BillObs";
            this.BillObs.Name = "BillObs";
            // 
            // frmReportExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 608);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PBCS - Report Expenses";
            this.Load += new System.EventHandler(this.FrmReportExpenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCSDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.account1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.account2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Account account1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BillBindingSource;
        private PBCSDataSet12 PBCSDataSet12;
        private PBCSDataSet12TableAdapters.BillTableAdapter BillTableAdapter;
        private Account account2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private Vendor vendor;
        private System.Windows.Forms.BindingSource vendorBindingSource1;
        private VendorTableAdapters.VendorTableAdapter vendorTableAdapter;
        private Bills bills;
        private System.Windows.Forms.BindingSource billBindingSource1;
        private BillsTableAdapters.BillTableAdapter billTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillId;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillPayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillObs;
    }
}