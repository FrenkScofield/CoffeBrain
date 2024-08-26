namespace CoffeBrainDesktopApp
{
    partial class AllProductList
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label txbx_Pnavbcme;
            System.Windows.Forms.Label txbx_Pprice;
            System.Windows.Forms.Label Username;
            System.Windows.Forms.Label label9;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllProductList));
            this.cmbx_PNew = new System.Windows.Forms.ComboBox();
            this.txbx_PName = new System.Windows.Forms.TextBox();
            this.cmbx_PCatagory = new System.Windows.Forms.ComboBox();
            this.dBCaffeBrainDataSet7 = new CoffeBrainDesktopApp.DBCaffeBrainDataSet7();
            this.allProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allProductTableAdapter = new CoffeBrainDesktopApp.DBCaffeBrainDataSet7TableAdapters.AllProductTableAdapter();
            this.dataGridView_AllProductList = new System.Windows.Forms.DataGridView();
            this.allProductBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBCaffeBrainDataSet8 = new CoffeBrainDesktopApp.DBCaffeBrainDataSet8();
            this.allProductTableAdapter1 = new CoffeBrainDesktopApp.DBCaffeBrainDataSet8TableAdapters.AllProductTableAdapter();
            this.txbx_PId = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_ExitAllEmploye = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_Price = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label4 = new System.Windows.Forms.Label();
            txbx_Pnavbcme = new System.Windows.Forms.Label();
            txbx_Pprice = new System.Windows.Forms.Label();
            Username = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBCaffeBrainDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allProductBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCaffeBrainDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.LightGreen;
            label4.Location = new System.Drawing.Point(79, 336);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(47, 20);
            label4.TabIndex = 53;
            label4.Text = "New";
            label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label4.UseMnemonic = false;
            // 
            // txbx_Pnavbcme
            // 
            txbx_Pnavbcme.AutoSize = true;
            txbx_Pnavbcme.BackColor = System.Drawing.Color.Transparent;
            txbx_Pnavbcme.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txbx_Pnavbcme.ForeColor = System.Drawing.Color.LightGreen;
            txbx_Pnavbcme.Location = new System.Drawing.Point(79, 241);
            txbx_Pnavbcme.Name = "txbx_Pnavbcme";
            txbx_Pnavbcme.Size = new System.Drawing.Size(59, 20);
            txbx_Pnavbcme.TabIndex = 52;
            txbx_Pnavbcme.Text = "Name";
            txbx_Pnavbcme.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            txbx_Pnavbcme.UseMnemonic = false;
            // 
            // txbx_Pprice
            // 
            txbx_Pprice.AutoSize = true;
            txbx_Pprice.BackColor = System.Drawing.Color.Transparent;
            txbx_Pprice.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txbx_Pprice.ForeColor = System.Drawing.Color.LightGreen;
            txbx_Pprice.Location = new System.Drawing.Point(374, 241);
            txbx_Pprice.Name = "txbx_Pprice";
            txbx_Pprice.Size = new System.Drawing.Size(53, 20);
            txbx_Pprice.TabIndex = 50;
            txbx_Pprice.Text = "Price";
            txbx_Pprice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            txbx_Pprice.UseMnemonic = false;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = System.Drawing.Color.Transparent;
            Username.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Username.ForeColor = System.Drawing.Color.LightGreen;
            Username.Location = new System.Drawing.Point(374, 337);
            Username.Name = "Username";
            Username.Size = new System.Drawing.Size(113, 20);
            Username.TabIndex = 49;
            Username.Text = "Category ID";
            Username.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            Username.UseMnemonic = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.ForeColor = System.Drawing.Color.LightGreen;
            label9.Location = new System.Drawing.Point(79, 439);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(28, 20);
            label9.TabIndex = 74;
            label9.Text = "ID";
            label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label9.UseMnemonic = false;
            // 
            // cmbx_PNew
            // 
            this.cmbx_PNew.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_PNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_PNew.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cmbx_PNew.FormattingEnabled = true;
            this.cmbx_PNew.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmbx_PNew.Location = new System.Drawing.Point(83, 369);
            this.cmbx_PNew.Name = "cmbx_PNew";
            this.cmbx_PNew.Size = new System.Drawing.Size(224, 37);
            this.cmbx_PNew.TabIndex = 54;
            // 
            // txbx_PName
            // 
            this.txbx_PName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_PName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbx_PName.Location = new System.Drawing.Point(83, 274);
            this.txbx_PName.Multiline = true;
            this.txbx_PName.Name = "txbx_PName";
            this.txbx_PName.Size = new System.Drawing.Size(224, 38);
            this.txbx_PName.TabIndex = 51;
            this.txbx_PName.TextChanged += new System.EventHandler(this.txbx_PName_TextChanged);
            // 
            // cmbx_PCatagory
            // 
            this.cmbx_PCatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_PCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_PCatagory.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cmbx_PCatagory.FormattingEnabled = true;
            this.cmbx_PCatagory.Location = new System.Drawing.Point(378, 369);
            this.cmbx_PCatagory.Name = "cmbx_PCatagory";
            this.cmbx_PCatagory.Size = new System.Drawing.Size(224, 37);
            this.cmbx_PCatagory.TabIndex = 47;
            // 
            // dBCaffeBrainDataSet7
            // 
            this.dBCaffeBrainDataSet7.DataSetName = "DBCaffeBrainDataSet7";
            this.dBCaffeBrainDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allProductBindingSource
            // 
            this.allProductBindingSource.DataMember = "AllProduct";
            this.allProductBindingSource.DataSource = this.dBCaffeBrainDataSet7;
            // 
            // allProductTableAdapter
            // 
            this.allProductTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView_AllProductList
            // 
            this.dataGridView_AllProductList.AutoGenerateColumns = false;
            this.dataGridView_AllProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AllProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.newDataGridViewCheckBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn});
            this.dataGridView_AllProductList.DataSource = this.allProductBindingSource1;
            this.dataGridView_AllProductList.Location = new System.Drawing.Point(736, 274);
            this.dataGridView_AllProductList.Name = "dataGridView_AllProductList";
            this.dataGridView_AllProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_AllProductList.Size = new System.Drawing.Size(552, 507);
            this.dataGridView_AllProductList.TabIndex = 57;
            this.dataGridView_AllProductList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AllProductList_CellClick);
            // 
            // allProductBindingSource1
            // 
            this.allProductBindingSource1.DataMember = "AllProduct";
            this.allProductBindingSource1.DataSource = this.dBCaffeBrainDataSet8;
            // 
            // dBCaffeBrainDataSet8
            // 
            this.dBCaffeBrainDataSet8.DataSetName = "DBCaffeBrainDataSet8";
            this.dBCaffeBrainDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allProductTableAdapter1
            // 
            this.allProductTableAdapter1.ClearBeforeFill = true;
            // 
            // txbx_PId
            // 
            this.txbx_PId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_PId.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbx_PId.Location = new System.Drawing.Point(83, 475);
            this.txbx_PId.Multiline = true;
            this.txbx_PId.Name = "txbx_PId";
            this.txbx_PId.ReadOnly = true;
            this.txbx_PId.Size = new System.Drawing.Size(224, 38);
            this.txbx_PId.TabIndex = 75;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(301, 732);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(165, 49);
            this.btn_Update.TabIndex = 73;
            this.btn_Update.Text = "Update Select";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_ExitAllEmploye
            // 
            this.btn_ExitAllEmploye.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_ExitAllEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExitAllEmploye.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_ExitAllEmploye.Location = new System.Drawing.Point(508, 732);
            this.btn_ExitAllEmploye.Name = "btn_ExitAllEmploye";
            this.btn_ExitAllEmploye.Size = new System.Drawing.Size(165, 49);
            this.btn_ExitAllEmploye.TabIndex = 72;
            this.btn_ExitAllEmploye.Text = "Exit";
            this.btn_ExitAllEmploye.UseVisualStyleBackColor = false;
            this.btn_ExitAllEmploye.Click += new System.EventHandler(this.btn_ExitAllEmploye_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(95, 733);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(165, 49);
            this.btn_Delete.TabIndex = 71;
            this.btn_Delete.Text = "Delete Select";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(417, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 112);
            this.label1.TabIndex = 76;
            this.label1.Text = "All Product list";
            // 
            // txbx_Price
            // 
            this.txbx_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_Price.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbx_Price.Location = new System.Drawing.Point(378, 274);
            this.txbx_Price.Multiline = true;
            this.txbx_Price.Name = "txbx_Price";
            this.txbx_Price.Size = new System.Drawing.Size(224, 38);
            this.txbx_Price.TabIndex = 77;
            this.txbx_Price.TextChanged += new System.EventHandler(this.txbx_Price_TextChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // newDataGridViewCheckBoxColumn
            // 
            this.newDataGridViewCheckBoxColumn.DataPropertyName = "New";
            this.newDataGridViewCheckBoxColumn.HeaderText = "New";
            this.newDataGridViewCheckBoxColumn.Name = "newDataGridViewCheckBoxColumn";
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            // 
            // AllProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1444, 881);
            this.Controls.Add(this.txbx_Price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_PId);
            this.Controls.Add(label9);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_ExitAllEmploye);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.dataGridView_AllProductList);
            this.Controls.Add(this.cmbx_PNew);
            this.Controls.Add(label4);
            this.Controls.Add(txbx_Pnavbcme);
            this.Controls.Add(this.txbx_PName);
            this.Controls.Add(txbx_Pprice);
            this.Controls.Add(Username);
            this.Controls.Add(this.cmbx_PCatagory);
            this.Name = "AllProductList";
            this.Text = "AllProductList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AllProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBCaffeBrainDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allProductBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCaffeBrainDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbx_PNew;
        private System.Windows.Forms.TextBox txbx_PName;
        private System.Windows.Forms.ComboBox cmbx_PCatagory;
        private DBCaffeBrainDataSet7 dBCaffeBrainDataSet7;
        private System.Windows.Forms.BindingSource allProductBindingSource;
        private DBCaffeBrainDataSet7TableAdapters.AllProductTableAdapter allProductTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView_AllProductList;
        private DBCaffeBrainDataSet8 dBCaffeBrainDataSet8;
        private System.Windows.Forms.BindingSource allProductBindingSource1;
        private DBCaffeBrainDataSet8TableAdapters.AllProductTableAdapter allProductTableAdapter1;
        private System.Windows.Forms.TextBox txbx_PId;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_ExitAllEmploye;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn newDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
    }
}