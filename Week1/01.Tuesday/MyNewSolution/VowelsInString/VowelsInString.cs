using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsInString
{
    class VowelsInString
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter some string: ");
            string str = Console.ReadLine();

            int result = CountVowels(str);
            Console.WriteLine("CountVowels ({0}) = {1}", str, result);
            
        }

        private static int CountVowels(string str)
        {
            int counter = 0;
            foreach (var ch in str)
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'y') // aeiouy
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
