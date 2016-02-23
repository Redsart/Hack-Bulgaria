using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape : IMovable
    {
        protected double Perimeter { get; set; }
        protected double Area { get; set; }
        protected Point Center { get; set; }

        public virtual double GetPerimeter()
        {
            return this.Perimeter;
        }

        public virtual double GetArea()
        {
            return this.Area;
        }

        public void Move(double x, double y)
        {
            this.Center.X += x;
            this.Center.Y += y;
        }

        public override string ToString()
        {
            return String.Format("Perimeter: {0}, Area: {1}",this.GetPerimeter(),this.GetArea());
        }
    }
}
