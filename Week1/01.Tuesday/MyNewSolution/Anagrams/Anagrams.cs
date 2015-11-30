using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    class Anagrams
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first string: ");
            string strA = Console.ReadLine();
            Console.Write("Enter second string: ");
            string strB = Console.ReadLine();
        }

        private static Boolean IsAnagram(string strA, string strB)
        {
            bool check = true;
            char[] strToArray = strB.ToCharArray();
            foreach (var ch in strA)
            {
                if (!strToArray.Contains(ch))
                {
                    check = false;
                }
            }
            return check;
        }
    }
}
