using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTimeZone
{
    public static class CustomTimeZone
    {
        public static DateTime TehranTimeZone()
        {
            string displayName = "(GMT+03:30) Iran/Tehran Time";
            string standardName = "Tehran Time";
            TimeSpan offset = new TimeSpan(03, 30, 00);
            TimeZoneInfo Tehran = TimeZoneInfo.CreateCustomTimeZone(standardName, offset, displayName, standardName);
            return TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, Tehran);
        }


        public static DateTime BaghdadTimeZone()
        {
            string displayName = "(GMT+03) Iraq/Baghdad Time";
            string standardName = "Baghdad Time";
            TimeSpan offset = new TimeSpan(03, 00, 00);
            TimeZoneInfo Baghdad = TimeZoneInfo.CreateCustomTimeZone(standardName, offset, displayName, standardName);
            return TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, Baghdad);
        }

        public static DateTime BeirutTimeZone()
        {
            string displayName = "(GMT+02) Lebanon/Beirut Time";
            string standardName = "Beirut Time";
            TimeSpan offset = new TimeSpan(02, 00, 00);
            TimeZoneInfo Beirut = TimeZoneInfo.CreateCustomTimeZone(standardName, offset, displayName, standardName);
            return TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, Beirut);
        }

        public static DateTime BerlinTimeZone()
        {
            string displayName = "(GMT+02) Germany/Berlin Time";
            string standardName = "Berlin Time";
            TimeSpan offset = new TimeSpan(02, 00, 00);
            TimeZoneInfo Berlin = TimeZoneInfo.CreateCustomTimeZone(standardName, offset, displayName, standardName);
            return TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, Berlin);
        }

        public static DateTime BeijingTimeZone()
        {
            string displayName = "(GMT+08) China/Beijigng Time";
            string standardName = "Beijing Time";
            TimeSpan offset = new TimeSpan(08, 00, 00);
            TimeZoneInfo Beijing = TimeZoneInfo.CreateCustomTimeZone(standardName, offset, displayName, standardName);
            return TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, Beijing);
        }

        public static DateTime TokyoTimeZone()
        {
            string displayName = "(GMT+09) Jpan/Tokyo Time";
            string standardName = "Tokyo Time";
            TimeSpan offset = new TimeSpan(09, 00, 00);
            TimeZoneInfo Tokyo = TimeZoneInfo.CreateCustomTimeZone(standardName, offset, displayName, standardName);
            return TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, Tokyo);
        }

        public static DateTime LondonTimeZone()
        {
            string displayName = "(GMT+01) United Kingdom/London Time";
            string standardName = "London Time";
            TimeSpan offset = new TimeSpan(01, 00, 00);
            TimeZoneInfo London = TimeZoneInfo.CreateCustomTimeZone(standardName, offset, displayName, standardName);
            return TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, London);
        }

        public static DateTime NewYorkTimeZone()
        {
            string displayName = "(GMT-05) United State/New York Time";
            string standardName = "New York Time";
            TimeSpan offset = new TimeSpan(-05, 00, 00);
            TimeZoneInfo NewYork = TimeZoneInfo.CreateCustomTimeZone(standardName, offset, displayName, standardName);
            return TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, NewYork);
        }
    }
}
