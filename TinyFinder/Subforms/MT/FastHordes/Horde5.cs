using System;
using System.Windows.Forms;
using TinyFinder.RNG;

namespace TinyFinder.Subforms.MT
{
    public partial class MTForm
    {
        bool Carbink5 = false;
        void Charm_Sync_HA_Gender(uint seed, uint frame, uint psv, bool charm, bool sync, byte HA, bool genderless, string pattern)
        {
            string species = genderless ? "Genderless" : Carbink5 ? "Carbink" : "Any";

            Invoke(new Action(() => { HORDE_DGV.Rows.Add(hex(seed), frame, psv, charm, sync, HA, species, pattern); }));
            Carbink5 = false;
        }


        public void HordesResearch5(uint initial, uint step)
        {
            uint[] P = new uint[Max + 52];
            uint HordePID;
            MersenneTwister_Fast mt;

            while (initial < EndSeed)
            {
                mt = new MersenneTwister_Fast(initial);

                for (uint frame = 0; frame < Min + 62; frame++)                                     //62 is the number of advances before the PID is calculated
                    mt.Nextuint();

                for (uint frame = Min; frame < Min + 52; frame++)                                   //52 is the maximum possible jump between slot 1 and 5
                {
                    HordePID = mt.Nextuint();                                                       //Setting up the array so we can jump up to 52 frames
                    P[frame] = ((HordePID >> 16) ^ (HordePID & 0xFFFF)) >> 4;
                }

                for (uint frame = Min; frame < Max; frame++)
                {
                    HordePID = mt.Nextuint();
                    P[frame + 52] = ((HordePID >> 16) ^ (HordePID & 0xFFFF)) >> 4;

                    #region +8, To enter: HA 1st slot + Sync + Genderless / Fixed gender
                    //We jumped 8 which means that we used the HA in the 1st slot already and it's genderless / fixed + nature sync (possible jumps are now 9, 10, 11)
                    if (P[frame] == P[frame + 8])
                    {
                        if (P[frame] == P[frame + 17])
                        {
                            if (P[frame] == P[frame + 26])
                            {
                                if (P[frame] == P[frame + 35] || P[frame] == P[frame + 36] || P[frame] == P[frame + 37])
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], P[frame] != P[frame + 35], true, 1, true, "00     08     17     26     35");
                            }
                            else if (P[frame] == P[frame + 27])
                            {
                                if (P[frame] == P[frame + 36] || P[frame] == P[frame + 37] || P[frame] == P[frame + 38])
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 1, true, "00     08     17     27     36");
                            }
                            else if (P[frame] == P[frame + 28])
                            {
                                if (P[frame] == P[frame + 37] || P[frame] == P[frame + 38] || P[frame] == P[frame + 39])
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 1, true, "00     08     17     28     37");
                            }
                        }
                        else if (P[frame] == P[frame + 18])
                        {
                            if (P[frame] == P[frame + 27])
                            {
                                if (P[frame] == P[frame + 36] || P[frame] == P[frame + 37] || P[frame] == P[frame + 38])
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 1, true, "00     08     18     27     36");
                            }
                            else if (P[frame] == P[frame + 28])
                            {
                                if (P[frame] == P[frame + 37] || P[frame] == P[frame + 38] || P[frame] == P[frame + 39])
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 1, true, "00     08     18     28     37");
                            }
                            else if (P[frame] == P[frame + 29])
                            {
                                if (P[frame] == P[frame + 38] || P[frame] == P[frame + 39] || P[frame] == P[frame + 40])
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 1, true, "00     08     18     29     38");
                            }
                        }
                        else if (P[frame] == P[frame + 19])
                        {
                            if (P[frame] == P[frame + 28])
                            {
                                if (P[frame] == P[frame + 37] || P[frame] == P[frame + 38] || P[frame] == P[frame + 39])
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 1, true, "00     08     19     28     37");
                            }
                            else if (P[frame] == P[frame + 29])
                            {
                                if (P[frame] == P[frame + 38] || P[frame] == P[frame + 39] || P[frame] == P[frame + 40])
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 1, true, "00     08     19     29     38");
                            }
                            else if (P[frame] == P[frame + 30])
                            {
                                if (P[frame] == P[frame + 39] || P[frame] == P[frame + 40] || P[frame] == P[frame + 41])
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 1, true, "00     08     19     30     39");
                            }
                        }
                    }

                    #endregion

                    #region +9, To enter: HA 1st slot / Sync / Genderless (At least 2 of them)
                    //Since we jumped 9, the possible jumps are: 8, 9, 10
                    else if (P[frame] == P[frame + 9])
                    {
                        if (P[frame] == P[frame + 17]) //HA in slot 2
                        {
                            if (P[frame] == P[frame + 26])
                            {
                                if (P[frame] == P[frame + 35] || P[frame] == P[frame + 36] || P[frame] == P[frame + 37])
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], P[frame] != P[frame + 35], true, 2, true, "00     09     17     26     35");
                            }
                            else if (P[frame] == P[frame + 27])
                            {
                                if (P[frame] == P[frame + 36] || P[frame] == P[frame + 37] || P[frame] == P[frame + 38])
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 2, true, "00     09    17     27     36");
                            }
                            else if (P[frame] == P[frame + 28])
                            {
                                if (P[frame] == P[frame + 37] || P[frame] == P[frame + 38] || P[frame] == P[frame + 39])
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 2, true, "00     09     17     28     37");
                            }
                        }
                        else if (P[frame] == P[frame + 18])
                        {
                            if (P[frame] == P[frame + 26])
                            {
                                if (P[frame] == P[frame + 35] || P[frame] == P[frame + 36] || P[frame] == P[frame + 37])
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], P[frame] != P[frame + 35], true, 3, true, "00     09     18     26     35");
                            }
                            else if (P[frame] == P[frame + 27])
                            {
                                if (P[frame] == P[frame + 35])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], false, true, 4, true, "00     09     18     27     35");
                                }
                                else if (P[frame] == P[frame + 36])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], false, true, 0, true, "00     09     18     27     36");
                                }
                                else if (P[frame] == P[frame + 37] || P[frame] == P[frame + 38])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, true, "00     09     18     27     37");
                                }
                            }
                            else if (P[frame] == P[frame + 28])
                            {
                                if (P[frame] == P[frame + 36])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, true, "00     09     18     28    36");
                                }
                                else if (P[frame] == P[frame + 37] || P[frame] == P[frame + 38] || P[frame] == P[frame + 39])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, true, "00     09     18     28     37");
                                }
                            }
                            else if (P[frame] == P[frame + 29])
                            {
                                if (P[frame] == P[frame + 37])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, true, "00     09     18     29     37");
                                }
                                else if (P[frame] == P[frame + 38] || P[frame] == P[frame + 39] || P[frame] == P[frame + 40])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, true, "00     09     18     29     38");
                                }
                            }
                        }
                        else if (P[frame] == P[frame + 19])
                        {
                            if (P[frame] == P[frame + 27])
                            {
                                if (P[frame] == P[frame + 36] || P[frame] == P[frame + 37] || P[frame] == P[frame + 38])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 3, true, "00     09     19     27     36");
                                }
                            }
                            else if (P[frame] == P[frame + 28])
                            {
                                if (P[frame] == P[frame + 36])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, true, "00     09     19     28     36");
                                }
                                else if (P[frame] == P[frame + 37] || P[frame] == P[frame + 38] || P[frame] == P[frame + 39])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, true, "00     09     19     28     37");
                                }
                            }
                            else if (P[frame] == P[frame + 29])
                            {
                                if (P[frame] == P[frame + 37])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, true, "00     09     19     29     37");
                                }
                                else if (P[frame] == P[frame + 38])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, true, "00     09     19     29     38");
                                }
                                else if (P[frame] == P[frame + 39])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], false, true, 1, false, "00     09     19     29     39");
                                }
                                else if (P[frame] == P[frame + 40] || P[frame] == P[frame + 41])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 1, false, "00     09     19     29     40");
                                }
                            }
                            else if (P[frame] == P[frame + 30])
                            {
                                if (P[frame] == P[frame + 38])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, true, "00     09     19     30     38");
                                }
                                else if (P[frame] == P[frame + 39])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, true, "00     09     19     30     39");
                                }
                                else if (P[frame] == P[frame + 40] || P[frame] == P[frame + 41] || P[frame] == P[frame + 42])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 1, false, "00     09     19     30     40");
                                }
                            }
                            else if (P[frame] == P[frame + 31])
                            {
                                if (P[frame] == P[frame + 40] || P[frame] == P[frame + 41] || P[frame] == P[frame + 42] || P[frame] == P[frame + 43])
                                {
                                    Carbink5 = P[frame] == P[frame + 40];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 1, false, "00     09     19     31     40");
                                }
                            }
                        }
                        else if (P[frame] == P[frame + 20])
                        {
                            if (P[frame] == P[frame + 28])
                            {
                                if (P[frame] == P[frame + 37])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 3, true, "00     09     20     28     37");
                                }
                                else if (P[frame] == P[frame + 38])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 3, true, "00     09     20     28     38");
                                }
                                else if (P[frame] == P[frame + 39])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 3, true, "00     09     20     28     39");
                                }
                            }
                            else if (P[frame] == P[frame + 29])
                            {
                                if (P[frame] == P[frame + 37])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, true, "00     09     20     29     37");
                                }
                                else if (P[frame] == P[frame + 38] || P[frame] == P[frame + 39] || P[frame] == P[frame + 40])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, true, "00     09     20     29     38");
                                }
                            }
                            else if (P[frame] == P[frame + 30])
                            {

                                if (P[frame] == P[frame + 38])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, true, "00     09     20     30     38");
                                }
                                else if (P[frame] == P[frame + 39])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, true, "00     09     20     30     39");
                                }
                                else if (P[frame] == P[frame + 40] || P[frame] == P[frame + 41] || P[frame] == P[frame + 42])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 1, false, "00     09     20     30     40");
                                }
                            }
                            else if (P[frame] == P[frame + 31])
                            {
                                if (P[frame] == P[frame + 39])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, true, "00     09     20     31     39");
                                }
                                else if (P[frame] == P[frame + 40])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, true, "00     09     20     31     40");
                                }
                                else if (P[frame] == P[frame + 41] || P[frame] == P[frame + 42])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     09     20     31     41");
                                }
                                else if (P[frame] == P[frame + 43])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 1, false, "00     09     20     31     43");
                                }
                            }
                            else if (P[frame] == P[frame + 32])
                            {
                                if (P[frame] == P[frame + 41] || P[frame] == P[frame + 42] || P[frame] == P[frame + 43] || P[frame] == P[frame + 44])
                                {
                                    Carbink5 = P[frame] == P[frame + 41];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 1, false, "00     09     20     32     41");
                                }
                            }
                        }
                        else if (P[frame] == P[frame + 21])
                        {
                            if (P[frame] == P[frame + 31])
                            {
                                if (P[frame] == P[frame + 40] || P[frame] == P[frame + 41] || P[frame] == P[frame + 42] || P[frame] == P[frame + 43])
                                {
                                    Carbink5 = P[frame] == P[frame + 40];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 1, false, "00     09     21     31     40");
                                }
                            }
                            else if (P[frame] == P[frame + 32])
                            {
                                if (P[frame] == P[frame + 41] || P[frame] == P[frame + 42] || P[frame] == P[frame + 43] || P[frame] == P[frame + 44])
                                {
                                    Carbink5 = P[frame] == P[frame + 41];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 1, false, "00     09     21     32     41");
                                }
                            }
                            else if (P[frame] == P[frame + 33])
                            {
                                if (P[frame] == P[frame + 42] || P[frame] == P[frame + 43] || P[frame] == P[frame + 44] || P[frame] == P[frame + 45])
                                {
                                    Carbink5 = P[frame] == P[frame + 42];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 1, false, "00     09     21     33     42");
                                }
                            }
                        }
                    }

                    #endregion

                    #region +10, To enter: HA in 1st slot / Sync / Genderless (At least 1 of them)

                    else if (P[frame] == P[frame + 10])
                    {
                        //Possible jumps after entering 18: 9
                        if (P[frame] == P[frame + 18]) //HA in the 2nd slot + Sync + Genderless
                        {
                            if (P[frame] == P[frame + 27])
                            {
                                if (P[frame] == P[frame + 36] || P[frame] == P[frame + 37] || P[frame] == P[frame + 38])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 2, true, "00     10     18     27     36");
                                }
                            }
                            else if (P[frame] == P[frame + 28])
                            {
                                if (P[frame] == P[frame + 37] || P[frame] == P[frame + 38] || P[frame] == P[frame + 39])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 2, true, "00     10     18     28     37");
                                }
                            }
                            else if (P[frame] == P[frame + 29])
                            {
                                if (P[frame] == P[frame + 38] || P[frame] == P[frame + 39] || P[frame] == P[frame + 40])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 2, true, "00     10     18     29     38");
                                }
                            }
                        }
                        //Possible jumps after entering 19: 9, 10
                        else if (P[frame] == P[frame + 19])
                        {
                            if (P[frame] == P[frame + 27])
                            {
                                if (P[frame] == P[frame + 36] || P[frame] == P[frame + 37] || P[frame] == P[frame + 38])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 3, true, "00     10     19     27     36");
                                }
                            }
                            else if (P[frame] == P[frame + 28])
                            {
                                if (P[frame] == P[frame + 36])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, true, "00     10     19     28     36");
                                }
                                else if (P[frame] == P[frame + 37] || P[frame] == P[frame + 38] || P[frame] == P[frame + 39])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, true, "00     10     19     28     37");
                                }
                            }
                            else if (P[frame] == P[frame + 29])
                            {
                                if (P[frame] == P[frame + 37])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, true, "00     10     19     29     37");
                                }
                                else if (P[frame] == P[frame + 38])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, true, "00     10     19     29     38");
                                }
                                else if (P[frame] == P[frame + 39] || P[frame] == P[frame + 40] || P[frame] == P[frame + 41])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], P[frame] != P[frame + 39], true, 2, false, "00     10     19     29     39");
                                }
                            }
                            else if (P[frame] == P[frame + 30])
                            {
                                if (P[frame] == P[frame + 38])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, true, "00     10     19     30     38");
                                }
                                else if (P[frame] == P[frame + 39])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, true, "00     10     19     30     39");
                                }
                                else if (P[frame] == P[frame + 40] || P[frame] == P[frame + 41] || P[frame] == P[frame + 42])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 2, false, "00     10     19     30     40");
                                }
                            }
                            else if (P[frame] == P[frame + 31])
                            {
                                if (P[frame] == P[frame + 40] || P[frame] == P[frame + 41] || P[frame] == P[frame + 42] || P[frame] == P[frame + 43])
                                {
                                    Carbink5 = P[frame] == P[frame + 40];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 2, false, "00     10     19     31     40");
                                }
                            }
                        }
                        //Not possible to enter here if you had HA in the 1st slot and no Sync, so +21 is the first possible with HA 1 + No Sync
                        else if (P[frame] == P[frame + 20])
                        {
                            //Charm is not necessary for 28, 29 and 30 but necessary for 31 and 32
                            //Possible jumps after entering 20: 8, 9, 10
                            if (P[frame] == P[frame + 28])
                            {
                                if (P[frame] == P[frame + 37] || P[frame] == P[frame + 38] || P[frame] == P[frame + 39])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 3, true, "00     10     20     28     37");
                                }
                            }
                            else if (P[frame] == P[frame + 29])
                            {
                                if (P[frame] == P[frame + 37])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, true, "00     10     20     29     37");
                                }
                                else if (P[frame] == P[frame + 38])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, true, "00     10     20     29     38");
                                }
                                else if (P[frame] == P[frame + 39] || P[frame] == P[frame + 40] || P[frame] == P[frame + 41])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], P[frame] != P[frame + 39], true, 3, false, "00     10     20     29     39");
                                }
                            }
                            else if (P[frame] == P[frame + 30])
                            {
                                if (P[frame] == P[frame + 38])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, true, "00     10     20     30     38");
                                }
                                else if (P[frame] == P[frame + 39])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], false, true, 4, false, "00     10     20     30     39");
                                }
                                else if (P[frame] == P[frame + 40])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], false, true, 0, false, "00     10     20     30     40");
                                }
                                else if (P[frame] == P[frame + 41] || P[frame] == P[frame + 42])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     10     20     30     41");
                                }
                            }
                            else if (P[frame] == P[frame + 31])
                            {
                                if (P[frame] == P[frame + 39])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, true, "00     10     20     31     39");
                                }
                                else if (P[frame] == P[frame + 40])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, false, "00     10    20     31     40");
                                }
                                else if (P[frame] == P[frame + 41] || P[frame] == P[frame + 42] || P[frame] == P[frame + 43])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     10     20     31     41");
                                }
                            }
                            else if (P[frame] == P[frame + 32])
                            {
                                if (P[frame] == P[frame + 40] || P[frame] == P[frame + 41])
                                {
                                    Carbink5 = P[frame] == P[frame + 40];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, false, "00     10     20     32     40");
                                }
                                else if (P[frame] == P[frame + 42] || P[frame] == P[frame + 43] || P[frame] == P[frame + 44])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     10     20     32     42");
                                }
                            }
                        }
                        else if (P[frame] == P[frame + 21])
                        {
                            //Possible jumps after entering 21: 8, 9, 10, 11
                            if (P[frame] == P[frame + 29])
                            {
                                if (P[frame] == P[frame + 38] || P[frame] == P[frame + 39] || P[frame] == P[frame + 40])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 3, true, "00     10     21     29     38");
                                }
                            }
                            else if (P[frame] == P[frame + 30])
                            {
                                if (P[frame] == P[frame + 38])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, true, "00     10     21     30     38");
                                }
                                else if (P[frame] == P[frame + 39])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, true, "00     10     21     30     39");
                                }
                                else if (P[frame] == P[frame + 40] || P[frame] == P[frame + 41] || P[frame] == P[frame + 42])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 3, false, "00     10     21     30     40");
                                }
                            }
                            else if (P[frame] == P[frame + 31])
                            {
                                if (P[frame] == P[frame + 39])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, true, "00     10     21     31     39");
                                }
                                else if (P[frame] == P[frame + 40])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, false, "00     10     21     31     40");
                                }
                                else if (P[frame] == P[frame + 41] || P[frame] == P[frame + 42] || P[frame] == P[frame + 43])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     10     21     31     41");
                                }
                            }
                            else if (P[frame] == P[frame + 32])
                            {
                                if (P[frame] == P[frame + 40])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, true, "00     10     21     32     40");
                                }
                                else if (P[frame] == P[frame + 41])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, false, "00     10     21     32     41");
                                }
                                else if (P[frame] == P[frame + 42])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     10     21     32     42");
                                }
                                else if (P[frame] == P[frame + 43])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], false, false, 1, false, "00     10     21     32     43");
                                }
                                else if (P[frame] == P[frame + 44])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00    10     21     32     44");
                                }
                                else if (P[frame] == P[frame + 45])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 1, false, "00     10     21     32     45");
                                }
                            }
                            else if (P[frame] == P[frame + 33])
                            {
                                if (P[frame] == P[frame + 41] || P[frame] == P[frame + 42])
                                {
                                    Carbink5 = P[frame] == P[frame + 41];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, false, "00     10     21     33     41");
                                }
                                else if (P[frame] == P[frame + 43])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     10     21     33     43");
                                }
                                else if (P[frame] == P[frame + 44])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     10     21     33     44");
                                }
                                else if (P[frame] == P[frame + 45])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     10     21     33     45");
                                }
                                else if (P[frame] == P[frame + 46])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 1, false, "00     10     21     33     46");
                                }
                            }
                            else if (P[frame] == P[frame + 34])
                            {
                                if (P[frame] == P[frame + 44] || P[frame] == P[frame + 45] || P[frame] == P[frame + 46] || P[frame] == P[frame + 47])
                                {
                                    Carbink5 = P[frame] == P[frame + 44];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 1, false, "00     10     21     34     44");
                                }
                            }
                        }
                        else if (P[frame] == P[frame + 22])
                        {
                            //Possible jumps after entering 22: 10, 11 (9 with HA once)
                            if (P[frame] == P[frame + 31])
                            {
                                if (P[frame] == P[frame + 40] || P[frame] == P[frame + 41] || P[frame] == P[frame + 42] || P[frame] == P[frame + 43])
                                {
                                    Carbink5 = P[frame] == P[frame + 40];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 3, false, "00     10     22     31     40");
                                }
                            }
                            else if (P[frame] == P[frame + 32])
                            {
                                if (P[frame] == P[frame + 40] || P[frame] == P[frame + 41])
                                {
                                    Carbink5 = P[frame] == P[frame + 40];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, false, "00     10     22     32     40");
                                }
                                else if (P[frame] == P[frame + 42] || P[frame] == P[frame + 43] || P[frame] == P[frame + 44])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     10     22     32     42");
                                }
                            }
                            else if (P[frame] == P[frame + 33])
                            {
                                if (P[frame] == P[frame + 41] || P[frame] == P[frame + 42])
                                {
                                    Carbink5 = P[frame] == P[frame + 41];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, false, "00     10     22     33     41");
                                }
                                else if (P[frame] == P[frame + 43] || P[frame] == P[frame + 44] || P[frame] == P[frame + 45])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     10     22     33     43");
                                }
                                else if (P[frame] == P[frame + 46])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 1, false, "00     10     22     33     46");
                                }
                            }
                            else if (P[frame] == P[frame + 34])
                            {
                                if (P[frame] == P[frame + 42] || P[frame] == P[frame + 43])
                                {
                                    Carbink5 = P[frame] == P[frame + 42];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, false, "00     10     22     34     42");
                                }
                                else if (P[frame] == P[frame + 44] || P[frame] == P[frame + 45] || P[frame] == P[frame + 46])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     10     22     34     44");
                                }
                                else if (P[frame] == P[frame + 47])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 1, false, "00     10     22     34     47");
                                }
                            }
                            else if (P[frame] == P[frame + 35])
                            {
                                if (P[frame] == P[frame + 45] || P[frame] == P[frame + 46] || P[frame] == P[frame + 47] || P[frame] == P[frame + 48])
                                {
                                    Carbink5 = P[frame] == P[frame + 45];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 1, false, "00     10     22     35     45");
                                }
                            }
                        }
                        else if (P[frame] == P[frame + 23])   //Charm + HA 1 + Not Sync
                        {
                            if (P[frame] == P[frame + 34])
                            {
                                if (P[frame] == P[frame + 44] || P[frame] == P[frame + 45] || P[frame] == P[frame + 46] || P[frame] == P[frame + 47])
                                {
                                    Carbink5 = P[frame] == P[frame + 44];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 1, false, "00     10     23     34     44");
                                }
                            }
                            else if (P[frame] == P[frame + 35])
                            {
                                if (P[frame] == P[frame + 45] || P[frame] == P[frame + 46] || P[frame] == P[frame + 47] || P[frame] == P[frame + 48])
                                {
                                    Carbink5 = P[frame] == P[frame + 45];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 1, false, "00     10     23     35     45");
                                }
                            }
                            else if (P[frame] == P[frame + 36])
                            {
                                if (P[frame] == P[frame + 46] || P[frame] == P[frame + 47] || P[frame] == P[frame + 48] || P[frame] == P[frame + 49])
                                {
                                    Carbink5 = P[frame] == P[frame + 46];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 1, false, "00     10     23     36     46");
                                }
                            }
                        }
                    }


                    #endregion

                    #region +11, To enter: No requirements

                    else if (P[frame] == P[frame + 11])
                    {
                        if (P[frame] == P[frame + 19])    //Genderless + Sync + HA 2
                        {
                            //Possible jumps after entering 19: 9
                            if (P[frame] == P[frame + 28])
                            {
                                if (P[frame] == P[frame + 37] || P[frame] == P[frame + 38] || P[frame] == P[frame + 39])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 2, true, "00     11       19     28     37");
                                }
                            }
                            else if (P[frame] == P[frame + 29])
                            {
                                if (P[frame] == P[frame + 38] || P[frame] == P[frame + 39] || P[frame] == P[frame + 40])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 2, true, "00     11     19     29     38");
                                }
                            }
                            else if (P[frame] == P[frame + 30])
                            {
                                if (P[frame] == P[frame + 39] || P[frame] == P[frame + 40] || P[frame] == P[frame + 41])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 2, true, "00     11     19     30     39");
                                }
                            }
                        }

                        else if (P[frame] == P[frame + 20])
                        {
                            //Possible jumps after 0 -> 11 -> 20: 8 (once with HA), 9 ,10
                            if (P[frame] == P[frame + 28])
                            {
                                if (P[frame] == P[frame + 37] || P[frame] == P[frame + 38] || P[frame] == P[frame + 39])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 3, true, "00     11     20     28     37");
                                }
                            }
                            else if (P[frame] == P[frame + 29])
                            {
                                if (P[frame] == P[frame + 37])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, true, "00     11     20     29     37");
                                }
                                else if (P[frame] == P[frame + 38] || P[frame] == P[frame + 39] || P[frame] == P[frame + 40])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, true, "00     11     20     29     38");
                                }
                            }
                            else if (P[frame] == P[frame + 30])
                            {
                                if (P[frame] == P[frame + 38])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, true, "00     11     20     30     38");
                                }
                                else if (P[frame] == P[frame + 39])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, true, "00     11     20     30     39");
                                }
                                else if (P[frame] == P[frame + 40] || P[frame] == P[frame + 41] || P[frame] == P[frame + 42])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 2, false, "00     11     20     30     40");
                                }
                            }
                            else if (P[frame] == P[frame + 31])
                            {
                                if (P[frame] == P[frame + 39])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, true, "00     11     20     31     39");
                                }
                                else if (P[frame] == P[frame + 40])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, true, "00     11     20     31     40");
                                }
                                else if (P[frame] == P[frame + 41] || P[frame] == P[frame + 42] || P[frame] == P[frame + 43])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 2, false, "00     11     20     31     41");
                                }
                            }
                            else if (P[frame] == P[frame + 32])
                            {
                                if (P[frame] == P[frame + 41] || P[frame] == P[frame + 42] || P[frame] == P[frame + 43] || P[frame] == P[frame + 44])
                                {
                                    Carbink5 = P[frame] == P[frame + 41];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 2, false, "00     11     20     32     41");
                                }
                            }
                        }

                        else if (P[frame] == P[frame + 21])
                        {
                            //Possible jumps after 0 -> 11 -> 21: 8 (once with HA), 9 , 10, 11
                            if (P[frame] == P[frame + 29])
                            {
                                if (P[frame] == P[frame + 38] || P[frame] == P[frame + 39] || P[frame] == P[frame + 40])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 3, true, "00     11     21     32     38");
                                }
                            }
                            else if (P[frame] == P[frame + 30])
                            {
                                if (P[frame] == P[frame + 38])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, true, "00     11     21     30     38");
                                }
                                else if (P[frame] == P[frame + 39])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, true, "00     11     21     30     39");
                                }
                                else if (P[frame] == P[frame + 40] || P[frame] == P[frame + 41] || P[frame] == P[frame + 42])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 3, false, "00     11     21     30     40");
                                }
                            }
                            else if (P[frame] == P[frame + 31])
                            {
                                if (P[frame] == P[frame + 39])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, true, "00     11     21     31     39");
                                }
                                else if (P[frame] == P[frame + 40])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, false, "00     11     21     31     40");
                                }
                                else if (P[frame] == P[frame + 41] || P[frame] == P[frame + 42] || P[frame] == P[frame + 43])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     11     21     31     41");
                                }
                            }
                            else if (P[frame] == P[frame + 32])
                            {
                                if (P[frame] == P[frame + 40])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, true, "00     11     21     32     40");
                                }
                                else if (P[frame] == P[frame + 41])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, false, "00     11     21     32     41");
                                }
                                else if (P[frame] == P[frame + 42])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     11     21     32     42");
                                }
                                else if (P[frame] == P[frame + 43])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], false, false, 2, false, "00     11     21     32     43");
                                }
                                else if (P[frame] == P[frame + 44])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     11     21     32     44");    //We prefer sync over HA
                                }
                                else if (P[frame] == P[frame + 45])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 2, false, "00     11     21     32     45");
                                }
                            }
                            else if (P[frame] == P[frame + 33])
                            {
                                if (P[frame] == P[frame + 41] || P[frame] == P[frame + 42])
                                {
                                    Carbink5 = P[frame] == P[frame + 41];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, false, "00     11     21     33     41");
                                }
                                else if (P[frame] == P[frame + 43] || P[frame] == P[frame + 44] || P[frame] == P[frame + 45])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     11     21     33     43");
                                }
                                else if (P[frame] == P[frame + 46])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 2, false, "00     11     21     33     46");
                                }
                            }
                            else if (P[frame] == P[frame + 34])
                            {
                                if (P[frame] == P[frame + 44] || P[frame] == P[frame + 45] || P[frame] == P[frame + 46] || P[frame] == P[frame + 47])
                                {
                                    Carbink5 = P[frame] == P[frame + 44];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 2, false, "00     11     21     34     44");
                                }
                            }
                        }

                        else if (P[frame] == P[frame + 22])
                        {
                            //Possible jumps after 0 -> 11 -> 22: 8 (once with HA), 9, 10, 11
                            if (P[frame] == P[frame + 30])
                            {
                                if (P[frame] == P[frame + 39] || P[frame] == P[frame + 40] || P[frame] == P[frame + 41])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 3, true, "00     11     22     30     39");
                                }
                            }
                            else if (P[frame] == P[frame + 31])
                            {
                                if (P[frame] == P[frame + 39])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, true, "00     11     22     31     39");
                                }
                                else if (P[frame] == P[frame + 40])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, true, "00     11     22     31     40");
                                }
                                else if (P[frame] == P[frame + 41] || P[frame] == P[frame + 42] || P[frame] == P[frame + 43])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 3, false, "00     11     22     31     41");
                                }
                            }
                            else if (P[frame] == P[frame + 32])
                            {
                                if (P[frame] == P[frame + 40])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, true, "00     11     22     32     40");
                                }
                                else if (P[frame] == P[frame + 41])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, false, "00     11     22     32     41");
                                }
                                else if (P[frame] == P[frame + 42])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     11     22     32     42");
                                }
                                else if (P[frame] == P[frame + 43])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], false, false, 3, false, "00     11     22     32     43");
                                }
                                else if (P[frame] == P[frame + 44])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     11     22     32     44");
                                }
                                else if (P[frame] == P[frame + 45])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 3, false, "00     11     22     32     45");
                                }
                            }
                            else if (P[frame] == P[frame + 33])
                            {
                                //No charm somewhere
                                if (P[frame] == P[frame + 41])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 3, true, "00     11     22     33     41");
                                }
                                else if (P[frame] == P[frame + 42])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, false, "00     11     22     33     42");
                                }
                                else if (P[frame] == P[frame + 43])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], false, false, 4, false, "00     11     22     33     43");
                                }
                                else if (P[frame] == P[frame + 44])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], false, false, 0, false, "00     11     22     33     44");
                                }
                                else if (P[frame] == P[frame + 45] || P[frame] == P[frame + 46])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 0, false, "00     11     22     33     45");
                                }
                            }
                            else if (P[frame] == P[frame + 34])
                            {
                                if (P[frame] == P[frame + 42] || P[frame] == P[frame + 43])
                                {
                                    Carbink5 = P[frame] == P[frame + 42];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, false, "00     11     22     34     42");
                                }
                                else if (P[frame] == P[frame + 44])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     11     22     34     44");
                                }
                                else if (P[frame] == P[frame + 45] || P[frame] == P[frame + 46] || P[frame] == P[frame + 47])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 0, false, "00     11     22     34     45");
                                }
                            }
                            else if (P[frame] == P[frame + 35])
                            {
                                if (P[frame] == P[frame + 44] || P[frame] == P[frame + 45])
                                {
                                    Carbink5 = P[frame] == P[frame + 44];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 4, false, "00     11     22     35     44");
                                }
                                else if (P[frame] == P[frame + 46] || P[frame] == P[frame + 47] || P[frame] == P[frame + 48])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 0, false, "00     11     22     35     46");
                                }
                            }
                        }
                        else if (P[frame] == P[frame + 23])
                        {
                            //Possible jumps after 0 -> 11 -> 23: 9 (once with HA), 10, 11
                            if (P[frame] == P[frame + 32])
                            {
                                if (P[frame] == P[frame + 41] || P[frame] == P[frame + 42] || P[frame] == P[frame + 43] || P[frame] == P[frame + 44])
                                {
                                    Carbink5 = P[frame] == P[frame + 41];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 3, false, "00     11     23     32     41");
                                }
                            }
                            else if (P[frame] == P[frame + 33])
                            {
                                if (P[frame] == P[frame + 41] || P[frame] == P[frame + 42])
                                {
                                    Carbink5 = P[frame] == P[frame + 41];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, false, "00     11     23     33     41");
                                }
                                else if (P[frame] == P[frame + 43] || P[frame] == P[frame + 44] || P[frame] == P[frame + 45])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     11     23     33     43");
                                }
                                else if (P[frame] == P[frame + 46])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 3, false, "00     11     23     33     46");
                                }
                            }
                            else if (P[frame] == P[frame + 34])
                            {
                                if (P[frame] == P[frame + 42] || P[frame] == P[frame + 43])
                                {
                                    Carbink5 = P[frame] == P[frame + 42];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, false, "00     11     23     34     42");
                                }
                                else if (P[frame] == P[frame + 44])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     11     23     34     44");
                                }
                                else if (P[frame] == P[frame + 45] || P[frame] == P[frame + 46] || P[frame] == P[frame + 47])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 0, false, "00     11     23     34     45");
                                }
                            }
                            else if (P[frame] == P[frame + 35])
                            {
                                if (P[frame] == P[frame + 43] || P[frame] == P[frame + 44])
                                {
                                    Carbink5 = P[frame] == P[frame + 43];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, false, "00     11     23     35     43");
                                }
                                else if (P[frame] == P[frame + 45])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     11     23     35     45");
                                }
                                else if (P[frame] == P[frame + 46] || P[frame] == P[frame + 47] || P[frame] == P[frame + 48])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 0, false, "00     11     23     35     46");
                                }
                            }
                            else if (P[frame] == P[frame + 36])
                            {
                                if (P[frame] == P[frame + 45] || P[frame] == P[frame + 46])
                                {
                                    Carbink5 = P[frame] == P[frame + 45];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 4, false, "00     11     23     36     45");
                                }
                                else if (P[frame] == P[frame + 47] || P[frame] == P[frame + 48] || P[frame] == P[frame + 49])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 0, false, "00     11     23     36     47");
                                }
                            }
                        }

                        else if (P[frame] == P[frame + 24])   //NOT Sync, charm is necessary
                        {
                            if (P[frame] == P[frame + 34])
                            {
                                if (P[frame] == P[frame + 44] || P[frame] == P[frame + 45] || P[frame] == P[frame + 46] || P[frame] == P[frame + 47])
                                {
                                    Carbink5 = P[frame] == P[frame + 44];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 3, false, "00     11     24     34     44");
                                }
                            }
                            else if (P[frame] == P[frame + 35])
                            {
                                if (P[frame] == P[frame + 44] || P[frame] == P[frame + 45])
                                {
                                    Carbink5 = P[frame] == P[frame + 44];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 4, false, "00     11     24     35     44");
                                }
                                else if (P[frame] == P[frame + 46] || P[frame] == P[frame + 47] || P[frame] == P[frame + 48])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 0, false, "00     11     24     35     46");
                                }
                            }
                            else if (P[frame] == P[frame + 36])
                            {
                                if (P[frame] == P[frame + 45] || P[frame] == P[frame + 46])
                                {
                                    Carbink5 = P[frame] == P[frame + 45];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 4, false, "00     11     24     36     45");
                                }
                                else if (P[frame] == P[frame + 47] || P[frame] == P[frame + 48] || P[frame] == P[frame + 49])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 0, false, "00     11     24     36     47");
                                }
                            }
                            else if (P[frame] == P[frame + 37])
                            {
                                if (P[frame] == P[frame + 46] || P[frame] == P[frame + 47])
                                {
                                    Carbink5 = P[frame] == P[frame + 46];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 4, false, "00     11     24     37     46");
                                }
                                else if (P[frame] == P[frame + 48] || P[frame] == P[frame + 49] || P[frame] == P[frame + 50])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 0, false, "00     11     24     37     48");
                                }
                            }
                        }
                    }
                    #endregion

                    #region +12, To enter: Shiny Charm, No Genderless + Sync (would be max jump = 9)

                    else if (P[frame] == P[frame + 12])
                    {

                        if (P[frame] == P[frame + 21])    //HA slot 2 + Sync
                        {
                            //9 (HA once), 10, 11
                            if (P[frame] == P[frame + 31])
                            {
                                if (P[frame] == P[frame + 40] || P[frame] == P[frame + 41] || P[frame] == P[frame + 42] || P[frame] == P[frame + 43])
                                {
                                    Carbink5 = P[frame] == P[frame + 40];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 2, false, "00     12     21     31     40");
                                }
                            }
                            else if (P[frame] == P[frame + 32])
                            {
                                if (P[frame] == P[frame + 41] || P[frame] == P[frame + 42] || P[frame] == P[frame + 43] || P[frame] == P[frame + 44])
                                {
                                    Carbink5 = P[frame] == P[frame + 41];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 2, false, "00    12     21     32     41");
                                }
                            }
                            else if (P[frame] == P[frame + 33])
                            {
                                if (P[frame] == P[frame + 42] || P[frame] == P[frame + 43] || P[frame] == P[frame + 44] || P[frame] == P[frame + 45])
                                {
                                    Carbink5 = P[frame] == P[frame + 42];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 2, false, "00     12     21     33     42");
                                }
                            }
                        }
                        else if (P[frame] == P[frame + 22])
                        {
                            if (P[frame] == P[frame + 31])
                            {
                                if (P[frame] == P[frame + 40] || P[frame] == P[frame + 41] || P[frame] == P[frame + 42] || P[frame] == P[frame + 43])
                                {
                                    Carbink5 = P[frame] == P[frame + 40];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 3, false, "00     12     22     31     40");
                                }
                            }
                            else if (P[frame] == P[frame + 32])
                            {
                                if (P[frame] == P[frame + 40] || P[frame] == P[frame + 41])
                                {
                                    Carbink5 = P[frame] == P[frame + 40];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, false, "00     12     22     32     40");
                                }
                                else if (P[frame] == P[frame + 42] || P[frame] == P[frame + 43] || P[frame] == P[frame + 44])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     12     22     31     42");
                                }
                            }
                            else if (P[frame] == P[frame + 33])
                            {
                                if (P[frame] == P[frame + 41] || P[frame] == P[frame + 42])
                                {
                                    Carbink5 = P[frame] == P[frame + 41];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, false, "00     12     22     33     41");
                                }
                                else if (P[frame] == P[frame + 43] || P[frame] == P[frame + 44] || P[frame] == P[frame + 45])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     12     22     33     43");
                                }
                                else if (P[frame] == P[frame + 46])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 2, false, "00     12     22     33     46");
                                }
                            }
                            else if (P[frame] == P[frame + 34])
                            {
                                if (P[frame] == P[frame + 42] || P[frame] == P[frame + 43])
                                {
                                    Carbink5 = P[frame] == P[frame + 42];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, false, "00     12     22     34     42");
                                }
                                else if (P[frame] == P[frame + 44] || P[frame] == P[frame + 45] || P[frame] == P[frame + 46])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     12     22     34     44");
                                }
                                else if (P[frame] == P[frame + 47])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 2, false, "00     12     22     34     47");
                                }
                            }
                            else if (P[frame] == P[frame + 35])
                            {
                                if (P[frame] == P[frame + 45] || P[frame] == P[frame + 46] || P[frame] == P[frame + 47] || P[frame] == P[frame + 48])
                                {
                                    Carbink5 = P[frame] == P[frame + 45];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 2, false, "00     12     22     35     45");
                                }
                            }
                        }
                        else if (P[frame] == P[frame + 23])
                        {
                            if (P[frame] == P[frame + 32])
                            {
                                if (P[frame] == P[frame + 41] || P[frame] == P[frame + 42] || P[frame] == P[frame + 43] || P[frame] == P[frame + 44])
                                {
                                    Carbink5 = P[frame] == P[frame + 41];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 3, false, "00     12     23     32     41");
                                }
                            }
                            else if (P[frame] == P[frame + 33])
                            {
                                if (P[frame] == P[frame + 41] || P[frame] == P[frame + 42])
                                {
                                    Carbink5 = P[frame] == P[frame + 41];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, false, "00     12     23    33     41");
                                }
                                else if (P[frame] == P[frame + 43] || P[frame] == P[frame + 44] || P[frame] == P[frame + 45])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     12     23     33     43");
                                }
                                else if (P[frame] == P[frame + 46])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 3, false, "00     12     23     33     46");
                                }
                            }
                            else if (P[frame] == P[frame + 34])
                            {
                                if (P[frame] == P[frame + 42] || P[frame] == P[frame + 43])
                                {
                                    Carbink5 = P[frame] == P[frame + 42];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, false, "00     12     23     34     42");
                                }
                                else if (P[frame] == P[frame + 44])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     12     23     34     44");
                                }
                                else if (P[frame] == P[frame + 45] || P[frame] == P[frame + 46] || P[frame] == P[frame + 47])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 0, false, "00     12     23     34     45");
                                }
                            }
                            else if (P[frame] == P[frame + 35])
                            {
                                if (P[frame] == P[frame + 43] || P[frame] == P[frame + 44])
                                {
                                    Carbink5 = P[frame] == P[frame + 43];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, false, "00     12     23     35     43");
                                }
                                else if (P[frame] == P[frame + 45])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     12     23     35     45");
                                }
                                else if (P[frame] == P[frame + 46] || P[frame] == P[frame + 47] || P[frame] == P[frame + 48])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 0, false, "00     12     23     35     46");
                                }
                            }
                            else if (P[frame] == P[frame + 36])
                            {
                                if (P[frame] == P[frame + 45] || P[frame] == P[frame + 46])
                                {
                                    Carbink5 = P[frame] == P[frame + 45];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 4, false, "00     12     23     36     45");
                                }
                                else if (P[frame] == P[frame + 47] || P[frame] == P[frame + 48] || P[frame] == P[frame + 49])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 0, false, "00     12     23     36     47");
                                }
                            }
                        }
                        else if (P[frame] == P[frame + 24])
                        {
                            if (P[frame] == P[frame + 33])
                            {
                                if (P[frame] == P[frame + 42] || P[frame] == P[frame + 43] || P[frame] == P[frame + 44] || P[frame] == P[frame + 45])
                                {
                                    Carbink5 = P[frame] == P[frame + 42];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 3, false, "00     12     24     33     42");
                                }
                            }
                            else if (P[frame] == P[frame + 34])
                            {
                                if (P[frame] == P[frame + 42] || P[frame] == P[frame + 43])
                                {
                                    Carbink5 = P[frame] == P[frame + 42];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, false, "00     12     24     34     42");
                                }
                                else if (P[frame] == P[frame + 44] || P[frame] == P[frame + 45] || P[frame] == P[frame + 46])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     12     24     34     44");
                                }
                                else if (P[frame] == P[frame + 47])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 3, false, "00     12     24     34     47");
                                }
                            }
                            else if (P[frame] == P[frame + 35])
                            {
                                if (P[frame] == P[frame + 43] || P[frame] == P[frame + 44])
                                {
                                    Carbink5 = P[frame] == P[frame + 43];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, false, "00     12     24     35     43");
                                }
                                else if (P[frame] == P[frame + 45])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     12     24     35     45");
                                }
                                else if (P[frame] == P[frame + 46] || P[frame] == P[frame + 47] || P[frame] == P[frame + 48])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 0, false, "00     12     24     35     46");
                                }
                            }
                            else if (P[frame] == P[frame + 36])
                            {
                                if (P[frame] == P[frame + 44] || P[frame] == P[frame + 45])
                                {
                                    Carbink5 = P[frame] == P[frame + 44];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 4, false, "00     12     24     36     44");
                                }
                                else if (P[frame] == P[frame + 46])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, true, 0, false, "00     12     24     36     46");
                                }
                                else if (P[frame] == P[frame + 47] || P[frame] == P[frame + 48] || P[frame] == P[frame + 49])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 0, false, "00     12     24     36     47");
                                }
                            }
                            else if (P[frame] == P[frame + 37])
                            {
                                if (P[frame] == P[frame + 46] || P[frame] == P[frame + 47])
                                {
                                    Carbink5 = P[frame] == P[frame + 46];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 4, false, "00     12     24     37     46");
                                }
                                else if (P[frame] == P[frame + 48] || P[frame] == P[frame + 49] || P[frame] == P[frame + 50])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 0, false, "00     12     24     37     48");
                                }
                            }
                        }
                        else if (P[frame] == P[frame + 25])   //No sync, charm is necessary
                        {
                            if (P[frame] == P[frame + 35])
                            {
                                if (P[frame] == P[frame + 45] || P[frame] == P[frame + 46] || P[frame] == P[frame + 47] || P[frame] == P[frame + 48])
                                {
                                    Carbink5 = P[frame] == P[frame + 45];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 3, false, "00     12     25     35     44");
                                }
                            }
                            else if (P[frame] == P[frame + 36])
                            {
                                if (P[frame] == P[frame + 45] || P[frame] == P[frame + 46])
                                {
                                    Carbink5 = P[frame] == P[frame + 45];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 4, false, "00     12     25     36     45");
                                }
                                else if (P[frame] == P[frame + 47] || P[frame] == P[frame + 48] || P[frame] == P[frame + 49])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 0, false, "00     12     25     36     47");
                                }
                            }
                            else if (P[frame] == P[frame + 37])
                            {
                                if (P[frame] == P[frame + 46] || P[frame] == P[frame + 47])
                                {
                                    Carbink5 = P[frame] == P[frame + 46];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 4, false, "00     12     25     37     46");
                                }
                                else if (P[frame] == P[frame + 48] || P[frame] == P[frame + 49] || P[frame] == P[frame + 50])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 0, false, "00     12     25     37     48");
                                }
                            }
                            else if (P[frame] == P[frame + 38])
                            {
                                if (P[frame] == P[frame + 47] || P[frame] == P[frame + 48])
                                {
                                    Carbink5 = P[frame] == P[frame + 47];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 4, false, "00     12     25     38     47");
                                }
                                else if (P[frame] == P[frame + 49] || P[frame] == P[frame + 50] || P[frame] == P[frame + 51])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 0, false, "00     12     25     38     49");
                                }
                            }
                        }
                    }

                    #endregion

                    #region +13 Shiny Charm + No Sync + No HA in 1st slot + Not genderless

                    else if (P[frame] == P[frame + 13])   //No Sync or HA in the 1st slot. Only the charm which moved from 11 to 13
                    {
                        if (P[frame] == P[frame + 23])    //HA in slot 2, WASTED
                        {
                            if (P[frame] == P[frame + 34])
                            {
                                if (P[frame] == P[frame + 44] || P[frame] == P[frame + 45] || P[frame] == P[frame + 46] || P[frame] == P[frame + 47])
                                {
                                    Carbink5 = P[frame] == P[frame + 44];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 2, false, "00     13     23     34     44");
                                }
                            }
                            else if (P[frame] == P[frame + 35])
                            {
                                if (P[frame] == P[frame + 45] || P[frame] == P[frame + 46] || P[frame] == P[frame + 47] || P[frame] == P[frame + 48])
                                {
                                    Carbink5 = P[frame] == P[frame + 45];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 2, false, "00     13     23     35     45");
                                }
                            }
                            else if (P[frame] == P[frame + 36])
                            {
                                if (P[frame] == P[frame + 46] || P[frame] == P[frame + 47] || P[frame] == P[frame + 48] || P[frame] == P[frame + 49])
                                {
                                    Carbink5 = P[frame] == P[frame + 46];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 2, false, "00     13     23     36     46");
                                }
                            }
                        }
                        else if (P[frame] == P[frame + 24])
                        {
                            if (P[frame] == P[frame + 34])
                            {
                                if (P[frame] == P[frame + 44] || P[frame] == P[frame + 45] || P[frame] == P[frame + 46] || P[frame] == P[frame + 47])
                                {
                                    Carbink5 = P[frame] == P[frame + 44];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 3, false, "00     13     24     34     44");
                                }
                            }
                            else if (P[frame] == P[frame + 35])
                            {
                                if (P[frame] == P[frame + 44] || P[frame] == P[frame + 45])
                                {
                                    Carbink5 = P[frame] == P[frame + 44];  //+9 here only if carbink + HA in slot 4
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 4, false, "00     13     24     35     44");
                                }
                                else if (P[frame] == P[frame + 46] || P[frame] == P[frame + 47] || P[frame] == P[frame + 48])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 0, false, "00     13     24     35     46");
                                }
                            }
                            else if (P[frame] == P[frame + 36])
                            {
                                if (P[frame] == P[frame + 45] || P[frame] == P[frame + 46])
                                {
                                    Carbink5 = P[frame] == P[frame + 45];  //+9 here only if carbink + HA in slot 4
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 4, false, "00     13     24     36     45");
                                }
                                else if (P[frame] == P[frame + 47] || P[frame] == P[frame + 48] || P[frame] == P[frame + 49])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 0, false, "00     13     24     36     47");
                                }
                            }
                            else if (P[frame] == P[frame + 37])
                            {
                                if (P[frame] == P[frame + 46] || P[frame] == P[frame + 47])
                                {
                                    Carbink5 = P[frame] == P[frame + 46];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 4, false, "00     13     24     37     46");
                                }
                                else if (P[frame] == P[frame + 48] || P[frame] == P[frame + 49] || P[frame] == P[frame + 50])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 0, false, "00     13     24     37     48");
                                }
                            }
                        }
                        else if (P[frame] == P[frame + 25])
                        {
                            if (P[frame] == P[frame + 35])
                            {
                                if (P[frame] == P[frame + 45] || P[frame] == P[frame + 46] || P[frame] == P[frame + 47] || P[frame] == P[frame + 48])
                                {
                                    Carbink5 = P[frame] == P[frame + 45];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 3, false, "00     13     25     35     45");
                                }
                            }
                            else if (P[frame] == P[frame + 36])
                            {
                                if (P[frame] == P[frame + 45] || P[frame] == P[frame + 46])
                                {
                                    Carbink5 = P[frame] == P[frame + 45];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 4, false, "00     13     25     36     45");
                                }
                                else if (P[frame] == P[frame + 47] || P[frame] == P[frame + 48] || P[frame] == P[frame + 49])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 0, false, "00     13     25     36     47");
                                }
                            }
                            else if (P[frame] == P[frame + 37])
                            {
                                if (P[frame] == P[frame + 46] || P[frame] == P[frame + 47])
                                {
                                    Carbink5 = P[frame] == P[frame + 46];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 4, false, "00     13     25     37     46");
                                }
                                else if (P[frame] == P[frame + 48] || P[frame] == P[frame + 49] || P[frame] == P[frame + 50])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 0, false, "00     13     25     37     48");
                                }
                            }
                            else if (P[frame] == P[frame + 38])
                            {
                                if (P[frame] == P[frame + 47] || P[frame] == P[frame + 48])
                                {
                                    Carbink5 = P[frame] == P[frame + 47];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 4, false, "00     13     25     38     47");
                                }
                                else if (P[frame] == P[frame + 49] || P[frame] == P[frame + 50] || P[frame] == P[frame + 51])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 0, false, "00     13     25     38     49");
                                }
                            }
                        }
                        else if (P[frame] == P[frame + 26])
                        {
                            if (P[frame] == P[frame + 36])
                            {
                                if (P[frame] == P[frame + 46] || P[frame] == P[frame + 47] || P[frame] == P[frame + 48] || P[frame] == P[frame + 49])
                                {
                                    Carbink5 = P[frame] == P[frame + 46];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 3, false, "00     13     26     36     46");
                                }
                            }
                            else if (P[frame] == P[frame + 37])
                            {
                                if (P[frame] == P[frame + 46] || P[frame] == P[frame + 47])
                                {
                                    Carbink5 = P[frame] == P[frame + 46];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 4, false, "00     13     26     37     46");
                                }
                                else if (P[frame] == P[frame + 48] || P[frame] == P[frame + 49] || P[frame] == P[frame + 50])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 0, false, "00     13     26     37     48");
                                }
                            }
                            else if (P[frame] == P[frame + 38])
                            {
                                if (P[frame] == P[frame + 47] || P[frame] == P[frame + 48])
                                {
                                    Carbink5 = P[frame] == P[frame + 47];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 4, false, "00     13     26     38     47");
                                }
                                else if (P[frame] == P[frame + 49] || P[frame] == P[frame + 50] || P[frame] == P[frame + 51])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 0, false, "00     13     26     38     49");
                                }
                            }
                            else if (P[frame] == P[frame + 39])
                            {
                                if (P[frame] == P[frame + 48] || P[frame] == P[frame + 49])
                                {
                                    Carbink5 = P[frame] == P[frame + 48];
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 4, false, "00     13     26     39     48");
                                }
                                else if (P[frame] == P[frame + 50] || P[frame] == P[frame + 51] || P[frame] == P[frame + 52])
                                {
                                    Charm_Sync_HA_Gender(initial, frame, P[frame], true, false, 0, false, "00     13     26     39     50");
                                }
                            }
                        }
                    }
                    #endregion
                }
                initial += step;
            }
            Invoke(new Action(() => { Finished(); }));
            //MessageBox.Show("Finished at " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
