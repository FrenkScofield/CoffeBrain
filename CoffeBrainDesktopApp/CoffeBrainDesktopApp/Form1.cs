using System;
using System.Windows.Forms;
using System.Linq;
using CoffeBrainDesktopApp.SQLDB;
using static CoffeBrainDesktopApp.CalculateMD5Hash.Utiliters;
using CoffeBrainDesktopApp.CalculateMD5Hash;

namespace CoffeBrainDesktopApp
{
    public partial class Form1 : Form
    {
        private readonly DBCaffeBrainEntities _contex;

        public Form1()
        {
            InitializeComponent();
            _contex = new DBCaffeBrainEntities();

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txbx_Username.Text.Trim();
            string passvord = txbx_Password.Text.Trim();

            if(username == "" || passvord == "")
            {
                ShowMessage("Passvord or Username can not be empty");
                return;
            }

            string pss = Utiliters.CalculateMD5Hash(passvord);

              Enployee users = _contex.Enployees.FirstOrDefault(u => u.Username == username);

            if (users == null)
            {
                ShowMessage("Passvord or Username is Wrong");
                return;
            }

            if (!CheckPassword(passvord, users.Password))
            {
                ShowMessage("Passvord or Username is Wrong");
                return;
            }

            if (users.Mission.Name != "Admin")
            {
                (new Kassir()).ShowDialog();
                return;
            }


            (new AdminPanel()).ShowDialog();

            txbx_Username.Text = "";
            txbx_Password.Text = "";

            

        }

    }
}
