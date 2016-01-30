using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoGame
{
    public class Combination<T,U>
        where T: IComparable<T>
        where U: IComparable<U>
    {
        private T first, second, third;
        private U fourth, fifth, sixth;

        public Combination(T a, T b, T c, U d, U e, U f)
        {
            this.First = a;
            this.Second = b;
            this.Third = c;
            this.Fourth = d;
            this.Fifth = e;
            this.Sixth = f;
        }

        public T First
        {
            get
            {
                return this.first;
            }
            set
            {
                this.first = value;
            }
        }

        public T Second
        {
            get
            {
                return this.second;
            }
            set
            {
                this.second = value;
            }
        }

        public T Third
        {
            get
            {
                return this.third;
            }
            set
            {
                this.third = value;
            }
        }

        public U Fourth
        {
            get
            {
                return this.fourth;
            }
            set
            {
                this.fourth = value;
            }
        }

        public U Fifth
        {
            get
            {
                return this.fifth;
            }
            set
            {
                this.fifth = value;
            }
        }

        public U Sixth
        {
            get
            {
                return this.sixth;
            }
            set
            {
                this.sixth = value;
            }
        }

        public override bool Equals(object obj)
        {
            byte number;
            return GetMatchetNumbers(this, obj as Combination<T, U>, out number);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + this.First.GetHashCode();
                hash = hash * 23 + this.Second.GetHashCode();
                hash = hash * 23 + this.Third.GetHashCode();
                hash = hash * 23 + this.Fourth.GetHashCode();
                hash = hash * 23 + this.Fifth.GetHashCode();
                hash = hash * 23 + this.Sixth.GetHashCode();
                return hash;
            }
        }

        public static bool GetMatchetNumbers(Combination<T,U> firstCombination, Combination<T,U> secondCombination, out byte numbersMatched)
        {
            numbersMatched = 0;
            bool isWining = false;

            if (firstCombination.First.CompareTo(secondCombination.First)==0)
            {
                numbersMatched++;
                isWining = true;
            }

            if (firstCombination.Second.CompareTo(secondCombination.Second)==0)
            {
                numbersMatched++;
                isWining = true;
            }

            if (firstCombination.Third.CompareTo(secondCombination.Third)==0)
            {
                numbersMatched++;
                isWining = true;
            }

            if (firstCombination.Fourth.CompareTo(secondCombination.Fourth)==0)
            {
                numbersMatched++;
                isWining = true;
            }

            if (firstCombination.Fifth.CompareTo(secondCombination.Fifth)==0)
            {
                numbersMatched++;
                isWining = true;
            }

            if (firstCombination.Sixth.CompareTo(secondCombination.Sixth)==0)
            {
                numbersMatched++;
                isWining = true;
            }
            return isWining;
        }
    }
}
