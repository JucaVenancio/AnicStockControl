using System;
using System.Windows.Forms;
using System.Linq;
using AnicStockControl.Exceptions;
using AnicStockControl.Entities;
using AnicStockControl.Utilites;
using AnicStockControl.Enums;
using Org.BouncyCastle.Bcpg;
using System.Runtime.CompilerServices;
using System.Linq.Expressions;

namespace AnicStockControl.Screens
{
    public partial class CreateNewUser : Form
    {
        public CreateNewUser()
        {
            InitializeComponent();
        }

        private void BtnBackHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            UserType userType = (UserType)this.UserTypeBox.SelectedIndex;
            this.UserTypeTextBox.Text = userType.ToString();

            TextBox[] Fields = new TextBox[] { FirstNameTextBox, LastNameTextBox, UsernameTextBox, PasswordTextBox, UserTypeTextBox };

            User user = new User(FirstNameTextBox.Text, LastNameTextBox.Text, UsernameTextBox.Text, PasswordTextBox.Text, UserTypeTextBox.Text);

            if (AnicValidate.ValidateFields(Fields, user))
            {
                user.Insert_or_Change_Users();
                MessageBox.Show($"User: {user.Firstname} {user.Lastname} \n---|Registered Successfully|---");
                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong, please check the fields and try again");
            }
        }

    }
}
