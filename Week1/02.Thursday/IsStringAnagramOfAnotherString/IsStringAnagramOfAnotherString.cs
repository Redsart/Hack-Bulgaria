using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsStringAnagramOfAnotherString
{
    class IsStringAnagramOfAnotherString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first string: ");
            string firstAnagram = Console.ReadLine();
            Console.Write("Enter second string: ");
            string secondAnagram = Console.ReadLine();

            Console.WriteLine(IsAnagram(firstAnagram,secondAnagram));
        }

        private static bool IsAnagram(string firstAnagram, string secondAnagram)
        {
            bool isAnagram = true;

            foreach (var ch in secondAnagram)
            {
                if (!firstAnagram.Contains(ch))
                {
                    isAnagram = false;
                }
            }
            return isAnagram;
        }
    }
}
