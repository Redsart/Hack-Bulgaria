using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairHW
{
    public class Pair
    {
        private int X;
        private int Y;

        public Pair(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override bool Equals(object obj)
        {
            var obj1 = this;
            var obj2 = (Pair)obj;
            if (obj1.X==obj2.X && obj1.Y==obj2.Y)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
                string message="This class compare two Pair members using Equals method.";
                return message;
        }

        public static bool operator ==(Pair a, Pair b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Pair a, Pair b)
        {

            return !a.Equals(b);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + X.GetHashCode();
                hash = hash * 23 + Y.GetHashCode();
                return hash;
            }
        }
    }
}
