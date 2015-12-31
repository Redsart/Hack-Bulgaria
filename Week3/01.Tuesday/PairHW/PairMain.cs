using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairHW
{
    class PairMain
    {
        static void Main(string[] args)
        {
            Pair obj1 = new Pair(5, 6);
            Pair obj2 = new Pair(6, 7);
            
            Console.WriteLine(obj1.Equals(obj2));
        }
    }
}
