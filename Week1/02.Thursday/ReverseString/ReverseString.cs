using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string original = Console.ReadLine();
            ReverseMe(original);
        }

        private static void ReverseMe(string original)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = original.Length; i > 0; i--)
            {
                sb.Append(original[i-1]);
            }
            string reversed = sb.ToString();
            Console.WriteLine("Reversed string is: {0}",reversed);
        }
    }
}
