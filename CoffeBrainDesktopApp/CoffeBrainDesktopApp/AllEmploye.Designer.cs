namespace CoffeBrainDesktopApp
{
    partial class AllEmploye
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
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label Username;
            System.Windows.Forms.Label label9;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllEmploye));
            this.dataGridView_AllEmploye = new System.Windows.Forms.DataGridView();
            this.enployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBCaffeBrainDataSet5 = new CoffeBrainDesktopApp.DBCaffeBrainDataSet5();
            this.enployeeTableAdapter = new CoffeBrainDesktopApp.DBCaffeBrainDataSet5TableAdapters.EnployeeTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ExitAllEmploye = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.cmbx_Mission = new System.Windows.Forms.ComboBox();
            this.txbx_Password = new System.Windows.Forms.TextBox();
            this.txbx_Email = new System.Windows.Forms.TextBox();
            this.txbx_Lasname = new System.Windows.Forms.TextBox();
            this.txbx_Username = new System.Windows.Forms.TextBox();
            this.cmbx_Genders = new System.Windows.Forms.ComboBox();
            this.txbx_Firstname = new System.Windows.Forms.TextBox();
            this.txbx_Phone = new System.Windows.Forms.TextBox();
            this.txbx_Id = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.missionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            Username = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllEmploye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCaffeBrainDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.Color.LightGreen;
            label8.Location = new System.Drawing.Point(60, 585);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(76, 20);
            label8.TabIndex = 67;
            label8.Text = "Mission";
            label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label8.UseMnemonic = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.Color.LightGreen;
            label7.Location = new System.Drawing.Point(60, 659);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(74, 20);
            label7.TabIndex = 65;
            label7.Text = "Gender";
            label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label7.UseMnemonic = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.Color.LightGreen;
            label6.Location = new System.Drawing.Point(60, 504);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(91, 20);
            label6.TabIndex = 64;
            label6.Text = "Password";
            label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label6.UseMnemonic = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.Color.LightGreen;
            label5.Location = new System.Drawing.Point(60, 347);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(63, 20);
            label5.TabIndex = 62;
            label5.Text = "Phone";
            label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label5.UseMnemonic = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.LightGreen;
            label4.Location = new System.Drawing.Point(60, 274);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(57, 20);
            label4.TabIndex = 61;
            label4.Text = "Email";
            label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label4.UseMnemonic = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.LightGreen;
            label3.Location = new System.Drawing.Point(60, 199);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(95, 20);
            label3.TabIndex = 59;
            label3.Text = "LastName";
            label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label3.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.LightGreen;
            label2.Location = new System.Drawing.Point(60, 420);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 20);
            label2.TabIndex = 57;
            label2.Text = "UserName";
            label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label2.UseMnemonic = false;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = System.Drawing.Color.Transparent;
            Username.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Username.ForeColor = System.Drawing.Color.LightGreen;
            Username.Location = new System.Drawing.Point(60, 124);
            Username.Name = "Username";
            Username.Size = new System.Drawing.Size(99, 20);
            Username.TabIndex = 55;
            Username.Text = "FirstName";
            Username.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            Username.UseMnemonic = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.ForeColor = System.Drawing.Color.LightGreen;
            label9.Location = new System.Drawing.Point(355, 639);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(28, 20);
            label9.TabIndex = 69;
            label9.Text = "ID";
            label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label9.UseMnemonic = false;
            // 
            // dataGridView_AllEmploye
            // 
            this.dataGridView_AllEmploye.AutoGenerateColumns = false;
            this.dataGridView_AllEmploye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AllEmploye.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.missionIDDataGridViewTextBoxColumn,
            this.genderIDDataGridViewTextBoxColumn});
            this.dataGridView_AllEmploye.DataSource = this.enployeeBindingSource;
            this.dataGridView_AllEmploye.Location = new System.Drawing.Point(359, 156);
            this.dataGridView_AllEmploye.Name = "dataGridView_AllEmploye";
            this.dataGridView_AllEmploye.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_AllEmploye.Size = new System.Drawing.Size(945, 447);
            this.dataGridView_AllEmploye.TabIndex = 0;
            this.dataGridView_AllEmploye.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AllEmploye_CellClick);
            // 
            // enployeeBindingSource
            // 
            this.enployeeBindingSource.DataMember = "Enployee";
            this.enployeeBindingSource.DataSource = this.dBCaffeBrainDataSet5;
            // 
            // dBCaffeBrainDataSet5
            // 
            this.dBCaffeBrainDataSet5.DataSetName = "DBCaffeBrainDataSet5";
            this.dBCaffeBrainDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enployeeTableAdapter
            // 
            this.enployeeTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(496, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 112);
            this.label1.TabIndex = 7;
            this.label1.Text = "All Employee list";
            // 
            // btn_ExitAllEmploye
            // 
            this.btn_ExitAllEmploye.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_ExitAllEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExitAllEmploye.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_ExitAllEmploye.Location = new System.Drawing.Point(1139, 661);
            this.btn_ExitAllEmploye.Name = "btn_ExitAllEmploye";
            this.btn_ExitAllEmploye.Size = new System.Drawing.Size(165, 49);
            this.btn_ExitAllEmploye.TabIndex = 49;
            this.btn_ExitAllEmploye.Text = "Exit";
            this.btn_ExitAllEmploye.UseVisualStyleBackColor = false;
            this.btn_ExitAllEmploye.Click += new System.EventHandler(this.btn_ExitAllEmploye_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(625, 661);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(165, 49);
            this.btn_Delete.TabIndex = 48;
            this.btn_Delete.Text = "Delete Select";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(868, 662);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(165, 49);
            this.btn_Update.TabIndex = 50;
            this.btn_Update.Text = "Update Select";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // cmbx_Mission
            // 
            this.cmbx_Mission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Mission.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_Mission.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cmbx_Mission.FormattingEnabled = true;
            this.cmbx_Mission.Location = new System.Drawing.Point(64, 617);
            this.cmbx_Mission.Name = "cmbx_Mission";
            this.cmbx_Mission.Size = new System.Drawing.Size(224, 37);
            this.cmbx_Mission.TabIndex = 66;
            // 
            // txbx_Password
            // 
            this.txbx_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_Password.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbx_Password.Location = new System.Drawing.Point(64, 535);
            this.txbx_Password.Multiline = true;
            this.txbx_Password.Name = "txbx_Password";
            this.txbx_Password.PasswordChar = '*';
            this.txbx_Password.Size = new System.Drawing.Size(224, 38);
            this.txbx_Password.TabIndex = 63;
            // 
            // txbx_Email
            // 
            this.txbx_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_Email.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbx_Email.Location = new System.Drawing.Point(64, 306);
            this.txbx_Email.Multiline = true;
            this.txbx_Email.Name = "txbx_Email";
            this.txbx_Email.Size = new System.Drawing.Size(224, 38);
            this.txbx_Email.TabIndex = 60;
            // 
            // txbx_Lasname
            // 
            this.txbx_Lasname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_Lasname.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbx_Lasname.Location = new System.Drawing.Point(64, 231);
            this.txbx_Lasname.Multiline = true;
            this.txbx_Lasname.Name = "txbx_Lasname";
            this.txbx_Lasname.Size = new System.Drawing.Size(224, 38);
            this.txbx_Lasname.TabIndex = 58;
            this.txbx_Lasname.TextChanged += new System.EventHandler(this.txbx_Lasname_TextChanged);
            // 
            // txbx_Username
            // 
            this.txbx_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_Username.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbx_Username.Location = new System.Drawing.Point(64, 453);
            this.txbx_Username.Multiline = true;
            this.txbx_Username.Name = "txbx_Username";
            this.txbx_Username.Size = new System.Drawing.Size(224, 38);
            this.txbx_Username.TabIndex = 56;
            // 
            // cmbx_Genders
            // 
            this.cmbx_Genders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Genders.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_Genders.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cmbx_Genders.FormattingEnabled = true;
            this.cmbx_Genders.Location = new System.Drawing.Point(64, 691);
            this.cmbx_Genders.Name = "cmbx_Genders";
            this.cmbx_Genders.Size = new System.Drawing.Size(224, 37);
            this.cmbx_Genders.TabIndex = 54;
            // 
            // txbx_Firstname
            // 
            this.txbx_Firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_Firstname.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbx_Firstname.Location = new System.Drawing.Point(64, 156);
            this.txbx_Firstname.Multiline = true;
            this.txbx_Firstname.Name = "txbx_Firstname";
            this.txbx_Firstname.Size = new System.Drawing.Size(224, 38);
            this.txbx_Firstname.TabIndex = 53;
            this.txbx_Firstname.TextChanged += new System.EventHandler(this.txbx_Firstname_TextChanged);
            // 
            // txbx_Phone
            // 
            this.txbx_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_Phone.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbx_Phone.Location = new System.Drawing.Point(64, 370);
            this.txbx_Phone.Multiline = true;
            this.txbx_Phone.Name = "txbx_Phone";
            this.txbx_Phone.Size = new System.Drawing.Size(224, 38);
            this.txbx_Phone.TabIndex = 68;
            this.txbx_Phone.TextChanged += new System.EventHandler(this.txbx_Phone_TextChanged);
            // 
            // txbx_Id
            // 
            this.txbx_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_Id.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbx_Id.Location = new System.Drawing.Point(359, 662);
            this.txbx_Id.Multiline = true;
            this.txbx_Id.Name = "txbx_Id";
            this.txbx_Id.ReadOnly = true;
            this.txbx_Id.Size = new System.Drawing.Size(224, 38);
            this.txbx_Id.TabIndex = 70;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // missionIDDataGridViewTextBoxColumn
            // 
            this.missionIDDataGridViewTextBoxColumn.DataPropertyName = "Mission";
            this.missionIDDataGridViewTextBoxColumn.HeaderText = "MissionID";
            this.missionIDDataGridViewTextBoxColumn.Name = "missionIDDataGridViewTextBoxColumn";
            // 
            // genderIDDataGridViewTextBoxColumn
            // 
            this.genderIDDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderIDDataGridViewTextBoxColumn.HeaderText = "GenderID";
            this.genderIDDataGridViewTextBoxColumn.Name = "genderIDDataGridViewTextBoxColumn";
            // 
            // AllEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1380, 750);
            this.Controls.Add(this.txbx_Id);
            this.Controls.Add(label9);
            this.Controls.Add(this.txbx_Phone);
            this.Controls.Add(label8);
            this.Controls.Add(this.cmbx_Mission);
            this.Controls.Add(label7);
            this.Controls.Add(label6);
            this.Controls.Add(this.txbx_Password);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(this.txbx_Email);
            this.Controls.Add(label3);
            this.Controls.Add(this.txbx_Lasname);
            this.Controls.Add(label2);
            this.Controls.Add(this.txbx_Username);
            this.Controls.Add(Username);
            this.Controls.Add(this.cmbx_Genders);
            this.Controls.Add(this.txbx_Firstname);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_ExitAllEmploye);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_AllEmploye);
            this.Name = "AllEmploye";
            this.Text = "AllEmploye";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AllEmploye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllEmploye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCaffeBrainDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_AllEmploye;
        private DBCaffeBrainDataSet5 dBCaffeBrainDataSet5;
        private System.Windows.Forms.BindingSource enployeeBindingSource;
        private DBCaffeBrainDataSet5TableAdapters.EnployeeTableAdapter enployeeTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ExitAllEmploye;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ComboBox cmbx_Mission;
        private System.Windows.Forms.TextBox txbx_Password;
        private System.Windows.Forms.TextBox txbx_Email;
        private System.Windows.Forms.TextBox txbx_Lasname;
        private System.Windows.Forms.TextBox txbx_Username;
        private System.Windows.Forms.ComboBox cmbx_Genders;
        private System.Windows.Forms.TextBox txbx_Firstname;
        private System.Windows.Forms.TextBox txbx_Phone;
        private System.Windows.Forms.TextBox txbx_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn missionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderIDDataGridViewTextBoxColumn;
    }
}