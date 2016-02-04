using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicArray;

namespace DynamicArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new DynamicArray<string>();
            array.Add("Georgi");
            array.Add("Nikolai");
            Console.WriteLine(array.IndexOf("Nikolai"));
            Console.WriteLine(array.Cointains("Kiril"));
            array.Remove("Georgi");
            array.InsertAt(1, "Ivan");
            array.Clear();
            Console.WriteLine(array.Capacity);
            Console.WriteLine(array.Count);

            array.Add("Stefan");
            array.Add("Krum");
            var arr = array.ToArray();
            Console.WriteLine();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
