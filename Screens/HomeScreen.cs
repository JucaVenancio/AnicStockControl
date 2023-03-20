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
            User user = new User { Username = UsernameTextBox.Text, Password = PasswordTextBox.Text };
            try
            {
                if (user.Login_Validation())
                {
                    MessageBox.Show("Deu certo!");


                }
                else
                {
                    MessageBox.Show("Deu errado!");
                }
             }catch (Exception ex) 
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
