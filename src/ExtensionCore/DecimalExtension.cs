namespace ExtensionCore
{
    public static class DecimalExtension
    {
        public static decimal ToDecimal(this string val)
        {
            decimal valueReturn = 0;

            if (!val.IsNullOrEmptyOrWhiteSpace())
            {
                if (decimal.TryParse(val, out decimal aux))
                {
                    valueReturn = aux;
                }
            }

            return valueReturn;
        }

        public static decimal ToDecimal(this object val)
        {
            decimal valueReturn = 0;

            try
            {
                if (val != null)
                {
                    valueReturn = val.ToString().ToDecimal();
                }

                return valueReturn;
            }
            catch
            {
                return valueReturn;
            }
        }

    }
}
