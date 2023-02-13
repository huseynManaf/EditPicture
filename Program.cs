using PhotoEditorConsoleApp;
using System;
using System.Drawing;

namespace PhotoEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            var imageProcessingManager = new ImageProcessingManager();

            string key = "";
            while (key != "quit")
            {

                Console.Write("enter path:");
                string imagePath = (Console.ReadLine());
                Bitmap image = new Bitmap(imagePath);
                

                Console.WriteLine($"1.Random Filter\n2.Custom Filter");

            start:
                key = Console.ReadLine();


                switch (key)
                {
                    case "1":
                        var random = new Random();
                        int r = random.Next(0, 255);
                        int g = random.Next(0, 255);
                        int b = random.Next(0, 255);
                        Bitmap newRandmImage = imageProcessingManager.ChangePixelColor(image, r, g, b);
                        imageProcessingManager.SaveFile(newRandmImage);
                        image.Dispose();
                        break;
                    case "2":
                        Console.Write("R:");
                        int colorR = int.Parse(Console.ReadLine());
                        Console.Write("G:");
                        int colorG = int.Parse(Console.ReadLine());
                        Console.Write("B:");
                        int colorB = int.Parse(Console.ReadLine());
                        Bitmap newImage = imageProcessingManager.ChangePixelColor(image, colorR, colorG, colorB);
                        imageProcessingManager.SaveFile(newImage);
                        image.Dispose();
                        break;
                    default:
                        Console.WriteLine("switch correct case:");
                        goto start;
                        
                }
            }
        }
    }
}