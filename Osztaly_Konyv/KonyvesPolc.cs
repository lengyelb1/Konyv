using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv
{
    public class KonyvesPolc
    {
        List<Konyv> _konyvek=new List<Konyv>();
        Dictionary<int,Konyv> _konyvekDic = new Dictionary<int,Konyv>();
        public void konyvHozzaAdasa(Konyv konyv)
        {
            _konyvek.Add(konyv);
            for (int i = 0; i < _konyvek.Count; i++)
            {
                if(_konyvek[i] == konyv)
                {
                    _konyvekDic.Add(i, konyv);
                    break;
                }
            }
            
        }

        public void konyvSelejtezese(Konyv konyv)
        {
            _konyvek.Remove(konyv);
        }

        public int konyvekSzama
        {
            get { return _konyvek.Count;}
        }

        public int konyvekSzamaFuggveny()
        {
            return _konyvek.Count;
        
        }

        public int konyvekSzamaFuggvenyDic()
        {
            return _konyvekDic.Count;
        }
        //public KonyvesPolc() { }

    }
}
