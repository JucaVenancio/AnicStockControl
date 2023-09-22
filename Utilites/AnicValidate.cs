using AnicStockControl.Entities;
using System.Windows.Forms;


namespace AnicStockControl.Utilites
{
    internal static class AnicValidate
    {
        
        public static bool ValidateFields(TextBox[] textBoxes, User user)
        {
            bool allFieldsValid = true;

            foreach (TextBox textbox in textBoxes) { RemoveErrorLabel(textbox); }

            foreach (TextBox textBox in textBoxes)
            {
                Label errorLabel = new Label();
                errorLabel = new Label();
                errorLabel.ForeColor = System.Drawing.Color.Red;
                errorLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                errorLabel.Location = new System.Drawing.Point(textBox.Left - 5, textBox.Bottom + 5);
                errorLabel.AutoSize = true;

                int min = 4;
                int max = textBox.MaxLength;

                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    errorLabel.Text = "Field cannot be blank";
                    allFieldsValid = false;
                }
                else if (textBox.Text.Length < min || textBox.Text.Length > max)
                {
                    errorLabel.Text = $"Must be between {min} and {max} characters";
                    allFieldsValid = false;
                }
                else if (user.User_Exists() && textBox.Name == "UsernameTextBox")
                {
                    errorLabel.Text = $"The username already exists" ;
                    allFieldsValid = false;
                }

                textBox.Parent.Controls.Add(errorLabel);
            }

            return allFieldsValid;
        }

        public static void RemoveErrorLabel(Control control) 
        {
            foreach(Control child in control.Parent.Controls)
            {
                if(child is Label && child.ForeColor == System.Drawing.Color.Red)
                {
                    control.Parent.Controls.Remove(child);
                    break;
                }
            }
            
        }

    }
}
