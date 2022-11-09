using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TinyFinder.Main;
using TinyFinder.Properties;

namespace TinyFinder
{
    internal class Fishing : Index
    {
        public static int getcooldown1(uint rand) => (int)((rand * 60ul) >> 32) * 2 + 124;      //Long Blink duration > 124
        public static int getcooldown2(uint rand) => rand > 0x55555555 ? 12 : 20;               //Short blink duration 12/20
        public bool ShortBlinkHappened;

        public Fishing(uint[] currentState, UISettings current)
        {
            currentState.CopyTo(temp, 0);
            List<int> Timeline = new List<int>();
            Timeline.Add(current.targetFrame + current.delayRand);

            rand100 = CurrentRand(100);

            for (byte i = 0; i < current.advances; i++)
            {
                Advance();
            }

            uint FirstRand = tiny.temper(temp);

            //DelayRand is the frame where the delay is calculated for each location
            //GameCorrection is 144/146 for XY, custom for ORAS
            int TotalFrames = getcooldown1(FirstRand) + current.delayRand - current.gameCorrection;     
                                                                                                         
            Timeline.Add(current.targetFrame + TotalFrames);

            Advance();

            if (TotalFrames < current.delayRand)                    //!!! First blink already happened BEFORE before delay rand call !!!
            {
                if (tiny.temper(temp) > 0x55555555)                 //Second blink (before delay) is long (Blink +2)
                {
                    Advance();
                    TotalFrames += getcooldown1(tiny.temper(temp));
                    Timeline.Add(current.targetFrame + TotalFrames);

                    Advance();

                    ShortBlinkHappened = false;
                }
                else                                                //Second blink (before delay) is short (Blink +1, 12/20)
                {
                    Advance();

                    TotalFrames += getcooldown2(tiny.temper(temp));
                    Timeline.Add(current.targetFrame + TotalFrames);
                    Advance();

                    if (TotalFrames < current.delayRand)                            //Delay rand was called AFTER the next blink
                    {                                                               //We know there was just a short blink, otherwise we wouldn't reach here
                        TotalFrames += getcooldown1(tiny.temper(temp));             //so the next blink is long for sure
                        Timeline.Add(current.targetFrame + TotalFrames);
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
            ActualDelay = (ushort)(CurrentRand(7) * 30 + 60 + current.delayRand - 2);
            if (current.citra)
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

                Timeline.Add(current.targetFrame + TotalFrames);
            }

            Timeline.Add(current.targetFrame + ActualDelay);
            Timeline.Sort();
            timeline = string.Join(" → ", Timeline.Take(Timeline.Count - 1)) + " (" + Timeline.LastOrDefault() + ")";

            Wild fishing = new Wild(temp, current);
            Sync = fishing.Sync;
            encounter = fishing.encounter;
            trigger = fishing.trigger;
            slot = fishing.slot;
            if (current.oras)
                flute = fishing.flute;
            itemSlot = fishing.itemSlot;
        }
    }
}