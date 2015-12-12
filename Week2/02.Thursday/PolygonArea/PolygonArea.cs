using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PolygonArea
{
    class PolygonArea
    {
        static void Main(string[] args)
        {
            List<PointF> pointList = new List<PointF>();
            pointList.Add(new PointF(12.2f, 12.5f));
            pointList.Add(new PointF(14.5f, 16.9f));
            pointList.Add(new PointF(24.1f, 53.2f));
            pointList.Add(new PointF(43.3f, 17.2f));

            PointF[] points = pointList.ToArray();
            Console.WriteLine(CalcArea(points));

        }

        private static float CalcArea(PointF[] points)
        {
            int j;
            double area = 0;

            for (int i = 0; i < points.Length; i++)
            {
                j = (i + 1) % points.Length;

                area += points[i].X * points[j].Y;
                area -= points[i].Y * points[j].X;
            }

            area /= 2;
            return (float)Math.Abs(area);
        }
    }
}
