using System.Linq;
using TinyFinder.Main;

namespace TinyFinder
{
    class Radar : Index
    {
        public Patch[] patches = new Patch[5];

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

        public Radar(uint[] currentState, UISettings current)
        {
            currentState.CopyTo(temp, 0);

            rand100 = RandCall(100);

            if (current.chain == 0)
            {
                Sync = rand100 < 50;

                slot = data.getSlot(RandCall(100), 0);

                itemSlot = FindItem();

                Music = CurrentRand(100) < 2 ? 'A' : CurrentRand(100) > 49 ? 'M' : '-';

            }
            else
            {
                for (byte i = 0; i < current.advances; i++)         // 0 if using from Y menu
                    Advance();                                      // 27 if using from Bag

                Boost = current.bonusMusic && CurrentRand(100) >= 50;
                Music = CurrentRand(100) < 2 ? 'A' : CurrentRand(100) > 49 ? 'M' : '-';
            }

            byte ring = 0;
            for (; ring < 4; ring++)
            {
                patches[ring] = new Patch
                {
                    Ring = ring,
                    Direction = RandCall(4),
                    Location = RandCall(ring * 2 + 3),
                };
                if (RandCall(100) < GoodRate[ring])
                {
                    tiny.nextState(temp);
                    ulong Chance = Boost || current.chain >= 40 ? 100 : (ulong)(8100 - current.chain * 200);

                    tiny.nextState(temp);
                    patches[ring].condition = (byte)(tiny.temper(temp) * Chance <= uint.MaxValue ? 2 : 1);
                }
                shiny = patches.Any(p => p.condition == 2);
            }

            // 1 empty patch
            ring = RandCall(3);
            patches[4] = new Patch
            {
                Ring = ring,
                Direction = RandCall(4),
                Location = RandCall(ring * 2 + 3),
                condition = 3,
            };

            PatchBoard = string.Join("\n", Overview.Select(ov => ov));

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