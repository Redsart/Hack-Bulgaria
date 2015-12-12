using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockAngle
{
    class ClockAngle
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;
            Console.WriteLine(GetClockHandsAngle(time));
        }

        private static int GetClockHandsAngle(DateTime time)
        {
            int hours = time.Hour;
            int minutes = time.Minute;

            double hoursDegrees = 0.5D * (hours * 60 + minutes);
            double minutesDegrees = minutes * 6; // 360 / 60 = 6 degrees
            double angle = Math.Abs(hoursDegrees - minutesDegrees);
            angle = Math.Min(angle, 360 - angle);
            return Math.Abs((int)angle);
        }
    }
}
