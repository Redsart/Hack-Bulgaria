using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyEveryChar
{
    class CopyEveryChar
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some string: ");
            string input = Console.ReadLine();
            Console.Write("How many copyes of character you want: ");
            int k = int.Parse(Console.ReadLine());
            CopyEveryCharacter(input, k);
        }

        private static void CopyEveryCharacter(string input, int k)
        {
            string copy = "";
            StringBuilder sb = new StringBuilder();
            foreach (var ch in input)
            {
                copy = new string(ch, k);
                sb.Append(copy);
            }
            Console.WriteLine(sb);
        }
    }
}
