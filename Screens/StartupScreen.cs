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

        private void StartupScreen_Load(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (!(fc.Count > 2))
                {
                    MessageBox.Show("Teste start");
                }
            }
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.Show();
        }

        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateNewUser createNewUser = new CreateNewUser();
            createNewUser.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
