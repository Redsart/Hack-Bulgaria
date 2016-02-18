using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog : Mammal, ILandAnimal
    {
        public string Greet()
        {
            return "Bau";
        }

        public override string Move()
        {
            return String.Format("I'm dog and i moving on the land " + this.Greet());
        }
    }
}
