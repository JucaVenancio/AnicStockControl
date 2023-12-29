using AnicStockControl.Entities;
using System.Windows.Forms;

namespace AnicStockControl.Screens
{
    partial class CreateNewUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewUser));
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserTypeTextBox = new System.Windows.Forms.TextBox();
            this.RegisterGroupBox = new System.Windows.Forms.GroupBox();
            this.UserTypeLabel = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnBackHome = new System.Windows.Forms.Button();
            this.UserTypeBox = new System.Windows.Forms.ComboBox();
            this.RegisterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserTypeBox
            // 
            UserTypeBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            UserTypeBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            UserTypeBox.Cursor = System.Windows.Forms.Cursors.Hand;
            UserTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            UserTypeBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            UserTypeBox.ForeColor = System.Drawing.SystemColors.InfoText;
            UserTypeBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            UserTypeBox.ItemHeight = 25;
            UserTypeBox.Items.AddRange(new object[] {
            "ADMIN",
            "MANAGER",
            "COMMON"});
            UserTypeBox.Location = new System.Drawing.Point(291, 212);
            UserTypeBox.Name = "UserTypeBox";
            UserTypeBox.Size = new System.Drawing.Size(114, 33);
            UserTypeBox.TabIndex = 10;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(-5, 153);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(110, 25);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(295, 153);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(106, 25);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(37, 74);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(68, 25);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(286, 70);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(115, 25);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstNameTextBox.Location = new System.Drawing.Point(111, 74);
            this.FirstNameTextBox.MaxLength = 10;
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(142, 23);
            this.FirstNameTextBox.TabIndex = 4;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastNameTextBox.Location = new System.Drawing.Point(407, 72);
            this.LastNameTextBox.MaxLength = 10;
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(142, 23);
            this.LastNameTextBox.TabIndex = 5;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTextBox.Location = new System.Drawing.Point(111, 155);
            this.UsernameTextBox.MaxLength = 10;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(142, 23);
            this.UsernameTextBox.TabIndex = 6;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Location = new System.Drawing.Point(407, 155);
            this.PasswordTextBox.MaxLength = 8;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(142, 23);
            this.PasswordTextBox.TabIndex = 7;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // RegisterGroupBox
            // 
            this.RegisterGroupBox.Controls.Add(this.UserTypeLabel);
            this.RegisterGroupBox.Controls.Add(UserTypeBox);
            this.RegisterGroupBox.Controls.Add(this.FirstNameLabel);
            this.RegisterGroupBox.Controls.Add(this.BtnSave);
            this.RegisterGroupBox.Controls.Add(this.FirstNameTextBox);
            this.RegisterGroupBox.Controls.Add(this.PasswordTextBox);
            this.RegisterGroupBox.Controls.Add(this.UsernameTextBox);
            this.RegisterGroupBox.Controls.Add(this.BtnBackHome);
            this.RegisterGroupBox.Controls.Add(this.LastNameTextBox);
            this.RegisterGroupBox.Controls.Add(this.LastNameLabel);
            this.RegisterGroupBox.Controls.Add(this.PasswordLabel);
            this.RegisterGroupBox.Controls.Add(this.UsernameLabel);
            this.RegisterGroupBox.Controls.Add(this.UserTypeTextBox);
            this.RegisterGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterGroupBox.Location = new System.Drawing.Point(12, 23);
            this.RegisterGroupBox.Name = "RegisterGroupBox";
            this.RegisterGroupBox.Size = new System.Drawing.Size(608, 349);
            this.RegisterGroupBox.TabIndex = 9;
            this.RegisterGroupBox.TabStop = false;
            // 
            // UserTypeLabel
            // 
            this.UserTypeLabel.AutoSize = true;
            this.UserTypeLabel.Location = new System.Drawing.Point(173, 212);
            this.UserTypeLabel.Name = "UserTypeLabel";
            this.UserTypeLabel.Size = new System.Drawing.Size(112, 25);
            this.UserTypeLabel.TabIndex = 11;
            this.UserTypeLabel.Text = "User Type";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(6, 283);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(148, 45);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "SAVE";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnBackHome
            // 
            this.BtnBackHome.Location = new System.Drawing.Point(448, 283);
            this.BtnBackHome.Name = "BtnBackHome";
            this.BtnBackHome.Size = new System.Drawing.Size(154, 45);
            this.BtnBackHome.TabIndex = 8;
            this.BtnBackHome.Text = "BACK HOME";
            this.BtnBackHome.UseVisualStyleBackColor = true;
            this.BtnBackHome.Click += new System.EventHandler(this.BtnBackHome_Click);
            // 
            // UserTypeTextBox
            // 
            this.UserTypeTextBox.Location = new System.Drawing.Point(0, 0);
            this.UserTypeTextBox.Name = "UserTypeTextBox";
            this.UserTypeTextBox.Size = new System.Drawing.Size(100, 22);
            this.UserTypeTextBox.TabIndex = 0;
            this.UserTypeTextBox.Location = UserTypeBox.Location;
            this.UserTypeTextBox.Hide();
            // 
            // CreateNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(640, 396);
            this.Controls.Add(this.RegisterGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "CreateNewUser";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New User";
            this.RegisterGroupBox.ResumeLayout(false);
            this.RegisterGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UserTypeTextBox;
        private System.Windows.Forms.GroupBox RegisterGroupBox;
        private System.Windows.Forms.Button BtnBackHome;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label UserTypeLabel;
        private System.Windows.Forms.ComboBox UserTypeBox;
    }
}