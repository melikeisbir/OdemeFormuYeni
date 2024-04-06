using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormuYeni
{
    public class Paypal : IOdemeTipi
    {
        public string Ode(double tutar)
        {
            return " Paypal " + tutar + "  ile ödendi";
        }
    }
}
