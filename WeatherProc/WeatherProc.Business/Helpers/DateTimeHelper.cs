using System;

namespace WeatherProc.Business.Helpers
{
    public static class DateTimeHelper
    {
        public static DateTime UnixTimeStampToDateTime(this long uts)
        {
            DateTime date = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            date = date.AddSeconds(uts);
            return date;
        }
    }
}
