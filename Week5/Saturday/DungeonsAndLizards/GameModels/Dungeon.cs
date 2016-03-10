using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GameModels
{
    public class Dungeon
    {
        private char[,] map;
        private int currentRow;
        private int currentCol;
        private Hero hero;
        private List<ITreasure> treasures;

        public Dungeon(string filePath)
        {
            string[] path = File.ReadAllText(filePath).Split('\n');
            int width = path[0].Length - 1;
            int height = path.Length;
            this.map = new char[height,width];
            for (int i = 0; i < map.GetLength(0); i++)
            {
                var step = path[i];
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    this.map[i, j] = step[j];
                }
            }
            this.treasures=new List<ITreasure>();
        }

        public List<ITreasure> Treasures
        {
            get
            {
                return this.treasures;
            }
        }

        public void PrintMap()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            for (int row = 0; row < this.map.GetLength(0); row++)
            {
                for (int col = 0; col < this.map.GetLength(1); col++)
                {
                    if (this.map[row,col] == 'H')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(this.map[row,col]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (this.map[row,col] == 'S')
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(this.map[row, col]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (this.map[row,col] == 'G')
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(this.map[row, col]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (this.map[row,col] == '#')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(this.map[row, col]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (this.map[row,col] == '.')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(this.map[row, col]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (this.map[row,col] == 'T')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(this.map[row, col]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (this.map[row,col] == 'E')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(this.map[row, col]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write(this.map[row,col]);
                    }
                }
                Console.WriteLine();
            }
        }

        public bool Spawn(Hero hero)
        {
            for (int col = 0; col < this.map.GetLongLength(1); col++)
            {
                for (int row = 0; row < this.map.GetLongLength(0); row++)
                {
                    if (this.map[row,row] == 'S')
                    {
                        this.currentRow = row;
                        this.currentCol = row;
                        this.map[row, row] = 'H';
                        this.hero = hero;
                        return true;
                    }
                }
            }
            return false;
        }

        public bool MoveHero(Direction direction)
        {
            if (this.hero.IsAlive())
            {
                Enemy enemy = new Enemy(100, 100, 20);

                //var enemySpell = new Spell("Fire Blast", 25, 50, 2);
                //enemy.Spell = enemySpell;

                this.hero.TakeMana(this.hero.ManaRegeneration);
                switch (direction)
                {
                    case Direction.Up:
                        if (this.currentRow-1 < 0 || this.map[currentRow-1,currentCol] == '#' || this.map[currentRow-1,currentCol] == 'S')
                        {
                            return false;
                        }
                        else if (this.map[currentRow-1,currentCol] == 'T')
                        {
                            PickTreasure();   
                        }
                        else if (this.map[currentRow-1,currentCol] == 'E')
                        {
                            StartFight(enemy, this.currentRow - 1, currentCol);
                            return true;
                        }
                        else if (this.map[currentRow-1,currentCol] == 'G')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Congratulation, you finished the dungeon.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            return true;
                        }
                        this.map[this.currentRow, this.currentCol] = '.';
                        this.map[this.currentRow - 1, this.currentCol] = 'H';
                        this.currentRow = this.currentRow - 1;
                        return true;

                    case Direction.Down:
                        if (this.currentRow+1 >= this.map.GetLength(0) || this.map[this.currentRow+1,this.currentCol] == '#' || this.map[this.currentRow+1,this.currentCol] == 'S')
                        {
                            return false;
                        }
                        else if (this.map[currentRow+1,this.currentCol] == 'T')
                        {
                            PickTreasure();
                        }
                        else if (this.map[currentRow+1,currentCol] == 'E')
                        {
                            StartFight(enemy, this.currentRow + 1, this.currentCol);
                            return true;
                        }
                        else if (this.map[currentRow+1,currentCol] == 'G')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Congratulation, you finished the dungeon.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            return true;
                        }
                        this.map[this.currentRow, this.currentCol] = '.';
                        this.map[this.currentRow + 1, this.currentCol] = 'H';
                        this.currentRow = this.currentRow + 1;
                        return true;

                    case Direction.Left:
                        if (this.currentCol -1 < 0 || this.map[this.currentRow,this.currentCol-1] == '#' || this.map[this.currentRow,this.currentCol-1] == 'S')
                        {
                            return false;
                        }
                        else if (this.map[this.currentRow,this.currentCol-1] == 'T')
                        {
                            PickTreasure();
                        }
                        else if (this.map[this.currentRow,this.currentCol-1] == 'E')
                        {
                            StartFight(enemy, this.currentRow, this.currentCol - 1);
                            return true;
                        }
                        else if (this.map[this.currentRow,this.currentCol-1] == 'G')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Congratulation, you finished the dungeon.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            return true;
                        }
                        this.map[this.currentRow, this.currentCol] = '.';
                        this.map[this.currentRow, this.currentCol - 1] = 'H';
                        this.currentCol = this.currentCol - 1;
                        return true;

                    case Direction.Right:
                        if (this.currentCol+1 > this.map.GetLength(1)-1 || this.map[this.currentRow,this.currentCol+1] == '#' || this.map[this.currentRow,this.currentCol+1] == 'S')
                        {
                            return false;
                        }
                        else if (this.map[this.currentRow,this.currentCol+1] == 'T')
                        {
                            PickTreasure();
                        }
                        else if (this.map[this.currentRow,this.currentCol+1] == 'E')
                        {
                            StartFight(enemy, this.currentRow, this.currentCol + 1);
                            return true;
                        }
                        else if (this.map[this.currentRow,this.currentCol+1] == 'G')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Congratulation, you finished the dungeon.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                            return true;
                        }
                        this.map[this.currentRow, this.currentCol] = '.';
                        this.map[this.currentRow, this.currentCol + 1] = 'H';
                        this.currentCol = this.currentCol + 1;
                        return true;

                    default:
                        return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void PickTreasure()
        {
            if (this.treasures.Count < 1)
            {
                Console.WriteLine("No treasures found");
                Console.WriteLine();
                return;
            }
            Random rnd=new Random();
            int number=rnd.Next(0,this.treasures.Count);
            var treasure = this.treasures[number];

            if (treasure is Potion)
            {
                var potion = treasure as Potion;
                if (potion.PotionType == PotionType.health)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (this.hero.TakeHealing(potion.Points))
                    {
                        Console.WriteLine("You found {0}. {1}'s health is {2}",potion.Name,this.hero.Name,this.hero.GetHealth());
                    }
                    else
                    {
                        Console.WriteLine("You found {0}. {1}'s health is full.",potion.Name,this.hero.Name);
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else if (potion.PotionType == PotionType.mana)
                {
                    if (this.hero.TakeMana(potion.Points))
                    {
                        Console.WriteLine("You found {0}. {1}'s mana is {2}",potion.Name,this.hero.Name,this.hero.GetMana());
                    }
                    else
                    {
                        Console.WriteLine("You found {0}. {1}'s mana is full",potion.Name,this.hero.Name);
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            else if (treasure is Weapon)
            {
                var weapon = treasure as Weapon;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You found {0}, Damage {1}",weapon.Name,weapon.DamageDone);
                Console.ForegroundColor = ConsoleColor.White;
            option:
                Console.WriteLine("Do you want to equip the {0}. Type yes/no",weapon.Name);
            var option = Console.ReadLine();
            if (option.ToLower()=="yes")
            {
                this.hero.Equip(weapon);
            }
            else if (option.ToLower() == "no")
            {

            }
            else
            {
                goto option;
            }
            Console.WriteLine();
            }

            else if (treasure is Spell)
            {
                var spell = treasure as Spell;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("You found {0}, Damage{1}, Castrange {2}",spell.Name,spell.Damage,spell.CastRange);
                Console.ForegroundColor = ConsoleColor.White;
            option:
                Console.WriteLine("Do you want to learn it. Type yes/no.");
            var option = Console.ReadLine();
            if (option.ToLower() == "yes")
            {
                this.hero.Learn(spell);
            }
            else if (option.ToLower() == "no")
            {

            }
            else
            {
                goto option;
            }
            Console.WriteLine();
            }
        }

        public void HeroAttack(string by)
        {
            if (this.hero.IsAlive() == true)
            {
                var enemy = new Enemy(100, 100, 20);

                //var enemyspell = new Spell("Fire Blast", 25, 50, 2);
                //enemy.Spell = enemyspell;

                for (int i = 1; i <= this.hero.Spell.CastRange; i++)
                {
                    if ((this.currentRow - i == '#') || (this.currentRow - i < 0))
                    {
                        break;
                    }
                    else if (this.map[this.currentRow - i,this.currentCol] == 'E')
                    {
                        StartFight(enemy, this.currentRow - i, this.currentCol);
                        return;
                    }
                }
                for (int i = 1; i <= this.hero.Spell.CastRange; i++)
                {
                    if ((this.currentRow+1 == '#') || (this.currentRow+i > this.map.GetLength(0)-1))
                    {
                        break;
                    }
                    else if (this.map[currentRow+i,currentCol] == 'E')
                    {
                        StartFight(enemy, this.currentRow + i, this.currentCol);
                        return;
                    }
                }
                for (int i = 1; i <= this.hero.Spell.CastRange; i++)
                {
                    if ((this.currentCol+i == '#') || (this.currentCol+1 > this.map.GetLength(1) -1))
                    {
                        break;
                    }
                    else if (this.map[currentRow,currentCol+i] == 'E')
                    {
                        StartFight(enemy, this.currentRow, this.currentCol + 1);
                        return;
                    }
                    else if (i==this.hero.Spell.CastRange)
                    {
                        Console.WriteLine("No target in range.");
                        Console.WriteLine();
                    }
                }
                for (int i = 1; i <=this.hero.Spell.CastRange; i++)
                {
                    if ((this.currentCol-i == '#') || (this.currentCol-i < 0))
                    {
                        break;
                    }
                    else if (this.map[currentRow,currentCol-1] == 'E')
                    {
                        StartFight(enemy, this.currentRow, this.currentCol - i);
                        return;
                    }
                }
            }
            else if (this.hero.Spell == null)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("No learned spell.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hero dont have enough mana.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
        }

        private void StartFight(Enemy enemy, int enemyCurrentRow, int enemyCurrentCol)
        {
            var enemyRow = enemyCurrentRow;
            var enemyCol = enemyCurrentCol;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Fight between our Hero(healt:{0},mana:{1}) and Enemy(health:{2},mana{3},damage:{4}) started!"
                ,this.hero.GetHealth(),this.hero.GetMana(),enemy.GetHealth(),enemy.GetMana(),enemy.Attack(enemy.Weapon));
            Console.WriteLine();
            bool check = false;

            while (true)
            {
                if (!this.hero.CanCast() && !check)
                {
                    check = true;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("You dont have mana for {0}",this.hero.Spell.Name);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (this.hero.Spell.Damage >= this.hero.Weapon.DamageDone || this.currentRow < enemyRow || this.currentRow > enemyRow || this.currentCol < enemyCol || this.currentRow > enemyCol && this.hero.CanCast())
                {
                    enemy.TakeDamage(this.hero.Spell.Damage);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("{0} hits an enemy with {1}! Enemy health now is {2}",this.hero.Name,this.hero.Spell.Name,enemy.GetHealth());
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    if (enemyRow < this.currentRow)
                    {
                        this.map[currentRow, currentCol] = '.';
                        this.currentRow--;
                        this.map[currentRow, currentCol] = 'H';
                        Console.WriteLine("The hero move one step up to the enemy.");
                    }
                    else if (enemyRow > this.currentRow)
                    {
                        this.map[currentRow, currentCol] = '.';
                        this.currentRow++;
                        this.map[currentRow, currentCol] = 'H';
                        Console.WriteLine("The hero move one step down to the enemy.");
                    }
                    else if (enemyCol < this.currentCol)
                    {
                        this.map[currentRow, currentCol] = '.';
                        this.currentCol--;
                        this.map[currentRow, currentCol] = 'H';
                        Console.WriteLine("The hero move one step left to the enemy.");
                    }
                    else if (enemyCol > this.currentCol)
                    {
                        this.map[currentRow, currentCol] = '.';
                        this.currentCol++;
                        this.map[currentRow, currentCol] = 'H';
                        Console.WriteLine("The hero move one step right to the enemy.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        enemy.TakeDamage(hero.Attack(hero.Weapon));
                        Console.WriteLine("{0} hits the enemy with {1} damage. Enemy health now is {2}"
                            ,this.hero.Name,this.hero.Weapon.DamageDone,enemy.GetHealth());
                    }
                }
                if (!enemy.IsAlive())
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The enemy is dead!");
                    if (this.map[enemyRow,enemyCol] != 'H')
                    {
                        this.map[enemyRow, enemyCol] = '.';
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                if (enemyRow < this.currentRow)
                {
                    if (enemy.Spell != null)
                    {
                        var distance = this.currentRow - enemyRow;
                        if (enemy.CanCast() && distance <= enemy.Spell.CastRange)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            hero.TakeDamage(enemy.Spell.Damage);
                            Console.WriteLine("{0} has attacked by enemy with {1} damage! Hero health now is {2}",this.hero.Name,enemy.Spell.Damage,this.hero.GetHealth());
                        }
                        else
                        {
                            enemyRow++;
                            Console.WriteLine("Enemy move one step down to the hero.");
                        }
                    }
                    else
                    {
                        enemyRow++;
                        Console.WriteLine("Enemy move one step down to the hero.");
                    }
                }
                else if (enemyRow > this.currentRow)
                {
                    if (enemy.Spell != null)
                    {
                        var distance = enemyRow - this.currentRow;
                        if (enemy.CanCast() && distance <= enemy.Spell.CastRange)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            hero.TakeDamage(enemy.Spell.Damage);
                            Console.WriteLine("{0} has attacked by enemy with {1} damage! Hero health now is {2}", this.hero.Name, enemy.Spell.Damage, this.hero.GetHealth());
                        }
                        else
                        {
                            enemyRow--;
                            Console.WriteLine("Enemy move one step up to the hero");
                        }
                    }
                    else
                    {
                        enemyRow--;
                        Console.WriteLine("Enemy move one step up to the hero.");
                    }
                }
                else if (enemyCol < this.currentCol)
                {
                    if (enemy.Spell != null)
                    {
                        var distance = enemyCol - this.currentCol;
                        if (enemy.CanCast() && distance <= enemy.Spell.CastRange)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            hero.TakeDamage(enemy.Spell.Damage);
                            Console.WriteLine("{0} has attacked by enemy with {1} damage! Hero health now is {2}", this.hero.Name, enemy.Spell.Damage, this.hero.GetHealth());
                        }
                        else
                        {
                            enemyCol++;
                            Console.WriteLine("Enemy move one step right to the hero.");
                        }
                    }
                    else
                    {
                        enemyCol++;
                        Console.WriteLine("Enemy move one step right to the hero.");
                    }
                }
                else if (enemyCol > this.currentCol)
                {
                    if (enemy.Spell != null)
                    {
                        var distance = enemyCol - this.currentCol;
                        if (enemy.CanCast() && distance <= enemy.Spell.CastRange)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            hero.TakeDamage(enemy.Spell.Damage);
                            Console.WriteLine("{0} has attacked by enemy with {1} damage! Hero health now is {2}", this.hero.Name, enemy.Spell.Damage, this.hero.GetHealth());
                        }
                        else
                        {
                            enemyCol--;
                            Console.WriteLine("Enemy move one step left to the hero.");
                        }
                    }
                    else
                    {
                        enemyCol--;
                        Console.WriteLine("Enemy move one step left to the hero.");
                    }
                }
                else
                {
                    if (enemy.Spell != null)
                    {
                        if (enemy.Spell.Damage >= enemy.Attack(enemy.Weapon) && enemy.CanCast())
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            hero.TakeDamage(enemy.Spell.Damage);
                            Console.WriteLine("{0} has attacked by enemy with {1} damage! Hero health now is {2}", this.hero.Name, enemy.Spell.Damage, this.hero.GetHealth());
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            hero.TakeDamage(enemy.Weapon.DamageDone);
                            Console.WriteLine("{0} has attacked by enemy with {1} damage! Hero health now is {2}", this.hero.Name, enemy.Weapon.DamageDone, this.hero.GetHealth());
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        hero.TakeDamage(enemy.Attack(enemy.Weapon));
                        Console.WriteLine("{0} has attacked by enemy with {1} damage! Hero health now is {2}", this.hero.Name, enemy.Attack(enemy.Weapon), this.hero.GetHealth());
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                if (!this.hero.IsAlive())
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("{0} is dead!",this.hero.Name);
                    this.map[this.currentRow, this.currentCol] = '.';
                    bool canRespawn = this.Spawn(this.hero);
                    if (!canRespawn)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Game over!");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
