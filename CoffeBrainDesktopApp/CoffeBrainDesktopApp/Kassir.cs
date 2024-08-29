
using CoffeBrainDesktopApp.SQLDB;
using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Timers;
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
            txbx_KassirName.Text = "Hi  " + Form1.currentUser;
            txbx_KassirName.ReadOnly = true;
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
            if (txbx_Count.Text != "" && txbx_Price.Text != "" && cmbx_Additions.Text != "" && cmbx_ProducName.Text != "")
            {
                int g = dataGridView_OrderList.Rows.Add();
            dataGridView_OrderList.Rows[g].Cells[0].Value = cmbx_Catagory.Text;
            dataGridView_OrderList.Rows[g].Cells[1].Value = cmbx_ProducName.Text;
            dataGridView_OrderList.Rows[g].Cells[2].Value = cmbx_Additions.Text;
            dataGridView_OrderList.Rows[g].Cells[3].Value = txbx_Count.Text;
            dataGridView_OrderList.Rows[g].Cells[4].Value = txbx_Price.Text;

            }
            else
            {
                MessageBox.Show("Cannot be sent empty");
                return;
            }
            txbx_Count.Text = "";
            txbx_Price.Text = "";
            cmbx_Catagory.SelectedIndex = 0;
            cmbx_Additions.Text = "";
            cmbx_ProducName.Text = "";

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
        string nl = Environment.NewLine;
        private void btn_Finis_Click(object sender, EventArgs e)
        {

            string[,] DataValue = new string[dataGridView_OrderList.Rows.Count, dataGridView_OrderList.Columns.Count];
           
            foreach (DataGridViewRow row in dataGridView_OrderList.Rows)
            {
                foreach (DataGridViewColumn col in dataGridView_OrderList.Columns)
                {
                    DataValue[row.Index, col.Index] = dataGridView_OrderList.Rows[row.Index].Cells[col.Index].Value.ToString();
                }
            }

              var a = listBox_Orderlist.Items;
            //foreach (string row in a)
            //{
            //    if(row == "                                YOUR BILL")
            //    {
            //        int num = 1;
            //        string strval1 = "";
            //        foreach (string ss in DataValue)
            //        {
            //            strval1 += ss;
            //            strval1 += " , ";
            //            if (num == 5)
            //            {
            //                strval1 += "     ---       " + DateTime.Now.ToString();
            //                listBox_Orderlist.Items.AddRange(strval1.Split('\n'));
            //                strval1 = "";
            //                num = 0;
            //            }
            //            num++;
            //        };

            //        dataGridView_Clear();
            //        return;
            //    }
            //}

            int i = 1;
            string strval = "";
           
            string title = nl + "                                YOUR BILL" + nl;

            if (a.Count == 0)
            {
              listBox_Orderlist.Items.AddRange(title.Split('\n'));
               
            }

            foreach (string ss in DataValue)
            {
                strval += ss;
                strval += " , ";
                if (i == 5)
                {
                    strval += "     ---       " + DateTime.Now.ToString();
                    listBox_Orderlist.Items.AddRange(strval.Split('\n'));
                    strval = "";
                    i = 0;
                }
                i++;
            };

            dataGridView_Clear();
        }

        public void dataGridView_Clear()
        {
            int rowCount = dataGridView_OrderList.Rows.Count;

            for (int item = 0; item < rowCount; item++)
            {
                dataGridView_OrderList.Rows.RemoveAt(0);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int count = dataGridView_OrderList.Rows.Count;

            if (count != 0)
            {
                int currentOrder = dataGridView_OrderList.CurrentCell.RowIndex;
                dataGridView_OrderList.Rows.RemoveAt(currentOrder);
                MessageBox.Show("Successfully deleted");
            }
            else
            {
                MessageBox.Show("Please select any employee");
            }
        }

            int num = 0;
        private void checkOut_Click(object sender, EventArgs e)
        {
            string currentCashier = nl + Form1.currentUser;

            if (num == 0)
            {
                listBox_Orderlist.Items.AddRange(currentCashier.Split('\n'));
                num++;
                btn_Finis.Enabled = false;
            }
        }

        private void newOrder_Click(object sender, EventArgs e)
        {
           listBox_Orderlist.Items.Clear();
            btn_Finis.Enabled = true;
            num = 0;
        }
    }
}
