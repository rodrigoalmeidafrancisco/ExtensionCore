using System.Globalization;

namespace ExtensionCore
{
    public static class DecimalExtension
    {
        public static decimal ToDecimal(this string val)
        {
            try
            {
                decimal valueReturn = decimal.MinValue;

                if (!val.IsNullOrEmptyOrWhiteSpace())
                {
                    if (decimal.TryParse(val, out decimal aux))
                    {
                        valueReturn = aux;
                    }
                }

                return valueReturn;
            }
            catch
            {
                return decimal.MinValue;
            }
        }

        public static decimal ToDecimal(this string val, NumberStyles style, string cultureInfo)
        {
            try
            {
                decimal valueReturn = decimal.MinValue;

                if (!val.IsNullOrEmptyOrWhiteSpace())
                {
                    if (decimal.TryParse(val, style, new CultureInfo(cultureInfo), out decimal aux))
                    {
                        valueReturn = aux;
                    }
                }

                return valueReturn;
            }
            catch
            {
                return decimal.MinValue;
            }
        }
       

    }
}
