using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionCore
{
    public static class IntExtension
    {
        public static int ToInt(this string val)
        {
            int valueReturn = 0;

            if (!val.IsNullOrEmptyOrWhiteSpace())
            {
                if (int.TryParse(val, out int aux))
                {
                    valueReturn = aux;
                }
            }

            return valueReturn;
        }

        public static int ToInt(this object val)
        {
            int valueReturn = 0;

            if (val != null)
            {
                if (val is int aux)
                {
                    valueReturn = aux;
                }
            }

            return valueReturn;
        }

        public static int ToInt(this Enum value)
        {
            int aux;

            if (value == null)
            {
                aux = 0;
            }
            else
            {
                var valor = Convert.ChangeType(value, value.GetTypeCode());
                aux = valor == null ? "0".ToInt() : valor.ToInt();
            }

            return aux;
        }


    }
}
