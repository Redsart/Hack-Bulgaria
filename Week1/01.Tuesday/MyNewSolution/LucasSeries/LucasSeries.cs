using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasSeries
{
    class LucasSeries
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[] series = new int[n];
            series[0] = 2;
            series[1] = 1;

            for (int i = 0; i < series.Length; i++)
            {
                if (i > 1)
                {
                    series[i] = series[i - 1] + series[i - 2];
                }
                Console.Write("{0} ",series[i]);
                Console.WriteLine();
            }
        }
    }
}
