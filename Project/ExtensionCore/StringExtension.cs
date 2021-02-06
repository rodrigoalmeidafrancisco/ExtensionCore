using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExtensionCore
{
    public static class StringExtension
    {
        public static string ToDate(this DateTime datetime, string specificCulture)
        {
            return datetime.ToString(CultureInfo.CreateSpecificCulture(specificCulture));
        }

        public static string ToDateBR(this DateTime datetime)
        {
            return datetime.ToDate("pt-BR");
        }



    }
}
