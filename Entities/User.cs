using System;
using System.Text;
using System.Security.Cryptography;
using AnicStockControl.Exceptions;
using MySql.Data.MySqlClient;
using AnicStockControl.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AnicStockControl.Entities
{
    public class User
    {
        public int Id_user { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        private static readonly string ConnectionString = "server=localhost;user id=Developer;password=192837;database=db_anicstockcontrol";
        private MySqlConnection Connection { get; set; } = new MySqlConnection(ConnectionString);
        private MySqlCommand Command { get; set; }
        public User()
        {
        
        }

        private static string GetSHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sb = new StringBuilder();

                for(int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }
        public bool Login_Validation()
        {
            using (AnicStockControlContext context = new AnicStockControlContext())
            {
                
                    if (context.Users.FirstOrDefault(u => u.Username == GetSHA256Hash(Username) && u.Password == GetSHA256Hash(Password)) != null)
                {
                    context.RecordUserActions.Add(new RecordUserAction
                    {
                        UserId = Id_user,
                        Action = "Login",
                        Date = DateTime.Now
                    });
                    context.SaveChanges();
                    return true;

                }
                else
                {
                    throw new LoginException("Username or password is invalid!!");
                }
            }
        }

        public bool Insert_or_Change_Users()
        {
            
                    string messageError = "User already registered!!";
                    return false;
              
        }
        

    }
}
