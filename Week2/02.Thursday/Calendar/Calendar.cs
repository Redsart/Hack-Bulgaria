using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace Calendar
{
    class Calendar
    {
        static void Main(string[] args)
        {
            Console.Write("Enter month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            CultureInfo culture = new CultureInfo("bg-BG");
           
            PrintCalendar(month, year, culture);
        }

        private static void PrintCalendar(int month, int year, CultureInfo culture)
        {
            List<DateTime> dates = new List<DateTime>();
            //get dates
            for (var date = new DateTime(year, month, 1); date.Month == month; date=date.AddDays(1) )
            {
                dates.Add(date); 
            }
            DateTime givenDate = new DateTime(year, month, 1);
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            Console.WriteLine(givenDate.Month.ToString("d",culture));

        }

    }
}
