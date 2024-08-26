namespace CoffeBrainDesktopApp
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.btn_Exit = new System.Windows.Forms.Button();
            this.cmbx_New = new System.Windows.Forms.ComboBox();
            this.txbx_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.cmbx_Catagory = new System.Windows.Forms.ComboBox();
            this.dBCaffeBrainDataSet1 = new CoffeBrainDesktopApp.DBCaffeBrainDataSet1();
            this.allProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allProductTableAdapter = new CoffeBrainDesktopApp.DBCaffeBrainDataSet1TableAdapters.AllProductTableAdapter();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.allProductBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dBCaffeBrainDataSet9 = new CoffeBrainDesktopApp.DBCaffeBrainDataSet9();
            this.dBCaffeBrainDataSet3 = new CoffeBrainDesktopApp.DBCaffeBrainDataSet3();
            this.allProductBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.allProductTableAdapter1 = new CoffeBrainDesktopApp.DBCaffeBrainDataSet3TableAdapters.AllProductTableAdapter();
            this.txbx_price = new System.Windows.Forms.TextBox();
            this.allProductTableAdapter2 = new CoffeBrainDesktopApp.DBCaffeBrainDataSet9TableAdapters.AllProductTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.New = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label4 = new System.Windows.Forms.Label();
            txbx_Pnavbcme = new System.Windows.Forms.Label();
            txbx_Pprice = new System.Windows.Forms.Label();
            Username = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBCaffeBrainDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allProductBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCaffeBrainDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCaffeBrainDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allProductBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.LightGreen;
            label4.Location = new System.Drawing.Point(486, 302);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 20);
            label4.TabIndex = 31;
            label4.Text = "Show";
            label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label4.UseMnemonic = false;
            // 
            // txbx_Pnavbcme
            // 
            txbx_Pnavbcme.AutoSize = true;
            txbx_Pnavbcme.BackColor = System.Drawing.Color.Transparent;
            txbx_Pnavbcme.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txbx_Pnavbcme.ForeColor = System.Drawing.Color.LightGreen;
            txbx_Pnavbcme.Location = new System.Drawing.Point(486, 211);
            txbx_Pnavbcme.Name = "txbx_Pnavbcme";
            txbx_Pnavbcme.Size = new System.Drawing.Size(59, 20);
            txbx_Pnavbcme.TabIndex = 29;
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
            txbx_Pprice.Location = new System.Drawing.Point(191, 302);
            txbx_Pprice.Name = "txbx_Pprice";
            txbx_Pprice.Size = new System.Drawing.Size(53, 20);
            txbx_Pprice.TabIndex = 27;
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
            Username.Location = new System.Drawing.Point(191, 211);
            Username.Name = "Username";
            Username.Size = new System.Drawing.Size(88, 20);
            Username.TabIndex = 25;
            Username.Text = "Category";
            Username.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            Username.UseMnemonic = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_Exit.Location = new System.Drawing.Point(254, 472);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(165, 49);
            this.btn_Exit.TabIndex = 38;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // cmbx_New
            // 
            this.cmbx_New.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_New.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cmbx_New.FormattingEnabled = true;
            this.cmbx_New.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmbx_New.Location = new System.Drawing.Point(490, 335);
            this.cmbx_New.Name = "cmbx_New";
            this.cmbx_New.Size = new System.Drawing.Size(224, 37);
            this.cmbx_New.TabIndex = 36;
            // 
            // txbx_Name
            // 
            this.txbx_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_Name.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbx_Name.Location = new System.Drawing.Point(490, 243);
            this.txbx_Name.Multiline = true;
            this.txbx_Name.Name = "txbx_Name";
            this.txbx_Name.Size = new System.Drawing.Size(224, 38);
            this.txbx_Name.TabIndex = 28;
            this.txbx_Name.TextChanged += new System.EventHandler(this.txbx_Name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(417, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 85);
            this.label2.TabIndex = 24;
            this.label2.Text = "Add New Product";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Green;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Chocolate;
            this.btn_Add.Location = new System.Drawing.Point(490, 472);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(165, 49);
            this.btn_Add.TabIndex = 22;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // cmbx_Catagory
            // 
            this.cmbx_Catagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Catagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_Catagory.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cmbx_Catagory.FormattingEnabled = true;
            this.cmbx_Catagory.Location = new System.Drawing.Point(195, 243);
            this.cmbx_Catagory.Name = "cmbx_Catagory";
            this.cmbx_Catagory.Size = new System.Drawing.Size(224, 37);
            this.cmbx_Catagory.TabIndex = 23;
            // 
            // dBCaffeBrainDataSet1
            // 
            this.dBCaffeBrainDataSet1.DataSetName = "DBCaffeBrainDataSet1";
            this.dBCaffeBrainDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allProductBindingSource
            // 
            this.allProductBindingSource.DataMember = "AllProduct";
            this.allProductBindingSource.DataSource = this.dBCaffeBrainDataSet1;
            // 
            // allProductTableAdapter
            // 
            this.allProductTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Name,
            this.Price,
            this.New,
            this.CategoryID});
            this.dataGridView.DataSource = this.allProductBindingSource2;
            this.dataGridView.Location = new System.Drawing.Point(759, 243);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(532, 278);
            this.dataGridView.TabIndex = 45;
            // 
            // allProductBindingSource2
            // 
            this.allProductBindingSource2.DataMember = "AllProduct";
            this.allProductBindingSource2.DataSource = this.dBCaffeBrainDataSet9;
            // 
            // dBCaffeBrainDataSet9
            // 
            this.dBCaffeBrainDataSet9.DataSetName = "DBCaffeBrainDataSet9";
            this.dBCaffeBrainDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBCaffeBrainDataSet3
            // 
            this.dBCaffeBrainDataSet3.DataSetName = "DBCaffeBrainDataSet3";
            this.dBCaffeBrainDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allProductBindingSource1
            // 
            this.allProductBindingSource1.DataMember = "AllProduct";
            this.allProductBindingSource1.DataSource = this.dBCaffeBrainDataSet3;
            // 
            // allProductTableAdapter1
            // 
            this.allProductTableAdapter1.ClearBeforeFill = true;
            // 
            // txbx_price
            // 
            this.txbx_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_price.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbx_price.Location = new System.Drawing.Point(195, 335);
            this.txbx_price.Multiline = true;
            this.txbx_price.Name = "txbx_price";
            this.txbx_price.Size = new System.Drawing.Size(224, 38);
            this.txbx_price.TabIndex = 46;
            this.txbx_price.TextChanged += new System.EventHandler(this.txbx_price_TextChanged);
            // 
            // allProductTableAdapter2
            // 
            this.allProductTableAdapter2.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // New
            // 
            this.New.DataPropertyName = "New";
            this.New.HeaderText = "New";
            this.New.Name = "New";
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "Category";
            this.CategoryID.HeaderText = "CategoryID";
            this.CategoryID.Name = "CategoryID";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1444, 836);
            this.Controls.Add(this.txbx_price);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.cmbx_New);
            this.Controls.Add(label4);
            this.Controls.Add(txbx_Pnavbcme);
            this.Controls.Add(this.txbx_Name);
            this.Controls.Add(txbx_Pprice);
            this.Controls.Add(Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbx_Catagory);
            this.Controls.Add(this.btn_Add);
            this.Text = "AddProduct";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBCaffeBrainDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allProductBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCaffeBrainDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBCaffeBrainDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allProductBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ComboBox cmbx_New;
        private System.Windows.Forms.TextBox txbx_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ComboBox cmbx_Catagory;
        private DBCaffeBrainDataSet1 dBCaffeBrainDataSet1;
        private System.Windows.Forms.BindingSource allProductBindingSource;
        private DBCaffeBrainDataSet1TableAdapters.AllProductTableAdapter allProductTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView;
        private DBCaffeBrainDataSet3 dBCaffeBrainDataSet3;
        private System.Windows.Forms.BindingSource allProductBindingSource1;
        private DBCaffeBrainDataSet3TableAdapters.AllProductTableAdapter allProductTableAdapter1;
        private System.Windows.Forms.TextBox txbx_price;
        private DBCaffeBrainDataSet9 dBCaffeBrainDataSet9;
        private System.Windows.Forms.BindingSource allProductBindingSource2;
        private DBCaffeBrainDataSet9TableAdapters.AllProductTableAdapter allProductTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewCheckBoxColumn New;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
    }
}