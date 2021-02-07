namespace ExtensionCore
{
    public static class DoubleExtension
    {
        public static double ToDouble(this string val)
        {
            double valueReturn = 0;

            if (!val.IsNullOrEmptyOrWhiteSpace())
            {
                if (double.TryParse(val, out double aux))
                {
                    valueReturn = aux;
                }
            }

            return valueReturn;
        }

        public static double ToDouble(this object val)
        {
            double valueReturn = 0;

            try
            {
                if (val != null)
                {
                    valueReturn = val.ToString().ToDouble();
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
