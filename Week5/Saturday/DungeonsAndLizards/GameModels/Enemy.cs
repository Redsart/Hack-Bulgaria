using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameModels
{
    public class Enemy : ICharacther
    {
        private int health;
        private int mana;
        private int baseDamage;
        private int currentHealth;
        private int currentMana;
        private Weapon weapon;
        private Spell spell;

        public Enemy(int health, int mana, int damage)
        {
            this.health = health;
            this.currentHealth = health;
            this.mana = mana;
            this.baseDamage = damage;
        }

        public bool IsAlive()
        {
            if (this.currentHealth > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CanCast()
        {
            int manaNeeded = 0;
            if (IsAlive() && this.spell != null)
            {
                manaNeeded = this.spell.ManaCost;
            }
            if (this.currentMana > manaNeeded)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHealth()
        {
            return this.currentHealth;
        }

        public int GetMana()
        {
            return this.currentMana;
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

        public int Attack(Weapon weapon)
        {
            if (this.weapon == null)
            {
                return this.baseDamage;
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
                return this.baseDamage;
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
            set
            {
                this.weapon = value;
            }
        }

        public Spell Spell
        {
            get
            {
                return this.spell;
            }
            set
            {
                this.spell = value;
            }
        }

        public void TakeDamage(int damage)
        {
            this.currentHealth -= damage;
            if (currentHealth < 0)
            {
                this.currentHealth = 0;
            }
        }
    }
}
