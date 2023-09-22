using System;
using System.Text;
using System.Security.Cryptography;
using AnicStockControl.Exceptions;
using AnicStockControl.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Internal;
using System.Runtime.Remoting.Contexts;
using Microsoft.EntityFrameworkCore;

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
            Username = username.ToLower();
            Password = password.ToLower();
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
            Console.WriteLine("Initializing User Validation...");
            bool Validation = false;

            using (AnicStockControlContext context = new AnicStockControlContext())
            {
                Validation = context.Users.Any(u => u.Username == GetSHA256Hash(this.Username));

                if (Validation == true)
                {
                    Console.WriteLine("Validation Successful!!");
                }
                else
                {
                    Console.WriteLine("Validation Fail!");

                }
            }

            return Validation;
        }

        public bool Password_Validate()
        {

            Console.WriteLine("Initializing Password Validation...");
            bool Validate = false;

            using (AnicStockControlContext context = new AnicStockControlContext())
            {

                Validate = context.Users.Any(u => u.Password + u.Username == GetSHA256Hash(this.Password) + GetSHA256Hash(this.Username));

                if (Validate == true)
                {
                    Console.WriteLine("Validate Successful!!");
                }
                else
                {
                    Console.WriteLine("Validate Fail!");
                }


            }

            return Validate;
        }

        public void Insert_or_Change_Users()
        {
            Username = GetSHA256Hash(this.Username);
            Password = GetSHA256Hash(this.Password);

            using (AnicStockControlContext context = new AnicStockControlContext())
            {
                context.Users.Add(this);
                context.SaveChanges();
            }
        }
    }
}
