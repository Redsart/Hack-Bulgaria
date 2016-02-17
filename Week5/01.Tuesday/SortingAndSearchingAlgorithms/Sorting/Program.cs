using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public delegate bool PredicateDelegate<T>(T first, T second);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*LastDigitComparer + BubbleSort: ");
            Console.WriteLine();

            var array = new List<int>() { 2, 4, 1, 6, 10 };
            var sortedArray = array.BubleSort(new LastDigitComparer());

            foreach (var item in sortedArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("BubbleSort with Delegate - Predicate for Compare Integers : ");
            Console.WriteLine();

            var secondArrey = new List<int>() { 2, 4, 1, 6, 10 };
            PredicateDelegate<int> myDelegate = CompareIntegers;
            var sortedArreyPredicate = secondArrey.BubleSort(myDelegate);

            foreach (var item in sortedArreyPredicate)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("*ReverseComparer<T> + StringLengthComparer + SelectionSort: ");
            Console.WriteLine();

            var strings = new List<string>() { "grr", "brrr", null, "aaaaa", "yeaaaaa", "A" };
            var stringsArray = strings.SelectionSort(new ReverseComparer<string>(new StringLengthComparer()));
            strings.Add("o");
            foreach (var item in stringsArray)
            {
                if (item == null)
                {
                    Console.WriteLine("\"null\"");
                }
                else
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine();
        }

        public static bool CompareIntegers(int x, int y)
        {
            if (x > y)
            {
                return true;
            }
            return false;
        }
    }
}
