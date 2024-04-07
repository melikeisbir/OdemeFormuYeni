using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace OdemeFormuYeni
{
    public class OdemeIslemiFactory
    {
        public IOdemeTipi NesneOlustur(string classAdi)
        {
            var yeniNesne = Assembly.GetAssembly(typeof(IOdemeTipi)).CreateInstance("OdemeFormuYeni." + classAdi); //proje içinde class adı 
            return (IOdemeTipi)yeniNesne;
        }
    }
}
