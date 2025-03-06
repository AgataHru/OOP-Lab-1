using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumbers
{
    internal class TimePrinterDecorator : TimePrinter
    {
        protected TimePrinter timePrinter;

        public TimePrinterDecorator(TimePrinter got)
        {
            timePrinter = got;
        }
        virtual public void Print() 
        { 
            timePrinter.Print();
        }
    }
}
