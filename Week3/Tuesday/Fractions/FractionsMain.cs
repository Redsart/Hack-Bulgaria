using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    class FractionsMain
    {
        static void Main(string[] args)
        {
            Fraction a = new Fraction(3,4);
            Fraction b = new Fraction(5,7);
            Fraction c = new Fraction(9,9);
            
            Console.WriteLine(a*b+c);
        }
    }
}
