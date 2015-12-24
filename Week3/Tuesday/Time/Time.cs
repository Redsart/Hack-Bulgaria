using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    public class Time
    {
        private DateTime date;
        private DateTime dateTime;

        public Time(DateTime dateTime)
        {
            // TODO: Complete member initialization
            this.dateTime = dateTime;
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            private set
            {
                this.date = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0:hh:mm:ss dd.MM.YY}", this.date);
        }

        public static Time Now()
        {
            return new Time(DateTime.Now);
        }
    }
}
