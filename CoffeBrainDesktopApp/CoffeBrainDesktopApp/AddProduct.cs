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
using static CoffeBrainDesktopApp.Utiliters.Utiliters;
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

        private void AddProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBCaffeBrainDataSet3.AllProduct' table. You can move, or remove it, as needed.
        //    this.allProductTableAdapter1.Fill(this.dBCaffeBrainDataSet3.AllProduct);
            // TODO: This line of code loads data into the 'dBCaffeBrainDataSet1.AllProduct' table. You can move, or remove it, as needed.
    //        this.allProductTableAdapter.Fill(this.dBCaffeBrainDataSet1.AllProduct);
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
            string price = txbx_price.Text.Trim();
            Category category = cmbx_Catagory.SelectedItem as Category;
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
            
            int n = dataGridView.Rows.Add();
            dataGridView.Rows[n].Cells[0].Value = cmbx_Catagory.Text;
            dataGridView.Rows[n].Cells[1].Value = txbx_Name.Text;
            dataGridView.Rows[n].Cells[2].Value = txbx_price.Text;
            dataGridView.Rows[n].Cells[3].Value = cmbx_New.Text;
           

            txbx_Name.Text = "";
            txbx_price.Text = "";
            cmbx_Catagory.Text = "";
            cmbx_New.Text = "";
          

            _contex.AllProducts.Add(allProduct);
            _contex.SaveChanges();

         

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
