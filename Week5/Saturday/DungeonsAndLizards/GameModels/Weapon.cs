using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameModels
{
    public class Weapon : ITreasure
    {
        private string name;
        private int damageDone;

        public Weapon(string name, int damageDone)
        {
            this.name = name;
            this.damageDone = damageDone;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int DamageDone
        {
            get
            {
                return this.damageDone;
            }
        }
    }
}
