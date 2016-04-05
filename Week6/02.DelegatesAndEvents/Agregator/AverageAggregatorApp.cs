using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregator
{
    class AverageAggregatorApp
    {
        static void Main(string[] args)
        {
            AverageAggregator agregator = new AverageAggregator();
            agregator.AddNumber(3);
            agregator.AddNumber(7);
            agregator.AddNumber(6);

            Console.WriteLine("Average is {0}", agregator.Average);
            Console.WriteLine();

            agregator.Change += AverageIsChanged;
            Console.WriteLine("Adding more nimbers...");
            agregator.AddNumber(12);
            agregator.AddNumber(15);
            Console.WriteLine("Average is {0}", agregator.Average);
        }

        private static void AverageIsChanged(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("Average is changed!");
        }
    }
}
