using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameModels;

namespace StartGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string mapPath = @"..\..\maps\";
            var map = new Dungeon(mapPath + "Level1.txt");
            map.Treasures.Add(new Weapon("Shadowmourne", 30));
            map.Treasures.Add(new Spell("Storm of Glory", 25, 30, 2));
            map.Treasures.Add(new Potion("Healing Potion", 50, PotionType.health));
            map.Treasures.Add(new Potion("Mana Potion", 50, PotionType.mana));
            map.PrintMap();
            Console.WriteLine();
            var hero = new Hero("Bron", "Dragonslayer", 100, 100, 2);
            var weap = new Weapon("Pacifer", 25);
            hero.Equip(weap);
            var spell = new Spell("Fireball", 20, 25, 2);
            hero.Learn(spell);
            map.Spawn(hero);
            map.PrintMap();
            Console.WriteLine();
            map.MoveHero(Direction.Right);
            map.MoveHero(Direction.Down);
            map.PrintMap();
            Console.WriteLine();
            map.HeroAttack("spell");
            map.MoveHero(Direction.Down);
            map.MoveHero(Direction.Down);
            map.PrintMap();
            Console.WriteLine();
            map.HeroAttack("spell");
            map.PrintMap();
            Console.WriteLine();
        }
    }
}
