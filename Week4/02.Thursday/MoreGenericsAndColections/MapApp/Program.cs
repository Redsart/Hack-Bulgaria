using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Map;

namespace MapApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var map = new Map<int, string>();
            map.Add(1, "Stormwind");
            map.Add(2, "Ogrimar");
            map.Add(3, "Ironforge");
            map.Add(4, "Darnasus");

            Console.WriteLine(map[1]);
            Console.WriteLine(map[2]);
            Console.WriteLine(map[3]);
            Console.WriteLine(map[4]);
            Console.WriteLine();

            map[9] = "Thunder Bluff";
            map.Remove(4);

            Console.WriteLine(map[1]);
            Console.WriteLine(map[2]);
            Console.WriteLine(map[3]);
            //Console.WriteLine(map[4]); // throw an Exception
            Console.WriteLine(map[9]);
            Console.WriteLine();

            Console.WriteLine(map.CointainsKey(2));
            Console.WriteLine(map.ContainsValue("Dalaran"));
        }
    }
}
