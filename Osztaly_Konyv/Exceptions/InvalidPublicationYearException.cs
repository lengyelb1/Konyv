using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv.Exceptions
{
    public class InvalidPublicationYearException : Exception
    {
        public InvalidPublicationYearException()
        {

        }
        public override string Message => $"Az évnek -10000 és {DateTime.Now.Year} között kell lennie.";
    }
}
