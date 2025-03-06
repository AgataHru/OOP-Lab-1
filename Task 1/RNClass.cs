using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumbers
{
    public class RNClass
    {

        public int Numerator { get; }
        public int Denominator { get; }

        static int GCD(int a, int b)
        {
            int temp = 0;

            while (b!=0)
            {
                temp = b;
                b = a % b;
                a = temp;
            }

            return Math.Abs(a);
        }

        public RNClass(int numerator, int denominator)
        {
            if (denominator == 0) { throw new ArgumentException("Denominator cannot be zero!!!"); }
            
            if (denominator < 0)
            {
                denominator = -denominator;
                numerator = -numerator;
            }

            int gcd= GCD(numerator, denominator);

            Numerator = numerator/gcd;
            Denominator = denominator/gcd;
        }
        override public string ToString()
        {
            if (Denominator == 1)
                return $"{Numerator}";
            return $"{Numerator}/{Denominator}";
        }

        public static RNClass operator +(RNClass rn1, RNClass rn2)
        {
            int numenator = rn1.Numerator*rn2.Denominator + rn2.Numerator*rn1.Denominator;
            int denominator = rn1.Denominator * rn2.Denominator;

            return new RNClass(numenator,denominator);
        }

        public static RNClass operator -(RNClass rn1, RNClass rn2)
        {
            int numenator = rn1.Numerator * rn2.Denominator - rn2.Numerator * rn1.Denominator;
            int denominator = rn1.Denominator * rn2.Denominator;

            return new RNClass(numenator, denominator);
        }

        public static RNClass operator *(RNClass rn1, RNClass rn2)
        {
            int numerator = rn1.Numerator * rn2.Numerator;
            int denominator = rn1.Denominator * rn2.Denominator;

            return new RNClass(numerator, denominator);
        }

        public static RNClass operator /(RNClass rn1, RNClass rn2)
        {
            int numerator = rn1.Numerator * rn2.Denominator;
            int denominator = rn1.Denominator * rn2.Numerator;

            return new RNClass(numerator, denominator);
        }

        public static RNClass operator -(RNClass rn)
        {
            return new RNClass(-rn.Numerator, rn.Denominator);
        }

        public static bool operator ==(RNClass rn1, RNClass rn2)
        {
            return (rn1.Numerator==rn2.Numerator)&&(rn1.Denominator==rn2.Denominator);
        }

        public static bool operator !=(RNClass rn1, RNClass rn2)
        {
            return !(rn1.Numerator == rn2.Numerator) && (rn1.Denominator == rn2.Denominator);
        }

        public static bool operator <(RNClass rn1, RNClass rn2)
        {
            return rn1.Numerator * rn2.Denominator < rn2.Numerator * rn1.Denominator;
        }

        public static bool operator <=(RNClass rn1, RNClass rn2)
        {
            return rn1.Numerator * rn2.Denominator <= rn2.Numerator * rn1.Denominator;
        }

        public static bool operator >(RNClass rn1, RNClass rn2)
        {
            return rn1.Numerator * rn2.Denominator > rn2.Numerator * rn1.Denominator;
        }

        public static bool operator >=(RNClass rn1, RNClass rn2)
        {
            return rn1.Numerator * rn2.Denominator >= rn2.Numerator * rn1.Denominator;
        }
    }
}
