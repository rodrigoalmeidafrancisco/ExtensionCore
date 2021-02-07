using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionCore
{
    public static class LongExtension
    {
        public static long Tolong(this string val)
        {
            long valueReturn = 0;

            if (!val.IsNullOrEmptyOrWhiteSpace())
            {
                if (long.TryParse(val, out long aux))
                {
                    valueReturn = aux;
                }
            }

            return valueReturn;
        }

        public static long Tolong(this object val)
        {
            long valueReturn = 0;

            if (val != null)
            {
                if (val is long aux)
                {
                    valueReturn = aux;
                }
            }

            return valueReturn;
        }

        public static long Tolong(this Enum value)
        {
            long aux;

            if (value == null)
            {
                aux = 0;
            }
            else
            {
                var valor = Convert.ChangeType(value, value.GetTypeCode());
                aux = valor == null ? "0".Tolong() : valor.Tolong();
            }

            return aux;
        }
    }
}
