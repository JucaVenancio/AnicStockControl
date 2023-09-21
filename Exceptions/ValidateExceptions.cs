using System;

namespace AnicStockControl.Exceptions
{
    internal class ValidateExceptions : Exception
    {
        public ValidateExceptions(string message) : base(message)
        {

        }
    }
}
