using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummStringNumbers
{
    class SumStringNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine() + "v";

            SumOfNumbersInString(str);
        }

        private static void SumOfNumbersInString(string str)
        {
            int sum = 0;
            StringBuilder sb = new StringBuilder();
            List<int> numbers = new List<int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    sb.Append(str[i]);
                }
                else
                {
                    if (sb.Length>0)
                    {
                        numbers.Add(int.Parse(sb.ToString()));
                    }
                        sb.Clear();
                }
            }
            foreach (var n in numbers)
            {
                sum += n;
            }
            Console.WriteLine(sum);
        }
    }
}
