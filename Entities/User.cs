using System;
using System.Text;
using System.Security.Cryptography;
using AnicStockControl.Exceptions;
using AnicStockControl.Data;
using System.Linq;
using System.Windows.Forms;

namespace AnicStockControl.Entities
{
    public class User
    {
        public int Id { get; private set; }
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public User(string firstname, string lastname, string username, string password)
        {
            Firstname = firstname;
            Lastname = lastname;
            Username = username;
            Password = password;
        }
        private static string GetSHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x23"));
                }

                return sb.ToString();
            }
        }
        public bool User_Exists()
        {
            using (AnicStockControlContext context = new AnicStockControlContext())
            {
                User user = context.Users.FirstOrDefault(u => u.Username == GetSHA256Hash(this.Username));
                bool Validation = false;
                if (!String.IsNullOrEmpty(user.Username))
                {
                    /*context.RecordUserActions.Add(new RecordUserAction
                    {
                        UserId = Id,
                        Action = "Login",
                        Date = DateTime.Now
                    });
                    context.SaveChanges();*/
                    Validation = true;
                }
                else
                {
                    Validation = false;
                }

                return Validation;
            }

            
        }

        public bool Insert_or_Change_Users()
        {

            if (User_Exists())
            {
                using (AnicStockControlContext context = new AnicStockControlContext())
                {
                    context.Users.Add(this);
                    context.SaveChanges();
                    return true;
                }
            }
            else
            {
                throw new ValidateExceptions("The username already exists!");
            }
        }

    }
}
