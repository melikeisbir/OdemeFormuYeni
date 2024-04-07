using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormuYeni
{
    public class ApplePay : IOdemeTipi
    {
        public string Ode(double tutar)
        {
            return " Apple Pay ile " + tutar + " TL ödeme yapıldı";
        }
    }
}
