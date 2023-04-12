using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv.Exceptions
{
    public class InvalidTitleException : Exception
    {
        public InvalidTitleException() { }

        public override string Message => "The book title must not be empty.";
    }
}
