
namespace TinyFinder
{
    class Location
    {
        public int Map;
        public string Name;
        public int NPC;
        public int Enc_Ratio;
        public int Bag_Advances;
        public int FirstLongBlinkRand;
        public int FirstLongBlinkRand_Emu;

        public ushort   [] GrassTable;
        public ushort   [] LongTable;
        public ushort   [] CaveTable;
        public ushort   [] RideTable;
        public int      [] WildLevel;

        public ushort   [] RedTable;
        public int      [] RedLevel;
        public ushort   [] YellowTable;
        public int      [] YellowLevel;
        public ushort   [] PurpleTable;
        public int      [] PurpleLevel;

        public ushort   [] SwampTable;
        public int      [] SwampLevel;

        public ushort   [] HordeTable1;
        public ushort   [] HordeTable2;
        public ushort   [] HordeTable3;
        public int      [] HordeLevel;

        public ushort   [] SurfTable;
        public int      [] SurfLevel;

        public ushort   [] OldTable;
        public int      [] OldLevel;

        public ushort   [] GoodTable;
        public int      [] GoodLevel;

        public ushort   [] SuperTable;
        public int      [] SuperLevel;

        public ushort   [] SmashTable;
        public int      [] SmashLevel;

        public ushort   [] DexNavTable;
        public int         DexNavLevel;

        public ushort   [] AmbushTable;
        public int      [] AmbushLevel;


        public bool HasNormalWild()
        {
            return !(
                GrassTable == null && 
                LongTable == null && 
                CaveTable == null && 
                RedTable == null && 
                YellowTable == null &&
                PurpleTable == null &&
                SwampTable == null && 
                RideTable == null && 
                SurfTable == null);
        }

        public bool HasMovingHordes()
        {
            return !(
                GrassTable == null &&
                LongTable == null &&
                CaveTable == null &&
                RedTable == null &&
                YellowTable == null &&
                PurpleTable == null) && HordeTable1 != null;
        }

        public bool HasHoneyWild()
        {
            if (SurfTable != null || SwampTable != null)
                return true;

            if (HordeTable1 == null && RideTable == null)
            {
                if (!(GrassTable == null &&
                    LongTable == null &&
                    CaveTable == null &&
                    RedTable == null &&
                    YellowTable == null &&
                    PurpleTable == null))
                    return true;
            }
            return false;
        }

        public bool HasFishing()
        {
            return OldTable != null && GoodTable != null && SuperTable != null && 
                FirstLongBlinkRand != 0 && FirstLongBlinkRand_Emu != 0;
        }

        public bool HasSmash()
        {
            return SmashTable != null && FirstLongBlinkRand != 0 && FirstLongBlinkRand_Emu != 0;
        }

        public bool HasRadar()
        {
            return !(
                GrassTable == null  && 
                RedTable == null && 
                YellowTable == null && 
                PurpleTable == null);
        }

        public bool HasDexNav()
        {
            return !(
                GrassTable == null &&
                LongTable == null &&
                CaveTable == null &&
                SurfTable == null &&
                DexNavTable == null);
        }

    }
}
