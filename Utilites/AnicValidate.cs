using AnicStockControl.Exceptions;
using System.Windows.Forms;

namespace AnicStockControl.Utilites
{
    internal static class AnicValidate
    {
        
        public static bool ValidateField(TextBox[] values)
        {
            bool aux = false;
            foreach (TextBox t in values)
            {
                int min = 3;
                int max = t.MaxLength;

                if (!string.IsNullOrEmpty(t.Text))
                {
                    if (t.Text.Length > min && t.Text.Length <= max)
                    {
                        aux = true;
                    }
                    else
                    {
                        aux = false;
                        throw new ValidateExceptions("Only Min " + min + " and Max " + max + " characters are allowed");
                    }
                }
                else
                {
                    aux = false;
                    throw new ValidateExceptions("The field its empty!");
                }
            }

            return aux;
        }


    }
}
