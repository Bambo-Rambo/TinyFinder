using System;
using System.Collections.Generic;
using System.Linq;

namespace TinyFinder
{
    internal class Fishing
    {
        private TinyMT tiny = new TinyMT();
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

        public void SetTimeLine(uint[] currentState)
        {
            currentState.CopyTo(temp, 0);
            List<int> Timeline = new List<int>();
            Timeline.Add(TargetFrame + DelayRand);

            rand100 = tiny.Rand(temp, 100);

            for (byte i = 0; i < Advances; i++)
            {
                tiny.nextState(temp);
            }

            uint FirstRand = tiny.temper(temp);
            int TotalFrames = getcooldown1(FirstRand) + DelayRand - GameCorrection;     //DelayRand is the frame where the delay is calculated for each location
                                                                                        //GameCorrection is 144/146 for XY, custom for ORAS
            Timeline.Add(TargetFrame + TotalFrames);

            tiny.nextState(temp);

            if (TotalFrames < DelayRand)                            //!!! First blink already happened BEFORE before delay rand call !!!
            {
                if (tiny.temper(temp) > 0x55555555)          //Second blink (before delay) is long (Blink +2)
                {
                    tiny.nextState(temp);
                    TotalFrames += getcooldown1(tiny.temper(temp));
                    Timeline.Add(TargetFrame + TotalFrames);

                    tiny.nextState(temp);

                    ShortBlinkHappened = false;
                }
                else                                                //Second blink (before delay) is short (Blink +1, 12/20)
                {
                    tiny.nextState(temp);

                    TotalFrames += getcooldown2(tiny.temper(temp));
                    Timeline.Add(TargetFrame + TotalFrames);
                    tiny.nextState(temp);

                    if (TotalFrames < DelayRand)                                    //Delay rand was called AFTER the next blink
                    {                                                               //We know there was just a short blink, otherwise we wouldn't reach here
                        TotalFrames += getcooldown1(tiny.temper(temp));      //so the next blink is long for sure
                        Timeline.Add(TargetFrame + TotalFrames);
                        tiny.nextState(temp);

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
            ActualDelay = (ushort)(tiny.Rand(temp, 7) * 30 + 60 + SystemDelay + DelayRand - 2);


            while (TotalFrames < ActualDelay)
            {
                tiny.nextState(temp);

                if (tiny.temper(temp) > 0x55555555 || ShortBlinkHappened)     //There can't be consecutive short (12/20) blinks
                {
                    if (!ShortBlinkHappened)
                        tiny.nextState(temp);
                    TotalFrames += getcooldown1(tiny.temper(temp));

                    ShortBlinkHappened = false;
                }
                else
                {
                    tiny.nextState(temp);
                    TotalFrames += getcooldown2(tiny.temper(temp));

                    ShortBlinkHappened = true;
                }

                Timeline.Add(TargetFrame + TotalFrames);
            }

            Timeline.Add(TargetFrame + ActualDelay);
            Timeline.Sort();
            timeline = string.Join(" → ", Timeline.Take(Timeline.Count - 1)) + " (" + Timeline.LastOrDefault() + ")";

            Wild fishing = new Wild()
            {
                ratio = Ratio_Fishing,
                oras = ORAS_Fishing,
                slotType = 3,
                Noise = 0,
                CanStepHorde = false,
                XY_TallGrass = false,
            };
            fishing.GenerateIndex(temp);

            Sync = fishing.Sync;
            encounter = fishing.encounter;
            trigger = fishing.trigger;
            slot = fishing.slot;
            if (ORAS_Fishing)
                flute = fishing.flute;

        }
    }
}