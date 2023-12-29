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
            User user = new User(UsernameTextBox.Text, PasswordTextBox.Text);                
              

        }

        private void BtnBackHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {

        }
    }
}
