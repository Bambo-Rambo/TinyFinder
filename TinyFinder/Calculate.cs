using System;

namespace TinyFinder
{
    class Calculate
    {
        public uint yearMilliseconds;
        public uint startingPoint(int y)
        {
            yearMilliseconds = 0;
            for (int i = 0; i < (y - 2000); i++)
            {
                if (DateTime.IsLeapYear(2000 + i))
                    yearMilliseconds += 0x5CD78800;     
                else
                    yearMilliseconds += 0x57B12C00;
            }
            return yearMilliseconds;
        }

        public string secondsToDate(uint sec, int year)
        {
            DateTime standar = new DateTime(year, 1, 1, 13, 0, 0);
            DateTime date = standar.AddSeconds(sec);

            if (TimeZoneInfo.Local.IsDaylightSavingTime(date))
                return date.AddSeconds(3600).ToString("yyyy-MM-ddTHH:mm:ss");
            return date.ToString("yyyy-MM-ddTHH:mm:ss");
        }

        public uint FindSeconds(byte monthDiff, int year)
        {
            uint seconds;
            if (DateTime.IsLeapYear(year))
                seconds = 86400;
            else
                seconds = 0;
            for (byte i = 0; i < monthDiff - 1; i++)
                for (byte j = 0; j < days[i]; j++)
                    seconds += 86400;
            return seconds;
        }

        public uint FindMonthSeed(uint seed, uint seconds) => (seconds * 1000) + seed;


        public byte[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    }
}