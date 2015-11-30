using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(n));
            Console.Write("List of first prime numbers: ");
            ListFirstPrimes(n);
            Console.WriteLine();
            Console.WriteLine("Sieve of Eratosthenes: ");
            SieveOfEratosthenes(n);
            Console.WriteLine();
        }

        private static bool IsPrime(int n)
        {
            bool numberIsPrime = true;
            if (n > 0)
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        numberIsPrime = false;
                    }
                }
            }
            else
            {
                Console.WriteLine("Number must be possitive!");
            }
            return numberIsPrime;
        }

        private static void ListFirstPrimes(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write("{0} ",i);
                }
            }
        }

        private static void SieveOfEratosthenes(int n)
        {
            List<int> EratosthenesList = new List<int>();
            for (int i = 2; i < n; i++)
            {
                for (int j = i*2; j < n; j+=i)
                {
                    if (!EratosthenesList.Contains(j))
                    {
                        EratosthenesList.Add(j);
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (!EratosthenesList.Contains(i))
                {
                    Console.Write(i);
                }
            }
        }
    }
}
