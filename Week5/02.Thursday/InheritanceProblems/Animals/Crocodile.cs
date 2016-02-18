using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Crocodile : Reptyle
    {
        public override string Temperature()
        {
            Random rnd=new Random();
            int temperature = rnd.Next(8, 28);
            return String.Format(temperature.ToString());
        }

        public override string Move()
        {
            return String.Format("I am crocodile.I can swim and i can move on the land.My temperature is: {0}",this.Temperature());
        }
    }
}
