using System;

namespace ExtensionCore
{
    public static class TimeSpanExtension
    {
        public static TimeSpan ToTimeSpan(this DateTime dataHora)
        {
            return new TimeSpan(dataHora.Hour, dataHora.Minute, dataHora.Second);
        }

    }
}
