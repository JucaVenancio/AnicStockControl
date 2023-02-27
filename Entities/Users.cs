using AnicStockControl.DataBase.DataBaseStockDataSetTableAdapters;
using AnicStockControl.Exceptions;
using System;
using static AnicStockControl.DataBase.DataBaseStockDataSet;

namespace AnicStockControl.Entities
{
    internal class Users
    {
        public int Id_user { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        private usersTableAdapter usersTableAdapter = new usersTableAdapter();
        private usersDataTable usersTable = new usersDataTable();

        public Users()
        {
        
        }

        public bool Login_Validation(ref string  messageError)
        {
            if (Username != "" & Password != "")
            {
                if (usersTableAdapter.Username_Validation(usersTable, Username) != 1)
                {
                    messageError = "Username invalid!";
                    return false;
                }

                if (usersTableAdapter.Login_Validation(usersTable, Username, Password) != 1)
                {
                    messageError = "Password invalid!!";
                    return false;
                }
                
            }
            else
            {
                messageError = "Username or password are fields empty!";
                return false;
            }

            return true;

        }

        public bool Insert_or_Change_Users(ref string messageError)
        {

            if (First_name != "" & Last_name != "")
            {

                if (Login_Validation(ref messageError))
                {

                    usersTableAdapter.Insert_or_Change_Users(Id_user, First_name, Last_name, Username, Password, 0);
                    return true;
                }
                else
                {
                    usersTableAdapter.Insert_or_Change_Users(default, First_name, Last_name, Username, Password, 1);
                    return true;
                }
            }

            messageError = "First name or last name fields are empty";
            return false;
        }
        

    }
}
