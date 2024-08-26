using CoffeBrainDesktopApp.SQLDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CoffeBrainDesktopApp.CalculateMD5Hash.Utiliters;
namespace CoffeBrainDesktopApp
{
    public partial class AddProduct : Form
    {
        private readonly DBCaffeBrainEntities _contex;

        public AddProduct()
        {
            InitializeComponent();
            _contex = new DBCaffeBrainEntities();
        }
        int productNum;
        private void AddProduct_Load(object sender, EventArgs e)
        {
            this.allProductTableAdapter2.Fill(this.dBCaffeBrainDataSet9.AllProduct);

            dataGridView.AutoGenerateColumns = false;

            dataGridView.DataSource = _contex.AllProducts.ToList();

            FillCatagoryCombo();
            cmbx_New.DataSource = new bool[] { true, false };
        }

        private void FillCatagoryCombo()
        {
            cmbx_Catagory.Items.AddRange(_contex.Categories.ToArray());
           
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string name = txbx_Name.Text.Trim();
            Category category = cmbx_Catagory.SelectedItem as Category;
            string price = txbx_price.Text.Trim();
            bool New = (bool)cmbx_New.SelectedItem;
            

            if (name == "" || price == "" )
            {
                ShowMessage("Please fill in correctly.");
                return;
            }
            if (_contex.AllProducts.Any(nem => nem.Name == name))
            {
                ShowMessage("This product already exists");
                return;
            }
            if(category == null)
            {
                ShowMessage("Catagory should be selectid");
                return;
            }

            AllProduct allProduct = new AllProduct()
            {
                Name = name,
                Price = price,
                CategoryID = category.id,
                New = (bool)cmbx_New.SelectedItem,
                
            };

            _contex.AllProducts.Add(allProduct);

            txbx_Name.Text = "";
            txbx_price.Text = "";
            cmbx_Catagory.Text = "";
            cmbx_New.Text = "";

            if (productNum >= 0 && productNum < dataGridView.Rows.Count)
            {
                DataGridViewRow product = dataGridView.Rows[productNum];
                product.Cells[1].Value = txbx_price.Text;
                product.Cells[2].Value = txbx_Name.Text;
                product.Cells[3].Value = cmbx_New.Text;
                product.Cells[4].Value = category;
            }
            else
            {
                Console.WriteLine("Product number is out of range.");
            }
            _contex.SaveChanges();

            dataGridView.DataSource = _contex.AllProducts.ToList();

            ShowMessage("Product added succseesfully ", error: false);

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbx_Name_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txbx_Name.Text, "[0-9]"))   
            {
                MessageBox.Show("Please enter only letter.");
                txbx_Name.Text = txbx_Name.Text.Remove(txbx_Name.Text.Length - 1);
            }
        }

        private void txbx_price_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(txbx_price.Text, "[A-z]"))
            {
                MessageBox.Show("Please enter only number.");

                txbx_price.Text = txbx_price.Text.Remove(txbx_price.Text.Length - 1);
            }
        }
    }
}
