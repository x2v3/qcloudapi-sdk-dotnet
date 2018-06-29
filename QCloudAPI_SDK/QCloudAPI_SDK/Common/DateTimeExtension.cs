using System;
using System.Collections.Generic;
using System.Text;

namespace QCloudAPI_SDK.Common
{
    public static class DateTimeExtension
    {
        public static long ToUnixTime(this DateTime time)
        {
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1, 0, 0, 0, 0));
            long unixTime = (long)Math.Round((time - startTime).TotalMilliseconds, MidpointRounding.AwayFromZero);
            return unixTime;
        }
    }
}