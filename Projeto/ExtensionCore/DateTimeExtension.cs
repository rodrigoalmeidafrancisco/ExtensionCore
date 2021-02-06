using System;

namespace ExtensionCore
{
    public static class DateTimeExtension
    {
        public static DateTime ToDateTime(this string val)
        {
            DateTime date = DateTime.MinValue;

            if (!val.IsNullOrEmptyOrWhiteSpace())
            {
                if (DateTime.TryParse(val, out DateTime tmp))
                {
                    date = tmp;
                }
            }

            return date;
        }

        public static DateTime? ToDateTimeNull(this string val)
        {
            DateTime? date = null;

            if (!val.IsNullOrEmptyOrWhiteSpace())
            {
                if (DateTime.TryParse(val, out DateTime tmp))
                {
                    date = tmp;
                }
            }

            return date;
        }

        public static DateTime ToDateTimeDayEnd(this DateTime val)
        {
            return val.AddDays(1).AddMilliseconds(-1);
        }

        public static DateTime ToDateTimeDayEnd(this DateTime? val)
        {
            return val.HasValue ? val.Value.ToDateTimeDayEnd() : DateTime.MaxValue;
        }
    }
}
