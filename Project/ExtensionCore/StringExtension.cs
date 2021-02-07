using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExtensionCore
{
    public static class StringExtension
    {
        public static string ToDate(this DateTime val, string specificCulture)
        {
            return val.ToString(CultureInfo.CreateSpecificCulture(specificCulture));
        }

        public static string ToDateBR(this DateTime val)
        {
            return val.ToDate("pt-BR");
        }

        public static string ToDateTimeBR(this DateTime datetime)
        {
            return datetime.ToString("dd/MM/yyyy HH:mm:ss");
        }

        public static string ToDateTimeUS(this DateTime datetime)
        {
            return datetime.ToString("yyyy/MM/dd HH:mm:ss");
        }

        public static string ReduceText(this string val, int maximoCaracteres)
        {
            if (!val.IsNullOrEmptyOrWhiteSpace() && val.Length > maximoCaracteres)
            {
                val = $"{val.Substring(0, maximoCaracteres)}";
            }

            return val;
        }

        public static string ReduceTextWithEllipsis(this string val, int maximoCaracteres)
        {
            if (!val.IsNullOrEmptyOrWhiteSpace() && val.Length > maximoCaracteres)
            {
                val = $"{val.Substring(0, maximoCaracteres)}...";
            }

            return val;
        }

    }
}
