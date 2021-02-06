using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.IO;

namespace ExtensionCore
{
    public static class ByteExtension
    {
        public static byte ToByte(this string val)
        {
            byte valueReturn = 0;

            if (!val.IsNullOrEmptyOrWhiteSpace())
            {
                if (byte.TryParse(val, out byte aux))
                {
                    valueReturn = aux;
                }
            }

            return valueReturn;
        }

        public static byte ToByte(this object val)
        {
            byte valueReturn = 0;

            if (val != null)
            {
                if (val is byte aux)
                {
                    valueReturn = aux;
                }
            }

            return valueReturn;
        }

        public static byte ToByte(this Enum value)
        {
            byte aux;

            if (value == null)
            {
                aux = 0;
            }
            else
            {
                var valor = Convert.ChangeType(value, value.GetTypeCode());
                aux = valor == null ? "0".ToByte() : valor.ToByte();
            }

            return aux;
        }

        public static byte[] ImageScale(this byte[] imageSource, int scale)
        {
            byte[] retorno = null;

            if (imageSource != null)
            {
                using (Image image = Image.Load(imageSource))
                {
                    image.Mutate(x => x.Resize(image.Width / scale, image.Height / scale));

                    using (var stream = new MemoryStream())
                    {
                        image.SaveAsPng(stream);
                        retorno = stream.GetBuffer();
                    }
                }
            }

            return retorno;
        }

        public static byte[] ToPathByteArray(this string path)
        {
            byte[] retorno = null;

            if (!path.IsNullOrEmptyOrWhiteSpace())
            {
                using (FileStream imageFileStream = File.OpenRead(path))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        imageFileStream.CopyTo(ms);
                        retorno = ms.ToArray();
                    }
                }
            }

            return retorno;
        }


    }
}
