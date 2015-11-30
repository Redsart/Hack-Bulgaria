using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharHistogram
{
    class CharHistograms
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            CharHistogram(str);
            Console.WriteLine();
        }

        private static void CharHistogram(string str)
        {
            Dictionary<char,int> dict=new Dictionary<char,int>();
            foreach (var item in str)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item] += 1;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }

            int counter = 0;
            Console.Write("{ ");
            foreach (var ch in dict)
            {
                if (counter==dict.Count()-1)
                {
                    Console.Write("'" + ch.Key + "'" + ": " + ch.Value + " }");
                }
                else
                {
                    Console.Write("'" + ch.Key + "'" + ": " + ch.Value + ", ");
                }
                counter++;
            }
        }
    }
}
