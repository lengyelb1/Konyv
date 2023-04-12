using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv.Exceptions
{
    internal class InvalidEbook:Exception
    {
        public InvalidEbook() { }
        public override string Message => "Nem megfelő bemenet (i vagy n)!";

    }
}
