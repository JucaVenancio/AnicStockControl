using AnicStockControl.Entities;
using AnicStockControl.Exceptions;
using AnicStockControl.Screens;
using System;
using System.Windows.Forms;

namespace AnicStockControl
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();

        }



        private void BtnLogin_Click(object sender, EventArgs e)
        {
            User = new Users { Username = UsernameTextBox.Text, Password = PasswordTextBox.Text };
            string MessageError = "";

            try
            {

                if(!User.Login_Validation(ref MessageError))
                {
                   throw new LoginException(MessageError);
                }
                MessageBox.Show("Deu certo");
            }
            catch (LoginException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            
            CreateNewUser createNewUsser =  new CreateNewUser();
            createNewUsser.Show();
            this.Close();
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {

        }
    }
}
