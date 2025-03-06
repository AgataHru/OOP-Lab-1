using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumbers
{
    internal class EuropTimePrinter : TimePrinter
    {
        public void Print() 
        {
            var cultureInfo = new CultureInfo("es-ES");
            Console.WriteLine(DateTime.Now.ToString(cultureInfo));
        }

        public override string ToString() 
        {
            var cultureInfo = new CultureInfo("es-ES");
            return DateTime.Now.ToString(cultureInfo);
        }
    }
}
