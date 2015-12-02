using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayRanges
{
    class BirthdayRanges
    {
        static void Main(string[] args)
        {
            List<int> birthdays = new List<int> { 1, 2, 3, 4, 5 };
            List<KeyValuePair<int, int>> ranges= new List<KeyValuePair<int,int>>();
            ranges.Add(new KeyValuePair<int, int>(1, 2));
            ranges.Add(new KeyValuePair<int, int>(1, 3));
            ranges.Add(new KeyValuePair<int, int>(1, 4));
            ranges.Add(new KeyValuePair<int, int>(1, 5));
            ranges.Add(new KeyValuePair<int, int>(4, 6));

            var result=BirthdayRangess(birthdays, ranges);
            Console.WriteLine("{" + string.Join(", ", result) + "}");

        }

        private static List<int> BirthdayRangess(List<int> birthdays, List<KeyValuePair<int, int>> ranges)
        {
            List<int> birthDayRanges = new List<int>();
            birthdays.Sort();

            foreach (KeyValuePair<int,int> kvp in ranges)
            {
                int counter = 0;
                foreach (var item in birthdays)
                {
                    if (item>=kvp.Key && item<=kvp.Value)
                    {
                        counter++;
                    }
                }
                birthDayRanges.Add(counter);
            }

            return birthDayRanges;
        }
    }
}
