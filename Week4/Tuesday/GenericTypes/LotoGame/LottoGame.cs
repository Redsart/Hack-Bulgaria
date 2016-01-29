using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoGame
{
    public class LottoGame<T,U>
        where T: IComparable<T>
        where U: IComparable<U>
    {
        private Combination<T, U> userCombination;
        private Combination<T, U> winCombination;

        public LottoGame(Combination<T,U> winningCombination)
        {
            this.GetWining = winCombination;
        }

        public void UserCombination(Combination<T, U> userCombination)
        {
            this.userCombination = userCombination;
        }

        public Combination<T, U> GetWining
        {
            get
            {
                return this.winCombination;
            }
            set
            {
                this.winCombination = value;
            }
        }
    }
}
