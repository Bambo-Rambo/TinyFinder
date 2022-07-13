using System.Linq;
namespace TinyFinder
{
    class Radar
    {
        public Data data = new Data();
        public static TinyMT tiny;
        public byte slot, rand100, music, chain, party; //public byte item;
        public bool sync, BonusMusic, boost;
        public uint[] temp = new uint[4];

        public Patch[] patches = new Patch[5];
        public char Music => music < 2 ? 'A' : music > 49 ? 'M' : '-';
        public bool Shiny => patches.Any(p => p.condition == 2);
        private static byte Rand(uint[] array, ulong n) => (byte)((tiny.Nextuint(array) * n) >> 32);

        public string[] Overview
        {
            get
            {
                var a = new bool[9].Select(b => Enumerable.Repeat('#', 9).ToArray()).ToArray(); // 9x9 '#'
                a[4][4] = 'C'; // Center
                foreach (var p in patches)
                    if (a[p.Y][p.X] == '#')
                        a[p.Y][p.X] = p.State;
                return a.Select(t => new string(t)).ToArray();
            }
        }

        public void GenerateIndex(uint[] currentState)
        {
            tiny = new TinyMT();
            currentState.CopyTo(temp, 0);
            rand100 = Rand(temp, 100);
            if (chain == 0)
            {
                sync = rand100 < 50;

                tiny.nextState(temp);
                slot = data.getSlot(tiny.Rand(temp, 100), 0);

                tiny.nextState(temp);
                tiny.nextState(temp);
                /*if (tinyradar.Rand(temp, 100) < 50)
                    item = 50;
                else if (tinyradar.Rand(temp, 100) < 55)
                    item = 5;
                else if (tinyradar.Rand(temp, 100) < 56)
                    item = 1;
                else item = 0;*/

                for (int i = 0; i < 3 * (party - 1); i++)
                    tiny.nextState(temp);
                music = tiny.Rand(temp, 100);

            }
            else
            {

                /*Number of Advances calculated only once in FindResults.cs:
                                                                                        // 0 if using from Y menu
                for (byte i = 0; i < Advances + (3 * party); i++)                       // 27 if using from Bag
                    tinyhoney.nextState(temp);                                          */

                music = tiny.Rand(temp, 100);
                boost = BonusMusic && music >= 50;

                byte ring = 0;
                for (; ring < 4; ring++)
                {
                    patches[ring] = new Patch
                    {
                        Ring = ring,
                        Direction = Rand(temp, 4),
                        Location = Rand(temp, ring * 2ul + 3ul),
                    };
                    if (Rand(temp, 100) < GoodRate[ring])
                    {
                        tiny.nextState(temp);
                        ulong Chance = boost || chain >= 40 ? 100 : (ulong)(8100 - chain * 200);

                        tiny.nextState(temp);
                        patches[ring].condition = (byte)(tiny.temper(temp) * Chance <= uint.MaxValue ? 2 : 1);
                    }
                }
                // 1 empty patch
                ring = Rand(temp, 3);
                patches[4] = new Patch
                {
                    Ring = ring,
                    Direction = Rand(temp, 4),
                    Location = Rand(temp, ring * 2ul + 3ul),
                    condition = 3,
                };
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

        public int X
        {
            get
            {
                switch (Direction)
                {
                    case 0:
                    case 1:
                        return 3 - Ring + Location;
                    case 2:
                        return 3 - Ring;
                    case 3:
                        return 5 + Ring;
                }
                return 4;
            }
        }
        public int Y
        {
            get
            {
                switch (Direction)
                {
                    case 0:
                        return 3 - Ring;
                    case 1:
                        return 5 + Ring;
                    case 2:
                    case 3:
                        return 3 - Ring + Location;
                }
                return 4;
            }
        }
    }
}