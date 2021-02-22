using System;

namespace ExtensionCore
{
    public static class DateTimeExtension
    {
        public static DateTime ToDateTime(this string val)
        {
            DateTime date = DateTime.MinValue;

            try
            {
                if (!val.IsNullOrEmptyOrWhiteSpace())
                {
                    if (DateTime.TryParse(val, out DateTime tmp))
                    {
                        date = tmp;
                    }
                }

                return date;
            }
            catch
            {
                return date;
            }

        }

        public static DateTime? ToDateTimeNull(this string val)
        {
            DateTime? date = null;

            try
            {
                if (!val.IsNullOrEmptyOrWhiteSpace())
                {
                    if (DateTime.TryParse(val, out DateTime tmp))
                    {
                        date = tmp;
                    }
                }

                return date;
            }
            catch
            {
                return date;
            }
        }

        public static DateTime ToDateTimeDayEnd(this DateTime val)
        {
            try
            {
                return val.AddDays(1).AddMilliseconds(-1);
            }
            catch
            {
                return DateTime.MaxValue;
            }
        }

        public static DateTime ToDateTimeDayEnd(this DateTime? val)
        {
            try
            {
                return val.HasValue ? val.Value.ToDateTimeDayEnd() : DateTime.MaxValue;
            }
            catch
            {
                return DateTime.MaxValue;
            }
        }
    }
}
