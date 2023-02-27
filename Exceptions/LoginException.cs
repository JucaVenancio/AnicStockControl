using System;

namespace AnicStockControl.Exceptions
{
    internal class LoginException : Exception
    {
        public LoginException(string message) : base(message)
        {

        }
    }
}
