using System;
using System.Collections.Generic;
using System.Linq;
using TinyFinder.RNG;

namespace TinyFinder.Subforms.MT
{
    public partial class MTForm
    {
        readonly char[] PossibleDigit = { '6', '7', '8', '9', 'A', };
        string hex(uint dec) => dec.ToString("X").PadLeft(8, '0');
        uint rand(uint mtrand, uint n) => (uint)(mtrand * (ulong)n >> 32);
        uint GetPSV(uint PID) => ((PID >> 16) ^ (PID & 0xFFFF)) >> 4;
        byte GetPRV(uint PID) => (byte)(((PID >> 16) ^ (PID & 0xFFFF)) & 0xF);


        #region Functions
        public bool FindIVsNature(int[] IVs, ref string Nature, uint[] PIDList, uint frame)
        {
            for (int j = IVcount; j > 0;)
            {
                frame++;
                uint tmp = rand(PIDList[frame], 6);
                if (IVs[tmp] == 0)
                {
                    j--;
                    IVs[tmp] = 31;
                }
            }
            for (int j = 0; j < 6; j++)
                if (IVs[j] == 0)
                {
                    frame++;
                    IVs[j] = (int)(PIDList[frame] >> 27);
                }

            if (CheckIVs(IVs))
            {
                if (SelectedNatures.Contains((int)rand(PIDList[frame + 2], 25)) || SelectedNatures.Count == 0)
                {
                    Nature = Natures[(int)rand(PIDList[frame + 2], 25)];
                    UnownLetter3 = FindUnown((byte)rand(PIDList[frame + 1], 28));
                    UnownLetter2 = FindUnown((byte)rand(PIDList[frame + 2], 28));
                    UnownLetter1 = FindUnown((byte)rand(PIDList[frame + 3], 28));
                    return true;
                }
            }
            return false;
        }
        public char FindUnown(byte Form)
        {
            if (Form < 26)
                return (char)('A' + Form);
            else
                return Form == 26 ? '!' : '?';
        }
        private bool CheckIVs(int[] IVs)
        {
            return IVs[0] >= Min_hp && IVs[1] >= Min_atk && IVs[2] >= Min_def && IVs[3] >= Min_spA && IVs[4] >= Min_spD && IVs[5] >= Min_spe &&
                            IVs[0] <= Max_hp && IVs[1] <= Max_atk && IVs[2] <= Max_def && IVs[3] <= Max_spA && IVs[4] <= Max_spD && IVs[5] <= Max_spe;
        }

        void AddToListPID(uint seed, uint frame, uint pid, uint psv, byte prv, int[] IVs, string Nature, char Unown1, char Unown2, char Unown3)
        {
            string IVList = string.Join(" / ", IVs.Select(v => v.ToString().PadLeft(2, '0')));
            Invoke(new Action(() => { G6_DGV.Rows.Add(seed, frame, pid, psv, prv.ToString("X"), IVList, Nature, Unown1, Unown2, Unown3, Count8); }));
        }
        void AddToListEC(uint Seed, uint Frame, uint EC, int[] IVs1, int[] IVs2)
        {
            string IVList1 = string.Join(" / ", IVs1.Select(v => v.ToString().PadLeft(2, '0')));
            string IVList2 = string.Join(" / ", IVs2.Select(v => v.ToString().PadLeft(2, '0')));
            Invoke(new Action(() => { EC_DGV.Rows.Add(Seed, Frame, EC, IVList1, IVList2); }));
        }
        #endregion


        #region IVs
        public void IVResearch(uint IVSeed, uint step)
        {
            MersenneTwister_Fast mt;
            TSV = (uint)CurrentTSV.Value; TRV = (byte)CurrentTRV.Value;
            uint Current_PSV;
            int[] IVs;
            uint[] PIDList = new uint[Max + 20];
            string Nature = "";

            while (IVSeed < EndSeed)
            {
                mt = new MersenneTwister_Fast(IVSeed);

                for (uint frame = 0; frame < Min + 62; frame++)
                    mt.Nextuint();
                for (uint frame = Min; frame < Min + 20; frame++)
                    PIDList[frame] = mt.Nextuint();
                for (uint frame = Min; frame < Max; frame++)
                {
                    PIDList[frame + 20] = mt.Nextuint();
                    Current_PSV = GetPSV(PIDList[frame]);

                    if (TSV == Current_PSV && FindIVsNature(IVs = new int[6], ref Nature, PIDList, frame))
                    {
                        byte Current_TRV = GetPRV(PIDList[frame]);
                        if (ShininessType != 3)
                        {
                            if ((ShininessType == 2 && Current_TRV == TRV) || (ShininessType == 1 && Current_TRV != TRV) || ShininessType == 0)
                                AddToListPID(IVSeed, frame, PIDList[frame], Current_PSV, Current_TRV, IVs, Nature, UnownLetter1, UnownLetter2, UnownLetter3);
                        }
                        else
                            AddToListPID(IVSeed, frame, PIDList[frame], Current_PSV, Current_TRV, IVs, Nature, UnownLetter1, UnownLetter2, UnownLetter3);
                    }
                    else if (ShininessType == 0)
                        if (FindIVsNature(IVs = new int[6], ref Nature, PIDList, frame))
                            AddToListPID(IVSeed, frame, PIDList[frame], Current_PSV, GetPRV(PIDList[frame]), IVs, Nature, UnownLetter1, UnownLetter2, UnownLetter3);
                }
                IVSeed += step;
            }
            Invoke(new Action(() => { Finished(); }));
        }
        #endregion


        #region PID/EC Only
        public void PIDResearch(uint PIDSeed, uint step)
        {
            MersenneTwister_Fast mt;
            uint[] PIDList = new uint[Max + 20];
            string Nature = "";

            while (PIDSeed < EndSeed)
            {
                mt = new MersenneTwister_Fast(PIDSeed);

                for (uint frame = 0; frame < Min + 62; frame++)
                    mt.Nextuint();
                for (uint frame = Min; frame < Min + 20; frame++)
                    PIDList[frame] = mt.Nextuint();
                for (uint frame = Min; frame < Max; frame++)
                {
                    PIDList[frame + 20] = mt.Nextuint();

                    if (PIDList[frame] == Desired_PID)
                    {
                        uint ActualFrame = EC ? frame + 1 : frame;
                        int[] IVs1 = new int[6];
                        if (!EC && FindIVsNature(IVs1, ref Nature, PIDList, ActualFrame))
                            AddToListPID(PIDSeed, ActualFrame, Desired_PID, GetPSV(PIDList[ActualFrame]), GetPRV(PIDList[ActualFrame]), IVs1, Nature, UnownLetter1, UnownLetter2, UnownLetter3);
                        else if (EC)
                        {
                            SelectedNatures.Clear();
                            int[] IVs2 = new int[6];
                            if (FindIVsNature(IVs1, ref Nature, PIDList, ActualFrame) | FindIVsNature(IVs2, ref Nature , PIDList, ActualFrame + 2))  //Both IVs should be calculated even if the first matches
                                AddToListEC(PIDSeed, ActualFrame, PIDList[frame], IVs1, IVs2);
                        }
                    }
                }
                PIDSeed += step;
            }
            Invoke(new Action(() => { Finished(); }));
        }
        #endregion


        #region PID Reroll
        public void PIDRerollResearch(uint PIDSeed, uint step)
        {
            MersenneTwister_Fast mt;
            int[] IVs;
            uint[] PIDList = new uint[Max + 20];
            uint PidLow = Desired_PID << 16;
            string Nature = "";

            while (PIDSeed < EndSeed)
            {
                mt = new MersenneTwister_Fast(PIDSeed);

                for (uint frame = 0; frame < Min + 62; frame++)
                    mt.Nextuint();
                for (uint frame = Min; frame < Min + 20; frame++)
                    PIDList[frame] = mt.Nextuint();
                for (uint frame = Min; frame < Max; frame++)
                {
                    PIDList[frame + 20] = mt.Nextuint();

                    if (PIDList[frame] << 16 == PidLow && FindIVsNature(IVs = new int[6], ref Nature, PIDList, frame))
                        AddToListPID(PIDSeed, frame, Desired_PID, GetPSV(Desired_PID), GetPRV(Desired_PID), IVs, Nature, UnownLetter1, UnownLetter2, UnownLetter3);
                }
                PIDSeed += step;
            }
            Invoke(new Action(() => { Finished(); }));
        }
        #endregion


        #region PID_EC
        public void EC_PID_Research(uint PIDSeed, uint step)
        {
            bool NiceECs = NiceEC.Checked;
            MersenneTwister_Fast mt;
            uint[] PIDList = new uint[Max + 20];
            byte DigitCount;
            string ECstring;

            while (PIDSeed < EndSeed)
            {
                mt = new MersenneTwister_Fast(PIDSeed);

                if (NiceECs)
                {
                    for (uint frame = 0; frame < Min + 62; frame++)
                        mt.Nextuint();
                    for (uint frame = Min; frame < Min + 20; frame++)
                        PIDList[frame] = mt.Nextuint();
                    for (uint frame = Min; frame < Max; frame++)
                    {
                        PIDList[frame + 20] = mt.Nextuint();

                        if (PIDList[frame] << 16 == PIDList[frame + 1] << 16) //frame -> PID, frame + 1 -> EC
                        {
                            ECstring = hex(PIDList[frame]);

                            DigitCount = 0;
                            for (int p = 0; p < 5; p++)
                                for (int digit = 0; digit < 8; digit++)
                                    if (ECstring[digit].Equals(PossibleDigit[p]))
                                        DigitCount++;

                            if (DigitCount == 8)
                                FoundEC(PIDSeed, mt, frame, PIDList, ECstring);
                        }
                    }
                }
                else
                {
                    for (uint frame = 0; frame < Min + 62; frame++)
                        mt.Nextuint();
                    for (uint frame = Min; frame < Min + 20; frame++)
                        PIDList[frame] = mt.Nextuint();
                    for (uint frame = Min; frame < Max; frame++)
                    {
                        PIDList[frame + 20] = mt.Nextuint();

                        if (PIDList[frame] << 16 == PIDList[frame + 1] << 16) //+1 = EC
                            FoundEC(PIDSeed, mt, frame, PIDList, hex(PIDList[frame]));
                    }
                }
                PIDSeed += step;
            }
            Invoke(new Action(() => { Finished(); }));
        }
        private void FoundEC(uint EC_Seed, MersenneTwister_Fast mt, uint frame, uint[] PIDList, string ECstring)
        {
            string Nature = "";
            int[] IVs = new int[6];
            if (FindIVsNature(IVs, ref Nature, PIDList, frame + 1))
            {
                Count8 = 0;
                for (int digit = 0; digit < 8; digit++)
                    if (ECstring[digit].Equals('8'))
                        Count8++;

                AddToListPID(EC_Seed, frame + 1, PIDList[frame], GetPSV(PIDList[frame]), GetPRV(PIDList[frame]), IVs, Nature, UnownLetter1, UnownLetter2, UnownLetter3);
            }
        }
        #endregion


        #region Hordes
        public void HordesResearch(uint Seed, uint Step)
        {
            if (Fast && ShinyCount >= 3)
            {
                switch (ShinyCount)
                {
                    case 3:
                        HordesResearch3(Seed, Step);
                        break;
                    case 4:
                        HordesResearch4(Seed, Step);
                        break;
                    case 5:
                        HordesResearch5(Seed, Step);
                        break;
                }
            }
            else
            {
                if (AnyTSV)
                    HordesResearchAny(Seed, Step);
                else
                    HordesResearchTSV(Seed, Step);
            }
        }

        private void HordesResearchAny(uint Initial, uint step)
        {
            byte Counter;
            uint[] PSVList = new uint[Max + 80];
            uint[] PIDList = new uint[Max + 80];
            uint HordePID;

            MersenneTwister_Fast mt;
            for (uint Seed = Initial; Seed <= EndSeed; Seed += step)
            {
                mt = new MersenneTwister_Fast(Seed);

                for (uint Frame = 0; Frame < Min + 62; Frame++)
                    mt.Nextuint();

                for (uint Frame = Min; Frame < Min + 80; Frame++)
                {
                    PIDList[Frame] = mt.Nextuint();
                    PSVList[Frame] = GetPSV(PIDList[Frame]);
                }

                for (uint Frame = Min; Frame < Max; Frame++)
                {
                    HordePID = mt.Nextuint();
                    PIDList[Frame + 80] = HordePID;
                    PSVList[Frame + 80] = GetPSV(HordePID);

                    Counter = 1;
                    for (byte c = 8; c < 53; c++)
                        if (PSVList[Frame] == PSVList[Frame + c])
                            Counter++;

                    if (Counter >= ShinyCount)
                    {
                                                                    //Genderless, Carbink, 3IVs
                        if (CheckAll(Seed, Frame, PSVList[Frame], PIDList, false, false, false))        //Any species is top priority
                            continue;

                        if (CheckAll(Seed, Frame, PSVList[Frame], PIDList, true, false, false))         //Any genderless
                            continue;

                        if (CheckAll(Seed, Frame, PSVList[Frame], PIDList, true, false, true))          //Smoochum
                            continue;

                        if (CheckAll(Seed, Frame, PSVList[Frame], PIDList, false, false, true))         //Mime Jr.
                            continue;

                        if (CheckAll(Seed, Frame, PSVList[Frame], PIDList, false, true, false))         //Carbink
                            continue;

                    }
                }
            }
            Invoke(new Action(() => { Finished(); }));
        }
        private void HordesResearchTSV(uint Initial, uint step)
        {
            uint[] PSVList = new uint[Max + 80];
            uint[] PIDList = new uint[Max + 80];
            uint HordePID;

            MersenneTwister_Fast mt;
            for (uint Seed = Initial; Seed <= EndSeed; Seed += step)
            {
                mt = new MersenneTwister_Fast(Seed);

                for (uint frame = 0; frame < Min + 62; frame++)
                    mt.Nextuint();

                for (uint frame = Min; frame < Min + 80; frame++)
                {
                    PIDList[frame] = mt.Nextuint();
                    PSVList[frame] = GetPSV(PIDList[frame]);
                }

                for (uint Frame = Min; Frame < Max; Frame++)
                {
                    HordePID = mt.Nextuint();
                    PIDList[Frame + 80] = HordePID;
                    PSVList[Frame + 80] = GetPSV(HordePID);

                    if (PSVList[Frame] == TSV)
                    {
                                                                    //Genderless, Carbink, 3IVs
                        if (CheckAll(Seed, Frame, PSVList[Frame], PIDList, false, false, false))        //Any species is top priority
                            continue;

                        if (CheckAll(Seed, Frame, PSVList[Frame], PIDList, true, false, false))         //Any genderless
                            continue;

                        if (CheckAll(Seed, Frame, PSVList[Frame], PIDList, true, false, true))          //Smoochum
                            continue;

                        if (CheckAll(Seed, Frame, PSVList[Frame], PIDList, false, false, true))         //Mime Jr.
                            continue;

                        if (CheckAll(Seed, Frame, PSVList[Frame], PIDList, false, true, false))         //Carbink
                            continue;

                    }
                }
            }
            Invoke(new Action(() => { Finished(); }));
        }

        private bool CheckAll(uint Seed, uint Frame, uint PSV, uint[] PIDList, bool Genderless, bool Carbink, bool IV3)
        {
            for (byte Charm = 1; Charm < 4; Charm += 2)

                for (byte HA = 0; HA < 5; HA++)

                    for (byte Sync = 0; Sync < 2; Sync++)

                        if (SetJumps(Seed, Frame, PIDList, PSV, Sync == 1, Genderless, Carbink, IV3, HA, Charm))
                            return true;

            return false;
        }

        private bool SetJumps(uint Seed, uint Frame, uint[] PIDList, uint PSV, bool Sync, bool Genderless, bool Carbink, bool IV3, byte HA, byte Charm)
        {
            uint DefaultJump = (uint)((Sync && Genderless) ? 9 : (Sync || Genderless) ? 10 : 11);
            uint[] Jumps = { DefaultJump, DefaultJump, DefaultJump, DefaultJump, DefaultJump };

            if (Carbink)
                Jumps[3]--;
            if (HA != 0)
                Jumps[HA - 1]--;


            uint[] frameList = new uint[5];
            uint[] PList = new uint[5];

            uint CurrentPSV = PSV;
            uint Firstframe = Frame;

            for (byte r = 0; r < 5; r++)
            {
                for (int Reroll = Charm; Reroll > 0; Reroll--)
                {
                    CurrentPSV = GetPSV(PIDList[Frame]);

                    if (CurrentPSV != PSV)
                    {
                        if (Reroll != 1)
                            Frame++;
                    }
                    else
                    {
                        Reroll = 0;
                    }
                }

                if (IV3)
                {
                    uint tmp;
                    bool[] IVs = new bool[6];
                    for (int i = 3; i > 0;)
                    {
                        Frame++;
                        tmp = (uint)(PIDList[Frame] * (ulong)6 >> 32);
                        if (!IVs[tmp])
                        {
                            i--;
                            IVs[tmp] = true;
                        }
                    }
                    Frame -= 3;
                }

                frameList[r] = Frame;
                PList[r] = CurrentPSV;

                Frame += Jumps[r];
            }

            List<uint> ShinyList = new List<uint>();
            byte count = 0;

            for (byte i = 0; i < 5; i++)
            {
                if (PList[i] == PSV)
                {
                    count++;
                    ShinyList.Add(frameList[i]);
                }
            }
            if (count >= ShinyCount)
            {
                string Jump = "";
                ShinyList.ForEach(f => { Jump += ((int)f - ShinyList.ElementAt(0)).ToString().PadLeft(2, '0') + "     "; });

                string Species = "Any";
                if (IV3)
                    Species = Genderless ? "Smoochum" : "Mime Jr.";
                else if (Genderless || Carbink)
                    Species = Carbink ? "Carbink" : "Genderless";

                Invoke(new Action(() => { HORDE_DGV.Rows.Add(Seed, Firstframe, PSV, Charm == 3, Sync, HA, Species, Jump); }));
                return true;
            }
            return false;
        }

        #endregion


        #region Seed RNG
        private void SeedResearch(uint SecondsAdvance, uint Offset)
        {
            uint Frame300Seed = Frame300.Value;
            uint NewSavePar = calc.FindSavePar(CitraRTC, CurrentSavePar.Value, Frame300Seed, Target.Value);

            Frame300Seed += Offset * 1000;  //Start seed will be different for each thread obviously

            DateTime Finaldate = CitraRTC;
            uint SecondsAdd = Offset;

            int SaveDelay = XY_MTButton.Checked ? 24 : 26;
            MersenneTwister_Fast rng;


            if (!SpecificTime.Checked)
            {
                uint SavePar;
                rng = new MersenneTwister_Fast(Frame300Seed);
                for (uint i = 0; i < 2000; i++)
                    rng.Nextuint();
                for (uint i = 2000; i < 200000; i++)
                {
                    SavePar = rng.Nextuint();

                    //86400000 is the total MS in a day. For every 1000 added to the Save Par, the seconds are increased by 1
                    //for (uint j = NewSavePar - 86400000; j <= NewSavePar; j += 1000) <- Slow

                    if (SavePar >= NewSavePar - 86400000 && SavePar <= NewSavePar && ((SavePar - (NewSavePar - 86400000)) % 1000 == 0))
                    {
                        Invoke(new Action(() =>
                        {
                            Seed_DGV.Rows.Add(
                                null, hex(Frame300Seed), i - SaveDelay, hex(SavePar), calc.Check_DST(Finaldate, (NewSavePar - SavePar) / 1000));
                        }));
                    }
                }
                Invoke(new Action(() => { Finished(); }));
            }
            else
            {
                uint SeedAdvance = SecondsAdvance * 1000;
                while (true)
                {
                    rng = new MersenneTwister_Fast(Frame300Seed);

                    for (uint i = 0; i < 2000; i++)
                        rng.Nextuint();
                    for (uint i = 2000; i < 10000; i++)
                    {
                        if (rng.Nextuint() == NewSavePar)
                        {
                            Invoke(new Action(() =>
                            {
                                Seed_DGV.Rows.Add(
                                    calc.Check_DST(Finaldate, SecondsAdd), hex(Frame300Seed), i - SaveDelay, hex(NewSavePar), null);
                            }));
                        }
                    }
                    SecondsAdd += SecondsAdvance;            //+1 second in the RTC increases the Seed by 1000
                    Frame300Seed += SeedAdvance;
                }
            }
        }

        
        #endregion


    }
}
