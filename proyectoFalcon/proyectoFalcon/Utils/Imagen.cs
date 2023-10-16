using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoFalcon.Utils
{
    public class Imagen
    {

        public static byte[] imageToByte(Image image)
        {
            using (var stream = new MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                return stream.ToArray();
            }
        }

        public static Image bytesToImage(byte[] bytes)
        {
            using (var stream = new MemoryStream(bytes))
            {
                return Image.FromStream(stream);
            }
        }
    }
}
