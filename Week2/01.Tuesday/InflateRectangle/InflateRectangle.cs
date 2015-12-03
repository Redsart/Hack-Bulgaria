using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InflateRectangle
{
    class InflateRectangle
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(0, 0, 10, 10);
            Size size=new Size(2, 2);

            Inflate(ref rect, size);
        }

        private static void Inflate(ref Rectangle rect, Size inflateSize)
        {
            rect.Inflate(inflateSize.Width, inflateSize.Height);
            Console.WriteLine(rect);
        }
    }
}
