using System;

namespace ExtensionCore
{
    public static class BoolExtension
    {
        public static bool IsBetween(this DateTime val, DateTime start, DateTime end)
        {
            return val >= start && val <= end;
        }

        public static bool IsBetween(this int val, int start, int end)
        {
            return val >= start && val <= end;
        }

        public static bool IsBetween(this long val, long start, long end)
        {
            return val >= start && val <= end;
        }

        public static bool IsBetween(this decimal val, decimal start, decimal end)
        {
            return val >= start && val <= end;
        }

        public static bool IsBetween(this float val, float start, float end)
        {
            return val >= start && val <= end;
        }

        public static bool IsBetween(this double val, double start, double end)
        {
            return val >= start && val <= end;
        }

        public static bool IsBetween(this TimeSpan val, TimeSpan start, TimeSpan end)
        {
            return val >= start && val <= end;
        }

        public static bool IsNullOrEmpty(this string val)
        {
            return string.IsNullOrEmpty(val);
        }

        public static bool IsNullOrWhiteSpace(this string val)
        {
            return string.IsNullOrWhiteSpace(val);
        }

        public static bool IsNullOrEmptyOrWhiteSpace(this string val)
        {
            return string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val);
        }

    }
}
