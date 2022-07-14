using System;
using System.Collections.Generic;
using System.Linq;

namespace TinyFinder
{
    internal class Fishing : Index
    {
        public byte Advances;
        public ushort ActualDelay;
        public string timeline;
        public bool ShortBlinkHappened;

        public static int getcooldown1(uint rand) => (int)((rand * 60ul) >> 32) * 2 + 124;      //Long Blink duration > 124
        public static int getcooldown2(uint rand) => rand > 0x55555555 ? 12 : 20;               //Short blink duration 12/20

        public uint[] FindStateHit(uint[] currentState, int TargetFrame, bool Citra, int DelayRand, int GameCorrection)
        {
            currentState.CopyTo(temp, 0);
            List<int> Timeline = new List<int>();
            Timeline.Add(TargetFrame + DelayRand);

            rand100 = CurrentRand(100);

            for (byte i = 0; i < Advances; i++)
            {
                Advance();
            }

            uint FirstRand = tiny.temper(temp);
            int TotalFrames = getcooldown1(FirstRand) + DelayRand - GameCorrection;     //DelayRand is the frame where the delay is calculated for each location
                                                                                        //GameCorrection is 144/146 for XY, custom for ORAS
            Timeline.Add(TargetFrame + TotalFrames);

            Advance();

            if (TotalFrames < DelayRand)                            //!!! First blink already happened BEFORE before delay rand call !!!
            {
                if (tiny.temper(temp) > 0x55555555)                 //Second blink (before delay) is long (Blink +2)
                {
                    Advance();
                    TotalFrames += getcooldown1(tiny.temper(temp));
                    Timeline.Add(TargetFrame + TotalFrames);

                    Advance();

                    ShortBlinkHappened = false;
                }
                else                                                //Second blink (before delay) is short (Blink +1, 12/20)
                {
                    Advance();

                    TotalFrames += getcooldown2(tiny.temper(temp));
                    Timeline.Add(TargetFrame + TotalFrames);
                    Advance();

                    if (TotalFrames < DelayRand)                                    //Delay rand was called AFTER the next blink
                    {                                                               //We know there was just a short blink, otherwise we wouldn't reach here
                        TotalFrames += getcooldown1(tiny.temper(temp));             //so the next blink is long for sure
                        Timeline.Add(TargetFrame + TotalFrames);
                        Advance();

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

          //ActualDelay = (ushort)(CurrentRand(7) * 30 + 60 + SystemDelay + BagDelay + 144); //+4 for azure bay only??
            ActualDelay = (ushort)(CurrentRand(7) * 30 + 60 + DelayRand - 2);
            if (Citra)
                ActualDelay++;


            while (TotalFrames < ActualDelay)
            {
                Advance();

                if (tiny.temper(temp) > 0x55555555 || ShortBlinkHappened)           //There can't be consecutive short (12/20) blinks
                {
                    if (!ShortBlinkHappened)
                        Advance();
                    TotalFrames += getcooldown1(tiny.temper(temp));

                    ShortBlinkHappened = false;
                }
                else
                {
                    Advance();
                    TotalFrames += getcooldown2(tiny.temper(temp));

                    ShortBlinkHappened = true;
                }

                Timeline.Add(TargetFrame + TotalFrames);
            }

            Timeline.Add(TargetFrame + ActualDelay);
            Timeline.Sort();
            timeline = string.Join(" → ", Timeline.Take(Timeline.Count - 1)) + " (" + Timeline.LastOrDefault() + ")";

            return temp;
        }

        public void GenerateFishing(uint[] currentState, byte ratio, bool oras)
        {
            Wild fishing = new Wild()
            {
                slotType = 3,
                Noise = 0,
            };
            fishing.GenerateIndex(currentState, ratio, oras, false, false);

            Sync = fishing.Sync;
            encounter = fishing.encounter;
            trigger = fishing.trigger;
            slot = fishing.slot;
            if (oras)
                flute = fishing.flute;
        }
    }
}