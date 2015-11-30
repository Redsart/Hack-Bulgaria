using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtremeElements
{
    class ExtremeElements
    {
        static void Main(string[] args)
        {
            int[] items = { 6, 7, 12, 4, 15, 9 };
            int n = 3;
            Console.WriteLine("Min element in items is: {0}\n",Min(items));
            Console.WriteLine("Max element in items is: {0}\n",Max(items));
            NthMin(items,n);
            NthMax(items,n);
        }

        private static int Min(int[] items)
        {
            int minElement = items[0];
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i]<minElement)
                {
                    minElement = items[i];
                }
            }
            return minElement;
        }

        private static int Max(int[] items)
        {
            int maxElement = items[0];
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i]>maxElement)
                {
                    maxElement = items[i];
                }
            }
            return maxElement;
        }

        private static int NthMin(int[] items, int n)
        {
            Array.Sort(items);
            Console.WriteLine("The {0}th minimum element is: {1}\n",n,items[n-1]);
            return n;
        }

        private static int NthMax(int[] items, int n)
        {
            Array.Sort(items);
            int[] reversed = items.Reverse().ToArray();
            Console.WriteLine("The {0}th maximum element is: {1}\n",n,reversed[n-1]);
            return n;
        }
    }
}
