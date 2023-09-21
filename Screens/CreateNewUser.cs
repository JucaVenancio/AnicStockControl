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

            if (AnicValidate.ValidateFields(Fields)) 
            {
                User user = new User(Fields[0].Text, Fields[1].Text, Fields[2].Text, Fields[3].Text);

                if (user.Insert_or_Change_Users())
                {
                    MessageBox.Show($"User: {user.Firstname} {user.Lastname} \n---|Registered Successfully|---");

                }
                else
                {
                    MessageBox.Show("Teste");
                }
            }
        }

    }
}
