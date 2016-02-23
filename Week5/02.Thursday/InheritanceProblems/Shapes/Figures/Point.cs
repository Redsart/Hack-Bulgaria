using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Point : IMovable
    {
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }

        public override string ToString()
        {
            return String.Format("Point (X:{0}), (Y:{1})", this.X, this.Y);
        }

        public void Move(double x, double y)
        {
            this.X += x;
            this.Y += y;
        }
    }
}
