using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CashDesk
{
    public class Bill
    {
        private int amount;
        
        public int Amount
        {
            get
            {
                return this.amount;
            }
            set
            {
                this.amount = value;
            }
        }

        public Bill(int amount)
        {
            this.Amount = amount;
        }

        public override string ToString()
        {
            var ri = new RegionInfo(System.Threading.Thread.CurrentThread.CurrentCulture.LCID);
            return String.Format("{0} {1} Bill",this.amount,ri.ISOCurrencySymbol);
        }

        public override bool Equals(object obj)
        {
            Bill obj2 = obj as Bill;
            if (obj2 is Bill)
            {
                if (this.amount==obj2.amount)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(Bill a, Bill b)
        {
            if (a.amount==b.amount)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Bill a, Bill b)
        {
            return !(a == b);
        }

        public static explicit operator int(Bill bill)
        {
            return (int)bill;
        }
    }
}
