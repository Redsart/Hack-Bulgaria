using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Toy
    {
        public string Color { get; set; }
        public int Size { get; set; }

        public override string ToString()
        {
            return String.Format("Toy color: {0}\nToy size: {1} sm",this.Color,this,Size);
        }
    }
}
