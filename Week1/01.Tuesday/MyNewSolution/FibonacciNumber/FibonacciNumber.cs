using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumber
{
    class FibonacciNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int n =int.Parse(Console.ReadLine());
            int result = FibNumber(n);
        }

        private static int FibNumber(int n)
        {
            int firstNumber = 1;
            int secondNumber = 1;
            int sum;
            for (int i = 0; i < n; i++)
            {
                Console.Write(firstNumber);
                sum = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = sum;
            }
            return firstNumber;
        }
    }
}
