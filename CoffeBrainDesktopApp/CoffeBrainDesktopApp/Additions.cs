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
    public partial class Additions : Form
    {
        private readonly DBCaffeBrainEntities _contex;

        public Additions()
        {
            InitializeComponent();
            _contex = new DBCaffeBrainEntities();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string additions = txbx_Addition.Text.Trim();
            var additionsPrice = txbx_AdditionsPrice.Text.Trim();
            AllProduct allProduct = cmbx_ProducName.SelectedItem as AllProduct;
            if ( additions == "" || additionsPrice == " ")
            {
                ShowMessage("Please fill in correctly.");
                return;
            }
           
            if(_contex.Additions.Any(pro => pro.Name == additions))
            {
                ShowMessage("This product already exists");
                return;
            }

            Addition addition = new Addition()
            {
                Name = additions,
                Price = additionsPrice,
                ProductId = allProduct.id,
            };

            int a = dataGridView_Additions.Rows.Add();
            dataGridView_Additions.Rows[a].Cells[0].Value = txbx_Addition.Text;
            dataGridView_Additions.Rows[a].Cells[1].Value = txbx_AdditionsPrice.Text;
            dataGridView_Additions.Rows[a].Cells[2].Value = cmbx_ProducName.Text;
            txbx_Addition.Text = "";
            txbx_AdditionsPrice.Text = "";

            _contex.Additions.Add(addition);
            _contex.SaveChanges();

            ShowMessage("successfully added", error: false);

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbx_Addition_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(txbx_Addition.Text, "[0-9]"))
            {
                MessageBox.Show("Please enter only letter");
                txbx_Addition.Text = txbx_Addition.Text.Remove(txbx_Addition.Text.Length - 1);

            }
        }

        private void txbx_AdditionsPrice_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(txbx_AdditionsPrice.Text, "[A-z]"))
            {
                MessageBox.Show("Please enter only number");

                txbx_AdditionsPrice.Text = txbx_AdditionsPrice.Text.Remove(txbx_AdditionsPrice.Text.Length - 1);
            }
        }

        private void Additions_Load(object sender, EventArgs e)
        {
            FillProducts();
        }
        private void FillProducts()
        {
           cmbx_ProducName.Items.AddRange(_contex.AllProducts.ToArray());

        }


    }
}
