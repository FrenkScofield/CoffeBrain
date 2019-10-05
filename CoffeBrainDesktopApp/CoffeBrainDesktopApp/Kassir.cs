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

namespace CoffeBrainDesktopApp
{
    public partial class Kassir : Form
    {
        private readonly DBCaffeBrainEntities _contex;

        public Kassir()
        {
            InitializeComponent();
            _contex = new DBCaffeBrainEntities();
        }

        private void btn_ExitKassir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Kassir_Load(object sender, EventArgs e)
        {
            FillComboCatory();
        }
        private void FillComboCatory()
        {
            cmbx_Catagory.Items.AddRange(_contex.Categories.ToArray());
           
        }

        private void cmbx_Catagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbx_ProducName.Items.Clear();
            var _catagory = cmbx_Catagory.SelectedItem as Category;
            var products = _contex.AllProducts.Where(s => s.CategoryID == _catagory.id);
            cmbx_ProducName.Items.AddRange(products.ToArray());
        }

        private void cmbx_ProducName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbx_Additions.Items.Clear();
            var _producName = cmbx_ProducName.SelectedItem as AllProduct;
            var additions = _contex.Additions.Where(p => p.ProductId == _producName.id);
            cmbx_Additions.Items.AddRange(additions.ToArray());

        }

        private void btn_NextOrder_Click(object sender, EventArgs e)
        {
            int g = dataGridView_OrderList.Rows.Add();
            dataGridView_OrderList.Rows[g].Cells[0].Value = cmbx_Catagory.Text;
            dataGridView_OrderList.Rows[g].Cells[1].Value = cmbx_ProducName.Text;
            dataGridView_OrderList.Rows[g].Cells[2].Value = cmbx_Additions.Text;
            dataGridView_OrderList.Rows[g].Cells[3].Value = txbx_Count.Text;
            dataGridView_OrderList.Rows[g].Cells[4].Value = txbx_Price.Text;

            txbx_Count.Text = "";
            txbx_Price.Text = "";
            cmbx_Catagory.SelectedIndex = 0;
            cmbx_Additions.SelectedIndex = 0;
            cmbx_ProducName.SelectedIndex = 0;

        }

        private void txbx_Count_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txbx_Count.Text, "[A-z]"))
            {
                MessageBox.Show("Please enter only number.");

                txbx_Count.Text = txbx_Count.Text.Remove(txbx_Count.Text.Length - 1);
            }
        }

        private void txbx_Price_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txbx_Price.Text, "[A-z]"))
            {
                MessageBox.Show("Please enter only number.");

                txbx_Price.Text = txbx_Price.Text.Remove(txbx_Price.Text.Length - 1);
            }
        }

        private void btn_Finis_Click(object sender, EventArgs e)
        {

            //string[,] DataValue = new string[dataGridView_OrderList.Rows.Count, dataGridView_OrderList.Columns.Count];
            //foreach(DataGridViewRow row in dataGridView_OrderList.Rows)
            //{
            //    foreach (DataGridViewColumn col in dataGridView_OrderList.Columns)
            //    {
            //        DataValue[row.Index, col.Index] = dataGridView_OrderList.Rows[row.Index].Cells[col.Index].Value.ToString();
            //    }
            //}
            //int i = 1;
            //string strval = "";
            //foreach(string ss in DataValue)
            //{
            //    strval += ss;
            //    if(i == 5)
            //    {
            //        listBox_Orderlist.Items.Add(strval);
            //        strval = "";
            //        i = 0;
            //    }

            //        i++;
            //}

            for (int i = 0; i < dataGridView_OrderList.RowCount; i++)
            {
                listBox_Orderlist.Items.Add(dataGridView_OrderList.Rows[i].Cells[1]);
            }

        }
    }
}
