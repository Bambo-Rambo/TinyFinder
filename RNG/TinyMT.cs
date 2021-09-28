using System;
using System.Collections.Generic;
using System.Text;

namespace TinyFinder
{
    class TinyMT
    {
        public const uint mat1 = 0x8f7011ee;
        public const uint mat2 = 0xfc78ff1f;
        public const uint tmat = 0x3793fdff;

        private const uint TINYMT32_MASK = 0x7FFFFFFF;
        private const int TINYMT32_SH0 = 1;
        private const int TINYMT32_SH1 = 10;
        private const int TINYMT32_SH8 = 8;
        private const int MIN_LOOP = 8;
        private const int PRE_LOOP = 8;

        public uint[] state = new uint[4];

        public uint temper(uint[] array)
        {
            uint t0 = array[3];
            uint t1 = array[0] + (array[2] >> TINYMT32_SH8);

            t0 ^= t1;
            if ((t1 & 1) == 1)
            {
                t0 ^= tmat;
            }
            return t0;
        }

        public void nextState(uint[] status)
        {
            uint y = status[3];
            uint x = (status[0] & TINYMT32_MASK) ^ status[1] ^ status[2];
            x ^= (x << TINYMT32_SH0);
            y ^= (y >> TINYMT32_SH0) ^ x;
            status[0] = status[1];
            status[1] = status[2];
            status[2] = x ^ (y << TINYMT32_SH1);
            status[3] = y;
            if ((y & 1) == 1)
            {
                status[1] ^= mat1;
                status[2] ^= mat2;
            }

        }

        public uint[] init(uint seed, int adv) //Takes the TinyMT initial seed and returns the (initial state + adv) (depending on the method)
        {
            state[0] = seed;
            state[1] = mat1;
            state[2] = mat2;
            state[3] = tmat;

            for (int i = 1; i < MIN_LOOP; i++)
                state[i & 3] ^= (uint)i + 1812433253U * (state[(i - 1) & 3] ^ (state[(i - 1) & 3] >> 30));

            for (int i = 0; i < PRE_LOOP + adv; i++)
                nextState(state);

            return state;
        }

        public byte Rand(uint[] array, int n) => (byte)((temper(array) * (ulong)n) >> 32);

        public uint Nextuint(uint[] array)
        {
            nextState(array);
            return temper(array);
        }

    }
}
