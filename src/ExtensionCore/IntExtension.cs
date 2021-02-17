using System;

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

        public static int? ToIntNull(this string val)
        {
            int? valueReturn = null;

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

        public static int? ToIntNull(this object val)
        {
            int? valueReturn = null;

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

        public static int? ToIntNull(this Enum value)
        {
            int? aux = null;

            if (value != null)
            {
                var valor = Convert.ChangeType(value, value.GetTypeCode());
                aux = valor == null ? "0".ToInt() : valor.ToInt();
            }

            return aux;
        }

    }
}
