using System;
using System.IO;

namespace ainum
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            byte[] image = ImageReader.getBytesFromImage("C:\\Users\\GDSIEB01\\dev\\ainum\\Resources\\training_Data\\five_1.png");
            for (int i = 0; i < image.Length; i++)
            {
                Console.WriteLine(image[i]);
            }
        }
    }
}