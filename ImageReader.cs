using System.IO;

namespace ainum
{
    public class ImageReader
    {
        public static byte[] getBytesFromImage(string path)
        { 
            FileInfo file = new FileInfo(path);
            byte[] data = new byte[file.Length];
            
            using (FileStream fs = file.OpenRead())
            {
                fs.Read(data, 0, data.Length);
            }
            
            return data;
        }
    }
}