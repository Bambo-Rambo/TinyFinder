using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TinyFinder.Main;

namespace TinyFinder.Controls
{
    internal class BlinkSystem
    {
        public int LongCooldown(uint rand) => (int)((rand * 60ul) >> 32) * 2 + 124;
        public int ShortCooldown(uint rand) => rand > 0x55555555 ? 12 : 20;

        private int Current(int value) => index.Current(value);
        private int RandCall(int value) => index.RandCall(value);
        private uint CurrentU32 => index.CurrentU32();
        private uint RandU32 => index.RandU32();

        private void AdvanceOnce() => index.AdvanceOnce();
        private void Advance(int value)
        {
            for (int i = 0; i < value; i++)
                AdvanceOnce();
        }

        private Index index;
        private List<int> Timeline => index.TimelineInt;
        private int interactFrame;
        private bool ShortBlinkHappened;

        public BlinkSystem(Index index)
        {
            this.index = index;
        }

        public void Apply(UISettings current)
        {
            interactFrame = current.interactMTFrame;

            if (current.encounterKey == EnctrKey.Fishing)
            {
                /*
                Advance(current.advances);          // Advances are -1 because we need to calculate the 1st blink cycle duration

                ShortBlinkHappened = true;     // The blink cycle after exiting bag is guaranteed to be long

                int DelayRand;  // The frame that calls the rand that determines delay
                if (current.oras)
                {
                    DelayRand = current.longBlinkRand + (ushort)(current.emulator ? 154 : 148);
                }
                else
                {
                    DelayRand = current.longBlinkRand + (ushort)(current.emulator ? 142 : 144);
                }

                // For some reason, the 1st long cycle begins earlier than the moment it is being determined
                int MTAdvances = current.longBlinkRand;

                // First we need to calculate the number of TinyMT advances (due to blinks) until delay determination (DelayRand)
                AdvancesAtRange(ref MTAdvances, DelayRand);

                index.ActualDelay = (ushort)(DelayRand + RandCall(7) * 30 + 58);

                // Then we need to calculate the number of TinyMT advances (due to blinks) until delay ends (ActualDelay)
                AdvancesAtRange(ref MTAdvances, index.ActualDelay);
                */

                int MTAdvances = current.longBlinkRand + LongCooldown(CurrentU32);

                if (current.oras)
                    MTAdvances -= 16;

                Timeline.Add(MTAdvances);
                ShortBlinkHappened = false;

                Advance(current.advances);      // party * 3 + NPC influence (0/1/2)

                // 4 frames delay for registering the rod + 132 for the rand call that determines delay
                int DelayRand = interactFrame + 4 + 132;
                Timeline.Add(DelayRand);

                AdvancesAtRange(ref MTAdvances, DelayRand);

                index.ActualDelay = (ushort)(DelayRand + 58 + RandCall(7) * 30);
                AdvancesAtRange(ref MTAdvances, index.ActualDelay);
                Timeline.Add(index.ActualDelay);

                index.ActualDelay -= interactFrame;

            }

            else if (current.encounterKey == EnctrKey.RockSmash)
            {
                /*
                Advance(current.advances);

                index.ActualDelay = (ushort)current.longBlinkRand;

                if (current.oras)
                {
                    index.ActualDelay += (ushort)(current.emulator ? 290 : 300);      // Smeargle

                    //ActualDelay += (ushort)current.delayrandtemp;
                }
                else
                {
                    index.ActualDelay += (ushort)(current.emulator ? 274 : 276);      // Smeargle

                    // 300 on Azure bay retail
                    // 272 glittering

                    //ActualDelay += (ushort)current.delayrandtemp;
                }

                int MTAdvances = current.longBlinkRand + LongCooldown(CurrentU32) - 2;  // Unstable 0/2/4

                ShortBlinkHappened = false;
                Timeline.Add(MTAdvances);

                Advance(3);
                AdvanceOnce();  // The Pokemon's cry animation

                AdvancesAtRange(ref MTAdvances, index.ActualDelay);
                */

                Advance(current.advances);

                int MTAdvances = current.longBlinkRand + LongCooldown(CurrentU32);

                if (current.oras)
                    MTAdvances -= 16;

                Timeline.Add(MTAdvances);
                ShortBlinkHappened = false;

                index.ActualDelay = interactFrame + 276;

                AdvancesAtRange(ref MTAdvances, interactFrame + 18);    // There is a small delay (18) until rock smash is activated
                Advance(3);
                Timeline.Add(interactFrame + 18);

                AdvancesAtRange(ref MTAdvances, interactFrame + 66);    // The Pokemon's first blink during cry animation?
                AdvanceOnce();
                Timeline.Add(interactFrame + 66);

                AdvancesAtRange(ref MTAdvances, index.ActualDelay);

                Timeline.Add(index.ActualDelay);
                index.ActualDelay -= interactFrame;
            }

            else if (current.encounterKey == EnctrKey.Horde || current.encounterKey == EnctrKey.Honey)
            {
                ShortBlinkHappened = true;

                // If exit the bag using B, countdown begins 16 frames earlier
                // if exit the bag using X, countdown begins 4 frames earlier instead
                // 44 should probably become current.longBlinkRand - 4

                int MTAdvances = current.longBlinkRand;
                if (current.oras)
                    MTAdvances -= 4;

                index.ActualDelay = (ushort)(current.longBlinkRand + current.honeyDelay);
                Timeline.Add(index.ActualDelay);

                AdvancesAtRange(ref MTAdvances, index.ActualDelay);
            }

            else if (current.encounterKey == EnctrKey.DexNavSrch)
            {
                // After exiting the bag at Index 14, 1 rand call for determining the first (long) cycle 

                // If exit the bag using B, countdown begins 16 frames earlier
                // if exit the bag using X, countdown begins 4 frames earlier instead

                int MTAdvances = current.longBlinkRand  + LongCooldown(CurrentU32) - 4;     // The first long blink cycle just passed
                ShortBlinkHappened = false;                         // so the next one can be short
                Timeline.Add(MTAdvances);

                AdvanceOnce();      // The character's next stretching upon closing the X menu

                index.ActualDelay = (ushort)(40 * RandCall(3) + 138);     // Search Function Animation delay
                Timeline.Add(interactFrame + index.ActualDelay);

                AdvancesAtRange(ref MTAdvances, index.ActualDelay + interactFrame);
            }

        }

        // A short blink cycle will always happen before the long blink not after

        // Example
        //  (20)    -> Short cycle
        //  (178)   -> Long cycle

        // After a short blink cycle -> a long cycle is guaranteed so there is always only 1 rand call for exact frame number (ex. 178)
        // After a long blink cycle -> always 2 rand calls, 1 for short/long and one for exact frame number

        public void AdvancesAtRange(ref int MTAdvances, int Delay)
        {
            while (MTAdvances < Delay)
            {
                if (ShortBlinkHappened || RandU32 > 0x55555555)
                {
                    MTAdvances += LongCooldown(RandU32);
                    ShortBlinkHappened = false;
                }
                else
                {
                    MTAdvances += ShortCooldown(RandU32);
                    ShortBlinkHappened = true;
                }
                Timeline.Add(MTAdvances);
            }
        }

    }
}
