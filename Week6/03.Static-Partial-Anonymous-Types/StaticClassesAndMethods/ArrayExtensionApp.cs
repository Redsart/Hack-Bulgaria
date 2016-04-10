using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesAndMethods
{
    class ArrayExtensionApp
    {
        static void Main(string[] args)
        {
            var firstList = new List<int>() { 1, 3, 5, 7, 9 };
            var secondList = new List<int>() { 2, 4, 6, 7, 9 };

            var newList = ArrayExtension<int>.Union(firstList, secondList);
            //var newList = ArrayExtension<int>.UnionAll(firstList, secondList);
            //var newList = ArrayExtension<int>.Intersect(firstList, secondList);

            foreach (var item in firstList)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            Console.WriteLine(ArrayExtension<int>.GetReplacingValue());

            var stringList = new List<string>() { "whisp", "elf", "orc", "human", "dwarf" };
            Console.WriteLine(ArrayExtension<int>.Join(stringList));
        }
    }
}
