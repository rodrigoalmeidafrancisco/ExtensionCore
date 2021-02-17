using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ExtensionCore
{
    public static class StreamExtension
    {
        public static Stream ToBitmapStream(this Bitmap bitmap, ImageFormat imageFormat)
        {
            Image image = bitmap;

            using (Stream stream = new MemoryStream())
            {
                image.Save(stream, imageFormat);
                stream.Position = 0;
                return stream;
            }
        }


    }
}
