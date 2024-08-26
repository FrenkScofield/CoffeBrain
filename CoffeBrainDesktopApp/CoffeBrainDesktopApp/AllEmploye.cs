using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CoffeBrainDesktopApp.SQLDB;
using DataGridViewCellEventArgs = System.Windows.Forms.DataGridViewCellEventArgs;

namespace CoffeBrainDesktopApp
{
    public partial class AllEmploye : Form
    {
        

        public DBCaffeBrainEntities _contex;

        public AllEmploye()
        {
            InitializeComponent();
            _contex = new DBCaffeBrainEntities();
        }
        int selectRows;
        //BindingList<Enployee> bindigEnployees;
        private void AllEmploye_Load(object sender, EventArgs e)
        {
           // bindigEnployees = new BindingList<Enployee>();
           dataGridView_AllEmploye.DataSource = _contex.Enployees.ToList();
           

            FillMissionANDGenderCombo();
        }
        private void FillMissionANDGenderCombo()
        {

            cmbx_Mission.Items.AddRange(_contex.Missions.ToArray());
            cmbx_Genders.Items.AddRange(_contex.Genders.ToArray());
        }

        private void dataGridView_AllEmploye_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            selectRows = e.RowIndex;
            DataGridViewRow row = dataGridView_AllEmploye.Rows[selectRows];
            if (row.Cells[7].Value != null)
            {
            txbx_Id.Text = row.Cells[0].Value.ToString();
            txbx_Firstname.Text = row.Cells[1].Value.ToString();
            txbx_Lasname.Text = row.Cells[2].Value.ToString();
            txbx_Email.Text = row.Cells[3].Value.ToString();
            txbx_Phone.Text = row.Cells[4].Value.ToString();
            txbx_Username.Text = row.Cells[5].Value.ToString();
            txbx_Password.Text = row.Cells[6].Value.ToString();
            cmbx_Mission.Text = row.Cells[7].Value.ToString();
            cmbx_Genders.Text = row.Cells[8].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selected employee not found");
                dataGridView_AllEmploye.Refresh();
            }

        }

        public void TextSpace()
        {
            txbx_Email.Text = "";
            txbx_Firstname.Text = "";
            txbx_Lasname.Text = "";
            txbx_Password.Text = "";
            txbx_Phone.Text = "";
            txbx_Username.Text = "";
            txbx_Id.Text = "";
            
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txbx_Id.Text != "")
            {
                DataGridViewRow NewdataGridViewRow = dataGridView_AllEmploye.Rows[selectRows];

                NewdataGridViewRow.Cells[1].Value = txbx_Firstname.Text;
                NewdataGridViewRow.Cells[2].Value = txbx_Lasname.Text;
                NewdataGridViewRow.Cells[3].Value = txbx_Email.Text;
                NewdataGridViewRow.Cells[4].Value = txbx_Phone.Text;
                NewdataGridViewRow.Cells[5].Value = txbx_Username.Text;
                NewdataGridViewRow.Cells[6].Value = txbx_Password.Text;
                NewdataGridViewRow.Cells[7].Value = cmbx_Mission.SelectedItem as Mission;
                NewdataGridViewRow.Cells[8].Value = cmbx_Genders.SelectedItem as Gender;
                var Id = int.Parse(txbx_Id.Text);
                Enployee enployee = _contex.Enployees.FirstOrDefault(v => v.id == Id);
                enployee.FirstName = txbx_Firstname.Text.Trim();
                enployee.LastName = txbx_Lasname.Text.Trim();
                enployee.Email = txbx_Email.Text.Trim();
                enployee.Username = txbx_Username.Text.Trim();
                enployee.Password = CalculateMD5Hash.Utiliters.CalculateMD5Hash(txbx_Password.Text.Trim());
                enployee.Phone = txbx_Phone.Text.Trim();
                enployee.MissionID = (cmbx_Mission.SelectedItem as Mission).ID;
                enployee.GenderID = (cmbx_Genders.SelectedItem as Gender).ID;

                TextSpace();
                _contex.SaveChanges();
                MessageBox.Show("Update success");

            }
            else
            {
            MessageBox.Show("Please select any employee");
            }

        
    }

        private string HashPassword(object password)
        {
            throw new NotImplementedException();
        }

        private void btn_ExitAllEmploye_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txbx_Id.Text != "")
            {
                var Id = int.Parse(txbx_Id.Text);
                Enployee enployee = _contex.Enployees.FirstOrDefault(v => v.id == Id);
                _contex.Enployees.Remove(enployee);
                _contex.SaveChanges();
                dataGridView_AllEmploye.DataSource = _contex.Enployees.ToList();
                MessageBox.Show("Successfully deleted");
                TextSpace();
            }
            else
            {
                MessageBox.Show("Please select any employee");
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
           
            if(System.Text.RegularExpressions.Regex.IsMatch(txbx_Lasname.Text, "[0-9]"))
            {
                MessageBox.Show("Please enter only letter.");
                txbx_Lasname.Text = txbx_Lasname.Text.Remove(txbx_Lasname.Text.Length - 1);
            }
        }

        private void txbx_Phone_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(txbx_Phone.Text, "[A-z]"))
            {
                MessageBox.Show("Please enter only number");

                txbx_Phone.Text = txbx_Phone.Text.Remove(txbx_Phone.Text.Length - 1);
            }
        }
    }
}
