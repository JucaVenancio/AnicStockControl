using AnicStockControl.Entities;
using System.Windows.Forms;

namespace AnicStockControl
{
    partial class HomeScreen
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.Login = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnChangePassword = new System.Windows.Forms.Button();
            this.BtnNewUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.Black;
            this.Login.Location = new System.Drawing.Point(412, 143);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(71, 22);
            this.Login.TabIndex = 0;
            this.Login.Text = "LOGIN";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTextBox.Location = new System.Drawing.Point(363, 292);
            this.UsernameTextBox.MaxLength = 15;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.ShortcutsEnabled = false;
            this.UsernameTextBox.Size = new System.Drawing.Size(128, 23);
            this.UsernameTextBox.TabIndex = 2;
            this.UsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.Location = new System.Drawing.Point(363, 343);
            this.PasswordTextBox.MaxLength = 8;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.ShortcutsEnabled = false;
            this.PasswordTextBox.Size = new System.Drawing.Size(128, 23);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UsernameLabel.Location = new System.Drawing.Point(271, 294);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(86, 16);
            this.UsernameLabel.TabIndex = 4;
            this.UsernameLabel.Text = "USERNAME";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PasswordLabel.Location = new System.Drawing.Point(270, 345);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(87, 16);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "PASSWORD";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnLogin.Location = new System.Drawing.Point(261, 416);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(127, 39);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "ENTER";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnChangePassword
            // 
            this.BtnChangePassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangePassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnChangePassword.Location = new System.Drawing.Point(723, 447);
            this.BtnChangePassword.Name = "BtnChangePassword";
            this.BtnChangePassword.Size = new System.Drawing.Size(114, 41);
            this.BtnChangePassword.TabIndex = 8;
            this.BtnChangePassword.Text = "CHANGE PASSWORD";
            this.BtnChangePassword.UseVisualStyleBackColor = false;
            this.BtnChangePassword.Click += new System.EventHandler(this.BtnChangePassword_Click);
            // 
            // BtnNewUser
            // 
            this.BtnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewUser.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnNewUser.Location = new System.Drawing.Point(41, 447);
            this.BtnNewUser.Name = "BtnNewUser";
            this.BtnNewUser.Size = new System.Drawing.Size(114, 41);
            this.BtnNewUser.TabIndex = 7;
            this.BtnNewUser.Text = "NEW USER";
            this.BtnNewUser.UseVisualStyleBackColor = true;
            this.BtnNewUser.Click += new System.EventHandler(this.BtnNewUser_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(876, 500);
            this.Controls.Add(this.BtnChangePassword);
            this.Controls.Add(this.BtnNewUser);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.Login);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HomeScreen";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anic Stock Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
         
        private Label Login;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private Button BtnLogin;
        private Button BtnChangePassword;
        private Button BtnNewUser;
    }
}

