using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Combination<int, string> winningCombination = new Combination<int, string>(1, 2, 3, "a", "b", "c");
            Combination<int, string> newCombination = new Combination<int, string>(1, 2, 3, "a", "c", "b");
            LottoGame<int, string> obj = new LottoGame<int, string>(winningCombination);
            obj.UserCombination(newCombination);
            LottoResult<int, string> obj1 = new LottoResult<int, string>(winningCombination, newCombination);
        }
    }
}
