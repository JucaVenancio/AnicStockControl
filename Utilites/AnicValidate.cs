using AnicStockControl.Exceptions;
using System.Windows.Forms;

namespace AnicStockControl.Utilites
{
    internal static class AnicValidate
    {
        
        public static bool ValidateFields(TextBox[] textBoxes)
        {
            bool allFieldsValid = true;

            foreach (TextBox textBox in textBoxes)
            {
                Label errorLabel = new Label();
                errorLabel.ForeColor = System.Drawing.Color.Red;
                errorLabel.Font = new System.Drawing.Font(System.Drawing.Font, 7.8f);
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

                RemoveErrorLabel(textBox);
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
