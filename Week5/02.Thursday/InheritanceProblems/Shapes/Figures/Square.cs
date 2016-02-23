using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Rectangle
    {
        protected double Side { get; set; }

        public Square(double side)
            : base(side, side)
        {
            this.Side = side;
            this.Width = this.Side;
            this.Height = this.Side;
        }

        public override string ToString()
        {
            return string.Format("Square with Sides:{0} has Perimeter:{1}, Area:{2} and Center{3}", this.Side, this.Perimeter, this.Area, this.Center);
        }
    }
}
