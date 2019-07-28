namespace PBCS_v1._1
{
    partial class cmbUserID
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
            this.pBCSDataSet = new PBCS_v1._1.PBCSDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new PBCS_v1._1.PBCSDataSetTableAdapters.UsersTableAdapter();
            this.btnExitSetup = new System.Windows.Forms.Button();
            this.btnBackSetup = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbUserId1 = new System.Windows.Forms.ComboBox();
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.typeUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pBCSDataSet1 = new PBCS_v1._1.PBCSDataSet1();
            this.typeUserTableAdapter = new PBCS_v1._1.PBCSDataSet1TableAdapters.TypeUserTableAdapter();
            this.cmbUserNam = new System.Windows.Forms.ComboBox();
            this.cmbUserPassword = new System.Windows.Forms.ComboBox();
            this.cmbUserEmail = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.users = new PBCS_v1._1.Users();
            this.usersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter1 = new PBCS_v1._1.UsersTableAdapters.UsersTableAdapter();
            this.usersBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.pBCSDataSet9 = new PBCS_v1._1.PBCSDataSet9();
            this.userTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTypeTableAdapter = new PBCS_v1._1.PBCSDataSet9TableAdapters.UserTypeTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeUserIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource8)).BeginInit();
            this.SuspendLayout();
            // 
            // pBCSDataSet
            // 
            this.pBCSDataSet.DataSetName = "PBCSDataSet";
            this.pBCSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.pBCSDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // btnExitSetup
            // 
            this.btnExitSetup.Location = new System.Drawing.Point(682, 298);
            this.btnExitSetup.Name = "btnExitSetup";
            this.btnExitSetup.Size = new System.Drawing.Size(110, 33);
            this.btnExitSetup.TabIndex = 7;
            this.btnExitSetup.Text = "Exit";
            this.btnExitSetup.UseVisualStyleBackColor = true;
            this.btnExitSetup.Click += new System.EventHandler(this.BtnExitSetup_Click);
            // 
            // btnBackSetup
            // 
            this.btnBackSetup.Location = new System.Drawing.Point(551, 298);
            this.btnBackSetup.Name = "btnBackSetup";
            this.btnBackSetup.Size = new System.Drawing.Size(110, 33);
            this.btnBackSetup.TabIndex = 6;
            this.btnBackSetup.Text = "Back";
            this.btnBackSetup.UseVisualStyleBackColor = true;
            this.btnBackSetup.Click += new System.EventHandler(this.BtnBackSertup_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(144, 298);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(110, 33);
            this.btnEditUser.TabIndex = 8;
            this.btnEditUser.Text = "Edit";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.BtnUpdateUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Enabled = false;
            this.btnDeleteUser.Location = new System.Drawing.Point(415, 298);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(110, 33);
            this.btnDeleteUser.TabIndex = 9;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.BtnDeleteUser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(291, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 31);
            this.label5.TabIndex = 31;
            this.label5.Text = "User Edit";
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.pBCSDataSet;
            // 
            // cmbUserId1
            // 
            this.cmbUserId1.DataSource = this.usersBindingSource;
            this.cmbUserId1.DisplayMember = "UserId";
            this.cmbUserId1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserId1.FormattingEnabled = true;
            this.cmbUserId1.Location = new System.Drawing.Point(7, 230);
            this.cmbUserId1.Name = "cmbUserId1";
            this.cmbUserId1.Size = new System.Drawing.Size(64, 33);
            this.cmbUserId1.TabIndex = 33;
            this.cmbUserId1.ValueMember = "UserName";
            this.cmbUserId1.SelectedIndexChanged += new System.EventHandler(this.CmbUserId1_SelectedIndexChanged);
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataMember = "Users";
            this.usersBindingSource2.DataSource = this.pBCSDataSet;
            // 
            // cmbUserType
            // 
            this.cmbUserType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.typeUserBindingSource, "TypeUserName", true));
            this.cmbUserType.DataSource = this.usersBindingSource;
            this.cmbUserType.DisplayMember = "TypeUserId";
            this.cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserType.Enabled = false;
            this.cmbUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Location = new System.Drawing.Point(708, 230);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(84, 33);
            this.cmbUserType.TabIndex = 38;
            this.cmbUserType.ValueMember = "TypeUserId";
            this.cmbUserType.Click += new System.EventHandler(this.CmbUserType_Click);
            // 
            // typeUserBindingSource
            // 
            this.typeUserBindingSource.DataMember = "TypeUser";
            this.typeUserBindingSource.DataSource = this.pBCSDataSet1;
            // 
            // pBCSDataSet1
            // 
            this.pBCSDataSet1.DataSetName = "PBCSDataSet1";
            this.pBCSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeUserTableAdapter
            // 
            this.typeUserTableAdapter.ClearBeforeFill = true;
            // 
            // cmbUserNam
            // 
            this.cmbUserNam.DataSource = this.usersBindingSource;
            this.cmbUserNam.DisplayMember = "UserEmail";
            this.cmbUserNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbUserNam.Enabled = false;
            this.cmbUserNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserNam.FormattingEnabled = true;
            this.cmbUserNam.Location = new System.Drawing.Point(77, 230);
            this.cmbUserNam.Name = "cmbUserNam";
            this.cmbUserNam.Size = new System.Drawing.Size(267, 33);
            this.cmbUserNam.TabIndex = 39;
            this.cmbUserNam.ValueMember = "UserName";
            // 
            // cmbUserPassword
            // 
            this.cmbUserPassword.DataSource = this.usersBindingSource;
            this.cmbUserPassword.DisplayMember = "UserPassword";
            this.cmbUserPassword.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbUserPassword.Enabled = false;
            this.cmbUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserPassword.FormattingEnabled = true;
            this.cmbUserPassword.Location = new System.Drawing.Point(350, 230);
            this.cmbUserPassword.Name = "cmbUserPassword";
            this.cmbUserPassword.Size = new System.Drawing.Size(154, 33);
            this.cmbUserPassword.TabIndex = 40;
            this.cmbUserPassword.ValueMember = "UserPassword";
            // 
            // cmbUserEmail
            // 
            this.cmbUserEmail.DataSource = this.usersBindingSource;
            this.cmbUserEmail.DisplayMember = "UserEmail";
            this.cmbUserEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbUserEmail.Enabled = false;
            this.cmbUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserEmail.FormattingEnabled = true;
            this.cmbUserEmail.Location = new System.Drawing.Point(510, 230);
            this.cmbUserEmail.Name = "cmbUserEmail";
            this.cmbUserEmail.Size = new System.Drawing.Size(192, 33);
            this.cmbUserEmail.TabIndex = 41;
            this.cmbUserEmail.ValueMember = "UserEmail";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(277, 298);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 33);
            this.btnSave.TabIndex = 42;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Button1_Click);
            // 
            // users
            // 
            this.users.DataSetName = "Users";
            this.users.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource3
            // 
            this.usersBindingSource3.DataMember = "Users";
            this.usersBindingSource3.DataSource = this.users;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // usersBindingSource4
            // 
            this.usersBindingSource4.DataSource = this.users;
            this.usersBindingSource4.Position = 0;
            // 
            // usersBindingSource5
            // 
            this.usersBindingSource5.DataSource = this.users;
            this.usersBindingSource5.Position = 0;
            // 
            // pBCSDataSet9
            // 
            this.pBCSDataSet9.DataSetName = "PBCSDataSet9";
            this.pBCSDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTypeBindingSource
            // 
            this.userTypeBindingSource.DataMember = "UserType";
            this.userTypeBindingSource.DataSource = this.pBCSDataSet9;
            // 
            // userTypeTableAdapter
            // 
            this.userTypeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.userPasswordDataGridViewTextBoxColumn,
            this.userEmailDataGridViewTextBoxColumn,
            this.typeUserIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource7;
            this.dataGridView1.Location = new System.Drawing.Point(7, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 150);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "User Id";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // userPasswordDataGridViewTextBoxColumn
            // 
            this.userPasswordDataGridViewTextBoxColumn.DataPropertyName = "UserPassword";
            this.userPasswordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.userPasswordDataGridViewTextBoxColumn.Name = "userPasswordDataGridViewTextBoxColumn";
            // 
            // userEmailDataGridViewTextBoxColumn
            // 
            this.userEmailDataGridViewTextBoxColumn.DataPropertyName = "UserEmail";
            this.userEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.userEmailDataGridViewTextBoxColumn.Name = "userEmailDataGridViewTextBoxColumn";
            // 
            // typeUserIdDataGridViewTextBoxColumn
            // 
            this.typeUserIdDataGridViewTextBoxColumn.DataPropertyName = "TypeUserId";
            this.typeUserIdDataGridViewTextBoxColumn.HeaderText = "Type User";
            this.typeUserIdDataGridViewTextBoxColumn.Name = "typeUserIdDataGridViewTextBoxColumn";
            // 
            // usersBindingSource7
            // 
            this.usersBindingSource7.DataMember = "Users";
            this.usersBindingSource7.DataSource = this.usersBindingSource6;
            // 
            // usersBindingSource6
            // 
            this.usersBindingSource6.DataSource = this.users;
            this.usersBindingSource6.Position = 0;
            // 
            // usersBindingSource8
            // 
            this.usersBindingSource8.DataMember = "Users";
            this.usersBindingSource8.DataSource = this.usersBindingSource6;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(7, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // cmbUserID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 343);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbUserEmail);
            this.Controls.Add(this.cmbUserPassword);
            this.Controls.Add(this.cmbUserNam);
            this.Controls.Add(this.cmbUserType);
            this.Controls.Add(this.cmbUserId1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnExitSetup);
            this.Controls.Add(this.btnBackSetup);
            this.MaximizeBox = false;
            this.Name = "cmbUserID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PBCS - Edit User";
            this.Load += new System.EventHandler(this.FrmEditUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PBCSDataSet pBCSDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private PBCSDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button btnExitSetup;
        private System.Windows.Forms.Button btnBackSetup;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.ComboBox cmbUserId1;
        private System.Windows.Forms.BindingSource usersBindingSource2;
        private System.Windows.Forms.ComboBox cmbUserType;
        private PBCSDataSet1 pBCSDataSet1;
        private System.Windows.Forms.BindingSource typeUserBindingSource;
        private PBCSDataSet1TableAdapters.TypeUserTableAdapter typeUserTableAdapter;
        private System.Windows.Forms.ComboBox cmbUserNam;
        private System.Windows.Forms.ComboBox cmbUserPassword;
        private System.Windows.Forms.ComboBox cmbUserEmail;
        private System.Windows.Forms.Button btnSave;
        private Users users;
        private System.Windows.Forms.BindingSource usersBindingSource3;
        private UsersTableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.BindingSource usersBindingSource4;
        private System.Windows.Forms.BindingSource usersBindingSource5;
        private PBCSDataSet9 pBCSDataSet9;
        private System.Windows.Forms.BindingSource userTypeBindingSource;
        private PBCSDataSet9TableAdapters.UserTypeTableAdapter userTypeTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource usersBindingSource7;
        private System.Windows.Forms.BindingSource usersBindingSource6;
        private System.Windows.Forms.BindingSource usersBindingSource8;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeUserIdDataGridViewTextBoxColumn;
    }
}