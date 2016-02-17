using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Owl : Bird
    {
        public override string Nest()
        {
            return "This is my beautyful nest";
        }

        public override string Move()
        {
            return String.Format("I believe i can fly, because i am an Owl and {0}",this.Nest());
        }
    }
}
