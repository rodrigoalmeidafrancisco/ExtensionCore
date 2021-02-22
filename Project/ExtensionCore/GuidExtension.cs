using System;

namespace ExtensionCore
{
    public static class GuidExtension
    {
        public static Guid ToGuid(this string val)
        {
            Guid valueReturn = Guid.Empty;

            if (!val.IsNullOrEmptyOrWhiteSpace())
            {
                if (Guid.TryParse(val, out Guid aux))
                {
                    valueReturn = aux;
                }
            }

            return valueReturn;
        }

    }
}
