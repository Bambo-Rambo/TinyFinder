﻿// Copyright 2007-2008 Rory Plaire (codekaizen@gmail.com)

// Adapted from:

/* C# Version Copyright (C) 2001-2004 Akihilo Kramot (Takel).  */
/* C# porting from a C-program for MT19937, originaly coded by */
/* Takuji Nishimura and Makoto Matsumoto, considering the suggestions by */
/* Topher Cooper and Marc Rieffel in July-Aug. 1997.           */
/* This library is free software under the Artistic license:   */
/*                                                             */
/* You can find the original C-program at                      */
/*     http://www.math.keio.ac.jp/~matumoto/mt.html            */
/*                                                             */

// and:

/////////////////////////////////////////////////////////////////////////////
// C# Version Copyright (c) 2003 CenterSpace Software, LLC                 //
//                                                                         //
// This code is free software under the Artistic license.                  //
//                                                                         //
// CenterSpace Software                                                    //
// 2098 NW Myrtlewood Way                                                  //
// Corvallis, Oregon, 97330                                                //
// USA                                                                     //
// http://www.centerspace.net                                              //
/////////////////////////////////////////////////////////////////////////////

// and, of course:
/* 
   A C-program for MT19937, with initialization improved 2002/2/10.
   Coded by Takuji Nishimura and Makoto Matsumoto.
   This is a faster version by taking Shawn Cokus's optimization,
   Matthe Bellew's simplification, Isaku Wada's real version.
   Before using, initialize the state by using init_genrand(seed) 
   or init_by_array(init_key, key_length).
   Copyright (C) 1997 - 2002, Makoto Matsumoto and Takuji Nishimura,
   All rights reserved.                          
   Redistribution and use in source and binary forms, with or without
   modification, are permitted provided that the following conditions
   are met:
     1. Redistributions of source code must retain the above copyright
        notice, this list of conditions and the following disclaimer.
     2. Redistributions in binary form must reproduce the above copyright
        notice, this list of conditions and the following disclaimer in the
        documentation and/or other materials provided with the distribution.
     3. The names of its contributors may not be used to endorse or promote 
        products derived from this software without specific prior written 
        permission.
   THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
   "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
   LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
   A PARTICULAR PURPOSE ARE DISCLAIMED.  IN NO EVENT SHALL THE COPYRIGHT OWNER OR
   CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL,
   EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO,
   PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
   PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
   LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
   NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
   SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
   Any feedback is very welcome.
   http://www.math.sci.hiroshima-u.ac.jp/~m-mat/MT/emt.html
   email: m-mat @ math.sci.hiroshima-u.ac.jp (remove space)
*/

using System;

namespace TinyFinder.RNG
{
    public class MersenneTwister
    {
        /* Period parameters */
        private const Int32 N = 624;
        private const Int32 M = 397;
        private const uint MatrixA = 0x9908b0df; /* constant vector a */
        private const uint UpperMask = 0x80000000; /* most significant w-r bits */
        private const uint LowerMask = 0x7fffffff; /* least significant r bits */

        /* Tempering parameters */
        public const uint TemperingMaskB = 0x9d2c5680;
        public const uint TemperingMaskC = 0xefc60000;
        public static readonly uint[] _mag01 = { 0x0, MatrixA };
        public readonly uint[] _mt = new uint[N]; /* the array for the state vector  */
        public Int16 _mti;

        public MersenneTwister(uint seed)
        {
            init(seed);
        }

        public MersenneTwister(uint[] Key)
        {
            init_by_array(Key, Key.Length);
        }

        // copy constructor
        public MersenneTwister(byte[] Data)
        {
            if (Data.Length != N * 4 + 4)
                return;
            _mti = BitConverter.ToInt16(Data, 0);
            for (int i = 0; i < N; i++)
                _mt[i] = BitConverter.ToUInt32(Data, i * 4 + 4);
        }

        #region IRNG Members

        public void Reseed(uint seed) => init(seed);

        public void Reseed(uint[] Key) => init_by_array(Key, Key.Length);

        public uint Nextuint() => Generateuint();

        public void Next() => Generateuint();

        //public PRNGState CurrentState() => new PRNGState(_mt[_mti]);

        #endregion

        public uint Generateuint()
        {
            // Run-time shuffle, modified by wwwwwwzx
            short kk = (short)(_mti < N - 1 ? _mti + 1 : 0);
            short jj = (short)(_mti < N - M ? _mti + M : _mti + M - N);
            uint y = (_mt[_mti] & UpperMask) | (_mt[kk] & LowerMask);
            _mt[_mti] = _mt[jj] ^ (y >> 1) ^ _mag01[y & 0x1];

            y = _mt[_mti];
            y ^= temperingShiftU(y);
            y ^= temperingShiftS(y) & TemperingMaskB;
            y ^= temperingShiftT(y) & TemperingMaskC;
            y ^= temperingShiftL(y);

            _mti = kk;

            return y;
        }

        private static uint temperingShiftU(uint y) => (y >> 11);

        private static uint temperingShiftS(uint y) => (y << 7);

        private static uint temperingShiftT(uint y) => (y << 15);

        private static uint temperingShiftL(uint y) => (y >> 18);

        private void init(uint seed)
        {
            _mt[0] = seed;
            for (_mti = 1; _mti < N; _mti++)
                _mt[_mti] = (uint)(1812433253U * (_mt[_mti - 1] ^ (_mt[_mti - 1] >> 30)) + _mti);

            _mti = 0;
        }

        private readonly static uint[] InitialTable = new MersenneTwister(0x12BD6AA)._mt;

        private void init_by_array(uint[] init_key, int key_length)
        {
            short i, j;
            // Reduce Run-time Calculation, modified by wwwwwwzx
            InitialTable.CopyTo(_mt, 0);
            i = 1; j = 0;
            _mti = (short)(N > key_length ? N : key_length);
            for (; _mti > 0; _mti--)
            {
                _mt[i] = (uint)((_mt[i] ^ ((_mt[i - 1] ^ (_mt[i - 1] >> 30)) * 0x19660D)) + init_key[j] + j);
                i++; j++;
                if (i >= N) { _mt[0] = _mt[N - 1]; i = 1; }
                if (j >= key_length) j = 0;
            }
            for (_mti = N - 1; _mti > 0; _mti--)
            {
                _mt[i] = (uint)((_mt[i] ^ ((_mt[i - 1] ^ (_mt[i - 1] >> 30)) * 0x5D588B65)) - i);
                i++;
                if (i >= N) { _mt[0] = _mt[N - 1]; i = 1; }
            }

            _mt[0] = 0x80000000; /* MSB is 1; assuring non-zero initial array */
        }
    }
}