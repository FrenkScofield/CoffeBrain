using System;
using System.Windows.Forms;
using System.Linq;
using CoffeBrainDesktopApp.SQLDB;
using static CoffeBrainDesktopApp.CalculateMD5Hash.Utiliters;

namespace CoffeBrainDesktopApp
{
    public partial class CreateEnployee : Form
    {
        private readonly DBCaffeBrainEntities _contex;


        public CreateEnployee()
        {
            InitializeComponent();
            _contex = new DBCaffeBrainEntities();
        }
        int selectAddEnployeeRows;

        private void CreateEnployee_Load(object sender, EventArgs e)
        {
            dataGridView_AddEmploye.AutoGenerateColumns = false;
            dataGridView_AddEmploye.DataSource = _contex.Enployees.ToList();


            FillMissionCombo();
            FillGenderCombo();
        }

        private void FillMissionCombo()
        {
            cmbx_Mission.Items.AddRange(_contex.Missions.ToArray());
        
        }

        private void FillGenderCombo()
        {

            cmbx_Genders.Items.AddRange(_contex.Genders.ToArray());
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            string firstName = txbx_Firstname.Text.Trim();
            string lasName = txbx_Lasname.Text.Trim();
            string email = txbx_Email.Text.Trim();
            string userName = txbx_Username.Text.Trim();
            string password = txbx_Password.Text.Trim();
            string phonee = txbx_Phone.Text.Trim();
            Mission mission = cmbx_Mission.SelectedItem as Mission;
            Gender gender = cmbx_Genders.SelectedItem as Gender;

            if (firstName == "" || lasName == "" || email == "" || userName == "" || password == "" || phonee == "")
            {
                ShowMessage("FirstName or LasName or Email or UserName or Password or Phonee is empty ");
                return;
            }
            if (_contex.Enployees.Any(usr => usr.Username == userName ||
                           usr.Email == email || usr.Phone == phonee))
            {
                ShowMessage("Username or Email or Phone is exists");
                return;
            }
            if (mission == null || gender == null)
            {
                ShowMessage("Mission shold be selected");
                return;
            }

            Enployee enployee = new Enployee()
            {
                FirstName = firstName,
                LastName = lasName,
                Email = email,
                Username = userName,
                Password = CalculateMD5Hash.Utiliters.CalculateMD5Hash(password),
                Phone = phonee,
                MissionID = mission.ID,
                GenderID = gender.ID
            };

            _contex.Enployees.Add(enployee);
            TextSpace();

            DataGridViewRow enployee2 = dataGridView_AddEmploye.Rows[selectAddEnployeeRows];
            enployee2.Cells[1].Value = txbx_Firstname.Text;
            enployee2.Cells[2].Value = txbx_Lasname.Text;
            enployee2.Cells[3].Value = txbx_Username.Text;
            enployee2.Cells[4].Value = txbx_Email.Text;
            enployee2.Cells[5].Value = gender;
            enployee2.Cells[6].Value = mission;
            enployee2.Cells[7].Value = txbx_Phone.Text;
            enployee2.Cells[8].Value = txbx_Password.Text;

            _contex.SaveChanges();

            dataGridView_AddEmploye.DataSource = _contex.Enployees.ToList();

            ShowMessage("User succseesfully selected", error: false);
        }

      

        public void TextSpace()
        {
            txbx_Email.Text = "";
            txbx_Firstname.Text = "";
            txbx_Lasname.Text = "";
            txbx_Password.Text = "";
            txbx_Phone.Text = "";
            txbx_Username.Text = "";
            cmbx_Genders.SelectedItem = "";

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbx_Phone_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(txbx_Phone.Text, "[A-z]"))
            {
                MessageBox.Show("Please enter only numbers.");
               txbx_Phone.Text = txbx_Phone.Text.Remove(txbx_Phone.Text.Length - 1);
            }

        }

        private void txbx_Firstname_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(txbx_Firstname.Text, "[0-9]"))
            {
                MessageBox.Show("Please enter only letter.");
                txbx_Firstname.Text = txbx_Firstname.Text.Remove(txbx_Firstname.Text.Length - 1);
            }
        }

        private void txbx_Lasname_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txbx_Lasname.Text, "[0-9]" ))
            {
                MessageBox.Show("Please enter only letter.");
                txbx_Lasname.Text = txbx_Lasname.Text.Remove(txbx_Lasname.Text.Length - 1);
            }
        }
    }
}
