using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int result = Factrial(5);
            Console.WriteLine(result);

            int recursionResult = FactorialWithRecursion(5);
            Console.WriteLine(recursionResult);
        }

        public static int Factrial(int n)
        {
            int result = 1;
            for (int i = 1; i < n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static int FactorialWithRecursion(int n)
        {
            int result = 1;
            for (int i = 1; i < n; i++)
            {
                if (result==1)
                {
                    result = 1;
                }
                result = FactorialWithRecursion(i)*i;
            }
            return result;
        }
    }
}
