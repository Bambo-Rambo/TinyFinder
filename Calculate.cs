using System;

namespace TinyFinder
{
    class Calculate
    {
        public uint yearsSeed;
        public uint findTiny(int y)
        {
            yearsSeed = 0;
            for (int i = 0; i < (y - 2000); i++)
            {
                if (DateTime.IsLeapYear(2000 + i))
                    yearsSeed += 0x5CD78800;
                else
                    yearsSeed += 0x57B12C00;
            }
            return yearsSeed;

        }

        public string secondsToDate(uint sec, int year)
        {
            DateTime date1 = new DateTime(year, 1, 1, 13, 0, 0);
            DateTime date2 = date1.AddSeconds(sec);

            if (TimeZoneInfo.Local.IsDaylightSavingTime(date2))
                return date2.AddSeconds(3600).ToString("yyyy-MM-ddTHH:mm:ss");
            return date2.ToString("yyyy-MM-ddTHH:mm:ss");
        }

        public uint findSeconds(byte monthDiff, int year)
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

        public uint findSeed(uint seed, uint seconds) => (seconds * 1000) + seed;


        public byte[] days = { 31,28,31,30,31,30,31,31,30,31,30,31 };

    }
}