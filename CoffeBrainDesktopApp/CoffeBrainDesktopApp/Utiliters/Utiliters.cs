using System;
using System.Windows.Forms;
using System.Text;
using System.Security.Cryptography;
namespace CoffeBrainDesktopApp.Utiliters
{
    public static class Utiliters
    {
        public static void ShowMessage(string message, bool error = true)
        {
            if (error)
            {
                MessageBox.Show(message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public static string HashPassword(string password)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(password);
            byte[] Hashbytes = new SHA256Managed().ComputeHash(bytes);
            string HashPassword = Encoding.ASCII.GetString(Hashbytes);

            return HashPassword;
        }

        public static bool CheckPassword(string password, string hashPassword)
        {
            return HashPassword(password) == hashPassword;
        }

      
    }  
        
    
}
