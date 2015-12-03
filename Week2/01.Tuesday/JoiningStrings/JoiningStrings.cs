using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoiningStrings
{
    class JoiningStrings
    {
        static void Main(string[] args)
        {
            string[] strings = { "this", "yes", "draenai", "human" };
            string separator = ", ";
            Console.WriteLine(JoinStrings(separator,strings));
        }

        private static string JoinStrings(string separator, params string[] strings)
        {
            string joined="";
            for (int i = 0; i < strings.Length; i++)
            {
                joined = String.Join(separator, strings);
            }
            return joined;
        }
    }
}
