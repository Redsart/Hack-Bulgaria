using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        protected Point Vertex1 { get; set; }
        protected Point Vertex2 { get; set; }
        protected Point Vertex3 { get; set; }

        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            this.Vertex1 = vertex1;
            this.Vertex2 = vertex2;
            this.Vertex3 = vertex3;
            this.Center = new Point(0, 0);
            this.Area = this.GetArea();
            this.Perimeter = this.GetPerimeter();
        }

        public override double GetArea()
        {
            return ((this.Vertex1.X * (Math.Max(this.Vertex2.Y, this.Vertex3.Y) - Math.Min(this.Vertex2.Y, this.Vertex3.Y))) +
                (this.Vertex2.X * (Math.Max(this.Vertex1.Y, this.Vertex3.Y) - Math.Min(this.Vertex1.Y, this.Vertex3.Y))) +
                (this.Vertex3.X * (Math.Max(this.Vertex1.Y, this.Vertex2.Y) - Math.Min(this.Vertex1.Y, this.Vertex2.Y)))) / 2;
        }

        public override double GetPerimeter()
        {
            double first = (Math.Pow(Math.Max(this.Vertex1.X, this.Vertex2.X) - Math.Min(this.Vertex1.X, this.Vertex2.X), 2) + (Math.Pow(Math.Max(this.Vertex1.Y, this.Vertex2.Y) - Math.Min(this.Vertex1.Y, this.Vertex2.Y), 2)));
            double second = (Math.Pow(Math.Max(this.Vertex1.X, this.Vertex3.X) - Math.Min(this.Vertex1.X, this.Vertex3.X), 2) + (Math.Pow(Math.Max(this.Vertex1.Y, this.Vertex3.Y) - Math.Min(this.Vertex1.Y, this.Vertex3.Y), 2)));
            double third=(Math.Pow(Math.Max(this.Vertex2.X,this.Vertex3.X)-(Math.Min(this.Vertex2.X,this.Vertex3.X)),2)+(Math.Pow(Math.Max(this.Vertex2.Y,this.Vertex3.Y)-Math.Min(this.Vertex2.Y,this.Vertex3.Y),2)));
            double result = first + second + third;
            return result;
        }

        public override string ToString()
        {
            return String.Format("Triangle with Vertex1:{0}, Vertex2:{1}, Vertex3:{2} have Center:{3}, Area:{4}, Perimeter:{5}"
                , this.Vertex1, this.Vertex2, this.Vertex3, this.Center, this.Area, this.Perimeter);
        }
    }
}
