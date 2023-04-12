using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv.Exceptions
{
    public class InvalidLanguageException : Exception
    {
        public InvalidLanguageException()
        {

        }
        public override string Message => "A nyelv mező nem lehet üres!";
    }
}
