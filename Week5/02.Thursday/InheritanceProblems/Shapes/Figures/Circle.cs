using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Ellipse
    {
        protected double Radius { get; set; }

        public Circle(double radius)
            : base(radius, radius)
        {
            this.Radius = radius;
            if (RadiusX > RadiusY)
            {
                this.RadiusY = this.RadiusX;
            }
            else
            {
                this.RadiusX = this.RadiusY;
            }

            this.Center = new Point(this.Radius, this.Radius);
            this.Area = Math.PI * Math.Pow(this.Radius, 2);
            this.Perimeter = 2 * Math.PI * this.Radius;
        }

        public override string ToString()
        {
            return String.Format("Circle with radius{0} has Center:{1}, Area:{2} and Perimeter:{3}", this.Radius, this.Center, this.Area, this.Perimeter);
        }
    }
}
