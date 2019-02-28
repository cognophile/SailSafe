using System;
using System.Globalization;

namespace SailSafe.Utilities
{
    public abstract class DateTimeHelper
    {
        public static DateTime ParseStringDateTime(string dateTime)
        {
            return DateTime.ParseExact(dateTime, "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture);
        }

        public static DateTime ParseStringTime(string time)
        {
            return DateTime.ParseExact(time, "HH:mm", CultureInfo.InvariantCulture);
        }
    }
}
