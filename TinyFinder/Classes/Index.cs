using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TinyFinder.Controls;

namespace TinyFinder
{
    internal class Index
    {
        protected TinyMT tiny = new TinyMT();
        protected Data data = new Data();
        protected uint[] temp = new uint[4];

        public void AdvanceOnce() => tiny.nextState(temp);
        public void Advance(int count)
        {
            for (int i = 0; i < count; i++)
                tiny.nextState(temp);
        }

        public int Current(int range) => tiny.Rand(temp, range);
        public int RandCall(int range)
        {
            AdvanceOnce();
            return Current(range);
        }

        public uint CurrentU32() => tiny.temper(temp);
        public uint RandU32()
        {
            AdvanceOnce();
            return CurrentU32();
        }
        public uint RandCallUint(int n) => (uint)((RandU32() * (ulong)n) >> 32);

        public string RTC { get; set; }
        public uint InitTiny32 { get; set; }
        public uint IndexValue { get; set; }
        public uint Tiny3 { get; set; }
        public uint Tiny2 { get; set; }
        public uint Tiny1 { get; set; }
        public uint Tiny0 { get; set; }
        public ushort trainerID { get; set; }
        public ushort secretID { get; set; }
        public ushort TSV { get; set; }
        public byte TRV { get; set; }
        public uint randhex { get; set; }
        public int rand100 { get; set; }
        public bool Sync { get; set; }
        public int slot { get; set; }
        public int encounter { get; set; }
        public bool trigger { get; set; }
        public int ActualDelay { get; set; }
        public List<int> TimelineInt { get; set; } = new List<int>();
        public string timeline { get; set; }
        public bool risky { get; set; }
        public bool shiny { get; set; }
        public int flute { get; set; }
        public string Level { get; set; }
        public int itemSlot { get; set; }
        public string item { get; set; }
        
        public int HordeHA { get; set; }
        public int[] flutes = new int[5];
        public string HordeFlutes { get; set; }
        public int[] HordeLevels = new int[5];
        public int[] itemSlots = new int[5];
        public string PatchBoard { get; set; }
        public char Music { get; set; }

        public int right { get; set; }
        public int up { get; set; }
        public int EnctrType { get; set; }
        public string Type { get; set; }
        public uint LevelRand { get; set; }
        public int LevelBoost { get; set; }
        public bool DexNavHA { get; set; }
        public string eggMove { get; set; }
        public bool Boost { get; set; }
        public int potential { get; set; }
        
        public string SpeciesName { get; set; }

        public bool goodEggMove { get; set; }
        public List<uint> eggRands { get; set; } = new List<uint>();

        public int Findflute()
        {
            AdvanceOnce();

            if (Current(100) < 40)
                return 1;

            else if (Current(100) < 70)
                return 2;

            else if (Current(100) < 90)
                return 3;

            else
                return 4;

        }

        public int FindWildItem()
        {
            AdvanceOnce();

            if (Current(100) < 50)
                return 0;

            else if (Current(100) < 55)
                return 1;

            else
                return 2;
        }

    }
}