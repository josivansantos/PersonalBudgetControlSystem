namespace PBCS_v1._1
{
    partial class frmExpensiveIncomeStatusEditor
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
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pBCSDataSet2 = new PBCS_v1._1.PBCSDataSet2();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.accountTableAdapter = new PBCS_v1._1.PBCSDataSet2TableAdapters.AccountTableAdapter();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pBCSDataSet6 = new PBCS_v1._1.PBCSDataSet6();
            this.accountStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountStatusTableAdapter = new PBCS_v1._1.PBCSDataSet6TableAdapters.AccountStatusTableAdapter();
            this.accountStatusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AccountStatusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountStatusNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountStatusBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.pBCSDataSet7 = new PBCS_v1._1.PBCSDataSet7();
            this.accountStatusBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.accountStatusTableAdapter1 = new PBCS_v1._1.PBCSDataSet7TableAdapters.AccountStatusTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.accountStatusBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.txtAccountStatusId = new System.Windows.Forms.TextBox();
            this.txtAccountStatusName = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.accountStatusBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.pBCSDataSet10 = new PBCS_v1._1.PBCSDataSet10();
            this.accountStatusTableAdapter2 = new PBCS_v1._1.PBCSDataSet10TableAdapters.AccountStatusTableAdapter();
            this.accountStatusBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountStatusBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountStatusBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountStatusBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountStatusBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountStatusBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountStatusBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.pBCSDataSet2;
            // 
            // pBCSDataSet2
            // 
            this.pBCSDataSet2.DataSetName = "PBCSDataSet2";
            this.pBCSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(108, 150);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(236, 23);
            this.btnInsert.TabIndex = 60;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(188, 216);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 59;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.Button3_Click);
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(107, 246);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 53;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(188, 246);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 54;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBackUserCreation_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(269, 246);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 55;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(193, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(410, 31);
            this.label5.TabIndex = 58;
            this.label5.Text = "Expensive / Income Status editor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 57;
            this.label2.Text = "Name:";
            // 
            // pBCSDataSet6
            // 
            this.pBCSDataSet6.DataSetName = "PBCSDataSet6";
            this.pBCSDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountStatusBindingSource
            // 
            this.accountStatusBindingSource.DataMember = "AccountStatus";
            this.accountStatusBindingSource.DataSource = this.pBCSDataSet6;
            // 
            // accountStatusTableAdapter
            // 
            this.accountStatusTableAdapter.ClearBeforeFill = true;
            // 
            // accountStatusBindingSource1
            // 
            this.accountStatusBindingSource1.DataMember = "AccountStatus";
            this.accountStatusBindingSource1.DataSource = this.pBCSDataSet6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountStatusId,
            this.accountStatusNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.accountStatusBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(404, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(384, 358);
            this.dataGridView1.TabIndex = 61;
            // 
            // AccountStatusId
            // 
            this.AccountStatusId.DataPropertyName = "AccountStatusId";
            this.AccountStatusId.HeaderText = "AccountStatusId";
            this.AccountStatusId.Name = "AccountStatusId";
            this.AccountStatusId.ReadOnly = true;
            // 
            // accountStatusNameDataGridViewTextBoxColumn
            // 
            this.accountStatusNameDataGridViewTextBoxColumn.DataPropertyName = "AccountStatusName";
            this.accountStatusNameDataGridViewTextBoxColumn.HeaderText = "AccountStatusName";
            this.accountStatusNameDataGridViewTextBoxColumn.Name = "accountStatusNameDataGridViewTextBoxColumn";
            // 
            // accountStatusBindingSource3
            // 
            this.accountStatusBindingSource3.DataMember = "AccountStatus";
            this.accountStatusBindingSource3.DataSource = this.pBCSDataSet7;
            // 
            // pBCSDataSet7
            // 
            this.pBCSDataSet7.DataSetName = "PBCSDataSet7";
            this.pBCSDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountStatusBindingSource2
            // 
            this.accountStatusBindingSource2.DataMember = "AccountStatus";
            this.accountStatusBindingSource2.DataSource = this.pBCSDataSet6;
            // 
            // accountStatusTableAdapter1
            // 
            this.accountStatusTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 25);
            this.label1.TabIndex = 63;
            this.label1.Text = "Id:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // accountStatusBindingSource4
            // 
            this.accountStatusBindingSource4.DataMember = "AccountStatus";
            this.accountStatusBindingSource4.DataSource = this.pBCSDataSet7;
            // 
            // txtAccountStatusId
            // 
            this.txtAccountStatusId.Enabled = false;
            this.txtAccountStatusId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountStatusId.Location = new System.Drawing.Point(108, 64);
            this.txtAccountStatusId.Name = "txtAccountStatusId";
            this.txtAccountStatusId.Size = new System.Drawing.Size(236, 30);
            this.txtAccountStatusId.TabIndex = 66;
            this.txtAccountStatusId.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtAccountStatusName
            // 
            this.txtAccountStatusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountStatusName.Location = new System.Drawing.Point(108, 103);
            this.txtAccountStatusName.Name = "txtAccountStatusName";
            this.txtAccountStatusName.Size = new System.Drawing.Size(236, 30);
            this.txtAccountStatusName.TabIndex = 67;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(107, 216);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 68;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(269, 216);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 69;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // accountStatusBindingSource5
            // 
            this.accountStatusBindingSource5.DataMember = "AccountStatus";
            this.accountStatusBindingSource5.DataSource = this.pBCSDataSet10;
            // 
            // pBCSDataSet10
            // 
            this.pBCSDataSet10.DataSetName = "PBCSDataSet10";
            this.pBCSDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountStatusTableAdapter2
            // 
            this.accountStatusTableAdapter2.ClearBeforeFill = true;
            // 
            // accountStatusBindingSource6
            // 
            this.accountStatusBindingSource6.DataMember = "AccountStatus";
            this.accountStatusBindingSource6.DataSource = this.pBCSDataSet10;
            // 
            // frmExpensiveIncomeStatusEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 434);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtAccountStatusName);
            this.Controls.Add(this.txtAccountStatusId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "frmExpensiveIncomeStatusEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expensive / Income Status editor";
            this.Load += new System.EventHandler(this.FmrCreateAccountStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountStatusBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountStatusBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountStatusBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountStatusBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountStatusBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountStatusBindingSource6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource accountBindingSource;
        private PBCSDataSet2 pBCSDataSet2;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private PBCSDataSet2TableAdapters.AccountTableAdapter accountTableAdapter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private PBCSDataSet6 pBCSDataSet6;
        private System.Windows.Forms.BindingSource accountStatusBindingSource;
        private PBCSDataSet6TableAdapters.AccountStatusTableAdapter accountStatusTableAdapter;
        private System.Windows.Forms.BindingSource accountStatusBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource accountStatusBindingSource2;
        private PBCSDataSet7 pBCSDataSet7;
        private System.Windows.Forms.BindingSource accountStatusBindingSource3;
        private PBCSDataSet7TableAdapters.AccountStatusTableAdapter accountStatusTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource accountStatusBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountStatusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountStatusNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtAccountStatusId;
        private System.Windows.Forms.TextBox txtAccountStatusName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private PBCSDataSet10 pBCSDataSet10;
        private System.Windows.Forms.BindingSource accountStatusBindingSource5;
        private PBCSDataSet10TableAdapters.AccountStatusTableAdapter accountStatusTableAdapter2;
        private System.Windows.Forms.BindingSource accountStatusBindingSource6;
    }
}