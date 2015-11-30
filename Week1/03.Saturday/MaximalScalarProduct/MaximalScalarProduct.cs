using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalScalarProduct
{
    class MaximalScalarProduct
    {
        static void Main(string[] args)
        {
            List<int> v1 = new List<int> { 2, 3, 5 };
            List<int> v2 = new List<int> { 4, 1, 3 };

            Console.WriteLine("The maximal scalar product is: {0}",MaxScalarProduct(v1, v2));
        }

        private static int MaxScalarProduct(List<int> v1, List<int> v2)
        {
            int maximalProduct = 0;
            int multiplication = 0;
            for (int i = 0; i < (v1.ToArray().Length) && i < v2.ToArray().Length; i++)
            {
                    multiplication = v1[i] * v2[i];
                    maximalProduct += multiplication;
            }
            return maximalProduct;
        }
    }
}
