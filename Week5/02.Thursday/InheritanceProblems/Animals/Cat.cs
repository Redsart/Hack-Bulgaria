using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cat : Mammal, ILandAnimal
    {
        public string Greet()
        {
            return "Meow!";
        }

        public override string Move()
        {
            return String.Format("I'm cat and moving on the land"+ this.Greet());
        }
    }
}
