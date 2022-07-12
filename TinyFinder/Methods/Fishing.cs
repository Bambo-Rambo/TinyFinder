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
        public bool ShortBlinkHappened, ORAS_Fishing;

        public static int getcooldown1(uint rand) => (int)((rand * 60ul) >> 32) * 2 + 124;      //Long Blink duration > 124
        public static int getcooldown2(uint rand) => rand > 0x55555555 ? 12 : 20;               //Short blink duration 12/20

        public void SetTimeLine(uint[] current)
        {
            current.CopyTo(temp, 0);
            List<int> Timeline = new List<int>();
            Timeline.Add(TargetFrame + DelayRand);

            rand100 = tinyfishing.Rand(temp, 100);

            for (byte i = 0; i < Advances; i++)
            {
                tinyfishing.nextState(temp);
            }

            uint FirstRand = tinyfishing.temper(temp);
            int TotalFrames = getcooldown1(FirstRand) + DelayRand - GameCorrection;     //DelayRand is the frame where the delay is calculated for each location
                                                                                        //GameCorrection is 144/146 for XY, custom for ORAS
            Timeline.Add(TargetFrame + TotalFrames);

            tinyfishing.nextState(temp);

            if (TotalFrames < DelayRand)                            //!!! First blink already happened BEFORE before delay rand call !!!
            {
                if (tinyfishing.temper(temp) > 0x55555555)          //Second blink (before delay) is long (Blink +2)
                {
                    tinyfishing.nextState(temp);
                    TotalFrames += getcooldown1(tinyfishing.temper(temp));
                    Timeline.Add(TargetFrame + TotalFrames);

                    tinyfishing.nextState(temp);

                    ShortBlinkHappened = false;
                }
                else                                                //Second blink (before delay) is short (Blink +1, 12/20)
                {
                    tinyfishing.nextState(temp);

                    TotalFrames += getcooldown2(tinyfishing.temper(temp));
                    Timeline.Add(TargetFrame + TotalFrames);
                    tinyfishing.nextState(temp);

                    if (TotalFrames < DelayRand)                                    //Delay rand was called AFTER the next blink
                    {                                                               //We know there was just a short blink, otherwise we wouldn't reach here
                        TotalFrames += getcooldown1(tinyfishing.temper(temp));      //so the next blink is long for sure
                        Timeline.Add(TargetFrame + TotalFrames);
                        tinyfishing.nextState(temp);

                        ShortBlinkHappened = false;
                    }
                    else                                                            //Delay rand was called BEFORE the next blink
                    {
                        ShortBlinkHappened = true;
                    }
                }
            }
            else                                                    //!!! First blink will happen AFTER delay rand call !!!
            {
                ShortBlinkHappened = false;
            }

          //ActualDelay = (ushort)(tinyfishing.Rand(temp, 7) * 30 + 60 + SystemDelay + BagDelay + 144); //+4 for azure bay only??
            ActualDelay = (ushort)(tinyfishing.Rand(temp, 7) * 30 + 60 + SystemDelay + DelayRand - 2);


            while (TotalFrames < ActualDelay)
            {
                tinyfishing.nextState(temp);

                if (tinyfishing.temper(temp) > 0x55555555 || ShortBlinkHappened)     //There can't be consecutive short (12/20) blinks
                {
                    if (!ShortBlinkHappened)
                        tinyfishing.nextState(temp);
                    TotalFrames += getcooldown1(tinyfishing.temper(temp));

                    ShortBlinkHappened = false;
                }
                else
                {
                    tinyfishing.nextState(temp);
                    TotalFrames += getcooldown2(tinyfishing.temper(temp));

                    ShortBlinkHappened = true;
                }

                Timeline.Add(TargetFrame + TotalFrames);
            }

            Wild fishing = new Wild()
            {
                ratio = Ratio_Fishing,  // > 67 for cities???
                oras = ORAS_Fishing,
                slotType = 3,
                NPC = 0,
                CanStepHorde = false,
                XY_TallGrass = false,
            };
            fishing.results(temp);

            Sync = fishing.Sync;
            encounter = fishing.encounter;
            trigger = fishing.trigger;
            slot = fishing.slot;
            if (ORAS_Fishing)
                flute = fishing.flute;

            Timeline.Add(TargetFrame + ActualDelay);
            Timeline.Sort();
            timeline = string.Join(" → ", Timeline.Take(Timeline.Count - 1)) + " (" + Timeline.LastOrDefault() + ")";

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