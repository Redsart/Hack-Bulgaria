using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    public class Class1
    {
        int[] members={ 1, 2, 3 ,4, 5, 6 };

        public int this[int i]
        {
            get
            {
                return members[i];
            }
            set
            {
                members[i] = value;
            }
        }
    }
}
