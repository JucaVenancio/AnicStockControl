using System;
using System.Text;
using System.Security.Cryptography;
using AnicStockControl.Exceptions;
using AnicStockControl.Data;
using AnicStockControl.Enums;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Internal;
using System.Runtime.Remoting.Contexts;
using Microsoft.EntityFrameworkCore;
using AnicStockControl.Screens;

namespace AnicStockControl.Entities
{
    public class User
    {
        public  int Id { get; private set; }
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }

        public string User_Type { get; private set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public User(string firstname, string lastname, string username, string password, string user_Type)
        {
            Firstname = firstname;
            Lastname = lastname;
            Username = username.ToLower();
            Password = password.ToLower();
            User_Type = user_Type;
        }
        

        public User()
        {
        }
        private static string GetSHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }
        public bool User_Exists()
        {
            Console.WriteLine("[Initializing user validation...]");
            bool Validation = false;

            using (AnicStockControlContext context = new AnicStockControlContext())
            {
                string hashedUsername = GetSHA256Hash(this.Username);

                Validation = context.Users.Any(u => u.Username == hashedUsername);

                if (Validation == true)
                {

                    Console.WriteLine("[Validation successful]");
                }
                else
                {
                    Console.WriteLine("[Validation fail]");

                }
            }

            return Validation;
        }

        public bool Password_Validate()
        {

            Console.WriteLine("[Initializing password validation...]");
            bool Validate = false;

            using (AnicStockControlContext context = new AnicStockControlContext())
            {
                string hashedUsernameAndPassword = GetSHA256Hash(this.Username) + GetSHA256Hash(this.Password);


                Validate = context.Users.Any(u => u.Username+ u.Password == hashedUsernameAndPassword);

                if (Validate == true)
                {
                    Console.WriteLine("[Validate successful]");
                }
                else
                {
                    Console.WriteLine("[Validate fail]");
                }


            }

            return Validate;
        }

        public void Insert_or_Change_Users()
        {
            Console.WriteLine("[Initializing insert or change user...]");

            Username = GetSHA256Hash(this.Username);
            Password = GetSHA256Hash(this.Password);
            using (AnicStockControlContext context = new AnicStockControlContext())
            { 
                context.Users.Add(this);
                context.SaveChanges();
                Console.WriteLine("[Insert or change done successful]");
            }
        }

        public User Login()
        {
            User user = new User();
            
                if (this.User_Exists() && this.Password_Validate())
                {
                    using (AnicStockControlContext context = new AnicStockControlContext())
                    {


                    var test = context.Users
                                .Where(u => u.Username == GetSHA256Hash(this.Username));
                    }
                    return user;
                }
                else
                {
                    throw new LoginExceptions("User not found!!");
                }

        }
    }
}
