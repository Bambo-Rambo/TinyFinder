using System;
using System.Collections.Generic;
using System.Text;

namespace TinyFinder.Methods
{
    class DexNav
    {
        public bool trigger, sync, eggmove, HA, levelboost, shiny;
        public byte rand, slot, X, Y, flute, item, potential, delay = 0;
        public TinyMT tinynav = new TinyMT();
        public uint[] temp = new uint[4];

        public DexNav(uint[] current, uint searchlevel, uint chain, bool charm)
        {
            current.CopyTo(temp, 0);
            tinynav.nextState(temp);
            rand = tinynav.Rand(temp, 100);

            trigger = rand < 50;

        }
    }
}
