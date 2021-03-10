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

            try
            {
                if (!val.IsNullOrEmptyOrWhiteSpace())
                {
                    if (byte.TryParse(val, out byte aux))
                    {
                        valueReturn = aux;
                    }
                }
            }
            catch
            {
                valueReturn = byte.MinValue;
            }

            return valueReturn;
        }

        public static byte ToByte(this Enum value)
        {
            byte valueReturn = 0;

            try
            {
                if (value != null)
                {
                    string valor = Convert.ChangeType(value, value.GetTypeCode()).ToString();
                    valueReturn = valor == null ? "0".ToByte() : valor.ToByte();
                }
            }
            catch
            {
                valueReturn = byte.MinValue;
            }

            return valueReturn;
        }

        public static byte[] ImageScale(this byte[] imageSource, int scale)
        {
            byte[] retorno = null;

            try
            {
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
            }
            catch
            {
                retorno = null;
            }

            return retorno;
        }

        public static byte[] ToPathByteArray(this string path)
        {
            byte[] retorno = null;

            try
            {
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
            }
            catch
            {
                retorno = null;
            }

            return retorno;
        }


    }
}
