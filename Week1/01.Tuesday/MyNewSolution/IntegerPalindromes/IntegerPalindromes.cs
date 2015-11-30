using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerPalindromes
{
    class IntegerPalindromes
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(IsIntPalindrome(n));
            GetLargestPalindrome(n);
        }

        private static bool IsIntPalindrome(int n)
        {
            if (n.ToString()==new string(n.ToString().Reverse().ToArray()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void GetLargestPalindrome(int n)
        {
            int next = n + 1;
            if (n.ToString()==new string(n.ToString().Reverse().ToArray()))
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine(n+1);
            }
            
        }
    }
}
