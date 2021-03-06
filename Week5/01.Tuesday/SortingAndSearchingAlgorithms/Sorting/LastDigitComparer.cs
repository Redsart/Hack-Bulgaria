﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class LastDigitComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            int firstDigit = x;
            int secondDigit = y;
            int firstDigitLength = firstDigit.ToString().Length;
            int secondDigitLength = secondDigit.ToString().Length;

            if (firstDigitLength > 1)
            {
                firstDigit = int.Parse(x.ToString()[firstDigitLength - 1].ToString());
            }
            if (secondDigitLength > 1)
            {
                secondDigit = int.Parse(x.ToString()[firstDigitLength - 1].ToString());
            }

            if (firstDigit > secondDigit)
            {
                return 1;
            }
            else if (firstDigit < secondDigit)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
