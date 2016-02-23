using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        protected double Width { get; set; }
        protected double Height { get; set; }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
            this.Perimeter = (this.Width + this.Height) * 2;
            this.Area = this.Width * this.Width;
            this.Center = new Point(0.5 * this.Width, 0.5 * this.Height);
        }

        public override string ToString()
        {
            return String.Format("Rectangle with Width:{0} and Height:{1}, has Area:{2}, Perimeter:{3} and Center:{4}"
                , this.Width, this.Height, this.Area, this.Perimeter, this.Center);
        }
    }
}
