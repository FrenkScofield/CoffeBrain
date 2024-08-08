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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            (new CreateEnployee()).ShowDialog();
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            (new AddProduct()).ShowDialog();
        }

        private void btn_Additions_Click(object sender, EventArgs e)
        {
            (new Additions()).ShowDialog();
        }

        private void btnAllEmployee_Click(object sender, EventArgs e)
        {
            (new AllEmploye()).ShowDialog();
        }

        private void btn_AllProduct_Click(object sender, EventArgs e)
        {
            (new AllProductList()).ShowDialog();
        }

       
    }
}
