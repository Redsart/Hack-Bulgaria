using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            var circle = new Circle(3.5);
            var ellipse = new Ellipse(5, 4);
            var rectangle = new Rectangle(4.5, 5);
            var triangle = new Triangle(new Point(4.5,5),new Point(2,3), new Point(3.2,4));
            var square = new Square(5.6);

            shapes.Add(circle);
            shapes.Add(ellipse);
            shapes.Add(rectangle);
            shapes.Add(triangle);
            shapes.Add(square);

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.ToString());
                Console.WriteLine();
            }
        }
    }
}
