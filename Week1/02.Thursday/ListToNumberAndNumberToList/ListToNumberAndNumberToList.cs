//Number->List and List->Number

//Implement the two functions:

//List<int> NumberToList(int n) which takes an integer and returns a list of its digits
//int ListToNumber(string digits) which takes a list of digits and returns the number from those digits

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListToNumberAndNumberToList
{
    class ListToNumberAndNumberToList
    {
        static void Main(string[] args)
        {
            //NumberToList result
            Console.Write("Enter an integer: ");
            int n = int.Parse(Console.ReadLine());
            int result = NumberToList(n);

            //ListToNumber result
            List<int> digits = new List<int> { 1, 2, 3, 4, 5 };
            int listToNumber = ListToNumber(digits);
            Console.WriteLine("ListToNumber: {0}",listToNumber);
        }

        private static int NumberToList(int n)
        {
            string str = n.ToString();
            int number=0;
            List<int> numberToList = new List<int>();
            foreach (char ch in str)
            {
                number = ch - '0';
                numberToList.Add(number);
                Console.Write("{0} ",numberToList[numberToList.Count-1]);
            }
            Console.WriteLine();
            return number;
        }

        private static int ListToNumber(List<int> digits)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var digit in digits)
            {
                sb.Append(digit);
            }
            return int.Parse(sb.ToString());
        }
    }
}
