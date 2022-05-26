using System;
using System.Windows.Forms;
using TinyFinder.RNG;

namespace TinyFinder.Subforms.MT
{
    public partial class MTForm
    {
        void Charm_Sync_HA_Gend_Carb(uint seed, uint frame, uint psv, bool charm, bool sync, string HA, bool genderless, bool carbink, string check)
        {
            string species = genderless ? "Genderless" : carbink ? "Carbink" : "Any";
            Invoke(new Action(() => { HORDE_DGV.Rows.Add(hex(seed), frame, psv, charm, sync, HA, species, check); }));
        }

        public void HordesResearch3(uint initial, uint step)
        {
            uint[] P = new uint[Max + 52];
            uint HordePID;
            MersenneTwister_Fast mt;

            while (initial < EndSeed)
            {
                mt = new MersenneTwister_Fast(initial);

                for (uint frame = 0; frame < Min + 62; frame++)           //62 is the number of advances before the PID is calculated
                    mt.Nextuint();

                for (uint frame = Min; frame < Min + 52; frame++)
                {
                    HordePID = mt.Nextuint();
                    P[frame] = ((HordePID >> 16) ^ (HordePID & 0xFFFF)) >> 4;
                }

                for (uint frame = Min; frame < Max; frame++)
                {
                    HordePID = mt.Nextuint();
                    P[frame + 52] = ((HordePID >> 16) ^ (HordePID & 0xFFFF)) >> 4;

                    if (P[frame] == TSV || AnyTSV) //Shiny or Any TSV
                    {

                        #region 0 -> 8 -> ?
                        if (P[frame] == P[frame + 8])
                        {
                            if (P[frame] == P[frame + 17] || P[frame] == P[frame + 26] || P[frame] == P[frame + 35])
                            {
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "1", true, false, "00     08     17");
                            }
                            else if (P[frame] == P[frame + 18] || P[frame] == P[frame + 19] ||
                                P[frame] == P[frame + 28] || P[frame] == P[frame + 29] || P[frame] == P[frame + 30] ||
                                P[frame] == P[frame + 39] || P[frame] == P[frame + 40] || P[frame] == P[frame + 41])
                            {
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", true, false, "00     08     18");
                            }
                        }
                        #endregion

                        #region 0 -> 9 -> ?
                        else if (P[frame] == P[frame + 9])
                        {

                            if (P[frame] == P[frame + 17])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "2", true, false, "00     09     17");

                            else if (P[frame] == P[frame + 18])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "0", true, false, "00     09     18");

                            else if (P[frame] == P[frame + 19])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "1", false, false, "00     09     19");

                            else if (P[frame] == P[frame + 20] || P[frame] == P[frame + 21])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", false, false, "00     09     20");

                            else if (P[frame] == P[frame + 26])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "2", true, false, "00     09     26");

                            else if (P[frame] == P[frame + 27])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "0", true, false, "00     09     27");

                            else if (P[frame] == P[frame + 28])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", true, false, "00     09     28");

                            else if (P[frame] == P[frame + 29])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "1", false, false, "00     09     29");

                            else if (P[frame] == P[frame + 30])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     09     30");

                            else if (P[frame] == P[frame + 31] || P[frame] == P[frame + 32] || P[frame] == P[frame + 33])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", false, false, "00     09     31");

                            else if (P[frame] == P[frame + 35])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "4", true, false, "00     09     35");

                            else if (P[frame] == P[frame + 36])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "0", true, false, "00     09     36");

                            else if (P[frame] == P[frame + 38])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "1", false, true, "00     09     38");

                            else if (P[frame] == P[frame + 39])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "1", false, false, "00     09     39");

                            else if (P[frame] == P[frame + 40] || P[frame] == P[frame + 41] || P[frame] == P[frame + 42])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     09     40");

                            else if (P[frame] == P[frame + 43] || P[frame] == P[frame + 44] || P[frame] == P[frame + 45])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", false, false, "00     09     43");

                        }

                        #endregion

                        #region 0 -> 10 -> ?
                        else if (P[frame] == P[frame + 10])
                        {

                            if (P[frame] == P[frame + 18])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "2", true, false, "00     10     18");

                            else if (P[frame] == P[frame + 19])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "2", false, false, "00     10     19");

                            else if (P[frame] == P[frame + 20])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "0", false, false, "00     10     20");

                            else if (P[frame] == P[frame + 21])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, false, "1", false, false, "00     10     21");

                            else if (P[frame] == P[frame + 22])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     10     22");

                            else if (P[frame] == P[frame + 23])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "1", false, false, "00     10     23");

                            else if (P[frame] == P[frame + 29])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "2", false, false, "00     10     29");

                            else if (P[frame] == P[frame + 30])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "0", false, false, "00     10     30");

                            else if (P[frame] == P[frame + 31])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", true, false, "00     10     31");

                            else if (P[frame] == P[frame + 32])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, false, "1", false, false, "00     10     32");

                            else if (P[frame] == P[frame + 33])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, false, "00     10     33");

                            else if (P[frame] == P[frame + 34])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     10     34");

                            else if (P[frame] == P[frame + 35] || P[frame] == P[frame + 36])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "1", false, false, "00     10     35");

                            else if (P[frame] == P[frame + 38])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "4", false, true, "00     10     38");

                            else if (P[frame] == P[frame + 39])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "4", false, false, "00     10     39");

                            else if (P[frame] == P[frame + 40])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "0", false, false, "00     10     40");

                            else if (P[frame] == P[frame + 41])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     10     41");

                            else if (P[frame] == P[frame + 42])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, true, "00     10     42");

                            else if (P[frame] == P[frame + 43])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, false, "00     10     43");

                            else if (P[frame] == P[frame + 44] || P[frame] == P[frame + 45] || P[frame] == P[frame + 46])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     10     44");

                            else if (P[frame] == P[frame + 47] || P[frame] == P[frame + 48] || P[frame] == P[frame + 49])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "1", false, false, "00     10     47");

                        }


                        #endregion

                        #region 0 -> 11 -> ?
                        else if (P[frame] == P[frame + 11])
                        {

                            if (P[frame] == P[frame + 19])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "2", true, false, "00     11     19");

                            else if (P[frame] == P[frame + 20])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "2", false, false, "00     11     20");

                            else if (P[frame] == P[frame + 21])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, false, "2", false, false, "00     11     21");

                            else if (P[frame] == P[frame + 22])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, false, "0", false, false, "00     11     22");

                            else if (P[frame] == P[frame + 23] || P[frame] == P[frame + 24])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     11     23");

                            else if (P[frame] == P[frame + 30])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "2", true, false, "00     11     30");

                            else if (P[frame] == P[frame + 31])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     11     31");

                            else if (P[frame] == P[frame + 32])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, false, "3", false, false, "00     11     32");

                            else if (P[frame] == P[frame + 33])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, false, "0", false, false, "00     11     33");

                            else if (P[frame] == P[frame + 34])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     11     34");

                            else if (P[frame] == P[frame + 35] || P[frame] == P[frame + 36] || P[frame] == P[frame + 37])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     11     36");

                            else if (P[frame] == P[frame + 41])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", true, false, "00     11     41");

                            else if (P[frame] == P[frame + 42])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     11     42");

                            else if (P[frame] == P[frame + 43])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, false, "4", false, false, "00     11     43");

                            else if (P[frame] == P[frame + 44])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, false, "0", false, false, "00     11     44");

                            else if (P[frame] == P[frame + 45] || P[frame] == P[frame + 46] || P[frame] == P[frame + 47])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     11     45");

                            else if (P[frame] == P[frame + 48] || P[frame] == P[frame + 49] || P[frame] == P[frame + 50])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     11     48");

                        }
                        #endregion

                        #region 0 -> 12 -> ?
                        else if (P[frame] == P[frame + 12])
                        {
                            if (P[frame] == P[frame + 21])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "2", false, false, "00     12     21");

                            else if (P[frame] == P[frame + 22])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     12     22");

                            else if (P[frame] == P[frame + 23] || P[frame] == P[frame + 24] || P[frame] == P[frame + 25])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     12     23");

                            else if (P[frame] == P[frame + 33])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, false, "00     12     33");

                            else if (P[frame] == P[frame + 34] || P[frame] == P[frame + 35] || P[frame] == P[frame + 36])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     12     34");

                            else if (P[frame] == P[frame + 37])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "2", false, false, "00     12     37");

                            else if (P[frame] == P[frame + 38])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     12     38");

                            else if (P[frame] == P[frame + 44])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, true, "00     12     44");

                            else if (P[frame] == P[frame + 45])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, false, "00     12     45");

                            else if (P[frame] == P[frame + 46] || P[frame] == P[frame + 47] || P[frame] == P[frame + 48])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     12     46");

                            else if (P[frame] == P[frame + 49] || P[frame] == P[frame + 50] || P[frame] == P[frame + 51])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     12     49");

                        }
                        #endregion

                        #region 0 -> 13 -> ?
                        else if (P[frame] == P[frame + 13])
                        {
                            if (P[frame] == P[frame + 23])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "2", false, false, "00     13     23");

                            else if (P[frame] == P[frame + 24] || P[frame] == P[frame + 25] || P[frame] == P[frame + 26])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     13     24");

                            else if (P[frame] == P[frame + 36])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "3", false, false, "00     13     36");

                            else if (P[frame] == P[frame + 37] || P[frame] == P[frame + 38] || P[frame] == P[frame + 39])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     13     37");

                            else if (P[frame] == P[frame + 48])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, true, "00     13     48");

                            else if (P[frame] == P[frame + 49])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, false, "00     13     49");

                            else if (P[frame] == P[frame + 50] || P[frame] == P[frame + 51] || P[frame] == P[frame + 52])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     13     50");
                        }
                        #endregion



                        #region 0 -> ? -> 17 -> ?
                        else if (P[frame] == P[frame + 17])
                        {
                            if (P[frame] == P[frame + 26] || P[frame] == P[frame + 35])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "1", true, false, "00     17     26");
                        }
                        #endregion

                        #region 0 -> ? -> 18 -> ?
                        else if (P[frame] == P[frame + 18])
                        {
                            if (P[frame] == P[frame + 26] || P[frame] == P[frame + 35])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "3", true, false, "00     18     26");

                            else if (P[frame] == P[frame + 27] || P[frame] == P[frame + 36])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "0", true, false, "00     18     27");
                        }
                        #endregion

                        #region 0 -> ? -> 19 -> ?
                        else if (P[frame] == P[frame + 19])
                        {
                            if (P[frame] == P[frame + 28] || P[frame] == P[frame + 30])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", true, false, "00     19     28");

                            else if (P[frame] == P[frame + 29])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "1", false, false, "00     19     29");

                            else if (P[frame] == P[frame + 38])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "1", false, true, "00     19     38");

                            else if (P[frame] == P[frame + 39])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "1", false, false, "00     19     39");

                            else if (P[frame] == P[frame + 40] || P[frame] == P[frame + 41])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", true, false, "00     19     40");
                        }
                        #endregion

                        #region 0 -> ? -> 20 -> ?
                        else if (P[frame] == P[frame + 20])
                        {
                            if (P[frame] == P[frame + 28])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", true, false, "00     20     28");

                            else if (P[frame] == P[frame + 29])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "3", false, false, "00     20     29");

                            else if (P[frame] == P[frame + 30])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "0", false, false, "00     20     30");

                            else if (P[frame] == P[frame + 31])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     20     31");

                            else if (P[frame] == P[frame + 38])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "3", false, true, "00     20     38");

                            else if (P[frame] == P[frame + 39])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "3", false, false, "00     20     39");

                            else if (P[frame] == P[frame + 40])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "0", false, false, "00     20     40");

                            else if (P[frame] == P[frame + 41] || P[frame] == P[frame + 42])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     20     41");
                        }
                        #endregion

                        #region 0 -> ? -> 21 -> ?
                        else if (P[frame] == P[frame + 21])
                        {
                            if (P[frame] == P[frame + 29])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", true, false, "00     21     29");

                            else if (P[frame] == P[frame + 30] || P[frame] == P[frame + 31])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     21     30");

                            else if (P[frame] == P[frame + 32])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, false, "1", false, false, "00     21     32");

                            else if (P[frame] == P[frame + 33])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", false, false, "00     21     33");

                            else if (P[frame] == P[frame + 40])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", true, false, "00     21     40");

                            else if (P[frame] == P[frame + 41] || P[frame] == P[frame + 42])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     21     41");

                            else if (P[frame] == P[frame + 43])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, false, "1", false, false, "00     21     43");

                            else if (P[frame] == P[frame + 44] || P[frame] == P[frame + 45])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", false, false, "00     21     44");

                        }
                        #endregion

                        #region 0 -> ? -> 22 -> ?
                        else if (P[frame] == P[frame + 22])
                        {
                            if (P[frame] == P[frame + 30])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", true, false, "00     22     30");

                            else if (P[frame] == P[frame + 31])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, false, "00     22     31");

                            else if (P[frame] == P[frame + 32])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", false, false, "00     22     32");

                            else if (P[frame] == P[frame + 33])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, false, "0", false, false, "00     22     33");

                            else if (P[frame] == P[frame + 34])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     22     34");

                            else if (P[frame] == P[frame + 41])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", true, false, "00     22     41");

                            else if (P[frame] == P[frame + 42])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     22     42");

                            else if (P[frame] == P[frame + 43])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, false, "3", false, false, "00     22     43");

                            else if (P[frame] == P[frame + 44])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, false, "0", false, false, "00     22     44");

                            else if (P[frame] == P[frame + 45] || P[frame] == P[frame + 46])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     22     45");



                        }
                        #endregion

                        #region 0 -> ? -> 23 -> ?
                        else if (P[frame] == P[frame + 23])
                        {
                            if (P[frame] == P[frame + 32])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, false, "00     23     32");

                            else if (P[frame] == P[frame + 33] || P[frame] == P[frame + 34] || P[frame] == P[frame + 35])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     23     33");

                            else if (P[frame] == P[frame + 36])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "1", false, false, "00     23     36");

                            else if (P[frame] == P[frame + 43])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, true, "00     23     43");

                            else if (P[frame] == P[frame + 44])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, false, "00     23     44");

                            else if (P[frame] == P[frame + 45] || P[frame] == P[frame + 46] || P[frame] == P[frame + 47])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     23     45");

                            else if (P[frame] == P[frame + 48] || P[frame] == P[frame + 49])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "1", false, false, "00     23     48");

                        }
                        #endregion

                        #region 0 -> ? -> 24 -> ?
                        else if (P[frame] == P[frame + 24])
                        {
                            if (P[frame] == P[frame + 33])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, false, "00     24     33");

                            else if (P[frame] == P[frame + 34])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     24     34");

                            else if (P[frame] == P[frame + 35] || P[frame] == P[frame + 36] || P[frame] == P[frame + 37])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     24     35");

                            else if (P[frame] == P[frame + 44])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, true, "00     24     44");

                            else if (P[frame] == P[frame + 45])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "3", false, false, "00     24     45");

                            else if (P[frame] == P[frame + 46] || P[frame] == P[frame + 47] || P[frame] == P[frame + 48])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     24     46");

                            else if (P[frame] == P[frame + 49] || P[frame] == P[frame + 50])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     24     49");



                        }
                        #endregion

                        #region 0 -> ? -> 25 -> ?
                        else if (P[frame] == P[frame + 25])
                        {
                            if (P[frame] == P[frame + 35])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "3", false, false, "00     25     35");

                            else if (P[frame] == P[frame + 36] || P[frame] == P[frame + 37] || P[frame] == P[frame + 38])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     25     36");

                            else if (P[frame] == P[frame + 47])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "3", false, true, "00     25     47");

                            else if (P[frame] == P[frame + 48])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "3", false, false, "00     25     48");

                            else if (P[frame] == P[frame + 49] || P[frame] == P[frame + 50] || P[frame] == P[frame + 51])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     25     49");


                        }
                        #endregion

                        #region 0 -> ? -> 26 -> ?
                        else if (P[frame] == P[frame + 26])
                        {
                            if (P[frame] == P[frame + 35])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "1", true, false, "00     26     35");

                            else if (P[frame] == P[frame + 36])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "3", false, false, "00     26     36");

                            else if (P[frame] == P[frame + 37] || P[frame] == P[frame + 38] || P[frame] == P[frame + 39])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     26     37");

                            else if (P[frame] == P[frame + 48])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "3", false, true, "00     26     48");

                            else if (P[frame] == P[frame + 49])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "3", false, false, "00     26     49");

                            else if (P[frame] == P[frame + 50] || P[frame] == P[frame + 51] || P[frame] == P[frame + 52])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     26     50");

                        }
                        #endregion

                        #region 0 -> ? -> 27 -> ?
                        else if (P[frame] == P[frame + 27])
                        {
                            if (P[frame] == P[frame + 35])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "4", true, false, "00     27     35");

                            else if (P[frame] == P[frame + 36])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "0", true, false, "00     27     36");

                        }
                        #endregion

                        #region 0 -> ? -> 29 -> ?
                        else if (P[frame] == P[frame + 29])
                        {
                            if (P[frame] == P[frame + 38])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "1", false, true, "00     29     38");

                            else if (P[frame] == P[frame + 39])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "1", false, false, "00     29     39");

                        }
                        #endregion

                        #region 0 -> ? -> 30 -> ?
                        else if (P[frame] == P[frame + 30])
                        {
                            if (P[frame] == P[frame + 38])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "4", false, true, "00     30     38");

                            else if (P[frame] == P[frame + 39])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "4", false, false, "00     30     39");

                            else if (P[frame] == P[frame + 40])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], false, true, "0", false, false, "00     30     40");

                            else if (P[frame] == P[frame + 41])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", true, false, "00     30     41");

                        }
                        #endregion

                        #region 0 -> ? -> 31 -> ?
                        else if (P[frame] == P[frame + 31])
                        {
                            if (P[frame] == P[frame + 39])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", true, false, "00     31     39");

                            else if (P[frame] == P[frame + 40] || P[frame] == P[frame + 41] || P[frame] == P[frame + 42])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     30     40");

                        }
                        #endregion

                        #region 0 -> ? -> 32 -> ?
                        else if (P[frame] == P[frame + 32])
                        {
                            if (P[frame] == P[frame + 40])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", true, false, "00     32     40");

                            else if (P[frame] == P[frame + 41] || P[frame] == P[frame + 42] || P[frame] == P[frame + 43])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     32     41");

                        }
                        #endregion

                        #region 0 -> ? -> 33 -> ?
                        else if (P[frame] == P[frame + 33])
                        {
                            if (P[frame] == P[frame + 41])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", true, false, "00     33     41");

                            else if (P[frame] == P[frame + 42] || P[frame] == P[frame + 43] || P[frame] == P[frame + 44])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", true, false, "00     33     42");

                            else if (P[frame] == P[frame + 45])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "1", false, false, "00     33     45");

                        }
                        #endregion

                        #region 0 -> ? -> 34 -> ?
                        else if (P[frame] == P[frame + 34])
                        {
                            if (P[frame] == P[frame + 42])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, true, "00     34     42");

                            else if (P[frame] == P[frame + 43])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, false, "00     34     43");

                            else if (P[frame] == P[frame + 44] || P[frame] == P[frame + 45] || P[frame] == P[frame + 46])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     34     44");

                        }
                        #endregion

                        #region 0 -> ? -> 35 -> ?
                        else if (P[frame] == P[frame + 35])
                        {
                            if (P[frame] == P[frame + 43])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, true, "00     35     43");

                            else if (P[frame] == P[frame + 44])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, false, "00     35     44");

                            else if (P[frame] == P[frame + 45] || P[frame] == P[frame + 46] || P[frame] == P[frame + 47])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     35     45");

                        }
                        #endregion

                        #region 0 -> ? -> 36 -> ?
                        else if (P[frame] == P[frame + 36])
                        {
                            if (P[frame] == P[frame + 44])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, true, "00     36     44");

                            else if (P[frame] == P[frame + 45])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "4", false, false, "00     36     45");

                            else if (P[frame] == P[frame + 46] || P[frame] == P[frame + 47] || P[frame] == P[frame + 48])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, true, "0", false, false, "00     36     46");

                            else if (P[frame] == P[frame + 49])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "1", false, false, "00     36     49");
                        }
                        #endregion

                        #region 0 -> ? -> 37 -> ?
                        else if (P[frame] == P[frame + 37])
                        {
                            if (P[frame] == P[frame + 46])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, true, "00     37     46");

                            else if (P[frame] == P[frame + 47])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, false, "00     37     47");

                            else if (P[frame] == P[frame + 48] || P[frame] == P[frame + 49] || P[frame] == P[frame + 50])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     37     48");

                        }
                        #endregion

                        #region 0 -> ? -> 38 -> ?
                        else if (P[frame] == P[frame + 38])
                        {
                            if (P[frame] == P[frame + 47])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, true, "00     38     47");

                            else if (P[frame] == P[frame + 48])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, false, "00     38     48");

                            else if (P[frame] == P[frame + 49] || P[frame] == P[frame + 50] || P[frame] == P[frame + 51])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     38     49");

                        }
                        #endregion

                        #region 0 -> ? -> 39 -> ?
                        else if (P[frame] == P[frame + 39])
                        {
                            if (P[frame] == P[frame + 48])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, true, "00     39     48");

                            else if (P[frame] == P[frame + 49])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "4", false, false, "00     39     49");

                            else if (P[frame] == P[frame + 50] || P[frame] == P[frame + 51] || P[frame] == P[frame + 52])
                                Charm_Sync_HA_Gend_Carb(initial, frame, P[frame], true, false, "0", false, false, "00     39     50");
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
