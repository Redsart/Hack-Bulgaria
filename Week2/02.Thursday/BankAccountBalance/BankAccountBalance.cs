using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Threading;

namespace BankAccountBalance
{
    class BankAccountBalance
    {
        static void Main(string[] args)
        {
            
            string[] input = File.ReadAllText(@"..\..\Pesho.txt").Split(new char[] {';',' '});
            CultureInfo culture = new CultureInfo("bg-BG");
            for (int i = 0; i < input.Length; i+=3)
            {
                DateTime currentDate =DateTime.Parse(input[i]);
                Console.WriteLine(currentDate);
            }
        }
    }
}
