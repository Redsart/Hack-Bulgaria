using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameModels
{
    public class Hero : ICharacther
    {
        private string name;
        private string clas;
        private int health;
        private int currentHealth;
        private int mana;
        private int currentMana;
        private int manaRegeneration;
        private int attackPoints;
        private Weapon weapon;
        private Spell spell;

        public Hero(string name, string clas, int health, int mana, int manaRegen)
        {
            this.name = name;
            this.clas = clas;
            this.health = health;
            this.currentHealth = health;
            this.mana = mana;
            this.currentMana = mana;
            this.manaRegeneration = manaRegen;
            this.attackPoints = 0;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public string KnownAs()
        {
            return String.Format("{0} the {1}", this.name, this.clas);
        }

        public int GetHealth()
        {
            return this.currentHealth;
        }

        public int GetMana()
        {
            return this.currentMana;
        }

        public int ManaRegeneration
        {
            get
            {
                return this.manaRegeneration;
            }
        }

        public bool IsAlive()
        {
            if (this.currentHealth > 0)
            {
                return true;
            }
            return false;
        }

        public bool CanCast()
        {
            int manaNeeded=0;
            if (this.spell != null)
            {
                manaNeeded = this.spell.ManaCost;
            }
            if (manaNeeded >= this.currentMana)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TakeDamage(int damage)
        {
            this.currentHealth -= damage;
            if (this.currentHealth < 0)
            {
                this.currentHealth = 0;
            }
        }

        public bool TakeHealing(int healingPoints)
        {
            if (IsAlive())
            {
                this.currentHealth += healingPoints;
                if (this.currentHealth > this.health)
                {
                    this.currentHealth = this.health;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TakeMana(int manaPoints)
        {
            if (IsAlive() && this.currentMana < this.mana)
            {
                this.currentMana += manaPoints;
                if (this.currentMana > this.mana)
                {
                    this.currentMana = this.mana;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Equip(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public void Learn(Spell spell)
        {
            this.spell = spell;
        }

        public int Attack(Weapon weapon)
        {
            if (this.weapon == null)
            {
                return 0;
            }
            else
            {
                return this.weapon.DamageDone;
            }
        }

        public int Attack(Spell spell)
        {
            if (this.spell == null)
            {
                return 0;
            }
            else
            {
                return this.spell.Damage;
            }
        }

        public Weapon Weapon
        {
            get
            {
                return this.weapon;
            }
        }

        public Spell Spell
        {
            get
            {
                return this.spell;
            }
        }
    }
}
