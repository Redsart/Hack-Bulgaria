using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameModels
{
    public class Potion : ITreasure
    {
        private PotionType potionType;
        private string name;
        private int points;

        public Potion(string name, int points, PotionType type)
        {
            this.name = name;
            this.points = points;
            this.potionType = type;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int Points
        {
            get
            {
                return this.points;
            }
        }

        public PotionType PotionType
        {
            get
            {
                return this.potionType;
            }
        }
    }
}
