using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv.Exceptions
{
    internal class InvalidEnciklo : Exception
    {
        public InvalidEnciklo() { }

        public override string Message => "Nem megfelelő tipus (true vagy false)!";
    }
}
