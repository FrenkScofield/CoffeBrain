namespace CoffeBrainDesktopApp
{
    partial class Additions
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Additions));
            this.txbx_Addition = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Additions = new System.Windows.Forms.DataGridView();
            this.txbx_AdditionsPrice = new System.Windows.Forms.TextBox();
            this.cmbx_ProducName = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Additions)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.LightGreen;
            label3.Location = new System.Drawing.Point(387, 293);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(53, 20);
            label3.TabIndex = 50;
            label3.Text = "Price";
            label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label3.UseMnemonic = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.LightGreen;
            label1.Location = new System.Drawing.Point(387, 200);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(93, 20);
            label1.TabIndex = 49;
            label1.Text = "Additions";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label1.UseMnemonic = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.LightGreen;
            label4.Location = new System.Drawing.Point(97, 196);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(132, 20);
            label4.TabIndex = 74;
            label4.Text = "Product Name";
            label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label4.UseMnemonic = false;
            // 
            // txbx_Addition
            // 
            this.txbx_Addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_Addition.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbx_Addition.Location = new System.Drawing.Point(391, 232);
            this.txbx_Addition.Multiline = true;
            this.txbx_Addition.Name = "txbx_Addition";
            this.txbx_Addition.Size = new System.Drawing.Size(224, 38);
            this.txbx_Addition.TabIndex = 48;
            this.txbx_Addition.TextChanged += new System.EventHandler(this.txbx_Addition_TextChanged);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_Exit.Location = new System.Drawing.Point(101, 446);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(165, 49);
            this.btn_Exit.TabIndex = 47;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Green;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Chocolate;
            this.btn_Add.Location = new System.Drawing.Point(342, 446);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(165, 49);
            this.btn_Add.TabIndex = 46;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(190, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(603, 85);
            this.label2.TabIndex = 52;
            this.label2.Text = "New Product Additions";
            // 
            // dataGridView_Additions
            // 
            this.dataGridView_Additions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Additions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Name,
            this.Price,
            this.Product});
            this.dataGridView_Additions.Location = new System.Drawing.Point(695, 199);
            this.dataGridView_Additions.Name = "dataGridView_Additions";
            this.dataGridView_Additions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Additions.Size = new System.Drawing.Size(447, 296);
            this.dataGridView_Additions.TabIndex = 53;
            // txbx_AdditionsPrice
            // 
            this.txbx_AdditionsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_AdditionsPrice.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txbx_AdditionsPrice.Location = new System.Drawing.Point(391, 325);
            this.txbx_AdditionsPrice.Multiline = true;
            this.txbx_AdditionsPrice.Name = "txbx_AdditionsPrice";
            this.txbx_AdditionsPrice.Size = new System.Drawing.Size(224, 38);
            this.txbx_AdditionsPrice.TabIndex = 54;
            this.txbx_AdditionsPrice.TextChanged += new System.EventHandler(this.txbx_AdditionsPrice_TextChanged);
            // 
            // cmbx_ProducName
            // 
            this.cmbx_ProducName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_ProducName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_ProducName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cmbx_ProducName.FormattingEnabled = true;
            this.cmbx_ProducName.Location = new System.Drawing.Point(101, 229);
            this.cmbx_ProducName.Name = "cmbx_ProducName";
            this.cmbx_ProducName.Size = new System.Drawing.Size(224, 37);
            this.cmbx_ProducName.TabIndex = 73;
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
            // Product
            // 
            this.Product.DataPropertyName = "ProductId";
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            // 
            // Additions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1199, 636);
            this.Controls.Add(label4);
            this.Controls.Add(this.cmbx_ProducName);
            this.Controls.Add(this.txbx_AdditionsPrice);
            this.Controls.Add(this.dataGridView_Additions);
            this.Controls.Add(this.label2);
            this.Controls.Add(label3);
            this.Controls.Add(label1);
            this.Controls.Add(this.txbx_Addition);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Add);
            //this.Name = "Additions";
            this.Text = "Additions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Additions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Additions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbx_Addition;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Additions;
        private System.Windows.Forms.TextBox txbx_AdditionsPrice;
        private System.Windows.Forms.ComboBox cmbx_ProducName;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
    }
}