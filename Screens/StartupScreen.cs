using System;
using System.Windows.Forms;

namespace AnicStockControl.Screens
{
    public partial class StartupScreen : Form
    {
        public StartupScreen()
        { 
            InitializeComponent();
            
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.FormClosed += (s, args) => this.Show();
            homeScreen.Show();
        }

        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateNewUser createNewUser = new CreateNewUser();
            createNewUser.FormClosed+= (s, args) => this.Show();
            createNewUser.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
