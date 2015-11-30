using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubSequence
{
    class SubSequence
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first string: ");
            string firstAnagram = Console.ReadLine();
            Console.Write("Enter second string: ");
            string secondAnagram = Console.ReadLine();

            Console.WriteLine(HasAnagram(firstAnagram,secondAnagram));
        }

        private static bool HasAnagram(string firstAnagram, string secondAnagram)
        {
            int counter = 0;
            
            for (int i = 0; i < firstAnagram.Length; i++)
            {
                for (int j = 0; j < secondAnagram.Length; j++)
                {
                    if (firstAnagram[i]==secondAnagram[j])
                    {
                        counter++;
                        break;
                    }
                }
            }
            if (counter==firstAnagram.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
