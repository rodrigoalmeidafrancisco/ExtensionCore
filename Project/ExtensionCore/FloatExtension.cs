namespace ExtensionCore
{
    public static class FloatExtension
    {
        public static float ToFloat(this string val)
        {
            float valueReturn = 0;

            if (!val.IsNullOrEmptyOrWhiteSpace())
            {
                if (float.TryParse(val, out float aux))
                {
                    valueReturn = aux;
                }
            }

            return valueReturn;
        }

        public static float ToFloat(this object val)
        {
            float valueReturn = 0;

            try
            {
                if (val != null)
                {
                    valueReturn = val.ToString().ToFloat();
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
