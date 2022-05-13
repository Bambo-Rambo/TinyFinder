using System;

namespace TinyFinder
{
    class Calculate
    {
        public byte[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public uint yearMilliseconds;

        //TinyMT
        public uint startingPoint(int year)
        {
            yearMilliseconds = 0;
            for (int i = 0; i < (year - 2000); i++)
            {
                if (DateTime.IsLeapYear(2000 + i))
                    yearMilliseconds += 0x5CD78800;     //A leap year has 31622400000 milliseconds. In hex -> 0x75CD78800 -> 0x5CD78800
                else
                    yearMilliseconds += 0x57B12C00;     //A non leap year has 31536000000. In hex -> 0x757B12C00 -> 0x57B12C00
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
                seconds = 86400;        //A single day has 86400 seconds
            else
                seconds = 0;
            for (byte i = 0; i < monthDiff - 1; i++)
                for (byte j = 0; j < days[i]; j++)
                    seconds += 86400;
            return seconds;
        }

        public uint FindMonthSeed(uint seed, uint seconds) => (seconds * 1000) + seed;


        //MT
        public uint FindSavePar(DateTime CitraRTC, uint CurrentSavePar, uint ActualSeed, uint TargetSeed)
        {
            //https://gist.github.com/zaksabeast/c2140499a1c8280602d63d08937d22f9
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            double CurrentMS = Convert.ToInt64((CitraRTC - epoch).TotalMilliseconds);
            double TimeVar = CurrentMS - 946684800000;

            uint ExpectedSeed = (uint)(CurrentSavePar + TimeVar) & 0xFFFFFFFF;
            uint Correction = ExpectedSeed - ActualSeed;
            return (uint)(TargetSeed - TimeVar + Correction);
        }
    }
}