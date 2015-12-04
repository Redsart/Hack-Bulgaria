using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1337
{
    class Problem_1337
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            HackerTime(now);
        }

        private static void HackerTime(DateTime now)
        {
            DateTime hackerTime = new DateTime();

            if (now.Month == 12 && now.Day == 21 && now.Hour == 13 && now.Minute == 37)
            {
                hackerTime = new DateTime(now.Year, 12, 21, 13, 37, 00);
            }
            else
            {
                hackerTime = new DateTime(now.Year + 1, 12, 21, 13, 37, 00);
            }

            int months = Math.Abs(hackerTime.Month - now.Month);
            int days = Math.Abs(hackerTime.Day - now.Day);

            Console.WriteLine("{0}, {1}", months, days);
        }
    }
}
