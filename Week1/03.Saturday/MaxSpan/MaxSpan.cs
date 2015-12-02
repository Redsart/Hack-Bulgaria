using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSpan
{
    class MaxSpan
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 4, 2, 1, 4, 1, 4 };

            Console.WriteLine("MaxSpan = {0}",MaxSpann(numbers));
        }

        private static int MaxSpann(List<int> numbers)
        {
            int counter = 0;
            for (int i = 0; i < numbers.ToArray().Length / 2; i++)
            {
                counter++;
            }
            if (numbers.ToArray().Length==1)
            {
                counter = 1;
            }
            else
            {
                counter *= 2;
            }
            return counter;
        }
    }
}
