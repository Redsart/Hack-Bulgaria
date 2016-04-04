using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregates
{
    class AgregatesApp
    {
        public delegate decimal AggregationDelegate(List<int> numbers);

        //public delegate void AnotherAggregationDelegate(List<int> numbers);

        static void Main(string[] args)
        {
            var numbers = new List<int> { 2, 3, 14, 12, 19, 6, 4 };

            AggregationDelegate myDelegate = CalculateAverage;

            // Test void delegates

            //AnotherAggregationDelegate mySecondDelegate = Min;
            //mySecondDelegate += Max;
            //mySecondDelegate += Sum;
            //mySecondDelegate += Average;

            Console.WriteLine("Average of numbers is {0}",AggregateCollection(numbers,myDelegate));
        }

        public static decimal AggregateCollection(List<int> original, AggregationDelegate myDelegate)
        {
            return myDelegate(original);
        }

        public static void Sum(List<int> numbers)
        {
            var sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Sum of numbers is {0}",sum);
        }

        public static void Average(List<int> numbers)
        {
            var sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            var average = sum / numbers.Count;
            Console.WriteLine("Average of numbers is {0}",average);
        }

        public static decimal CalculateAverage(List<int> numbers)
        {
            var sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            var average = sum / numbers.Count;
            return average;
        }

        public static void Min(List<int> numbers)
        {
            var min = int.MaxValue;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine("Min element is {0}",min);
        }

        public static void Max(List<int> numbers)
        {
            var max = int.MinValue;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine("Max element is {0}",max);
        }
    }
}
