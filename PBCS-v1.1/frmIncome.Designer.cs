namespace PBCS_v1._1
{
    partial class frmIncome
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
            this.chkBoxPaid = new System.Windows.Forms.CheckBox();
            this.lblPaid = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.cmbAccount = new System.Windows.Forms.ComboBox();
            this.datePayDate = new System.Windows.Forms.DateTimePicker();
            this.lblPayDate = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.RichTextBox();
            this.dateDueDate = new System.Windows.Forms.DateTimePicker();
            this.txtIncValue = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pBCSDataSet14 = new PBCS_v1._1.PBCSDataSet14();
            this.incomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incomeTableAdapter = new PBCS_v1._1.PBCSDataSet14TableAdapters.IncomeTableAdapter();
            this.incomeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeDueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomePayDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeObsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chkBoxPaid
            // 
            this.chkBoxPaid.AutoSize = true;
            this.chkBoxPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxPaid.Location = new System.Drawing.Point(921, 110);
            this.chkBoxPaid.Name = "chkBoxPaid";
            this.chkBoxPaid.Size = new System.Drawing.Size(15, 14);
            this.chkBoxPaid.TabIndex = 124;
            this.chkBoxPaid.UseVisualStyleBackColor = true;
            this.chkBoxPaid.CheckedChanged += new System.EventHandler(this.ChkBoxPaid_CheckedChanged_1);
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.Location = new System.Drawing.Point(860, 102);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(57, 25);
            this.lblPaid.TabIndex = 123;
            this.lblPaid.Text = "Paid:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(921, 53);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(139, 33);
            this.cmbStatus.TabIndex = 122;
            this.cmbStatus.Click += new System.EventHandler(this.CmbStatus_Click_1);
            // 
            // cmbClient
            // 
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(118, 58);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(404, 33);
            this.cmbClient.TabIndex = 121;
            this.cmbClient.Click += new System.EventHandler(this.CmbClient_Click);
            // 
            // cmbAccount
            // 
            this.cmbAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccount.FormattingEnabled = true;
            this.cmbAccount.Location = new System.Drawing.Point(118, 104);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.Size = new System.Drawing.Size(202, 33);
            this.cmbAccount.TabIndex = 120;
            this.cmbAccount.Click += new System.EventHandler(this.CmbAccount_Click_1);
            // 
            // datePayDate
            // 
            this.datePayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePayDate.Location = new System.Drawing.Point(645, 104);
            this.datePayDate.Name = "datePayDate";
            this.datePayDate.Size = new System.Drawing.Size(156, 30);
            this.datePayDate.TabIndex = 119;
            this.datePayDate.Value = new System.DateTime(2019, 7, 21, 0, 0, 0, 0);
            this.datePayDate.Visible = false;
            this.datePayDate.ValueChanged += new System.EventHandler(this.DatePayDate_ValueChanged);
            // 
            // lblPayDate
            // 
            this.lblPayDate.AutoSize = true;
            this.lblPayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayDate.Location = new System.Drawing.Point(542, 106);
            this.lblPayDate.Name = "lblPayDate";
            this.lblPayDate.Size = new System.Drawing.Size(95, 25);
            this.lblPayDate.TabIndex = 118;
            this.lblPayDate.Text = "Pay date:";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(57, 143);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(55, 25);
            this.lblObs.TabIndex = 117;
            this.lblObs.Text = "Obs:";
            // 
            // txtObs
            // 
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(118, 143);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(404, 67);
            this.txtObs.TabIndex = 116;
            this.txtObs.Text = "";
            // 
            // dateDueDate
            // 
            this.dateDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDueDate.Location = new System.Drawing.Point(645, 53);
            this.dateDueDate.Name = "dateDueDate";
            this.dateDueDate.Size = new System.Drawing.Size(156, 30);
            this.dateDueDate.TabIndex = 115;
            this.dateDueDate.Value = new System.DateTime(2019, 7, 23, 0, 0, 0, 0);
            this.dateDueDate.ValueChanged += new System.EventHandler(this.DateDueDate_ValueChanged);
            // 
            // txtIncValue
            // 
            this.txtIncValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncValue.Location = new System.Drawing.Point(404, 104);
            this.txtIncValue.Name = "txtIncValue";
            this.txtIncValue.Size = new System.Drawing.Size(118, 30);
            this.txtIncValue.TabIndex = 113;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(329, 109);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(69, 25);
            this.lblValue.TabIndex = 114;
            this.lblValue.Text = "Value:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(788, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 105;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click_1);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(690, 187);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 104;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(887, 187);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 106;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click_1);
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(542, 55);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(97, 25);
            this.lblDueDate.TabIndex = 110;
            this.lblDueDate.Text = "Due date:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(982, 187);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 107;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click_1);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(844, 53);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(74, 25);
            this.lblStatus.TabIndex = 111;
            this.lblStatus.Text = "Status:";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncome.ForeColor = System.Drawing.Color.Blue;
            this.lblIncome.Location = new System.Drawing.Point(452, 9);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(178, 46);
            this.lblIncome.TabIndex = 112;
            this.lblIncome.Text = "Incomes";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(24, 104);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(90, 25);
            this.lblAccount.TabIndex = 109;
            this.lblAccount.Text = "Account:";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(33, 66);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(68, 25);
            this.lblClient.TabIndex = 108;
            this.lblClient.Text = "Client:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.incomeIdDataGridViewTextBoxColumn,
            this.incomeDueDateDataGridViewTextBoxColumn,
            this.incomePayDateDataGridViewTextBoxColumn,
            this.incomeValueDataGridViewTextBoxColumn,
            this.incomeObsDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.accountNameDataGridViewTextBoxColumn,
            this.statusNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.incomeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1022, 280);
            this.dataGridView1.TabIndex = 125;
            // 
            // pBCSDataSet14
            // 
            this.pBCSDataSet14.DataSetName = "PBCSDataSet14";
            this.pBCSDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incomeBindingSource
            // 
            this.incomeBindingSource.DataMember = "Income";
            this.incomeBindingSource.DataSource = this.pBCSDataSet14;
            // 
            // incomeTableAdapter
            // 
            this.incomeTableAdapter.ClearBeforeFill = true;
            // 
            // incomeIdDataGridViewTextBoxColumn
            // 
            this.incomeIdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.incomeIdDataGridViewTextBoxColumn.HeaderText = "Income Id";
            this.incomeIdDataGridViewTextBoxColumn.Name = "incomeIdDataGridViewTextBoxColumn";
            this.incomeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incomeDueDateDataGridViewTextBoxColumn
            // 
            this.incomeDueDateDataGridViewTextBoxColumn.DataPropertyName = "Due Date";
            this.incomeDueDateDataGridViewTextBoxColumn.HeaderText = "Income Due Date";
            this.incomeDueDateDataGridViewTextBoxColumn.Name = "incomeDueDateDataGridViewTextBoxColumn";
            // 
            // incomePayDateDataGridViewTextBoxColumn
            // 
            this.incomePayDateDataGridViewTextBoxColumn.DataPropertyName = "Pay Date";
            this.incomePayDateDataGridViewTextBoxColumn.HeaderText = "IncomePayDate";
            this.incomePayDateDataGridViewTextBoxColumn.Name = "incomePayDateDataGridViewTextBoxColumn";
            // 
            // incomeValueDataGridViewTextBoxColumn
            // 
            this.incomeValueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.incomeValueDataGridViewTextBoxColumn.HeaderText = "IncomeValue";
            this.incomeValueDataGridViewTextBoxColumn.Name = "incomeValueDataGridViewTextBoxColumn";
            // 
            // incomeObsDataGridViewTextBoxColumn
            // 
            this.incomeObsDataGridViewTextBoxColumn.DataPropertyName = "Observation";
            this.incomeObsDataGridViewTextBoxColumn.HeaderText = "IncomeObs";
            this.incomeObsDataGridViewTextBoxColumn.Name = "incomeObsDataGridViewTextBoxColumn";
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            // 
            // accountNameDataGridViewTextBoxColumn
            // 
            this.accountNameDataGridViewTextBoxColumn.DataPropertyName = "Account";
            this.accountNameDataGridViewTextBoxColumn.HeaderText = "AccountName";
            this.accountNameDataGridViewTextBoxColumn.Name = "accountNameDataGridViewTextBoxColumn";
            // 
            // statusNameDataGridViewTextBoxColumn
            // 
            this.statusNameDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusNameDataGridViewTextBoxColumn.HeaderText = "StatusName";
            this.statusNameDataGridViewTextBoxColumn.Name = "statusNameDataGridViewTextBoxColumn";
            // 
            // frmIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 526);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chkBoxPaid);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.cmbAccount);
            this.Controls.Add(this.datePayDate);
            this.Controls.Add(this.lblPayDate);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.dateDueDate);
            this.Controls.Add(this.txtIncValue);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblClient);
            this.Name = "frmIncome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PBCS - Incomes";
            this.Load += new System.EventHandler(this.FrmIncome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkBoxPaid;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.ComboBox cmbAccount;
        private System.Windows.Forms.DateTimePicker datePayDate;
        private System.Windows.Forms.Label lblPayDate;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.RichTextBox txtObs;
        private System.Windows.Forms.DateTimePicker dateDueDate;
        private System.Windows.Forms.TextBox txtIncValue;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PBCSDataSet14 pBCSDataSet14;
        private System.Windows.Forms.BindingSource incomeBindingSource;
        private PBCSDataSet14TableAdapters.IncomeTableAdapter incomeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeDueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomePayDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeObsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusNameDataGridViewTextBoxColumn;
    }
}