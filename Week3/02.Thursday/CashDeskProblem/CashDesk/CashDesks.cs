using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CashDesk
{
    public class CashDesks
    {
        private Dictionary<int, int> desk = new Dictionary<int, int>();

        public CashDesks()
        {

        }

        public static bool CheckBills(Bill bill)
        {
            if (bill.Amount==2 || bill.Amount==5 || bill.Amount==10 || bill.Amount==20 || bill.Amount==50 || bill.Amount==100)
            {
                return true;
            }
            return false;
        }

        public void TakeMoney(Bill bill)
        {
            if (CheckBills(bill))
            {
                if (desk.ContainsKey(bill.Amount))
                {
                    desk[bill.Amount] = desk[bill.Amount] + 1;
                }
                else
                {
                    desk.Add(bill.Amount, 1);
                }
            }
            else
            {
                Console.WriteLine("There is no bill!");
            }
        }

        public void TakeMoney(BatchBill batch)
        {
            bool check = false;
            foreach (Bill bill in batch)
            {
                if (CheckBills(bill))
                {
                    check = true;
                }
                else
                {
                    check = false;
                    break;
                }
            }

            if (check==true)
            {
                foreach (Bill bill in batch)
                {
                    if (desk.ContainsKey(bill.Amount))
                    {
                        desk[bill.Amount] = desk[bill.Amount] + 1;
                    }
                    else
                    {
                        desk.Add(bill.Amount, 1);
                    }
                }
            }
        }

        public void Inspect()
        {
            var bills = from pair in desk orderby pair.Key ascending select pair;

            foreach (var bill in bills)
            {
                Console.WriteLine("{0} - {1}", new Bill(bill.Key).ToString(), bill.Value);
            }
        }

        public void Total()
        {
            double total = 0;
            foreach (var item in desk)
            {
                total += (item.Key * item.Value);
            }

            var ri = new RegionInfo(System.Threading.Thread.CurrentThread.CurrentCulture.LCID);
            Console.WriteLine("Total = {0} " + ri.ISOCurrencySymbol + " ", total);
        }
    }
}
