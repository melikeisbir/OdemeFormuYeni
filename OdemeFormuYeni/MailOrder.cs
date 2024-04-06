using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormuYeni
{
    public class MailOrder : IOdemeTipi
    {
        public string Ode(double tutar)
        {
            return " Mail Order " + tutar + "  ile ödendi";
        }
    }
}
