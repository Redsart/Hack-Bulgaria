using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    public class BatchBill: IEnumerable
    {
        private List<Bill> bills=new List<Bill>();
        private int? total = null;
        private Bill[] bills1;

        public BatchBill(List<Bill> Bills)
        {
            bills = Bills;
        }

        public BatchBill(Bill[] bills1)
        {
            // TODO: Complete member initialization
            this.bills1 = bills1;
        }

        public List<Bill> Bills
        {
            get
            {
                return this.bills;
            }
        }

        public int Total
        {
            get
            {
                if (!this.total.HasValue)
                {
                    this.total = 0;
                    foreach (var bill in bills)
                    {
                        this.total += bill.Amount;
                    }
                }
                return this.total.Value;
            }
        }

        public override string ToString()
        {
            return String.Format("You have {0} Bills and his amount is {1}",bills.Capacity,this.total);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Bills.GetEnumerator();
        }
    }
}
