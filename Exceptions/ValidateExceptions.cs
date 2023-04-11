using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnicStockControl.Exceptions
{
    internal class ValidateExceptions : Exception
    {
        public ValidateExceptions(string message) : base(message)
        {

        }
    }
}
