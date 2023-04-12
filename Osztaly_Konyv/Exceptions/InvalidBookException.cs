using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv.Exceptions
{
    public class InvalidBookException : Exception
    {
        public InvalidBookException(string message) : base(message) { }


    }
}
