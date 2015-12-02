using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tranversal
{
    class Transversal
    {
        static void Main(string[] args)
        {
            List<int> tranversal = new List<int> { 4, 5, 6 };
            List<List<int>> family = new List<List<int>>();
            family.Add(new List<int> { 5, 7, 9 });
            family.Add(new List<int> { 1, 4, 3 });
            family.Add(new List<int> { 2, 6 });

            Console.WriteLine(IsTransversal(tranversal,family));
        }

        private static bool IsTransversal(List<int> transversal, List<List<int>> family)
        {
            bool isTranversal = false;
            foreach (var item in family)
            {
                foreach (var number in transversal)
                {
                    if (item.Contains(number))
                    {
                        isTranversal = true;
                    }
                }
            }
            return isTranversal;
        }
    }
}
