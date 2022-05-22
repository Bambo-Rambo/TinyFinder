using System;
using System.Windows.Forms;
using TinyFinder.RNG;

namespace TinyFinder.Subforms.MT
{
    public partial class MTForm
    {

        public void HordesResearch4(uint initial, uint step)
        {
            uint[] P = new uint[Max + 52];
            uint HordePID;
            MersenneTwister_Fast mt;

            while (initial < EndSeed)
            {
                mt = new MersenneTwister_Fast(initial);

                for (uint frame = 0; frame < Min + 62; frame++)                                     //62 is the number of advances before the PID is calculated
                    mt.Nextuint();

                for (uint frame = Min; frame < Min + 52; frame++)                                   //26 is the maximum possible jump between slot 1 and 3
                {
                    HordePID = mt.Nextuint();                                                       //Setting up the array so we can jump 26 frame immediately
                    P[frame] = ((HordePID >> 16) ^ (HordePID & 0xFFFF)) >> 4;
                }

                for (uint frame = Min; frame < Max; frame++)
                {
                    HordePID = mt.Nextuint();
                    P[frame + 52] = ((HordePID >> 16) ^ (HordePID & 0xFFFF)) >> 4;

                    if (P[frame] == TSV || AnyTSV) //Shiny or Any TSV
                    {

                        #region 0 -> 8 -> ? -> ?
                        if (P[frame] == P[frame + 8])
                        {
                            if (P[frame] == P[frame + 17])
                            {
                                if (P[frame] == P[frame + 26] || P[frame] == P[frame + 35])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "1", true, false, "00     08     17     26");

                                else if (P[frame] == P[frame + 27] || P[frame] == P[frame + 28]
                                    || P[frame] == P[frame + 37] || P[frame] == P[frame + 38] || P[frame] == P[frame + 39])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", true, false, "00     08     17     27");
                            }

                            else if (P[frame] == P[frame + 18] &&
                                (P[frame] == P[frame + 27] || P[frame] == P[frame + 28] || P[frame] == P[frame + 29]
                                    || P[frame] == P[frame + 38] || P[frame] == P[frame + 39] || P[frame] == P[frame + 40]))
                            {
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", true, false, "00     08    18     27");
                            }

                            else if (P[frame] == P[frame + 19] &&
                                (P[frame] == P[frame + 28] || P[frame] == P[frame + 29] || P[frame] == P[frame + 30]
                                    || P[frame] == P[frame + 39] || P[frame] == P[frame + 40] || P[frame] == P[frame + 41]))
                            {

                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", true, false, "00     08     19     28");
                            }

                            else if (P[frame] == P[frame + 26] && P[frame] == P[frame + 35])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "1", true, false, "00     08     26     35");

                            else if (P[frame] == P[frame + 28])
                            {
                                if (P[frame] == P[frame + 37] || P[frame] == P[frame + 38] || P[frame] == P[frame + 39])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", true, false, "00     08     28     37");
                            }

                            else if (P[frame] == P[frame + 29])
                            {
                                if (P[frame] == P[frame + 38] || P[frame] == P[frame + 39] || P[frame] == P[frame + 40])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", true, false, "00     08     29     38");
                            }

                            else if (P[frame] == P[frame + 30])
                            {
                                if (P[frame] == P[frame + 39] || P[frame] == P[frame + 40] || P[frame] == P[frame + 41])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", true, false, "00     08     30     39");
                            }



                        }
                        #endregion -> 

                        #region 0 -> 9 -> ? -> ?

                        else if (P[frame] == P[frame + 9])
                        {
                            if (P[frame] == P[frame + 17])
                            {
                                if (P[frame] == P[frame + 26] || P[frame] == P[frame + 35])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "2", true, false, "00     09     17     26");

                                else if (P[frame] == P[frame + 27] || P[frame] == P[frame + 28]
                                    || P[frame] == P[frame + 37] || P[frame] == P[frame + 38] || P[frame] == P[frame + 39])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "2", true, false, "00     09     17     27");
                            }

                            else if (P[frame] == P[frame + 18])
                            {
                                if (P[frame] == P[frame + 26] || P[frame] == P[frame + 35])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "3", true, false, "00     09     18     26");

                                else if (P[frame] == P[frame + 27] || P[frame] == P[frame + 36])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "0", true, false, "00     09     18     27");

                                else if (P[frame] == P[frame + 28] || P[frame] == P[frame + 29]
                                    || P[frame] == P[frame + 38] || P[frame] == P[frame + 39] || P[frame] == P[frame + 40])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     09     18     28");

                                else if (P[frame] == P[frame + 37])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", true, false, "00     09     18     37");

                            }

                            else if (P[frame] == P[frame + 19])
                            {
                                if (P[frame] == P[frame + 27])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", true, false, "00     09     19     27");

                                else if (P[frame] == P[frame + 28] || P[frame] == P[frame + 40])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     09     19     28");

                                else if (P[frame] == P[frame + 29] || P[frame] == P[frame + 39])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "1", false, false, "00     09     19     29");

                                else if (P[frame] == P[frame + 30] || P[frame] == P[frame + 31]
                                    || P[frame] == P[frame + 41] || P[frame] == P[frame + 42] || P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", false, false, "00     09     19     30");

                                else if (P[frame] == P[frame + 38])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", true, false, "00     09     19     38");

                            }

                            else if (P[frame] == P[frame + 20])
                            {
                                if (P[frame] == P[frame + 28])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", true, false, "00     09     20     28");

                                else if (P[frame] == P[frame + 29] ||
                                    P[frame] == P[frame + 40] || P[frame] == P[frame + 41])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     09     20     29");

                                else if (P[frame] == P[frame + 30] || P[frame] == P[frame + 31] || P[frame] == P[frame + 32]
                                      || P[frame] == P[frame + 42] || P[frame] == P[frame + 43] || P[frame] == P[frame + 44])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", false, false, "00     09     20     30");

                                else if (P[frame] == P[frame + 39])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", true, false, "00     09     20     39");

                            }

                            else if (P[frame] == P[frame + 21])
                            {
                                if (P[frame] == P[frame + 31] || P[frame] == P[frame + 32] || P[frame] == P[frame + 33]
                                    || P[frame] == P[frame + 43] || P[frame] == P[frame + 44] || P[frame] == P[frame + 45])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", false, false, "00     09     21     31");

                                else if (P[frame] == P[frame + 42])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", false, true, "00     09     21     42");

                            }


                            else if (P[frame] == P[frame + 26] && P[frame] == P[frame + 35])
                            {
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "2", true, false, "00     09     26     35");
                            }


                            else if (P[frame] == P[frame + 27])
                            {
                                if (P[frame] == P[frame + 35])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "4", true, false, "00     09     27     35");

                                else if (P[frame] == P[frame + 36])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "0", true, false, "00     09     27     36");

                            }

                            else if (P[frame] == P[frame + 28])
                            {
                                if (P[frame] == P[frame + 37] || P[frame] == P[frame + 38] || P[frame] == P[frame + 39])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "2", true, false, "00     09     28     37");

                            }

                            else if (P[frame] == P[frame + 29])
                            {
                                if (P[frame] == P[frame + 37])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", true, false, "00     09     29     37");

                                else if (P[frame] == P[frame + 38] || P[frame] == P[frame + 40])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     09     29     38");

                                else if (P[frame] == P[frame + 39])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "1", false, false, "00     09     29     39");
                            }

                            else if (P[frame] == P[frame + 30])
                            {
                                if (P[frame] == P[frame + 38])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", true, false, "00     09     30     38");

                                else if (P[frame] == P[frame + 39] || P[frame] == P[frame + 40] || P[frame] == P[frame + 41])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     09     30     39");

                            }

                            else if (P[frame] == P[frame + 31])
                            {
                                if (P[frame] == P[frame + 39])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", true, false, "00     09     31     39");

                                else if (P[frame] == P[frame + 40])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     09     31     40");

                                else if (P[frame] == P[frame + 41] || P[frame] == P[frame + 42] || P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", false, false, "00     09     31     41");

                            }

                            else if (P[frame] == P[frame + 32])
                            {
                                if (P[frame] == P[frame + 41])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", false, true, "00     09     32     41");

                                else if (P[frame] == P[frame + 42] || P[frame] == P[frame + 43] || P[frame] == P[frame + 44])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", false, false, "00     09     32     42");

                            }

                            else if (P[frame] == P[frame + 33])
                            {
                                if (P[frame] == P[frame + 42])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", false, true, "00     09     33     42");

                                else if (P[frame] == P[frame + 43] || P[frame] == P[frame + 44] || P[frame] == P[frame + 45])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", false, false, "00     09     33     43");

                            }
                        }

                        #endregion

                        #region 0 -> 10 -> ? -> ?
                        else if (P[frame] == P[frame + 10])
                        {
                            if (P[frame] == P[frame + 18]
                                &&
                                (P[frame] == P[frame + 27] || P[frame] == P[frame + 28] || P[frame] == P[frame + 29]
                                    || P[frame] == P[frame + 38] || P[frame] == P[frame + 39] || P[frame] == P[frame + 40]))
                            {
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "2", true, false, "00     10     18     27");
                            }

                            else if (P[frame] == P[frame + 19])
                            {
                                if (P[frame] == P[frame + 27] || P[frame] == P[frame + 38])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", true, false, "00     10     19     27");

                                else if (P[frame] == P[frame + 28] || P[frame] == P[frame + 40])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     10     19     28");

                                else if (P[frame] == P[frame + 29])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "2", false, false, "00     10     19     29");

                                else if (P[frame] == P[frame + 30] || P[frame] == P[frame + 31]
                                    || P[frame] == P[frame + 41] || P[frame] == P[frame + 42] || P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "2", false, false, "00     10     19     30");

                                else if (P[frame] == P[frame + 39])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "2", false, false, "00     10     19     39");

                            }

                            else if (P[frame] == P[frame + 20])
                            {
                                if (P[frame] == P[frame + 28])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", true, false, "00     10     20     28");

                                else if (P[frame] == P[frame + 29] || P[frame] == P[frame + 39])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "3", false, false, "00     10     20     29");

                                else if (P[frame] == P[frame + 30] || P[frame] == P[frame + 40])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "0", false, false, "00     10     20     30");

                                else if (P[frame] == P[frame + 31] || P[frame] == P[frame + 32]
                                    || P[frame] == P[frame + 42] || P[frame] == P[frame + 43] || P[frame] == P[frame + 44])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     10     20     31");

                                else if (P[frame] == P[frame + 38])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "3", false, true, "00     10     20     38");

                                else if (P[frame] == P[frame + 41])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, false, "00     10     20     41");
                            }

                            else if (P[frame] == P[frame + 21])
                            {
                                if (P[frame] == P[frame + 29] || P[frame] == P[frame + 40])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", true, false, "00     10     21     29");

                                else if (P[frame] == P[frame + 30] || P[frame] == P[frame + 42])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, false, "00     10     21     30");

                                else if (P[frame] == P[frame + 31] || P[frame] == P[frame + 33] || P[frame] == P[frame + 44] || P[frame] == P[frame + 45])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     10     21     31");

                                else if (P[frame] == P[frame + 32] || P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, false, "1", false, false, "00     10     21     32");

                                else if (P[frame] == P[frame + 34] || P[frame] == P[frame + 46] || P[frame] == P[frame + 47])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "1", false, false, "00     10     21     34");

                                else if (P[frame] == P[frame + 41])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     10     21     41");
                            }

                            else if (P[frame] == P[frame + 22])
                            {
                                if (P[frame] == P[frame + 31] || P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, false, "00     10     22     31");

                                else if (P[frame] == P[frame + 32] || P[frame] == P[frame + 33] || P[frame] == P[frame + 34]
                                    || P[frame] == P[frame + 44] || P[frame] == P[frame + 45] || P[frame] == P[frame + 46])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     10     22     32");

                                else if (P[frame] == P[frame + 35] || P[frame] == P[frame + 47] || P[frame] == P[frame + 48])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "1", false, false, "00     10     22     35");

                                else if (P[frame] == P[frame + 42])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, true, "00     10     22     42");

                            }

                            else if (P[frame] == P[frame + 23])
                            {
                                if (P[frame] == P[frame + 34] || P[frame] == P[frame + 35] || P[frame] == P[frame + 36])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "1", false, false, "00     10     23     34");

                                else if (P[frame] == P[frame + 46])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "1", false, true, "00     10     23     46");

                                else if (P[frame] == P[frame + 47] || P[frame] == P[frame + 48] || P[frame] == P[frame + 49])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "1", false, false, "00     10     23     47");

                            }

                            else if (P[frame] == P[frame + 29])
                            {
                                if (P[frame] == P[frame + 38] || P[frame] == P[frame + 40])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "2", true, false, "00     10     29     38");

                                else if (P[frame] == P[frame + 39])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "2", false, false, "00     10     29     39");

                            }

                            else if (P[frame] == P[frame + 30])
                            {
                                if (P[frame] == P[frame + 38])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", true, false, "00     10     30     38");

                                else if (P[frame] == P[frame + 39])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "4", false, false, "00     10     30     39");

                                else if (P[frame] == P[frame + 40])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "0", false, false, "00     10     30     40");

                                else if (P[frame] == P[frame + 41])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     10     30     41");

                            }

                            else if (P[frame] == P[frame + 31])
                            {
                                if (P[frame] == P[frame + 39])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", true, false, "00     10     31     39");

                                else if (P[frame] == P[frame + 40])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     10     31     40");

                                else if (P[frame] == P[frame + 41] || P[frame] == P[frame + 42] || P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "2", false, false, "00     10     31     41");

                            }

                            else if (P[frame] == P[frame + 32])
                            {
                                if (P[frame] == P[frame + 40])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", true, false, "00     10     32     40");

                                else if (P[frame] == P[frame + 41])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, false, "00     10     32     41");

                                else if (P[frame] == P[frame + 42] || P[frame] == P[frame + 44])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     10     32     42");

                                else if (P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, false, "1", false, false, "00     10     32     43");

                            }

                            else if (P[frame] == P[frame + 33])
                            {
                                if (P[frame] == P[frame + 41])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, true, "00     10     33     41");

                                else if (P[frame] == P[frame + 42])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, false, "00     10     33     42");

                                else if (P[frame] == P[frame + 43] || P[frame] == P[frame + 44] || P[frame] == P[frame + 45])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     10     33     43");

                            }

                            else if (P[frame] == P[frame + 34])
                            {
                                if (P[frame] == P[frame + 42])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, true, "00     10     34     42");

                                else if (P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, false, "00     10     34     43");

                                else if (P[frame] == P[frame + 44] || P[frame] == P[frame + 45] || P[frame] == P[frame + 46])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     10     34     44");

                                else if (P[frame] == P[frame + 47])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "1", false, false, "00     10     34     47");

                            }

                            else if (P[frame] == P[frame + 35])
                            {
                                if (P[frame] == P[frame + 45])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "1", false, true, "00     10     35     45");

                                else if (P[frame] == P[frame + 46] || P[frame] == P[frame + 47] || P[frame] == P[frame + 48])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "1", false, false, "00     10     35     46");

                            }

                            else if (P[frame] == P[frame + 36])
                            {
                                if (P[frame] == P[frame + 46])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "1", false, true, "00     10     36     46");

                                else if (P[frame] == P[frame + 47] || P[frame] == P[frame + 48] || P[frame] == P[frame + 49])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "1", false, false, "00     10     36     47");

                            }

                        }
                        #endregion

                        #region 0 -> 11 -> ? -> ?
                        else if (P[frame] == P[frame + 11])
                        {
                            if (P[frame] == P[frame + 19])
                            {
                                if (P[frame] == P[frame + 28] || P[frame] == P[frame + 29] || P[frame] == P[frame + 30] ||
                                    P[frame] == P[frame + 39] || P[frame] == P[frame + 40] || P[frame] == P[frame + 41])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "2", true, false, "00     11     19     28");
                            }

                            else if (P[frame] == P[frame + 20])
                            {
                                if (P[frame] == P[frame + 28] || P[frame] == P[frame + 39])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", true, false, "00     11     20     28");

                                else if (P[frame] == P[frame + 29] || P[frame] == P[frame + 40] || P[frame] == P[frame + 41])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     11     20     29");

                                else if (P[frame] == P[frame + 30] || P[frame] == P[frame + 31] || P[frame] == P[frame + 32] ||
                                    P[frame] == P[frame + 42] || P[frame] == P[frame + 43] || P[frame] == P[frame + 44])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "2", false, false, "00     11     20     30");

                            }

                            else if (P[frame] == P[frame + 21])
                            {
                                if (P[frame] == P[frame + 29] || P[frame] == P[frame + 40])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", true, false, "00     11     21     29");

                                else if (P[frame] == P[frame + 30] || P[frame] == P[frame + 42])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, false, "00     11     21     30");

                                else if (P[frame] == P[frame + 31] || P[frame] == P[frame + 33] || P[frame] == P[frame + 41]
                                    || P[frame] == P[frame + 44] || P[frame] == P[frame + 45])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     11     21     31");

                                else if (P[frame] == P[frame + 32] || P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, false, "2", false, false, "00     11     21     32");

                                else if (P[frame] == P[frame + 34] || P[frame] == P[frame + 46] || P[frame] == P[frame + 47])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "2", false, false, "00     11     21     34");

                            }

                            else if (P[frame] == P[frame + 22])
                            {
                                if (P[frame] == P[frame + 30] || P[frame] == P[frame + 41])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", true, false, "00     11     22     30");

                                else if (P[frame] == P[frame + 31])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, false, "00     11     22     31");

                                else if (P[frame] == P[frame + 32] || P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, false, "3", false, false, "00     11     22     32");

                                else if (P[frame] == P[frame + 33] || P[frame] == P[frame + 44])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, false, "0", false, false, "00     11     22     33");

                                else if (P[frame] == P[frame + 34] || P[frame] == P[frame + 35]
                                    || P[frame] == P[frame + 46] || P[frame] == P[frame + 47] || P[frame] == P[frame + 48])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     11     22     34");

                                else if (P[frame] == P[frame + 42])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     11     22     42");

                                else if (P[frame] == P[frame + 45])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     11     22     45");
                            }

                            else if (P[frame] == P[frame + 23])
                            {
                                if (P[frame] == P[frame + 32] || P[frame] == P[frame + 44])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, false, "00     11     23     32");

                                else if (P[frame] == P[frame + 33]
                                    || P[frame] == P[frame + 45] || P[frame] == P[frame + 46] || P[frame] == P[frame + 47])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     11     23     33");

                                else if (P[frame] == P[frame + 34] || P[frame] == P[frame + 35] || P[frame] == P[frame + 36]
                                    || P[frame] == P[frame + 48] || P[frame] == P[frame + 49])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     11     23     34");

                                else if (P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, true, "00     11     23     43");

                            }

                            else if (P[frame] == P[frame + 24])
                            {
                                if (P[frame] == P[frame + 34] || P[frame] == P[frame + 47])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "3", false, false, "00     11     24     34");

                                else if (P[frame] == P[frame + 35] || P[frame] == P[frame + 36] || P[frame] == P[frame + 37]
                                    || P[frame] == P[frame + 48] || P[frame] == P[frame + 49] || P[frame] == P[frame + 50])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     11     24     35");

                                else if (P[frame] == P[frame + 46])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "3", false, true, "00     11     24     46");
                            }

                            else if (P[frame] == P[frame + 30])
                            {
                                if (P[frame] == P[frame + 39] || P[frame] == P[frame + 40] || P[frame] == P[frame + 41])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "2", true, false, "00     11     30     39");

                            }

                            else if (P[frame] == P[frame + 31])
                            {
                                if (P[frame] == P[frame + 39])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", true, false, "00     11     31     39");

                                else if (P[frame] == P[frame + 40] || P[frame] == P[frame + 41] || P[frame] == P[frame + 42])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     11     31     40");
                            }

                            else if (P[frame] == P[frame + 32])
                            {
                                if (P[frame] == P[frame + 40])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", true, false, "00     11     32     40");

                                else if (P[frame] == P[frame + 41])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     11     32     41");

                                else if (P[frame] == P[frame + 42] || P[frame] == P[frame + 44])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "2", false, false, "00     11     32     42");

                                else if (P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, false, "2", false, false, "00     11     32     43");
                            }

                            else if (P[frame] == P[frame + 33])
                            {
                                if (P[frame] == P[frame + 41])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", true, false, "00     11     33     41");

                                else if (P[frame] == P[frame + 42])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, false, "00     11     33     42");

                                else if (P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, false, "4", false, false, "00     11     33     43");

                                else if (P[frame] == P[frame + 44])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, false, "0", false, false, "00     11     33     44");

                                else if (P[frame] == P[frame + 45])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     11     33     45");

                            }

                            else if (P[frame] == P[frame + 34])
                            {
                                if (P[frame] == P[frame + 42])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, true, "00     11     34     42");

                                else if (P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, false, "00     11     34     43");

                                else if (P[frame] == P[frame + 44] || P[frame] == P[frame + 45] || P[frame] == P[frame + 46])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     11     34     44");

                                else if (P[frame] == P[frame + 47])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "2", false, false, "00     11     34     47");

                            }

                            else if (P[frame] == P[frame + 35])
                            {
                                if (P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, true, "00     11     35     43");

                                else if (P[frame] == P[frame + 44])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, false, "00     11     35     44");

                                else if (P[frame] == P[frame + 45])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     11     35     45");

                                else if (P[frame] == P[frame + 46] || P[frame] == P[frame + 47] || P[frame] == P[frame + 48])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     11     35     46");

                            }

                            else if (P[frame] == P[frame + 36])
                            {
                                if (P[frame] == P[frame + 45])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, true, "00     11     36     45");

                                else if (P[frame] == P[frame + 46])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, false, "00     11     36     46");

                                else if (P[frame] == P[frame + 47] || P[frame] == P[frame + 48] || P[frame] == P[frame + 49])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     11     36     47");
                            }

                            else if (P[frame] == P[frame + 37])
                            {
                                if (P[frame] == P[frame + 46])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, true, "00     11     37     46");

                                else if (P[frame] == P[frame + 47])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, false, "00     11     37     47");

                                else if (P[frame] == P[frame + 48] || P[frame] == P[frame + 49] || P[frame] == P[frame + 50])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     11     37     48");

                            }

                        }
                        #endregion

                        #region 0 -> 12 -> ? -> ?
                        else if (P[frame] == P[frame + 12])
                        {
                            if (P[frame] == P[frame + 21])
                            {
                                if (P[frame] == P[frame + 31] || P[frame] == P[frame + 32] || P[frame] == P[frame + 33] ||
                                    P[frame] == P[frame + 43] || P[frame] == P[frame + 44] || P[frame] == P[frame + 45])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "2", false, false, "00     12     21     31");

                                else if (P[frame] == P[frame + 42])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "2", false, true, "00     12     21     42");
                            }

                            else if (P[frame] == P[frame + 22])
                            {
                                if (P[frame] == P[frame + 31] || P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, false, "00     12     22     31");

                                else if (P[frame] == P[frame + 32] || P[frame] == P[frame + 33] || P[frame] == P[frame + 34] ||
                                    P[frame] == P[frame + 44] || P[frame] == P[frame + 45] || P[frame] == P[frame + 46])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     12     22     32");

                                else if (P[frame] == P[frame + 35] || P[frame] == P[frame + 47] || P[frame] == P[frame + 48])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "2", false, false, "00     12     22     35");

                                else if (P[frame] == P[frame + 42])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, true, "00     12     22     42");
                            }

                            else if (P[frame] == P[frame + 23])
                            {
                                if (P[frame] == P[frame + 32] || P[frame] == P[frame + 44])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, false, "00     12     23     32");

                                else if (P[frame] == P[frame + 33] || P[frame] == P[frame + 45] || P[frame] == P[frame + 46])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     12     23     33");

                                else if (P[frame] == P[frame + 34] || P[frame] == P[frame + 35] || P[frame] == P[frame + 36] ||
                                         P[frame] == P[frame + 47] || P[frame] == P[frame + 48] || P[frame] == P[frame + 49])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     12     23     34");

                                else if (P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, true, "00     12     23     43");
                            }

                            else if (P[frame] == P[frame + 24])
                            {
                                if (P[frame] == P[frame + 33] || P[frame] == P[frame + 45])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, false, "00     12     24     33");

                                else if (P[frame] == P[frame + 34] || P[frame] == P[frame + 46] || P[frame] == P[frame + 47])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     12     24     34");

                                else if (P[frame] == P[frame + 35] || P[frame] == P[frame + 36] || P[frame] == P[frame + 37] ||
                                         P[frame] == P[frame + 48] || P[frame] == P[frame + 49] || P[frame] == P[frame + 50])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     12     24     35");

                                else if (P[frame] == P[frame + 44])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, true, "00     12     24     44");
                            }

                            else if (P[frame] == P[frame + 25])
                            {
                                if (P[frame] == P[frame + 35] || P[frame] == P[frame + 48])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "3", false, false, "00     12     25     35");

                                else if (P[frame] == P[frame + 36] || P[frame] == P[frame + 37] || P[frame] == P[frame + 38] ||
                                         P[frame] == P[frame + 49] || P[frame] == P[frame + 50] || P[frame] == P[frame + 51])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     12     25     36");

                                else if (P[frame] == P[frame + 47])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "3", false, true, "00     12     25     47");

                            }

                            else if (P[frame] == P[frame + 33])
                            {
                                if (P[frame] == P[frame + 42])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "2", false, true, "00     12     33     42");

                                else if (P[frame] == P[frame + 43] || P[frame] == P[frame + 44] || P[frame] == P[frame + 45])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "2", false, false, "00     12     33     43");

                            }

                            else if (P[frame] == P[frame + 34])
                            {
                                if (P[frame] == P[frame + 42])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, true, "00     12     34     42");

                                else if (P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, false, "00     12     34     43");

                                else if (P[frame] == P[frame + 44] || P[frame] == P[frame + 45] || P[frame] == P[frame + 46])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     12     34     44");

                            }

                            else if (P[frame] == P[frame + 35])
                            {
                                if (P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, true, "00     12     35     43");

                                else if (P[frame] == P[frame + 44])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, false, "00     12     35     44");

                                else if (P[frame] == P[frame + 45] || P[frame] == P[frame + 46] || P[frame] == P[frame + 47])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     12     35     45");

                                else if (P[frame] == P[frame + 48])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "2", false, false, "00     12     35     48");

                            }

                            else if (P[frame] == P[frame + 36])
                            {
                                if (P[frame] == P[frame + 44])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, true, "00     12     36     44");

                                else if (P[frame] == P[frame + 45])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, false, "00     12     36     45");

                                else if (P[frame] == P[frame + 46])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     12     36     46");

                                else if (P[frame] == P[frame + 47] || P[frame] == P[frame + 48] || P[frame] == P[frame + 49])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     12     36     47");
                            }

                            else if (P[frame] == P[frame + 37])
                            {
                                if (P[frame] == P[frame + 46])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, true, "00     12     37     46");

                                else if (P[frame] == P[frame + 47])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, false, "00     12     37     47");

                                else if (P[frame] == P[frame + 48] || P[frame] == P[frame + 49] || P[frame] == P[frame + 50])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     12     37     48");

                            }

                            else if (P[frame] == P[frame + 38])
                            {
                                if (P[frame] == P[frame + 47])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, true, "00     12     38     47");

                                else if (P[frame] == P[frame + 48])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, false, "00     12     38     48");

                                else if (P[frame] == P[frame + 49] || P[frame] == P[frame + 50] || P[frame] == P[frame + 51])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     12     38     49");

                            }

                        }
                        #endregion

                        #region 0 -> 13 -> ? -> ?
                        else if (P[frame] == P[frame + 13])
                        {
                            if (P[frame] == P[frame + 23])
                            {
                                if (P[frame] == P[frame + 34] || P[frame] == P[frame + 35] || P[frame] == P[frame + 36] ||
                                    P[frame] == P[frame + 47] || P[frame] == P[frame + 48] || P[frame] == P[frame + 49])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "2", false, false, "00     13     23     34");

                                else if (P[frame] == P[frame + 46])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "2", false, true, "00     13     23     46");
                            }


                            else if (P[frame] == P[frame + 24])
                            {
                                if (P[frame] == P[frame + 34] || P[frame] == P[frame + 47])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "3", false, false, "00     13     24     34");

                                else if (P[frame] == P[frame + 35] || P[frame] == P[frame + 36] || P[frame] == P[frame + 37] ||
                                         P[frame] == P[frame + 48] || P[frame] == P[frame + 49] || P[frame] == P[frame + 50])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     13     24     35");

                                else if (P[frame] == P[frame + 46])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "3", false, true, "00     13     24     46");

                            }

                            else if (P[frame] == P[frame + 25])
                            {
                                if (P[frame] == P[frame + 35] || P[frame] == P[frame + 48])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "3", false, false, "00     13     25     35");

                                else if (P[frame] == P[frame + 36] || P[frame] == P[frame + 37] || P[frame] == P[frame + 38] ||
                                         P[frame] == P[frame + 49] || P[frame] == P[frame + 50] || P[frame] == P[frame + 51])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     13     25     36");

                                else if (P[frame] == P[frame + 47])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "3", false, true, "00     13     25     47");

                            }

                            else if (P[frame] == P[frame + 26])
                            {
                                if (P[frame] == P[frame + 36] || P[frame] == P[frame + 49])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "3", false, false, "00     13     26     36");

                                else if (P[frame] == P[frame + 37] || P[frame] == P[frame + 38] || P[frame] == P[frame + 39] ||
                                         P[frame] == P[frame + 50] || P[frame] == P[frame + 51] || P[frame] == P[frame + 52])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     13     26     37");

                                else if (P[frame] == P[frame + 48])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "3", false, true, "00     13     26     48");

                            }

                            else if (P[frame] == P[frame + 36])
                            {
                                if (P[frame] == P[frame + 46])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "2", false, true, "00     13     36     46");

                                else if (P[frame] == P[frame + 47] || P[frame] == P[frame + 48] || P[frame] == P[frame + 49])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "2", false, false, "00     13     36     47");

                            }

                            else if (P[frame] == P[frame + 37])
                            {
                                if (P[frame] == P[frame + 46])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, true, "00     13     37     46");

                                else if (P[frame] == P[frame + 47])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, false, "00     13     37     47");

                                else if (P[frame] == P[frame + 48] || P[frame] == P[frame + 49] || P[frame] == P[frame + 50])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     13     37     48");

                            }

                            else if (P[frame] == P[frame + 38])
                            {
                                if (P[frame] == P[frame + 47])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, true, "00     13     38     47");

                                else if (P[frame] == P[frame + 48])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, false, "00     13     38     48");

                                else if (P[frame] == P[frame + 49] || P[frame] == P[frame + 50] || P[frame] == P[frame + 51])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     13     38     49");

                            }

                            else if (P[frame] == P[frame + 39])
                            {
                                if (P[frame] == P[frame + 48])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, true, "00     13     39     48");

                                else if (P[frame] == P[frame + 49])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, false, "00     13     39     49");

                                else if (P[frame] == P[frame + 50] || P[frame] == P[frame + 51] || P[frame] == P[frame + 52])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     13     39     50");

                            }

                        }
                        #endregion





                        #region 0 -> ? -> 17 -> 26 -> 35
                        else if (P[frame] == P[frame + 17] && P[frame] == P[frame + 26] && P[frame] == P[frame + 35])
                        {
                            Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "1", true, false, "00     17     26     35");
                        }
                        #endregion

                        #region 0 -> ? -> 18 -> ?
                        else if (P[frame] == P[frame + 18])
                        {
                            if (P[frame] == P[frame + 26] && P[frame] == P[frame + 35])
                            {
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "3", true, false, "00     18     26     35");
                            }

                            else if (P[frame] == P[frame + 27])
                            {
                                if (P[frame] == P[frame + 35])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "4", true, false, "00     18     27     35");

                                else if (P[frame] == P[frame + 36])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "0", true, false, "00     18     27     36");
                            }

                        }
                        #endregion

                        #region 0 -> ? -> 19 -> ?
                        else if (P[frame] == P[frame + 19])
                        {
                            if (P[frame] == P[frame + 28])
                            {
                                if (P[frame] == P[frame + 37] || P[frame] == P[frame + 38] || P[frame] == P[frame + 39])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", true, false, "00     19     28     37");
                            }

                            else if (P[frame] == P[frame + 29])
                            {
                                if (P[frame] == P[frame + 38] || P[frame] == P[frame + 40])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", true, false, "00     19     29     38");

                                else if (P[frame] == P[frame + 39])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "1", false, false, "00     19     29     39");

                            }

                            else if (P[frame] == P[frame + 30])
                            {
                                if (P[frame] == P[frame + 39] || P[frame] == P[frame + 40] || P[frame] == P[frame + 41])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", true, false, "00     19     30     39");
                            }

                        }
                        #endregion

                        #region 0 -> ? -> 20 -> ?
                        else if (P[frame] == P[frame + 20])
                        {
                            if (P[frame] == P[frame + 28])
                            {
                                if (P[frame] == P[frame + 37] || P[frame] == P[frame + 38] || P[frame] == P[frame + 39])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", true, false, "00     20     28     37");
                            }

                            else if (P[frame] == P[frame + 29])
                            {
                                if (P[frame] == P[frame + 37])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", true, false, "00     20     29     37");

                                else if (P[frame] == P[frame + 38] || P[frame] == P[frame + 40])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     20     29     38");

                                else if (P[frame] == P[frame + 39])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "3", false, false, "00     20     29     39");

                            }

                            else if (P[frame] == P[frame + 30])
                            {
                                if (P[frame] == P[frame + 38])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", true, false, "00     20     30     38");

                                else if (P[frame] == P[frame + 39])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "4", false, false, "00     20     30     39");

                                else if (P[frame] == P[frame + 40])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "0", false, false, "00     20     30     40");

                                else if (P[frame] == P[frame + 41])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     20     30     41");

                            }

                            else if (P[frame] == P[frame + 31])
                            {
                                if (P[frame] == P[frame + 39])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", true, false, "00     20     31     39");

                                else if (P[frame] == P[frame + 40] || P[frame] == P[frame + 41] || P[frame] == P[frame + 42])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     20     31     40");

                            }


                        }
                        #endregion

                        #region 0 -> ? -> 21 -> ?
                        else if (P[frame] == P[frame + 21])
                        {
                            if (P[frame] == P[frame + 29])
                            {
                                if (P[frame] == P[frame + 38] || P[frame] == P[frame + 39] || P[frame] == P[frame + 40])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", true, false, "00     21     29     38");

                            }

                            else if (P[frame] == P[frame + 30])
                            {
                                if (P[frame] == P[frame + 38])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", true, false, "00     21     30     38");

                                else if (P[frame] == P[frame + 39] || P[frame] == P[frame + 40] || P[frame] == P[frame + 41])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     21     30     39");

                            }

                            else if (P[frame] == P[frame + 31])
                            {
                                if (P[frame] == P[frame + 39])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", true, false, "00     21     31     39");

                                else if (P[frame] == P[frame + 40])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     21     31     40");

                                else if (P[frame] == P[frame + 41] || P[frame] == P[frame + 42] || P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", false, false, "00     21     31     40");

                            }

                            else if (P[frame] == P[frame + 32])
                            {
                                if (P[frame] == P[frame + 40])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", true, false, "00     21     32     40");

                                else if (P[frame] == P[frame + 41])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     21     32     41");

                                else if (P[frame] == P[frame + 42] || P[frame] == P[frame + 44])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", false, false, "00     21     32     42");

                                else if (P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, false, "1", false, false, "00     21     32     43");

                            }

                            else if (P[frame] == P[frame + 33])
                            {
                                if (P[frame] == P[frame + 42])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", false, true, "00     21     33     42");

                                else if (P[frame] == P[frame + 43] || P[frame] == P[frame + 44] || P[frame] == P[frame + 45])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", false, false, "00     21     33     43");

                            }

                        }
                        #endregion

                        #region 0 -> ? -> 22 -> ?
                        else if (P[frame] == P[frame + 22])
                        {
                            if (P[frame] == P[frame + 30])
                            {
                                if (P[frame] == P[frame + 39] || P[frame] == P[frame + 40] || P[frame] == P[frame + 41])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", true, false, "00     22     30     39");

                            }

                            else if (P[frame] == P[frame + 31])
                            {
                                if (P[frame] == P[frame + 39])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", true, false, "00     22     31     39");

                                else if (P[frame] == P[frame + 40])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     22     31     40");

                                else if (P[frame] == P[frame + 41] || P[frame] == P[frame + 42] || P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, false, "00     22     31     41");

                            }

                            else if (P[frame] == P[frame + 32])
                            {
                                if (P[frame] == P[frame + 40])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", true, false, "00     22     32     40");

                                else if (P[frame] == P[frame + 41])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, false, "00     22     32     41");

                                else if (P[frame] == P[frame + 42] || P[frame] == P[frame + 44])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     22     32     42");

                                else if (P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, false, "3", false, false, "00     22     32     43");

                            }

                            else if (P[frame] == P[frame + 33])
                            {
                                if (P[frame] == P[frame + 41])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", true, false, "00     22     33     41");

                                else if (P[frame] == P[frame + 42])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, false, "00     22     33     42");

                                else if (P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, false, "4", false, false, "00     22     33     43");

                                else if (P[frame] == P[frame + 44])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, false, "0", false, false, "00     22     33     44");

                                else if (P[frame] == P[frame + 45])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     22     33     45");

                            }

                            else if (P[frame] == P[frame + 34])
                            {
                                if (P[frame] == P[frame + 42])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, true, "00     22     34     42");

                                else if (P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, false, "00     22     34     43");

                                else if (P[frame] == P[frame + 44] || P[frame] == P[frame + 45] || P[frame] == P[frame + 46])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     22     34     44");


                            }

                        }
                        #endregion

                        #region 0 -> ? -> 23 -> ?
                        else if (P[frame] == P[frame + 23])
                        {
                            if (P[frame] == P[frame + 32])
                            {
                                if (P[frame] == P[frame + 41])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, true, "00     23     32     41");

                                else if (P[frame] == P[frame + 42] || P[frame] == P[frame + 43] || P[frame] == P[frame + 44])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, false, "00     23     32     42");

                            }

                            else if (P[frame] == P[frame + 33])
                            {
                                if (P[frame] == P[frame + 41])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, true, "00     23     33     41");

                                else if (P[frame] == P[frame + 42])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, false, "00     23     33     42");

                                else if (P[frame] == P[frame + 43] || P[frame] == P[frame + 44] || P[frame] == P[frame + 45])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     23     33     43");

                            }

                            else if (P[frame] == P[frame + 34])
                            {
                                if (P[frame] == P[frame + 42])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, true, "00     23     34     42");

                                else if (P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, false, "00     23     34     43");

                                else if (P[frame] == P[frame + 44] || P[frame] == P[frame + 45] || P[frame] == P[frame + 46])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     23     34     44");

                                else if (P[frame] == P[frame + 47])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "1", false, false, "00     23     34     47");

                            }

                            else if (P[frame] == P[frame + 35])
                            {
                                if (P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, true, "00     23     35     43");

                                else if (P[frame] == P[frame + 44])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, false, "00     23     35     44");

                                else if (P[frame] == P[frame + 45] || P[frame] == P[frame + 46] || P[frame] == P[frame + 47])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     23     35     45");

                                else if (P[frame] == P[frame + 48])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "1", false, false, "00     23     35     48");

                            }

                            else if (P[frame] == P[frame + 36])
                            {
                                if (P[frame] == P[frame + 46])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "1", false, true, "00     23     36     46");

                                else if (P[frame] == P[frame + 47] || P[frame] == P[frame + 48] || P[frame] == P[frame + 49])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "1", false, false, "00     23     36     47");

                            }
                        }
                        #endregion

                        #region 0 -> ? -> 24 -> ?
                        else if (P[frame] == P[frame + 24])
                        {
                            if (P[frame] == P[frame + 33])
                            {
                                if (P[frame] == P[frame + 42])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, true, "00     24     33     42");

                                else if (P[frame] == P[frame + 43] || P[frame] == P[frame + 44] || P[frame] == P[frame + 45])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, false, "00     24     33     43");

                            }

                            else if (P[frame] == P[frame + 34])
                            {
                                if (P[frame] == P[frame + 42])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, true, "00     24     34     42");

                                else if (P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, false, "00     24     34     43");

                                else if (P[frame] == P[frame + 44] || P[frame] == P[frame + 45] || P[frame] == P[frame + 46])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     24     34     44");

                                else if (P[frame] == P[frame + 47])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "3", false, false, "00     24     34     47");

                            }

                            else if (P[frame] == P[frame + 35])
                            {
                                if (P[frame] == P[frame + 43])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, true, "00     24     35     43");

                                else if (P[frame] == P[frame + 44])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, false, "00     24     35     44");

                                else if (P[frame] == P[frame + 45])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     24     35     45");

                                else if (P[frame] == P[frame + 46] || P[frame] == P[frame + 47] || P[frame] == P[frame + 48])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     24     35     46");
                            }

                            else if (P[frame] == P[frame + 36])
                            {
                                if (P[frame] == P[frame + 44])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, true, "00     24     36     44");

                                else if (P[frame] == P[frame + 45])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, false, "00     24     36     45");

                                else if (P[frame] == P[frame + 46])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     24     36     46");

                                else if (P[frame] == P[frame + 47] || P[frame] == P[frame + 48] || P[frame] == P[frame + 49])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     24     36     47");
                            }

                            else if (P[frame] == P[frame + 37])
                            {
                                if (P[frame] == P[frame + 46])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, true, "00     24     37     46");

                                else if (P[frame] == P[frame + 47])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, false, "00     24     37     47");

                                else if (P[frame] == P[frame + 48] || P[frame] == P[frame + 49] || P[frame] == P[frame + 50])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     24     37     48");

                            }

                        }
                        #endregion

                        #region 0 -> ? -> 25 -> ?
                        else if (P[frame] == P[frame + 25])
                        {
                            if (P[frame] == P[frame + 35])
                            {
                                if (P[frame] == P[frame + 45])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "3", false, true, "00     25     35     45");

                                else if (P[frame] == P[frame + 46] || P[frame] == P[frame + 47] || P[frame] == P[frame + 48])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "3", false, false, "00     25     35     46");
                            }

                            else if (P[frame] == P[frame + 36])
                            {
                                if (P[frame] == P[frame + 45])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, true, "00     25     36     45");

                                else if (P[frame] == P[frame + 46])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, false, "00     25     36     46");

                                else if (P[frame] == P[frame + 47] || P[frame] == P[frame + 48] || P[frame] == P[frame + 49])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     25     36     47");
                            }

                            else if (P[frame] == P[frame + 37])
                            {
                                if (P[frame] == P[frame + 46])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, true, "00     25     37     46");

                                else if (P[frame] == P[frame + 47])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, false, "00     25     37     47");

                                else if (P[frame] == P[frame + 48] || P[frame] == P[frame + 49] || P[frame] == P[frame + 50])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     25     37     48");
                            }

                            else if (P[frame] == P[frame + 38])
                            {
                                if (P[frame] == P[frame + 47])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, true, "00     25     38     47");

                                else if (P[frame] == P[frame + 48])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, false, "00     25     38     48");

                                else if (P[frame] == P[frame + 49] || P[frame] == P[frame + 50] || P[frame] == P[frame + 51])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     25     38     49");
                            }

                        }
                        #endregion

                        #region 0 -> ? -> 26 -> ?
                        else if (P[frame] == P[frame + 26])
                        {
                            if (P[frame] == P[frame + 36])
                            {
                                if (P[frame] == P[frame + 46])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "3", false, true, "00     26     36     46");

                                else if (P[frame] == P[frame + 47] || P[frame] == P[frame + 48] || P[frame] == P[frame + 49])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "3", false, false, "00     26     36     47");
                            }

                            else if (P[frame] == P[frame + 37])
                            {
                                if (P[frame] == P[frame + 46])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, true, "00     26     37     46");

                                else if (P[frame] == P[frame + 47])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, false, "00     26     37     47");

                                else if (P[frame] == P[frame + 48] || P[frame] == P[frame + 49] || P[frame] == P[frame + 50])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     26     37     48");
                            }

                            else if (P[frame] == P[frame + 38])
                            {
                                if (P[frame] == P[frame + 47])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, true, "00     26     38     47");

                                else if (P[frame] == P[frame + 48])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, false, "00     26     38     48");

                                else if (P[frame] == P[frame + 49] || P[frame] == P[frame + 50] || P[frame] == P[frame + 51])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     26     38     49");
                            }

                            else if (P[frame] == P[frame + 39])
                            {
                                if (P[frame] == P[frame + 48])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, true, "00     26     39     48");

                                else if (P[frame] == P[frame + 49])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, false, "00     26     39     49");

                                else if (P[frame] == P[frame + 50] || P[frame] == P[frame + 51] || P[frame] == P[frame + 52])
                                    Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     26     39     50");
                            }


                        }
                        #endregion

                    }
                }
                initial += step;
            }
            Invoke(new Action(() => { Finished(); }));
            //MessageBox.Show("Finished at " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
