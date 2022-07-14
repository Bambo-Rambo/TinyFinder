using System;
using System.Collections.Generic;
using System.Linq;

namespace TinyFinder
{
    internal class Index
    {
        protected TinyMT tiny = new TinyMT();
        protected Data data = new Data();
        protected uint[] temp = new uint[4];

        protected void Advance() => tiny.nextState(temp);
        protected byte CurrentRand(int range) => tiny.Rand(temp, range);
        protected byte RandCall(int range)
        {
            Advance();
            return tiny.Rand(temp, range);
        }

        public byte rand100;
        public byte Noise;
        public bool Sync;
        public byte slotType;
        public byte slot;
        public byte encounter;
        public bool trigger;
        public byte flute;
      //public byte item;
        
    }
}