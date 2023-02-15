using System;
using AnicStockControl.Exceptions;
using static AnicStockControl.DataBase.DataBaseStockDataSet;
using AnicStockControl.DataBase.DataBaseStockDataSetTableAdapters;
using System.Threading.Tasks;

namespace AnicStockControl.Entities
{
    internal class Users
    {
        private String Frist_name { get; set; }
        private String Last_name { get; set; }
        public String Username { get; set; }
        public  String Password { get; set; }
        private usersTableAdapter usersTableAdapter = new usersTableAdapter();
        private usersDataTable usersTable = new usersDataTable();


        public Users()
        {

        }

        public bool Login_Validation(String username, String password)
        {
            
            if (username == "" || usersTableAdapter.Username_Validation(usersTable, username) != 1)
            {
                throw new LoginException("Username invalid!");
            }

            if (password == null || usersTableAdapter.Login_Validation(usersTable, username, password) != 1)
            {
                throw new LoginException("Password invalid!!");
            }


            return true;

        }
    }
}
