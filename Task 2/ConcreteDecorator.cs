using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumbers
{
    internal class ConcreteDecorator : TimePrinterDecorator
    {
        protected string expressionString;

        public ConcreteDecorator(string stringGot, TimePrinter got) : base (got)
        {
            expressionString = stringGot;
            timePrinter = got;
        }

        public override void Print() 
        { 
            var sb = new StringBuilder();
            sb.Append(expressionString);
            sb.Append(timePrinter.ToString());
            sb.Append(expressionString);

            Console.WriteLine(sb.ToString());
        }
    }
}
