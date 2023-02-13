using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEditorConsoleApp
{
    internal class ImageProcessingManager
    {
        public Bitmap ChangePixelColor(Bitmap image, int colorR, int colorG, int colorB)
        {
            int r, g, b;

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color pixelColor = image.GetPixel(i, j);

                    r = pixelColor.R + colorR;
                    if (r > 255)
                    {
                        r = r % 255;
                    }

                    g = pixelColor.G + colorG;
                    if (g > 255)
                    {
                        g = g % 255;
                    }

                    b = pixelColor.B + colorB;
                    if (b > 255)
                    {
                        b = b % 255;
                    }

                    Color newColor = Color.FromArgb(r, g, b);

                    image.SetPixel(i, j, newColor);
                }
            }

            return image;
        }
        internal void SaveFile(Bitmap image)
        {
            Console.Write("Enter new file name: ");
            string newImage = Console.ReadLine()+".jpg";

            image.Save(newImage);

            Console.WriteLine("Image saved successfully");
        }
    }
}
