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
            List<int> list = new List<int> { 2, 4, 6, 8, 10 };
            ReverseList(list);
        }

        private static void ReverseList(List<int> list)
        {
            List<int> reversed = new List<int>();
            for (int i = list.ToArray().Length-1; i >= 0 ; i--)
            {
                reversed.Add(list[i]);
            }
            list=reversed;
            Console.WriteLine(string.Join(", ",reversed));
        }
    }
}
