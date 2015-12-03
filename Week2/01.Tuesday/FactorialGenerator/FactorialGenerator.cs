using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialGenerator
{
    class FactorialGenerator
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(String.Join(", ",GenerateFactorials(n)));
        }

        private static IEnumerable<int> GenerateFactorials(int n)
        {
            int generate = 0;
            int current = 1;
            for (int i = 1; i <= n; i++)
            {
                current++;
                generate = Factorial(current);
                yield return generate;
            }
        }

        public static int Factorial(int current)
        {
            int result = 1;
            for (int i = 1; i < current; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
