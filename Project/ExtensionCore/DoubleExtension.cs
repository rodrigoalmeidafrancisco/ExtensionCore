using System.Globalization;

namespace ExtensionCore
{
    public static class DoubleExtension
    {
        public static double ToDouble(this string val)
        {
            try
            {
                double valueReturn = double.MinValue;

                if (!val.IsNullOrEmptyOrWhiteSpace())
                {
                    if (double.TryParse(val, out double aux))
                    {
                        valueReturn = aux;
                    }
                }

                return valueReturn;
            }
            catch
            {
                return double.MinValue;
            }
        }

        public static double ToDouble(this string val, NumberStyles style, string cultureInfo)
        {
            try
            {
                double valueReturn = double.MinValue;

                if (!val.IsNullOrEmptyOrWhiteSpace())
                {
                    if (double.TryParse(val, style, new CultureInfo(cultureInfo), out double aux))
                    {
                        valueReturn = aux;
                    }
                }

                return valueReturn;
            }
            catch
            {
                return double.MinValue;
            }
        }

    }
}
