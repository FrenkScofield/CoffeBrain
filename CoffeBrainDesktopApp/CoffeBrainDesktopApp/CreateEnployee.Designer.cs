namespace CoffeBrainDesktopApp
{
    partial class CreateEnployee
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
            System.Windows.Forms.Label Username;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEnployee));
            this.txbx_Firstname = new System.Windows.Forms.TextBox();
            this.enployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBCaffeBrainDataSet4 = new CoffeBrainDesktopApp.DBCaffeBrainDataSet4();
            this.btn_Add = new System.Windows.Forms.Button();
            this.cmbx_Genders = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_Username = new System.Windows.Forms.TextBox();
            this.txbx_Lasname = new System.Windows.Forms.TextBox();
            this.txbx_Email = new System.Windows.Forms.TextBox();
            this.txbx_Password = new System.Windows.Forms.TextBox();
            this.cmbx_Mission = new System.Windows.Forms.ComboBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.dataGridView_AddEmploye = new System.Windows.Forms.DataGridView();
            this.enployeeTableAdapter = new CoffeBrainDesktopApp.DBCaffeBrainDataSet4TableAdapters.EnployeeTableAdapter();
            this.txbx_Phone = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Username = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCaffeBrainDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AddEmploye)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = System.Drawing.Color.Transparent;
            Username.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Username.ForeColor = System.Drawing.Color.LightGreen;
            Username.Location = new System.Drawing.Point(74, 104);
            Username.Name = "Username";
            Username.Size = new System.Drawing.Size(99, 20);
            Username.TabIndex = 5;
            Username.Text = "FirstName";
            Username.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            Username.UseMnemonic = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.LightGreen;
            label1.Location = new System.Drawing.Point(646, 104);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(99, 20);
            label1.TabIndex = 7;
            label1.Text = "UserName";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label1.UseMnemonic = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.LightGreen;
            label3.Location = new System.Drawing.Point(369, 104);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(95, 20);
            label3.TabIndex = 9;
            label3.Text = "LastName";
            label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label3.UseMnemonic = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.LightGreen;
            label4.Location = new System.Drawing.Point(941, 104);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(57, 20);
            label4.TabIndex = 11;
            label4.Text = "Email";
            label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label4.UseMnemonic = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.Color.LightGreen;
            label5.Location = new System.Drawing.Point(646, 204);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(63, 20);
            label5.TabIndex = 13;
            label5.Text = "Phone";
            label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label5.UseMnemonic = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.Color.LightGreen;
            label6.Location = new System.Drawing.Point(941, 204);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(91, 20);
            label6.TabIndex = 15;
            label6.Text = "Password";
            label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label6.UseMnemonic = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.Color.LightGreen;
            label7.Location = new System.Drawing.Point(74, 205);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(74, 20);
            label7.TabIndex = 16;
            label7.Text = "Gender";
            label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label7.UseMnemonic = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ForeColor = System.Drawing.Color.LightGreen;
            label8.Location = new System.Drawing.Point(369, 205);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(76, 20);
            label8.TabIndex = 18;
            label8.Text = "Mission";
            label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label8.UseMnemonic = false;
            // 
            // txbx_Firstname
            // 
            this.txbx_Firstname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.enployeeBindingSource, "FirstName", true));
            this.txbx_Firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_Firstname.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbx_Firstname.Location = new System.Drawing.Point(78, 136);
            this.txbx_Firstname.Multiline = true;
            this.txbx_Firstname.Name = "txbx_Firstname";
            this.txbx_Firstname.Size = new System.Drawing.Size(224, 38);
            this.txbx_Firstname.TabIndex = 1;
            this.txbx_Firstname.TextChanged += new System.EventHandler(this.txbx_Firstname_TextChanged);
            // 
            // enployeeBindingSource
            // 
            this.enployeeBindingSource.DataMember = "Enployee";
            this.enployeeBindingSource.DataSource = this.dBCaffeBrainDataSet4;
            // 
            // dBCaffeBrainDataSet4
            // 
            this.dBCaffeBrainDataSet4.DataSetName = "DBCaffeBrainDataSet4";
            this.dBCaffeBrainDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Green;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Chocolate;
            this.btn_Add.Location = new System.Drawing.Point(1026, 541);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(143, 51);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // cmbx_Genders
            // 
            this.cmbx_Genders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Genders.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_Genders.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cmbx_Genders.FormattingEnabled = true;
            this.cmbx_Genders.Location = new System.Drawing.Point(78, 237);
            this.cmbx_Genders.Name = "cmbx_Genders";
            this.cmbx_Genders.Size = new System.Drawing.Size(224, 37);
            this.cmbx_Genders.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(112, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 85);
            this.label2.TabIndex = 4;
            this.label2.Text = "Create Enployee";
            // 
            // txbx_Username
            // 
            this.txbx_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_Username.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbx_Username.Location = new System.Drawing.Point(650, 136);
            this.txbx_Username.Multiline = true;
            this.txbx_Username.Name = "txbx_Username";
            this.txbx_Username.Size = new System.Drawing.Size(224, 38);
            this.txbx_Username.TabIndex = 6;
            // 
            // txbx_Lasname
            // 
            this.txbx_Lasname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_Lasname.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbx_Lasname.Location = new System.Drawing.Point(373, 136);
            this.txbx_Lasname.Multiline = true;
            this.txbx_Lasname.Name = "txbx_Lasname";
            this.txbx_Lasname.Size = new System.Drawing.Size(224, 38);
            this.txbx_Lasname.TabIndex = 8;
            this.txbx_Lasname.TextChanged += new System.EventHandler(this.txbx_Lasname_TextChanged);
            // 
            // txbx_Email
            // 
            this.txbx_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_Email.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbx_Email.Location = new System.Drawing.Point(945, 136);
            this.txbx_Email.Multiline = true;
            this.txbx_Email.Name = "txbx_Email";
            this.txbx_Email.Size = new System.Drawing.Size(224, 38);
            this.txbx_Email.TabIndex = 10;
            // 
            // txbx_Password
            // 
            this.txbx_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_Password.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbx_Password.Location = new System.Drawing.Point(945, 236);
            this.txbx_Password.Multiline = true;
            this.txbx_Password.Name = "txbx_Password";
            this.txbx_Password.PasswordChar = '*';
            this.txbx_Password.Size = new System.Drawing.Size(224, 38);
            this.txbx_Password.TabIndex = 14;
            // 
            // cmbx_Mission
            // 
            this.cmbx_Mission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Mission.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_Mission.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cmbx_Mission.FormattingEnabled = true;
            this.cmbx_Mission.Location = new System.Drawing.Point(373, 237);
            this.cmbx_Mission.Name = "cmbx_Mission";
            this.cmbx_Mission.Size = new System.Drawing.Size(224, 37);
            this.cmbx_Mission.TabIndex = 17;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_Exit.Location = new System.Drawing.Point(1026, 619);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(143, 53);
            this.btn_Exit.TabIndex = 19;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // dataGridView_AddEmploye
            // 
            this.dataGridView_AddEmploye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AddEmploye.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.FirstName,
            this.LastName,
            this.Nickname,
            this.Email,
            this.Gender,
            this.Mission,
            this.Phone,
            this.Password});
            this.dataGridView_AddEmploye.Location = new System.Drawing.Point(78, 332);
            this.dataGridView_AddEmploye.Name = "dataGridView_AddEmploye";
            this.dataGridView_AddEmploye.Size = new System.Drawing.Size(942, 340);
            this.dataGridView_AddEmploye.TabIndex = 21;
         //   this.dataGridView_AddEmploye.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AddEmployee_CellContentClick);
            // 
            // enployeeTableAdapter
            // 
            this.enployeeTableAdapter.ClearBeforeFill = true;
            // 
            // txbx_Phone
            // 
            this.txbx_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_Phone.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbx_Phone.Location = new System.Drawing.Point(650, 236);
            this.txbx_Phone.Multiline = true;
            this.txbx_Phone.Name = "txbx_Phone";
            this.txbx_Phone.Size = new System.Drawing.Size(224, 38);
            this.txbx_Phone.TabIndex = 22;
            this.txbx_Phone.TextChanged += new System.EventHandler(this.txbx_Phone_TextChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            // 
            // Nickname
            // 
            this.Nickname.DataPropertyName = "Username";
            this.Nickname.HeaderText = "Nickname";
            this.Nickname.Name = "Nickname";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // Mission
            // 
            this.Mission.DataPropertyName = "Mission";
            this.Mission.HeaderText = "Mission";
            this.Mission.Name = "Mission";
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // CreateEnployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1348, 799);
            this.Controls.Add(this.txbx_Phone);
            this.Controls.Add(this.dataGridView_AddEmploye);
            this.Controls.Add(this.btn_Exit);
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
            this.Controls.Add(label1);
            this.Controls.Add(this.txbx_Username);
            this.Controls.Add(Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbx_Genders);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txbx_Firstname);
            this.Name = "CreateEnployee";
            this.Text = "CreateEnployee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CreateEnployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCaffeBrainDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AddEmploye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbx_Firstname;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ComboBox cmbx_Genders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_Username;
        private System.Windows.Forms.TextBox txbx_Lasname;
        private System.Windows.Forms.TextBox txbx_Email;
        private System.Windows.Forms.ComboBox cmbx_Mission;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txbx_Password;
        private System.Windows.Forms.DataGridView dataGridView_AddEmploye;
        private DBCaffeBrainDataSet4 dBCaffeBrainDataSet4;
        private System.Windows.Forms.BindingSource enployeeBindingSource;
        private DBCaffeBrainDataSet4TableAdapters.EnployeeTableAdapter enployeeTableAdapter;
        private System.Windows.Forms.TextBox txbx_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mission;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
    }
}