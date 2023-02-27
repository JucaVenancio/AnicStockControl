using System;
using System.Windows.Forms;
using System.Linq;
using AnicStockControl.Exceptions;
using AnicStockControl.Entities;

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
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (!f.Visible)
                {
                    f.Show();
                }
            }

            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Users user = new Users { First_name = NameTextBox.Text, Last_name = NameTextBox.Text, Username = UsernameTextBox.Text, Password = PasswordTextBox.Text };
            string MessageError = "";

            try
            {
                if (user.Insert_or_Change_Users(ref MessageError))
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                }
                throw new LoginException(MessageError);
            }
            catch (LoginException ex)
            {
                ErrorLabel.Text = ex.Message;
                ErrorLabel.Visible = true;
            }
        }
    }
}
