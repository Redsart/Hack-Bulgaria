using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Shark : Fish
    {
        public override string Move()
        {
            return String.Format("I am shark and i can swim");
        }
    }
}
