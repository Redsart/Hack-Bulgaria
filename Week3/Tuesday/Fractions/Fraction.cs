using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    public class Fraction
    {
        private double num;
        private double denom;

        public Fraction(double num, double denom)
        {
            this.num = num;
            this.denom = denom;
            if (this.denom == 0)
            {
                throw new ArgumentException("Denominator cannot be 0");
            }
        }

        public double Numerator
        {
            get
            {
                return this.num;
            }
            private set
            {
                this.num = value;
            }
        }

        public double Denominator
        {
            get
            {
                return this.denom;
            }
            set
            {
                this.denom = value;
            }
        }

        // + operator
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction((a.num * b.denom) + a.denom + b.num,a.denom * b.denom);
        }

        // - operator
        public static Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.denom - a.denom + b.num, a.denom * b.denom);
        }

        // * operator
        public static Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.denom, a.denom * b.num);
        }

        // / operator
        public static Fraction operator /(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.denom, a.denom * b.num);
        }

        // + double operator
        public static double operator +(Fraction a, double b)
        {
            double current = a.num / a.denom;
            double result = current + b;
            return result;
        }

        // - double operator
        public static double operator -(Fraction a, double b)
        {
            double current = a.num / a.denom;
            double result = current - b;
            return result;
        }

        // * double operator
        public static double operator *(Fraction a, double b)
        {
            double current = a.num / a.denom;
            double result = current * b;
            return result;
        }

        // / double operator
        public static double operator /(Fraction a, double b)
        {
            double current = a.num / a.denom;
            double result = current / b;
            return result;
        }

        public static explicit operator double(Fraction frac)
        {
            double b = frac.num / frac.denom;
            return b;
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            bool result = false;
            if (Object.ReferenceEquals(a, b))
            {
                return true;
            }
            if (a.num == b.num && a.denom == b.denom)
            {
                result = true;
            }

            return result;
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            bool equals = false;
            if (this is Fraction && obj is Fraction)
            {
                Fraction obj1 = this;
                Fraction obj2 = (Fraction)obj;
                if (((float)obj1.num / obj1.denom) == ((float)obj2.num / obj2.denom))
                {
                    equals = true;
                }
            }
            return equals;
        }

        public override string ToString()
        {
            return String.Format("{0} / {1}",num.ToString(),denom.ToString());
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + num.GetHashCode();
                hash = hash * 23 + denom.GetHashCode();
                return hash;
            }
        }
    }
}
