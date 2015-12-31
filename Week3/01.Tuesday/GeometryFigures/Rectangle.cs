using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    public class Rectangle
    {
        private Point A, B, C, D;
        private LineSegment AB, CD;

        public Rectangle(Point firstPoint, Point secondPoint)
        {
            PointA = new Point(Math.Min(firstPoint.x, secondPoint.x), Math.Min(firstPoint.y, secondPoint.y));
            PointB = new Point(Math.Max(firstPoint.x, secondPoint.x), Math.Min(firstPoint.y, secondPoint.y));
            PointC = new Point(Math.Max(firstPoint.x, secondPoint.x), Math.Max(firstPoint.y, secondPoint.y));
            PointD = new Point(Math.Min(firstPoint.x, secondPoint.x), Math.Max(firstPoint.y, secondPoint.y));

            AB = new LineSegment(A, B);
            CD = new LineSegment(C, D);
        }

        public Rectangle(Rectangle rect)
        {
            rect.A = A;
            rect.B = B;
            rect.C = C;
            rect.D = D;
        }

        public Point PointA
        {
            get
            {
                return this.A;
            }
            private set
            {
                this.A = value;
            }
        }

        public Point PointB
        {
            get
            {
                return this.B;
            }
            private set
            {
                this.B = value;
            }
        }

        public Point PointC
        {
            get
            {
                return this.C;
            }
            private set
            {
                if (value.x==A.x && value.y==A.y)
                {
                    throw new ArgumentException("Invalid C coordinates!");
                }
                this.C = value;
            }
        }

        public Point PointD
        {
            get
            {
                return this.D;
            }
            private set
            {
                if (value.x==B.x && value.y==B.y)
                {
                    throw new ArgumentException("Invalid D coordinates!");
                }
                this.D = value;
            }
        }

        public double Height
        {
            get
            {
                return (D.y - A.y);
            }
        }

        public double Width
        {
            get
            {
                return (Math.Max(A.x, B.x) - Math.Min(A.x, B.x));
            }
        }

        public Point Center
        {
            get
            {
                return new Point (A.x + Width / 2,A.y + Height / 2);
            }
        }

        public double GetArea()
        {
            return ((B.x - A.x) * (D.y - A.y));
        }

        public double GetPerimeter()
        {
            return (((B.x - A.x) * 2) + ((C.y - B.y) * 2));
        }

        public override string ToString()
        {
            return String.Format("Rectangle[({0},{1}), ({2},{3})]",PointA,PointC,Height,Width);
        }

        public override bool Equals(object obj)
        {
            Rectangle rect = obj as Rectangle;
            if (obj is Rectangle)
            {
                if (Width==rect.Width && Height==rect.Height)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(Rectangle firstRect, Rectangle secondRect)
        {
            if (firstRect.A==secondRect.A && firstRect.B==secondRect.B && firstRect.C==secondRect.C && firstRect.D==secondRect.D)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Rectangle firstRect, Rectangle secondRect)
        {
            return !(firstRect == secondRect);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Height.GetHashCode();
                hash = hash * 23 + Width.GetHashCode();
                return hash;
            }
        }
    }
}
