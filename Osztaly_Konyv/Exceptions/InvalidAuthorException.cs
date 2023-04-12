using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv.Exceptions
{
    public class InvalidAuthorException : Exception
    {
        public InvalidAuthorException() { }

        public override string Message => "A szerző nevének legalább 6 karakter hosszúnak kell lennie";
    }
}
