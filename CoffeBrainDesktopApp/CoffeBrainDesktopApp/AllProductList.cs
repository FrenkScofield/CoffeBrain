using System;
using System.Linq;
using System.Windows.Forms;
using CoffeBrainDesktopApp.SQLDB;
using DataGridViewCellEventArgs = System.Windows.Forms.DataGridViewCellEventArgs;

namespace CoffeBrainDesktopApp
{
    public partial class AllProductList : Form
    {
        public DBCaffeBrainEntities _contex;

        public AllProductList()
        {
            InitializeComponent();
            _contex = new DBCaffeBrainEntities();
        }
        int selectRows;
        private void AllProductList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBCaffeBrainDataSet8.AllProduct' table. You can move, or remove it, as needed.
         //   this.allProductTableAdapter1.Fill(this.dBCaffeBrainDataSet8.AllProduct);
            // TODO: This line of code loads data into the 'dBCaffeBrainDataSet7.AllProduct' table. You can move, or remove it, as needed.
         //   this.allProductTableAdapter.Fill(this.dBCaffeBrainDataSet7.AllProduct);
            
            dataGridView_AllProductList.DataSource = _contex.AllProducts.ToList();
            FillCatagoryCombo();
        }

        private void FillCatagoryCombo()
        {
            cmbx_PCatagory.Items.AddRange(_contex.Categories.ToArray());
        }


        private void dataGridView_AllProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectRows = e.RowIndex;
            DataGridViewRow row = dataGridView_AllProductList.Rows[selectRows];
            txbx_PId.Text = row.Cells[0].Value.ToString();
            txbx_PName.Text = row.Cells[1].Value.ToString();
            txbx_Price.Text = row.Cells[2].Value.ToString();
            cmbx_PNew.Text = row.Cells[3].Value.ToString();
            cmbx_PCatagory.Text = row.Cells[4].Value.ToString();
        }

        private void btn_ExitAllEmploye_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbx_PName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txbx_PName.Text, "[0-9]"))
            {
                MessageBox.Show("Please enter only letter.");
                txbx_PName.Text = txbx_PName.Text.Remove(txbx_PName.Text.Length - 1);
            }
        }

        private void txbx_Price_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(txbx_Price.Text, "[A-z]"))
            {
                MessageBox.Show("Please enter only number.");
                txbx_Price.Text = txbx_Price.Text.Remove(txbx_Price.Text.Length - 1);
            }
        }
        public void TextSpace()
        {
        
            txbx_PName.Text = "";
            txbx_Price.Text = "";
            txbx_PId.Text = "";

        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdataGridViewRow = dataGridView_AllProductList.Rows[selectRows];
           // newdataGridViewRow.Cells[0].Value = txbx_PId.Text;
            newdataGridViewRow.Cells[1].Value = txbx_PName.Text;
            newdataGridViewRow.Cells[2].Value = txbx_Price.Text;
          //  newdataGridViewRow.Cells[3].Value = cmbx_PNew.Text;
            newdataGridViewRow.Cells[4].Value = (cmbx_PCatagory.SelectedItem as Category).id;
            int id = int.Parse(txbx_PId.Text);
            AllProduct allProduct = _contex.AllProducts.FirstOrDefault(s => s.id == id);
            allProduct.Name = txbx_PName.Text.Trim();
            allProduct.Price = txbx_Price.Text.Trim();
          //  allProduct.New = (bool)cmbx_PNew.SelectedItem;
            allProduct.CategoryID = (cmbx_PCatagory.SelectedItem as Category).id;
            TextSpace();
            _contex.SaveChanges();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            dataGridView_AllProductList.Rows.RemoveAt(selectRows);
            int id = int.Parse(txbx_PId.Text);
            AllProduct allProduct = _contex.AllProducts.FirstOrDefault(s => s.id == id);
            _contex.AllProducts.Remove(allProduct);
            MessageBox.Show("Successfully deleted");
            TextSpace();
            _contex.SaveChanges();
        }
    }
}
