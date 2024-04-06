using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormuYeni
{
    public class KrediKarti : IOdemeTipi
    {
        public string Ode(double tutar)
        {
            return " Kredi karti " + tutar + "  ile ödendi";
        }
    }
}
