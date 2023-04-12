using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv.Exceptions
{
    public class InvalidInventoryNumberException : InvalidBookException
    {
        public InvalidInventoryNumberException(string message) : base(message) { }
    }
}
