using System;
using System.Collections.Generic;
using System.Text;

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
