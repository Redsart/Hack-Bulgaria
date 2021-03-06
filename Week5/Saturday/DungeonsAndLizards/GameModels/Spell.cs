﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameModels
{
    public class Spell : ITreasure
    {
        private string name;
        private int damage;
        private int manaCost;
        private int range;

        public Spell(string name, int damage, int manaCost, int range)
        {
            this.name = name;
            this.damage = damage;
            this.manaCost = manaCost;
            this.range = range;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int Damage
        {
            get
            {
                return this.damage;
            }
        }

        public int ManaCost
        {
            get
            {
                return this.manaCost;
            }
        }

        public int CastRange
        {
            get
            {
                return this.range;
            }
        }
    }
}
