using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class TimeMain
    {
        static void Main(string[] args)
        {
            DateTime someDate = new DateTime(2015,03,03,21,00,00);
            var date = new Time(someDate);

            Console.WriteLine("{0}\n",date.ToString());

            Console.WriteLine(Time.Now());
        }
    }
}
