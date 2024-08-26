using System;
using System.Windows.Forms;
using System.Text;
using System.Security.Cryptography;
namespace CoffeBrainDesktopApp.CalculateMD5Hash
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

        //public static string HashPassword(string password)
        //{
        //    byte[] bytes = Encoding.ASCII.GetBytes(password);
        //    byte[] Hashbytes = new SHA256Managed().ComputeHash(bytes);
        //    string HashPassword = Encoding.ASCII.GetString(Hashbytes);

        //    return HashPassword;
        //}

         public static bool CheckPassword(string password, string hashPassword)
        {
            return CalculateMD5Hash(password) == hashPassword;
        }

        public static string CalculateMD5Hash(string password)
        {
            MD5 mD5 = MD5.Create();

            byte[] bytes1 = Encoding.UTF8.GetBytes(password);
            byte[] Hashbytes1 = mD5.ComputeHash(bytes1);

            StringBuilder sb = new StringBuilder(); 
            for(int i = 0; i < Hashbytes1.Length; i++)
            {
                sb.Append(Hashbytes1[i].ToString("X2"));
            }
            return sb.ToString();   
        }
      
    }  
        
    
}
