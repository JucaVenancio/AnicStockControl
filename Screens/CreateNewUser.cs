using System;
using System.Windows.Forms;
using System.Linq;
using AnicStockControl.Exceptions;
using AnicStockControl.Entities;
using AnicStockControl.Utilites;

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
            TextBox[] Fields = new TextBox[] { FirstNameTextBox, LastNameTextBox, UsernameTextBox, PasswordTextBox };

            User user = new User(FirstNameTextBox.Text, LastNameTextBox.Text, UsernameTextBox.Text, PasswordTextBox.Text);

            if (AnicValidate.ValidateFields(Fields, user)) 
            {
                user.Insert_or_Change_Users();
                MessageBox.Show($"User: {user.Firstname} {user.Lastname} \n---|Registered Successfully|---");
            }
        }

    }
}
