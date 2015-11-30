using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GrayscaleImage
{
    class GrayscaleImage
    {
        static void Main(string[] args)
        {
            Bitmap bmp = (Bitmap)Image.FromFile("arthas.bmp");

            GreyScaleImage(bmp);
        }

        private static void GreyScaleImage(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color pixel = bmp.GetPixel(i, j);
                    Color newPixel = Color.FromArgb(pixel.G, pixel.G, pixel.G);
                    bmp.SetPixel(i, j, newPixel);
                }
            }
            bmp.Save("newArthas.bmp");
        }
    }
}
