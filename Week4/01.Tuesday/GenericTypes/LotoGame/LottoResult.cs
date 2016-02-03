using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoGame
{
    public class LottoResult<T,U>
        where T: IComparable<T>
        where U: IComparable<U>
    {
        private bool isWining;
        private byte matchedNumberCount;

        public LottoResult(Combination<T,U> winCombination, Combination<T,U> userCombination)
        {
            byte numbers;
            IsWining = Combination<T,U>.GetMatchetNumbers(winCombination,userCombination, out numbers);
            MatchedNumberCount = numbers;
            Console.WriteLine(isWining);
            Console.WriteLine(MatchedNumberCount);
        }

        public bool IsWining
        {
            get
            {
                return this.isWining;
            }
            set
            {
                this.isWining = value;
            }
        }

        public byte MatchedNumberCount
        {
            get
            {
                return this.matchedNumberCount;
            }
            set
            {
                this.matchedNumberCount = value;
            }
        }
    }
}
