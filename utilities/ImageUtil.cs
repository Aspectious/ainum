using System.Drawing;


namespace ainum.utilities
{
    public class ImageUtil
    {
        public static float[,] ConvertImageTo2DArray(Bitmap image)
        {
            int width = image.Width;
            int height = image.Height;
            float[,] data = new float[height, width];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    data[y, x] = image.GetPixel(x, y).GetBrightness();
                }
            }
            return data;
        }
    }
}