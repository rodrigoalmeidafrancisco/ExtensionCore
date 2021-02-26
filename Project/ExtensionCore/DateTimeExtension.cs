using System;
using System.Globalization;

namespace ExtensionCore
{
    public static class DateTimeExtension
    {
        public static DateTime ToDateTime(this string val, CultureInfo cultureInfo = null)
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
                    else if (cultureInfo != null)
                    {
                        date = Convert.ToDateTime(val, cultureInfo);
                    }
                    else
                    {
                        date = Convert.ToDateTime(val);
                    }
                }

                return date;
            }
            catch
            {
                return date;
            }

        }

        public static DateTime? ToDateTimeNull(this string val, CultureInfo cultureInfo = null)
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
                    else if (cultureInfo != null)
                    {
                        date = Convert.ToDateTime(val, cultureInfo);
                    }
                    else
                    {
                        date = Convert.ToDateTime(val);
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
