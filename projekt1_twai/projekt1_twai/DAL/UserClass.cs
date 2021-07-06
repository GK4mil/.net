using projekt1_twai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace projekt1_twai.DAL
{
    public class UserClass
    {
        private UserContext uc = new UserContext();

        public bool Logging(String username, String password)
        {
            password = CreateMD5(password);
            
            var result = uc.us.FirstOrDefault(a => a.Username == username);
            if (result != null)
            {
                if (result.Password == password)
                    return true;
                else
                    return false;
            }
            else
                return false;


        }

        public bool AddUser(string us, string pass)
        {
            var result = uc.us.FirstOrDefault(a => a.Username == us);
            if (result != null)
            {
                return false;
            }
            else
            {
                uc.us.Add(new User() { Username = us, Password = CreateMD5(pass) });
                uc.SaveChanges();
                return true;
            }
        }

        private string CreateMD5(string input)
        {
            if (input != null)
            {
                // Use input string to calculate MD5 hash
                using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
                {
                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);

                    // Convert the byte array to hexadecimal string
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < hashBytes.Length; i++)
                    {
                        sb.Append(hashBytes[i].ToString("X2"));
                    }
                    return sb.ToString();
                }
            }
            else
                return null;
        }
    }
}