using System.Linq;


namespace TinyFinder
{
    class Radar
    {
        public SlotData data = new SlotData();
        public static TinyMT tinyradar;
        public byte slot, item, randInt, music;
        public bool sync;
        public uint[] temp = new uint[4];

        public Patch[] patches = new Patch[5];
        public char Music => music < 2 ? 'A' : music > 49 ? 'M' : '-';
        public bool Shiny => patches.Any(p => p.condition == 2);
        private static byte Rand(uint[] array, ulong n) => (byte)((tinyradar.Nextuint(array) * n) >> 32);
        public Radar(uint[] current, byte length, byte num, bool Boost)
        {

            tinyradar = new TinyMT();
            current.CopyTo(temp, 0);
            randInt = Rand(temp, 100);
            if (length == 0)
            {

                tinyradar.nextState(temp);
                slot = data.getSlot(tinyradar.Rand(temp, 100), 0);

                tinyradar.nextState(temp);
                sync = randInt < 50;

                tinyradar.nextState(temp);
                if (tinyradar.Rand(temp, 100) < 50)
                    item = 50;
                else if (tinyradar.Rand(temp, 100) < 55)
                    item = 5;
                else if (tinyradar.Rand(temp, 100) < 56)
                    item = 1;
                else item = 0;

                for (int i = 0; i < 3 * (num - 1); i++)
                    tinyradar.nextState(temp);
                music = tinyradar.Rand(temp, 100);

            }
            else
            {

                for (int i = 3 * num; i > 0; i--)
                    tinyradar.nextState(temp);

                music = tinyradar.Rand(temp, 100);
                Boost &= music >= 50;

                byte ring = 0;
                for (; ring < 4; ring++)
                {
                    tinyradar.nextState(temp);
                    patches[ring] = new Patch
                    {
                        Ring = ring,
                        Direction = Rand(temp, 4),
                        Location = Rand(temp, ring * 2ul + 3ul),
                    };
                    if (tinyradar.Rand(temp, 100) < GoodRate[ring])
                    {
                        tinyradar.nextState(temp);
                        ulong Chance = Boost || length >= 40 ? 100 : (ulong)(8100 - length * 200);

                        tinyradar.nextState(temp);
                        patches[ring].condition = (byte)(tinyradar.temper(temp) * Chance <= uint.MaxValue ? 2 : 1);
                    }
                }

            }
        }

        public static byte[] GoodRate = { 23, 43, 63, 83 };

    }


    public struct Patch
    {
        private static string StateChars = "BGSX"; // Bad / Good / Shiny / Empty (Never step in)
        public byte Ring;
        public byte Direction;
        public byte Location;
        public byte condition;
        public char State => StateChars[condition];
    }

}