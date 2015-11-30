using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackNumbers
{
    class HackNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsHack(8191));
            NextHack(8031);
        }

        private static bool IsHack(int n)
    {
        string binary = Convert.ToString(n, 2);
        int counter = 0;
        foreach (var digit in binary)
        {
            if (digit=='1')
            {
                counter++;
            }
            if (counter % 2 != 0 && (binary == new string(binary.Reverse().ToArray())))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        return false;
    }

        private static void NextHack(int n)
        {
            if (IsHack(n+1))
            {
                Console.WriteLine(n+1);   
            }
            else
            {
                NextHack(n+1);
            }
        }
    }
}
