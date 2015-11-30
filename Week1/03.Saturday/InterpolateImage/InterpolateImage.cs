using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InterpolateImage
{
    class InterpolateImage
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size: ");
            double newSize=double.Parse(Console.ReadLine());
            Bitmap bitmap = (Bitmap)Image.FromFile("arthas.bmp");
            string savePath = "resized.bmp";
            ResampleImage(bitmap, newSize, savePath);
        }

        private static void ResampleImage(Bitmap bitmap, double newSize, string savePath)
        {
            Console.Write("Type 'lower' or 'higher' to resize the picture: ");
            string choice = Console.ReadLine();
            if (choice == "lower")
            {
                Bitmap lowerResized = new Bitmap(bitmap, new Size(bitmap.Width / (int)Math.Round(newSize), bitmap.Height / (int)Math.Round(newSize)));
                lowerResized.Save("resized.bmp");
            }
            else if (choice == "higher")
            {
                Bitmap upperResized = new Bitmap(bitmap, new Size(bitmap.Width * (int)Math.Round(newSize), bitmap.Height * (int)Math.Round(newSize)));
                upperResized.Save(savePath);
            }
        }
    }
}
