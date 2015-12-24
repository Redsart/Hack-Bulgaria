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
        public readonly int pointA;
        public readonly int pointB;

        public LineSegment(Point pointA, Point pointB)
        {
            if (pointA.x==pointB.y)
            {
                throw new ArgumentException("Cannot create a line segment with zero lenght");
            }
            this.pointA = pointA.x;
            this.pointB = pointB.y;
        }

        // copy constructor
        public LineSegment(LineSegment origin)
        {
            pointA = origin.pointA;
            pointB = origin.pointB;
        }

        public static bool operator ==(LineSegment a,LineSegment b)
        {

        }

        public static bool operator !=(LineSegment a, LineSegment b)
        {

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
    }
}
