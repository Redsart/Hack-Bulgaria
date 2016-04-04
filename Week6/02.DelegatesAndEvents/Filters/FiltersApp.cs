using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filters
{
    class FiltersApp
    {
        public delegate bool FilterDelegate(int number);

        static void Main(string[] args)
        {
            //Program filters numbers greater than 5

            FilterDelegate filter = IsInRange;

            var numbers = new List<int> { 0, 2, 14, 12, 11, 4, -2, 6, 10 };

            numbers = FilterCollection(numbers, filter);

            var result = String.Join(", ", numbers);

            Console.WriteLine(result);
        }

        public static List<int> FilterCollection(List<int> original, FilterDelegate filter)
        {
            for (int i = 0; i < original.Count; i++)
            {
                if (!filter(original[i]))
                {
                    original.Remove(original[i]);
                    i--;
                }
            }
            return original;
        }

        public static bool IsInRange(int number)
        {
            if (number > 5)
            {
                return true;
            }
            return false;
        }
    }
}
