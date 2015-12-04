using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateSums
{
    class DateSums
    {
        static void Main(string[] args)
        {
            int value=int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int sum=0;

            DateTime start = new DateTime(year, 1, 1);
            DateTime end = new DateTime(year, 12, 31);

            for (DateTime current = start; current <= end; current = current.AddDays(1))
            {
                if (current.Day + current.Month + current.Year==value)
                {
                    Console.WriteLine(current);
                }
            }
        }
    }
}
