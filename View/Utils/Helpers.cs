using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace View.Utils
{
    class Helpers
    {
        public static BitmapImage ConvertByteToImageBitmap(byte[] array)
        {
            MemoryStream ms = new MemoryStream(array);
            var image = new BitmapImage();
            image.BeginInit();
            image.CacheOption = BitmapCacheOption.OnLoad;
            image.StreamSource = ms;
            image.EndInit();
            return image;
        }
        public static byte[] ConvertImageToByte(BitmapImage image)
        {
            var encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(image));
            var ms = new MemoryStream();
            encoder.Save(ms);
            return ms.ToArray();
        }
    }
}
