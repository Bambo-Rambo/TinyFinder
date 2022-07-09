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
        public bool TwoBlinks = false, ORAS_Fishing;

        public static int getcooldown1(uint rand) => (int)((rand * 60ul) >> 32) * 2 + 124;
        public static int getcooldown2(uint rand) => rand > 0x55555555 ? 12 : 20;

        public List<BlinkIndex> SetBlinks(uint[] current, byte advances, uint Max)
        {
            List<BlinkIndex> list = new List<BlinkIndex>();
            BlinkIndex index;

            current.CopyTo(temp, 0);

            for (uint i = 0; i < advances; i++)
                tinyfishing.nextState(temp);
            for (uint i = 0; i <= Max + 20; i++)
            {
                index = new BlinkIndex();
                if (tinyfishing.temper(temp) > 0x55555555 || TwoBlinks)
                {
                    index.IsLongBlink = true;
                    TwoBlinks = false;
                }
                else
                {
                    index.IsLongBlink = false;
                    TwoBlinks = true;
                }
                index.LongBlinkDur = getcooldown1(tinyfishing.temper(temp));
                index.ShortBlinkDur = getcooldown2(tinyfishing.temper(temp));

                list.Add(index);
                tinyfishing.nextState(temp);
            }
            return list;
        }

        public void SetTimeLine(uint[] current, List<BlinkIndex> list, uint CurrentIndex)
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

            //Initially, TotalFrames is the frame when the first blink happens after pressing A to use the rod
            int TotalFrames = getcooldown1(FirstRand) + DelayRand - GameCorrection;     //DelayRand is the frame where the delay is calculated for each location
                                                                                        //GameCorrection is 144/146 for XY, custom for ORAS
            Path.Add(TargetFrame + TotalFrames);

            tinyfishing.nextState(temp);                                                //1 - Always occurs 212 (caves) / 228 (outside) frames after using the rod
            counter++;

            if (TotalFrames < DelayRand)        //If blink happens before delay rand call, the actual delay is obviously affected
            {
                tinyfishing.nextState(temp);
                tinyfishing.nextState(temp);

                /*rand100 = tinyfishing.Rand(temp, 100);
                int Index = (int)(CurrentIndex + 2);
                if (!list.ElementAt(Index - 1).IsLongBlink)
                {
                    tinyfishing.nextState(temp);

                    TotalFrames += list.ElementAt(Index).ShortBlinkDur;

                    counter++;
                    Index++;

                    //Path.Add(TargetFrame + TotalFrames);
                }

                ActualDelay = (ushort)(tinyfishing.Rand(temp, 7) * 30 + 60 + SystemDelay + DelayRand - 2);

                
                while (TotalFrames < ActualDelay)
                {
                    if (list.ElementAt(Index - 2).IsLongBlink)
                    {
                        TotalFrames += list.ElementAt(Index).LongBlinkDur;
                        counter += 2;
                        Index += 2;

                        Path.Add(TargetFrame + TotalFrames);
                    }
                    else
                    {
                        TotalFrames += list.ElementAt(Index).ShortBlinkDur;
                        counter++;
                        Index++;

                        Path.Add(TargetFrame + TotalFrames);
                    }
                }*/
            }

            rand100 = tinyfishing.Rand(temp, 100);

            //ActualDelay = (ushort)(tinyfishing.Rand(temp, 7) * 30 + 60 + SystemDelay + BagDelay + 144); //+4 for azure bay only??
            ActualDelay = (ushort)(tinyfishing.Rand(temp, 7) * 30 + 60 + SystemDelay + DelayRand - 2);

            int Index = (int)(CurrentIndex + 3);
            while (TotalFrames < ActualDelay)
            {
                if (list.ElementAt(Index - 1).IsLongBlink)
                {
                    TotalFrames += list.ElementAt(Index).LongBlinkDur;
                    counter += 2;
                    Index += 2;

                    Path.Add(TargetFrame + TotalFrames);
                }
                else
                {
                    TotalFrames += list.ElementAt(Index).ShortBlinkDur;
                    counter++;
                    Index++;

                    Path.Add(TargetFrame + TotalFrames);
                }
            }


            Wild wild = new Wild()
            {
                ratio = Ratio_Fishing,
                oras = ORAS_Fishing,
                slotType = 3,
                NPC = (byte)counter,   //It is used for TinyMT advances here
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
