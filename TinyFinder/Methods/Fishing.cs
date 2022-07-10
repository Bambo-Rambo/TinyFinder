using System;
using System.Collections.Generic;
using System.Linq;

namespace TinyFinder
{
    internal class Fishing
    {
        private TinyMT tinyfishing = new TinyMT();
        private uint[] temp = new uint[4];

        public byte rand100, slot, encounter, flute, Ratio_Fishing;
        public bool Sync, trigger;

        public byte Advances, party;
        public ushort SystemDelay, ActualDelay;
        public int DelayRand, GameCorrection, TargetFrame;
        public string timeline;
        public bool TwoBlinks, ORAS_Fishing;

        public static int getcooldown1(uint rand) => (int)((rand * 60ul) >> 32) * 2 + 124;
        public static int getcooldown2(uint rand) => rand > 0x55555555 ? 12 : 20;

        public void SetTimeLine(uint[] current)
        {
            current.CopyTo(temp, 0);
            List<int> Path = new List<int>();
            Path.Add(TargetFrame + DelayRand);

            uint counter = 0;
            for (byte i = 0; i < Advances; i++)
            {
                tinyfishing.nextState(temp);
                counter++;
            }

            uint FirstRand = tinyfishing.temper(temp);

            int TotalFrames = getcooldown1(FirstRand) + DelayRand - GameCorrection;

            Path.Add(TargetFrame + TotalFrames);

            tinyfishing.nextState(temp);
            counter++;

            rand100 = tinyfishing.Rand(temp, 100);

            ActualDelay = (ushort)(tinyfishing.Rand(temp, 7) * 30 + 60 + SystemDelay + DelayRand - 2);

            TwoBlinks = false;
            while (TotalFrames < ActualDelay)
            {
                tinyfishing.nextState(temp);
                if (tinyfishing.temper(temp) > 0x55555555 || TwoBlinks)
                {
                    if (!TwoBlinks)
                        tinyfishing.nextState(temp);

                    TotalFrames += getcooldown1(tinyfishing.temper(temp));
                    counter += 2;

                    Path.Add(TargetFrame + TotalFrames);
                    TwoBlinks = false;
                }
                else
                {
                    tinyfishing.nextState(temp);
                    TotalFrames += getcooldown2(tinyfishing.temper(temp));
                    counter++;

                    Path.Add(TargetFrame + TotalFrames);
                    TwoBlinks = true;
                }
            }


            Wild wild = new Wild()
            {
                ratio = Ratio_Fishing,
                oras = ORAS_Fishing,
                slotType = 3,
                NPC = (byte)counter,   //counter is the number of advances due to blinks
                CanStepHorde = false,
                XY_TallGrass = false,
            };
            wild.results(current);

            Sync = wild.Sync;
            encounter = wild.encounter;
            trigger = wild.trigger;
            slot = wild.slot;
            if (ORAS_Fishing)
                flute = wild.flute;

            Path.Add(TargetFrame + ActualDelay);
            Path.Sort();
            timeline = string.Join(" → ", Path.Take(Path.Count - 1)) + " (" + Path.LastOrDefault() + ")";

            if (getcooldown1(FirstRand) + (DelayRand - GameCorrection) < DelayRand)
            {
                rand100 = 100;
                trigger = false;
            }
        }

        public void Findflute()
        {
            tinyfishing.nextState(temp);
            if (tinyfishing.Rand(temp, 100) < 40)
                flute = 1;
            else if (tinyfishing.Rand(temp, 100) < 70)
                flute = 2;
            else if (tinyfishing.Rand(temp, 100) < 90)
                flute = 3;
            else flute = 4;

            /*tinywild.nextState(temp);
            tinywild.nextState(temp);
            if (tinywild.Rand(temp, 100) < 50)
                item = 50;
            else if (tinywild.Rand(temp, 100) < 55)
                item = 5;
            else if (tinywild.Rand(temp, 100) < 56)
                item = 1;
            else item = 0;*/
        }
    }
}