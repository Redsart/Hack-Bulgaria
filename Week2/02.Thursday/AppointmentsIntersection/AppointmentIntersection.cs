using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentsIntersection
{
    class AppointmentIntersection
    {
        static void Main(string[] args)
        {
            DateTime[] startDates = {
                                        new DateTime(2015,02,09,20,12,00),
                                        new DateTime(2015,02,10,10,00,00),
                                        new DateTime(2015,02,12,08,30,00),
                                        new DateTime(2015,02,12,18,00,00),
                                        new DateTime(2015,02,14,08,00,00)
                                    };

            TimeSpan[] durations ={
                                     new TimeSpan(4,00,00),
                                     new TimeSpan(8,00,00),
                                     new TimeSpan(12,00,00),
                                     new TimeSpan(3,00,00),
                                     new TimeSpan(8,00,00)
                                 };
            FindIntersectingAppointments(startDates, durations);
        }

        private static void FindIntersectingAppointments(DateTime[] startDates, TimeSpan[] durations)
        {
            List<DateTime> dates = new List<DateTime>();

            for (int i = 0; i < startDates.Length; i++ )
            {
                dates.Add(startDates[i] + durations[i]);
            }
            for (int i = 0; i < startDates.Length; i++)
            {
                for (int j = 0; j < startDates.Length; j++)
                {
                    if (startDates[i]<=startDates[j] && dates[i]>=startDates[j] && startDates[i] !=startDates[j])
                    {
                        Console.WriteLine("The appointment starts at {0} intersecting the appointment starts at {1}",startDates[i],startDates[j]);
                    }
                }
            }
        }
    }
}
