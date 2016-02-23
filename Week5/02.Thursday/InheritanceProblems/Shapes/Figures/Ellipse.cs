using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Ellipse : Shape
    {
        protected double RadiusX { get; set; }
        protected double RadiusY { get; set; }

        public Ellipse(double semiAxesX, double semiAxesY)
        {
            this.RadiusX = semiAxesX;
            this.RadiusY = semiAxesY;
            this.Center = new Point(this.RadiusX, this.RadiusY);
            this.Area = Math.PI * this.RadiusX * this.RadiusY;
            this.Perimeter = Math.PI * ((3 * (this.RadiusX + this.RadiusY)) - Math.Sqrt(((3 * this.RadiusX) + this.RadiusY) * ((3 * this.RadiusY) + RadiusX)));
        }

        public override string ToString()
        {
            return String.Format("Eclipse with SemiAxes(X:{0}),(Y:{1}) has Center{2}, Area:{3} and Perimeter:{4}"
                , this.RadiusX, this.RadiusY, this.Center, this.Area, this.Perimeter);
        }
    }
}
