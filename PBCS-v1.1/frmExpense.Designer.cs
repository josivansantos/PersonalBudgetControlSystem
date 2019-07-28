namespace PBCS_v1._1
{
    partial class frmExpense
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
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pBCSDataSet4 = new PBCS_v1._1.PBCSDataSet4();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblVendor = new System.Windows.Forms.Label();
            this.txtBillValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.dateDueDate = new System.Windows.Forms.DateTimePicker();
            this.txtObs = new System.Windows.Forms.RichTextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.datePayDate = new System.Windows.Forms.DateTimePicker();
            this.lblPayDate = new System.Windows.Forms.Label();
            this.cmbAccount = new System.Windows.Forms.ComboBox();
            this.accountBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.account = new PBCS_v1._1.Account();
            this.accountBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pBCSDataSet2 = new PBCS_v1._1.PBCSDataSet2();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountTableAdapter = new PBCS_v1._1.PBCSDataSet2TableAdapters.AccountTableAdapter();
            this.cmbVendor = new System.Windows.Forms.ComboBox();
            this.vendorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vendor = new PBCS_v1._1.Vendor();
            this.vendorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pBCSDataSet3 = new PBCS_v1._1.PBCSDataSet3();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorTableAdapter = new PBCS_v1._1.PBCSDataSet3TableAdapters.VendorTableAdapter();
            this.statusTableAdapter = new PBCS_v1._1.PBCSDataSet4TableAdapters.StatusTableAdapter();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.accountStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billStatus = new PBCS_v1._1.BillStatus();
            this.statusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accountTableAdapter1 = new PBCS_v1._1.AccountTableAdapters.AccountTableAdapter();
            this.accountStatusTableAdapter = new PBCS_v1._1.BillStatusTableAdapters.AccountStatusTableAdapter();
            this.vendorTableAdapter1 = new PBCS_v1._1.VendorTableAdapters.VendorTableAdapter();
            this.lblPaid = new System.Windows.Forms.Label();
            this.chkBoxPaid = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.billIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billDueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billPayDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountStatusNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billObsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pBCSDataSet13 = new PBCS_v1._1.PBCSDataSet13();
            this.billTableAdapter = new PBCS_v1._1.PBCSDataSet13TableAdapters.BillTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.account)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.pBCSDataSet4;
            // 
            // pBCSDataSet4
            // 
            this.pBCSDataSet4.DataSetName = "PBCSDataSet4";
            this.pBCSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(736, 175);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(638, 175);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 38;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(835, 175);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBackUserCreation_Click);
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(535, 43);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(97, 25);
            this.lblDueDate.TabIndex = 44;
            this.lblDueDate.Text = "Due date:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(930, 175);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 41;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExitUserCreation_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(817, 45);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(74, 25);
            this.lblStatus.TabIndex = 45;
            this.lblStatus.Text = "Status:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(393, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(133, 31);
            this.lblTitle.TabIndex = 46;
            this.lblTitle.Text = "Expenses";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(4, 95);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(90, 25);
            this.lblAccount.TabIndex = 43;
            this.lblAccount.Text = "Account:";
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendor.Location = new System.Drawing.Point(13, 51);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(82, 25);
            this.lblVendor.TabIndex = 42;
            this.lblVendor.Text = "Vendor:";
            this.lblVendor.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtBillValue
            // 
            this.txtBillValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillValue.Location = new System.Drawing.Point(384, 89);
            this.txtBillValue.Name = "txtBillValue";
            this.txtBillValue.Size = new System.Drawing.Size(118, 30);
            this.txtBillValue.TabIndex = 47;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(309, 94);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(69, 25);
            this.lblValue.TabIndex = 48;
            this.lblValue.Text = "Value:";
            // 
            // dateDueDate
            // 
            this.dateDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDueDate.Location = new System.Drawing.Point(638, 43);
            this.dateDueDate.Name = "dateDueDate";
            this.dateDueDate.Size = new System.Drawing.Size(156, 30);
            this.dateDueDate.TabIndex = 49;
            this.dateDueDate.Value = new System.DateTime(2019, 7, 23, 0, 0, 0, 0);
            this.dateDueDate.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // txtObs
            // 
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(98, 131);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(404, 67);
            this.txtObs.TabIndex = 50;
            this.txtObs.Text = "";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(40, 134);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(55, 25);
            this.lblObs.TabIndex = 51;
            this.lblObs.Text = "Obs:";
            // 
            // datePayDate
            // 
            this.datePayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePayDate.Location = new System.Drawing.Point(638, 87);
            this.datePayDate.Name = "datePayDate";
            this.datePayDate.Size = new System.Drawing.Size(156, 30);
            this.datePayDate.TabIndex = 53;
            this.datePayDate.Value = new System.DateTime(2019, 7, 21, 0, 0, 0, 0);
            this.datePayDate.Visible = false;
            this.datePayDate.ValueChanged += new System.EventHandler(this.DatePayDate_ValueChanged);
            // 
            // lblPayDate
            // 
            this.lblPayDate.AutoSize = true;
            this.lblPayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayDate.Location = new System.Drawing.Point(535, 89);
            this.lblPayDate.Name = "lblPayDate";
            this.lblPayDate.Size = new System.Drawing.Size(95, 25);
            this.lblPayDate.TabIndex = 52;
            this.lblPayDate.Text = "Pay date:";
            // 
            // cmbAccount
            // 
            this.cmbAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccount.FormattingEnabled = true;
            this.cmbAccount.Location = new System.Drawing.Point(98, 89);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.Size = new System.Drawing.Size(202, 33);
            this.cmbAccount.TabIndex = 54;
            this.cmbAccount.SelectedIndexChanged += new System.EventHandler(this.CmbAccount_SelectedIndexChanged);
            this.cmbAccount.Click += new System.EventHandler(this.CmbAccount_Click);
            // 
            // accountBindingSource2
            // 
            this.accountBindingSource2.DataMember = "Account";
            this.accountBindingSource2.DataSource = this.account;
            // 
            // account
            // 
            this.account.DataSetName = "Account";
            this.account.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountBindingSource1
            // 
            this.accountBindingSource1.DataMember = "Account";
            this.accountBindingSource1.DataSource = this.pBCSDataSet2;
            // 
            // pBCSDataSet2
            // 
            this.pBCSDataSet2.DataSetName = "PBCSDataSet2";
            this.pBCSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.pBCSDataSet2;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // cmbVendor
            // 
            this.cmbVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVendor.FormattingEnabled = true;
            this.cmbVendor.Location = new System.Drawing.Point(98, 43);
            this.cmbVendor.Name = "cmbVendor";
            this.cmbVendor.Size = new System.Drawing.Size(404, 33);
            this.cmbVendor.TabIndex = 55;
            this.cmbVendor.SelectedIndexChanged += new System.EventHandler(this.CmbVendor_SelectedIndexChanged);
            this.cmbVendor.Click += new System.EventHandler(this.ComboBox2_Click);
            // 
            // vendorBindingSource2
            // 
            this.vendorBindingSource2.DataMember = "Vendor";
            this.vendorBindingSource2.DataSource = this.vendor;
            // 
            // vendor
            // 
            this.vendor.DataSetName = "Vendor";
            this.vendor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorBindingSource1
            // 
            this.vendorBindingSource1.DataMember = "Vendor";
            this.vendorBindingSource1.DataSource = this.pBCSDataSet3;
            // 
            // pBCSDataSet3
            // 
            this.pBCSDataSet3.DataSetName = "PBCSDataSet3";
            this.pBCSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataMember = "Vendor";
            this.vendorBindingSource.DataSource = this.pBCSDataSet3;
            // 
            // vendorTableAdapter
            // 
            this.vendorTableAdapter.ClearBeforeFill = true;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(897, 40);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(139, 33);
            this.cmbStatus.TabIndex = 56;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.CmbStatus_SelectedIndexChanged);
            this.cmbStatus.Click += new System.EventHandler(this.CmbStatus_Click);
            // 
            // accountStatusBindingSource
            // 
            this.accountStatusBindingSource.DataMember = "AccountStatus";
            this.accountStatusBindingSource.DataSource = this.billStatus;
            // 
            // billStatus
            // 
            this.billStatus.DataSetName = "BillStatus";
            this.billStatus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusBindingSource1
            // 
            this.statusBindingSource1.DataMember = "Status";
            this.statusBindingSource1.DataSource = this.pBCSDataSet4;
            // 
            // accountTableAdapter1
            // 
            this.accountTableAdapter1.ClearBeforeFill = true;
            // 
            // accountStatusTableAdapter
            // 
            this.accountStatusTableAdapter.ClearBeforeFill = true;
            // 
            // vendorTableAdapter1
            // 
            this.vendorTableAdapter1.ClearBeforeFill = true;
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.Location = new System.Drawing.Point(834, 92);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(57, 25);
            this.lblPaid.TabIndex = 57;
            this.lblPaid.Text = "Paid:";
            // 
            // chkBoxPaid
            // 
            this.chkBoxPaid.AutoSize = true;
            this.chkBoxPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxPaid.Location = new System.Drawing.Point(895, 100);
            this.chkBoxPaid.Name = "chkBoxPaid";
            this.chkBoxPaid.Size = new System.Drawing.Size(15, 14);
            this.chkBoxPaid.TabIndex = 58;
            this.chkBoxPaid.UseVisualStyleBackColor = true;
            this.chkBoxPaid.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billIdDataGridViewTextBoxColumn,
            this.billDueDateDataGridViewTextBoxColumn,
            this.billPayDateDataGridViewTextBoxColumn,
            this.billValueDataGridViewTextBoxColumn,
            this.accountStatusNameDataGridViewTextBoxColumn,
            this.vendorNameDataGridViewTextBoxColumn,
            this.accountNameDataGridViewTextBoxColumn,
            this.billObsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.billBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1012, 191);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // billIdDataGridViewTextBoxColumn
            // 
            this.billIdDataGridViewTextBoxColumn.DataPropertyName = "BillId";
            this.billIdDataGridViewTextBoxColumn.HeaderText = "BillId";
            this.billIdDataGridViewTextBoxColumn.Name = "billIdDataGridViewTextBoxColumn";
            this.billIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billDueDateDataGridViewTextBoxColumn
            // 
            this.billDueDateDataGridViewTextBoxColumn.DataPropertyName = "BillDueDate";
            this.billDueDateDataGridViewTextBoxColumn.HeaderText = "BillDueDate";
            this.billDueDateDataGridViewTextBoxColumn.Name = "billDueDateDataGridViewTextBoxColumn";
            // 
            // billPayDateDataGridViewTextBoxColumn
            // 
            this.billPayDateDataGridViewTextBoxColumn.DataPropertyName = "BillPayDate";
            this.billPayDateDataGridViewTextBoxColumn.HeaderText = "BillPayDate";
            this.billPayDateDataGridViewTextBoxColumn.Name = "billPayDateDataGridViewTextBoxColumn";
            // 
            // billValueDataGridViewTextBoxColumn
            // 
            this.billValueDataGridViewTextBoxColumn.DataPropertyName = "BillValue";
            this.billValueDataGridViewTextBoxColumn.HeaderText = "BillValue";
            this.billValueDataGridViewTextBoxColumn.Name = "billValueDataGridViewTextBoxColumn";
            // 
            // accountStatusNameDataGridViewTextBoxColumn
            // 
            this.accountStatusNameDataGridViewTextBoxColumn.DataPropertyName = "AccountStatusName";
            this.accountStatusNameDataGridViewTextBoxColumn.HeaderText = "AccountStatusName";
            this.accountStatusNameDataGridViewTextBoxColumn.Name = "accountStatusNameDataGridViewTextBoxColumn";
            // 
            // vendorNameDataGridViewTextBoxColumn
            // 
            this.vendorNameDataGridViewTextBoxColumn.DataPropertyName = "VendorName";
            this.vendorNameDataGridViewTextBoxColumn.HeaderText = "VendorName";
            this.vendorNameDataGridViewTextBoxColumn.Name = "vendorNameDataGridViewTextBoxColumn";
            // 
            // accountNameDataGridViewTextBoxColumn
            // 
            this.accountNameDataGridViewTextBoxColumn.DataPropertyName = "AccountName";
            this.accountNameDataGridViewTextBoxColumn.HeaderText = "AccountName";
            this.accountNameDataGridViewTextBoxColumn.Name = "accountNameDataGridViewTextBoxColumn";
            // 
            // billObsDataGridViewTextBoxColumn
            // 
            this.billObsDataGridViewTextBoxColumn.DataPropertyName = "BillObs";
            this.billObsDataGridViewTextBoxColumn.HeaderText = "BillObs";
            this.billObsDataGridViewTextBoxColumn.Name = "billObsDataGridViewTextBoxColumn";
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "Bill";
            this.billBindingSource.DataSource = this.pBCSDataSet13;
            // 
            // pBCSDataSet13
            // 
            this.pBCSDataSet13.DataSetName = "PBCSDataSet13";
            this.pBCSDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billTableAdapter
            // 
            this.billTableAdapter.ClearBeforeFill = true;
            // 
            // frmExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chkBoxPaid);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbVendor);
            this.Controls.Add(this.cmbAccount);
            this.Controls.Add(this.datePayDate);
            this.Controls.Add(this.lblPayDate);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.dateDueDate);
            this.Controls.Add(this.txtBillValue);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblVendor);
            this.Name = "frmExpense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PBCS - Expenses";
            this.Load += new System.EventHandler(this.FrmExpenseCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.account)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.TextBox txtBillValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.DateTimePicker dateDueDate;
        private System.Windows.Forms.RichTextBox txtObs;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.DateTimePicker datePayDate;
        private System.Windows.Forms.Label lblPayDate;
        private System.Windows.Forms.ComboBox cmbAccount;
        private PBCSDataSet2 pBCSDataSet2;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private PBCSDataSet2TableAdapters.AccountTableAdapter accountTableAdapter;
        private System.Windows.Forms.ComboBox cmbVendor;
        private PBCSDataSet3 pBCSDataSet3;
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private PBCSDataSet3TableAdapters.VendorTableAdapter vendorTableAdapter;
        private PBCSDataSet4 pBCSDataSet4;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private PBCSDataSet4TableAdapters.StatusTableAdapter statusTableAdapter;
        private System.Windows.Forms.BindingSource vendorBindingSource1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.BindingSource accountBindingSource1;
        private System.Windows.Forms.BindingSource statusBindingSource1;
        private Account account;
        private System.Windows.Forms.BindingSource accountBindingSource2;
        private AccountTableAdapters.AccountTableAdapter accountTableAdapter1;
        private BillStatus billStatus;
        private System.Windows.Forms.BindingSource accountStatusBindingSource;
        private BillStatusTableAdapters.AccountStatusTableAdapter accountStatusTableAdapter;
        private Vendor vendor;
        private System.Windows.Forms.BindingSource vendorBindingSource2;
        private VendorTableAdapters.VendorTableAdapter vendorTableAdapter1;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.CheckBox chkBoxPaid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PBCSDataSet13 pBCSDataSet13;
        private System.Windows.Forms.BindingSource billBindingSource;
        private PBCSDataSet13TableAdapters.BillTableAdapter billTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn billIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billDueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billPayDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountStatusNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billObsDataGridViewTextBoxColumn;
    }
}