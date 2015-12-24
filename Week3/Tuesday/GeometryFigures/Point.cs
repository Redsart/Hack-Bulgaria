using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    public class Point
    {
        public readonly int x;
        public readonly int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //copy constructor
        public Point(Point origin)
        {
            x = origin.x;
            y = origin.y;
        }

        public static bool operator ==(Point a, Point b)
        {
            bool equals = false;
            if (object.ReferenceEquals(a,b))
            {
                equals = true;
            }
            if (a.x == a.y && b.x == b.y)
            {
                equals = true;
            }
            return equals;
        }

        public static bool operator !=(Point a, Point b)
        {
            return !(a==b);
        }

        public override bool Equals(object obj)
        {
            bool equals = false;
            if (this is Point && obj is Point)
            {
                equals = true;
            }
            return equals;
        }

        public override string ToString()
        {
            return String.Format("Coordinates: {0}, {1}",x.ToString(), y.ToString());
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + x.GetHashCode();
                hash = hash * 23 + y.GetHashCode();
                return hash;
            }
        }
    }
}
