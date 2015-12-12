using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PolygonCircumference
{
    class PolygonCircumference
    {
        static void Main(string[] args)
        {
            List<PointF> pointList = new List<PointF>();
            pointList.Add(new PointF(12.2f, 12.5f));
            pointList.Add(new PointF(14.5f,16.9f));
            pointList.Add(new PointF(24.1f, 53.2f));
            pointList.Add(new PointF(43.3f, 17.2f));

            PointF[] points = pointList.ToArray();
            Console.WriteLine(CalcCircumference(points));
        }

        private static float CalcCircumference(PointF[] points)
        {
            List<PointF> pointsList = new List<PointF>();
            pointsList = points.ToList();

            pointsList.Add(pointsList[0]);
            double result = 0;
            for (int i = 0; i < pointsList.Count - 1; i++)
            {
                result += Distance(pointsList[i + 1], pointsList[i]);
            }
            pointsList.RemoveAt(pointsList.Count - 1);
            return (float)result;
        }

        private static double Distance(PointF firstPoint, PointF secondPoint)
        {
            return Math.Sqrt((secondPoint.X-firstPoint.X)*(secondPoint.X-firstPoint.X) + (secondPoint.Y-firstPoint.Y)*(secondPoint.Y-firstPoint.Y));
        }
    }
}
