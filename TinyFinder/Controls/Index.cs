using System;
using System.Collections.Generic;

namespace TinyFinder
{
    internal class Index
    {
        protected TinyMT tiny = new TinyMT();
        protected Data data = new Data();
        protected uint[] temp = new uint[4];


        protected int pointer;
        public byte Current(List<uint> rngList, int n)
        {
            return (byte)((rngList[pointer] * (ulong)n) >> 32);
        }
        public byte Rand(List<uint> rngList, int n)
        {
            Advance(1);
            return (byte)((rngList[pointer] * (ulong)n) >> 32);
        }

        public uint RandUint(List<uint> rngList, int n)
        {
            Advance(1);
            return (uint)((rngList[pointer] * n) >> 32);
        }
        public void Advance(int totalRands) => pointer += totalRands;


        protected void AdvanceOnce() => tiny.nextState(temp);
        protected byte CurrentRand(int range) => tiny.Rand(temp, range);
        protected byte RandCall(int range)
        {
            AdvanceOnce();
            return tiny.Rand(temp, range);
        }



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
        public byte rand100 { get; set; }
        public bool Sync { get; set; }
        public byte slot { get; set; }
        public byte encounter { get; set; }
        public bool trigger { get; set; }
        public ushort ActualDelay { get; set; }
        public string timeline { get; set; }
        public bool shiny { get; set; }
        public byte flute { get; set; }
        public string Level { get; set; }
        public int itemSlot { get; set; }
        public string item { get; set; }
        
        public byte HordeHA { get; set; }
        public byte[] flutes = new byte[5];
        public string HordeFlutes { get; set; }
        public byte[] HordeLevels = new byte[5];
        public byte[] itemSlots = new byte[5];
        public string PatchBoard { get; set; }
        public char Music { get; set; }

        public sbyte right { get; set; }
        public sbyte up { get; set; }
        public int EnctrType { get; set; }
        public string Type { get; set; }
        public uint LevelRand { get; set; }
        public int LevelBoost { get; set; }
        public bool DexNavHA { get; set; }
        public string eggMove { get; set; }
        public bool Boost { get; set; }
        public byte potential { get; set; }
        
        public string SpeciesName { get; set; }

        public bool goodEggMove { get; set; }
        public List<uint> eggRands = new List<uint>();

        public byte Findflute(List<uint> rngList)
        {
            Advance(1);

            if (Current(rngList, 100) < 40)
                return 1;

            else if (Current(rngList, 100) < 70)
                return 2;

            else if (Current(rngList, 100) < 90)
                return 3;

            else
                return 4;

        }

        public byte FindItem(List<uint> rngList)
        {
            Advance(1);

            if (Current(rngList, 100) < 50)
                return 0;

            else if (Current(rngList, 100) < 55)
                return 1;

            else
                return 2;
        }
        
    }
}