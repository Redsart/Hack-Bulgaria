using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Adult : Person
    {
        private List<Child> childrens;
        public Adult(string name, Gender gender)
            : base(name, gender)
        {
            this.childrens = new List<Child>();
        }

        public bool Isbooring { get; set; }

        public override string DailyStuff()
        {
            return "Go to work";
        }

        public List<Child> Childrens
        {
            get
            {
                return this.childrens;
            }
            set
            {
                this.childrens = value;
            }
        }

        public override string ToString()
        {
            int count = this.Childrens.Count;
            if (count == 1)
            {
                return String.Format("I am {0}.I {1}.I have {2} children. IsBooring: {3}",base.Name(), this.DailyStuff(), count, Isbooring);
            }
            else if (count < 1)
            {
                return String.Format("I am {0}.I {1}.I dont have a childrens. IsBooring: {2}",base.Name(), this.DailyStuff(), Isbooring);
            }
            else
            {
                return String.Format("I am {0}.I {1}.I have {2} childrens. IsBooring: {3}", base.Name(), this.DailyStuff(), count, Isbooring);
            }
        }
    }
}
