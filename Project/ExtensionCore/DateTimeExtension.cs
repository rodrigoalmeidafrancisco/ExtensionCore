using System;
using System.Globalization;

namespace ExtensionCore
{
    public static class DateTimeExtension
    {
        public static DateTime ToDateTime(this string val, string cultureInfo = null)
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
                    else if (!cultureInfo.IsNullOrEmptyOrWhiteSpace())
                    {
                        date = Convert.ToDateTime(val, new CultureInfo(cultureInfo));
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

        public static DateTime? ToDateTimeNull(this string val, string cultureInfo = null)
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
                    else if (!cultureInfo.IsNullOrEmptyOrWhiteSpace())
                    {
                        date = Convert.ToDateTime(val, new CultureInfo(cultureInfo));
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
