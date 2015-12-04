using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayThe_13th
{
    class Friday
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program return every Friday 13ths.");
            Console.Write("Enter start year: ");
            int startYear=int.Parse(Console.ReadLine());
            DateTime start = new DateTime(startYear, 1, 1);
            Console.Write("Enter end year: ");
            int endYear = int.Parse(Console.ReadLine());
            DateTime end = new DateTime(endYear, 12, 31);

            for (DateTime current = start; current <= end; current = current.AddDays(1))
            {
                if (current.DayOfWeek==DayOfWeek.Friday && current.Day==13)
                {
                    Console.WriteLine(current.ToLongDateString());
                }
            }
        }
    }
}
