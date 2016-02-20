using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Child : Person
    {
        private List<Toy> toys;
        public Child(string name, Gender gender)
            : base(name, gender)
        {
            this.toys = new List<Toy>();
        }

        public override string DailyStuff()
        {
            return "Go to play";
        }

        public List<Toy> Toys
        {
            get
            {
                return this.toys;
            }
            set
            {
                this.toys = value;
            }
        }

        public override string ToString()
        {
            return String.Format("I am {0}. I {1}, and i have a {2}",base.Name(),this.DailyStuff(),this.Toys.Count);
        }
    }
}
