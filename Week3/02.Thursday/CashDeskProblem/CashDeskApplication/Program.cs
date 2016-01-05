using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashDesk;

namespace CashDeskApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var a = new Bill(10);
            var b = new Bill(5);
            var c = new Bill(10);

            Console.WriteLine(a);

            var bills = new Bill[] { new Bill(10), new Bill(20), new Bill(50), new Bill(100) };
            var batch = new BatchBill(bills.ToList());

            foreach(var bill in batch)
            {
              Console.WriteLine(bill);
            }
        }
    }
}
