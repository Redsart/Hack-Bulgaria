using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsonantsInString
{
    class ConsonantsInString
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter some string: ");
            string str = Console.ReadLine();

            int result = CountConsonants(str);
            Console.WriteLine("CountConsonats ({0}) = {1}", str, result);
        }

        private static int CountConsonants(string str)
        {
            int counter = 0;
            foreach (var ch in str)
            {
                if (ch != 'a' && ch != 'e' && ch != 'i' && ch != 'o' && ch != 'u' && ch != 'y') // aeiouy
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
