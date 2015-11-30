using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeScore
{
    class PalindromeScore
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");
            int n = int.Parse(Console.ReadLine());

            int result = PScore(n);
            Console.WriteLine("PScore({0}) = {1}", n, result);
        }

        private static int PScore(int n)
        {
            int score = 1;

            while(true)
            {
                string numberToString =n.ToString();
                string reversedNumber = new string(numberToString.Reverse().ToArray());
                if (n.ToString() == new string(n.ToString().Reverse().ToArray()))
                {
                    return 1;
                }
                else
                {
                    int result = n + int.Parse(reversedNumber);
                    score++;
                    n = result;
                    if (PScore(n) == 1)
                    {
                        return score;
                    }
                }
            }
        }
    }
}
