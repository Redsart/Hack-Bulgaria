using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFigures
{
    class GeometryFiguresMain
    {
        static void Main(string[] args)
        {
            Point pointA = new Point(3, 4);
            Point pointB = new Point(6, 8);
            Point pointC = new Point(3, 4);
            Point pointD = new Point(6, 8);
            Rectangle firstRectangle = new Rectangle(pointA, pointB);
            Rectangle secondRectangle = new Rectangle(pointC, pointD);
            Console.WriteLine("Rectangle area is: {0}",firstRectangle.GetArea());
            Console.WriteLine("Rectang;e perimeter is: {0}",firstRectangle.GetPerimeter());
            Console.WriteLine(firstRectangle.ToString());
            Console.WriteLine(firstRectangle.Equals(secondRectangle));
        }
    }
}
