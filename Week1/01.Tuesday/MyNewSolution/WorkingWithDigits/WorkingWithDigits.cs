using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithDigits
{
    class WorkingWithDigits
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            string str = n.ToString();
            Console.WriteLine("n cointains {0} numbers", str.Length);

            int sumDigits = SumDigits(n);
            Console.WriteLine("The sum of all digits is: {0}",sumDigits);

            int factorialDigits = FactorialDigits(n);
            Console.WriteLine("The sum of factorials of all digits is: {0}",factorialDigits);
        }

        public static int SumDigits(int n)
        {
            string str = n.ToString();
            int sum = 0;
            foreach (var ch in str)
            {
                sum += ch - '0';
            }
            return sum;
        }

        public static int FactorialDigits(int n)
        {
            string str = n.ToString();
            int sum = 0;

            foreach (var ch in str)
            {
                int result = 1;
                for (int i = 1; i < ch - '0'; i++) // this loop find Factorial of current digit
                {
                    result *= i;
                }
                sum += result;
            }
            return sum;
        }
    }
}
