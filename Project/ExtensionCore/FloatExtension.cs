using System.Globalization;

namespace ExtensionCore
{
    public static class FloatExtension
    {
        public static float ToFloat(this string val)
        {
            try
            {
                float valueReturn = float.MinValue;

                if (!val.IsNullOrEmptyOrWhiteSpace())
                {
                    if (float.TryParse(val, out float aux))
                    {
                        valueReturn = aux;
                    }
                }

                return valueReturn;
            }
            catch 
            {
                return float.MinValue;
            }
        }

        public static float ToFloat(this string val, NumberStyles style, string cultureInfo)
        {
            try
            {
                float valueReturn = float.MinValue;

                if (!val.IsNullOrEmptyOrWhiteSpace())
                {
                    if (float.TryParse(val, style, new CultureInfo(cultureInfo), out float aux))
                    {
                        valueReturn = aux;
                    }
                }

                return valueReturn;
            }
            catch
            {
                return float.MinValue;
            }
        }


    }
}
