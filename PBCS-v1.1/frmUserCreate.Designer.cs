namespace PBCS_v1._1
{
    partial class frmUserCreate
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPasswordUserCreation = new System.Windows.Forms.TextBox();
            this.btnBackUserCreation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExitUserCreation = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmailUserCreation = new System.Windows.Forms.TextBox();
            this.txtNameUserCreation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUserTypeCreation = new System.Windows.Forms.ComboBox();
            this.typeUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pBCSDataSet1 = new PBCS_v1._1.PBCSDataSet1();
            this.userTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pBCSDataSet5 = new PBCS_v1._1.PBCSDataSet5();
            this.typeUserBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pBCSDataSet = new PBCS_v1._1.PBCSDataSet();
            this.pBCSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeUserTableAdapter = new PBCS_v1._1.PBCSDataSet1TableAdapters.TypeUserTableAdapter();
            this.typeUserBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.userTypeTableAdapter = new PBCS_v1._1.PBCSDataSet5TableAdapters.UserTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.typeUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUserBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUserBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Isert User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // txtPasswordUserCreation
            // 
            this.txtPasswordUserCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordUserCreation.Location = new System.Drawing.Point(225, 187);
            this.txtPasswordUserCreation.Name = "txtPasswordUserCreation";
            this.txtPasswordUserCreation.Size = new System.Drawing.Size(367, 30);
            this.txtPasswordUserCreation.TabIndex = 3;
            // 
            // btnBackUserCreation
            // 
            this.btnBackUserCreation.Location = new System.Drawing.Point(418, 285);
            this.btnBackUserCreation.Name = "btnBackUserCreation";
            this.btnBackUserCreation.Size = new System.Drawing.Size(75, 23);
            this.btnBackUserCreation.TabIndex = 7;
            this.btnBackUserCreation.Text = "Back";
            this.btnBackUserCreation.UseVisualStyleBackColor = true;
            this.btnBackUserCreation.Click += new System.EventHandler(this.BtnBackUserCreation_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Password:";
            // 
            // btnExitUserCreation
            // 
            this.btnExitUserCreation.Location = new System.Drawing.Point(513, 285);
            this.btnExitUserCreation.Name = "btnExitUserCreation";
            this.btnExitUserCreation.Size = new System.Drawing.Size(75, 23);
            this.btnExitUserCreation.TabIndex = 8;
            this.btnExitUserCreation.Text = "Exit";
            this.btnExitUserCreation.UseVisualStyleBackColor = true;
            this.btnExitUserCreation.Click += new System.EventHandler(this.BtnExitUserCreation_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(287, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 31);
            this.label5.TabIndex = 30;
            this.label5.Text = "User creation";
            // 
            // txtEmailUserCreation
            // 
            this.txtEmailUserCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailUserCreation.Location = new System.Drawing.Point(225, 145);
            this.txtEmailUserCreation.Name = "txtEmailUserCreation";
            this.txtEmailUserCreation.Size = new System.Drawing.Size(367, 30);
            this.txtEmailUserCreation.TabIndex = 2;
            // 
            // txtNameUserCreation
            // 
            this.txtNameUserCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameUserCreation.Location = new System.Drawing.Point(225, 103);
            this.txtNameUserCreation.Name = "txtNameUserCreation";
            this.txtNameUserCreation.Size = new System.Drawing.Size(367, 30);
            this.txtNameUserCreation.TabIndex = 1;
            this.txtNameUserCreation.TextChanged += new System.EventHandler(this.TxtNameUserCreation_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "e-Mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name:";
            // 
            // cmbUserTypeCreation
            // 
            this.cmbUserTypeCreation.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.typeUserBindingSource, "TypeUserId", true));
            this.cmbUserTypeCreation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserTypeCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUserTypeCreation.FormattingEnabled = true;
            this.cmbUserTypeCreation.Location = new System.Drawing.Point(225, 232);
            this.cmbUserTypeCreation.Name = "cmbUserTypeCreation";
            this.cmbUserTypeCreation.Size = new System.Drawing.Size(121, 33);
            this.cmbUserTypeCreation.TabIndex = 4;
            this.cmbUserTypeCreation.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            this.cmbUserTypeCreation.Click += new System.EventHandler(this.CmbUserTypeCreation_Click);
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
            // userTypeBindingSource
            // 
            this.userTypeBindingSource.DataMember = "UserType";
            this.userTypeBindingSource.DataSource = this.pBCSDataSet5;
            // 
            // pBCSDataSet5
            // 
            this.pBCSDataSet5.DataSetName = "PBCSDataSet5";
            this.pBCSDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeUserBindingSource1
            // 
            this.typeUserBindingSource1.DataMember = "TypeUser";
            this.typeUserBindingSource1.DataSource = this.pBCSDataSet1;
            // 
            // pBCSDataSet
            // 
            this.pBCSDataSet.DataSetName = "PBCSDataSet";
            this.pBCSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pBCSDataSetBindingSource
            // 
            this.pBCSDataSetBindingSource.DataSource = this.pBCSDataSet;
            this.pBCSDataSetBindingSource.Position = 0;
            // 
            // typeUserTableAdapter
            // 
            this.typeUserTableAdapter.ClearBeforeFill = true;
            // 
            // typeUserBindingSource2
            // 
            this.typeUserBindingSource2.DataMember = "TypeUser";
            this.typeUserBindingSource2.DataSource = this.pBCSDataSet1;
            // 
            // userTypeTableAdapter
            // 
            this.userTypeTableAdapter.ClearBeforeFill = true;
            // 
            // frmUserCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 345);
            this.Controls.Add(this.cmbUserTypeCreation);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPasswordUserCreation);
            this.Controls.Add(this.btnBackUserCreation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExitUserCreation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmailUserCreation);
            this.Controls.Add(this.txtNameUserCreation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmUserCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PBCS - User Creation";
            this.Load += new System.EventHandler(this.FrmCreateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.typeUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUserBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUserBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPasswordUserCreation;
        private System.Windows.Forms.Button btnBackUserCreation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExitUserCreation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmailUserCreation;
        private System.Windows.Forms.TextBox txtNameUserCreation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUserTypeCreation;
        private System.Windows.Forms.BindingSource pBCSDataSetBindingSource;
        private PBCSDataSet pBCSDataSet;
        private PBCSDataSet1 pBCSDataSet1;
        private System.Windows.Forms.BindingSource typeUserBindingSource;
        private PBCSDataSet1TableAdapters.TypeUserTableAdapter typeUserTableAdapter;
        private System.Windows.Forms.BindingSource typeUserBindingSource1;
        private System.Windows.Forms.BindingSource typeUserBindingSource2;
        private PBCSDataSet5 pBCSDataSet5;
        private System.Windows.Forms.BindingSource userTypeBindingSource;
        private PBCSDataSet5TableAdapters.UserTypeTableAdapter userTypeTableAdapter;
    }
}