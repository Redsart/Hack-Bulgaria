using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    public class LineSegment
    {
        //public Point coord;
        public readonly Point pointA;
        public readonly Point pointB;
        private double distance;

        public LineSegment(Point pointA, Point pointB)
        {
            if (pointA.x==pointB.y)
            {
                throw new ArgumentException("Cannot create a line segment with zero lenght");
            }
            this.pointA = pointA;
            this.pointB = pointB;
        }

        // copy constructor
        public LineSegment(LineSegment origin)
        {
            pointA = origin.pointA;
            pointB = origin.pointB;
        }

        public double GetLength()
        {
            double length = Math.Pow(Math.Max(pointA.x, pointA.y) - Math.Min(pointA.x, pointA.y), 2) -
                Math.Pow(Math.Max(pointB.x, pointB.y) - Math.Min(pointB.x, pointB.y), 2);
            return Math.Sqrt(length);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + pointA.GetHashCode();
                hash = hash * 23 + pointB.GetHashCode();
                return hash;
            }
        }

        public static bool operator ==(LineSegment a,LineSegment b)
        {
            bool equals = false;
            if (a.GetLength()==b.GetLength())
            {
                equals = true;
            }
            return equals;
        }

        public static bool operator !=(LineSegment a, LineSegment b)
        {
            return !(a==b);
        }

        public static bool operator <(LineSegment a, LineSegment b)
        {
            if (a.GetLength() < b.GetLength())
            {
                return true;
            }
            return false;
        }

        public static bool operator >(LineSegment a, LineSegment b)
        {
            if (a > b)
            {
                return true;
            }
            return false;
        }

        public static bool operator >=(LineSegment a, LineSegment b)
        {
            if (a >= b)
            {
                return true;
            }
            return false;
        }

        public static bool operator <=(LineSegment a, LineSegment b)
        {
            if (a <= b)
            {
                return true;
            }
            return false;
        }

        public static bool operator <(LineSegment a, double b)
        {
            if (a.GetLength() < b)
            {
                return true;
            }
            return false;
        }

        public static bool operator > (LineSegment a, double b)
        {
            if (a.GetLength() > b)
            {
                return true;
            }
            return false;
        }

        public static bool operator <=(LineSegment a, double b)
        {
            if (a.GetLength() <= b)
            {
                return true;
            }
            return false;
        }

        public static bool operator >=(LineSegment a, double b)
        {
            if (a.GetLength() >= b)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return String.Format("Line[({0},{1}),({2},{3})]",pointA.x,pointA.y,pointB.x,pointB.y);
        }
    }
}
