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
            CashDesks obj = new CashDesks();
            Console.WriteLine("Comand list \ntakebill \ntakebatch \ntotal \ninspect \nexit \n");

            while (true)
            {
                string comands = Console.ReadLine();
                string[] comand = comands.Split(' ');

                switch (comand[0])
                {
                    case "takebill":
                        if (comand.Length > 2)
                        {
                            throw new ArgumentException("takebill takes only 1 argument");
                        }
                        else
                        {
                            obj.TakeMoney(new Bill(int.Parse(comand[1])));
                        }
                        break;

                    case "takebatch":
                        if (comand.Length > 2)
                        {
                            List<Bill> bills = new List<Bill>();
                            for (int i = 1; i < bills.Capacity; i++)
                            {
                                bills.Add(new Bill(int.Parse(comand[i])));
                            }
                            obj.TakeMoney(new BatchBill(bills));
                            break;
                        }
                        else
                        {
                            throw new ArgumentException("takebatch must have more than 1 argument");
                        }

                    case "total":
                        obj.Total();
                        break;
                        
                    case "inspect":
                        obj.Inspect();
                        break;

                    case "exit":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Wrong option!");
                        break;
                }
            }
        }
    }
}
