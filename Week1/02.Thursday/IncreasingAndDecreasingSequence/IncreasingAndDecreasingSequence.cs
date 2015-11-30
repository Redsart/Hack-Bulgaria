using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingAndDecreasingSequence
{
    class IncreasingAndDecreasingSequence
    {
        static void Main(string[] args)
        {
            int[] sequence = new int [6] 
                                            {9, 8, 6, 5, 2, 1};
                                            //{1, 2, 3, 5, 6, 9};
                                            //{9, 9, 6, 5, 2, 1};
            Console.WriteLine("IsIncreasing : {0}\n",IsIncreasing(sequence));
            Console.WriteLine("IsDecreasing : {0}",IsDecreasing(sequence));
        }

        private static bool IsIncreasing(int[] sequence)
        {
            int counter = 0;
            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] > sequence[i - 1])
                {
                    counter++;
                }
            }

            if (counter==sequence.Length-1)
            {
                return true;
            }
            return false;
        }

        private static bool IsDecreasing(int[] sequence)
        {
            int counter = 0;
            for (int i = 1; i < sequence.Length; i++)
            {
                if (i < sequence.Length)
                {
                    if (sequence[i] < sequence[i - 1])
                    {
                        counter++;
                    }
                }
            }

            if (counter==sequence.Length-1)
            {
                return true;
            }
            return false;
        }
    }
}
