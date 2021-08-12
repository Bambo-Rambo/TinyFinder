
namespace TinyFinder
{
    class SlotData
    {
        public byte getSlot(int rand, byte SlotType)
        {
            var SlotSplitter = SlotDistribution[SlotType];
            for (byte i = 1; i < SlotSplitter.Length; i++)
            {
                rand -= SlotSplitter[i - 1];
                if (rand < 0)
                    return i;
            }
            return (byte)SlotSplitter.Length;
        }

        public readonly static byte[][] SlotDistribution = new byte[][]
        {
            new byte[] { 10,10,10,10,10,10,10,10,10,5,4,1 },    // Wild / Radar
            new byte[] { 34,33,33 },                            // Friend Safari
            new byte[] { 60,35,5 },                             // Horde / Fishing
            new byte[] { 50,30,15,4,1 },                        // Rock Smash / Surfing
        };

        public byte getAdvances(string loc)
        {
            if (loc.Equals("Route 7") || loc.Equals("Elsewhere"))
                return 10; //***Temporary solution
            else
                for (byte i = 0; i < 5; i++)
                    foreach (string x in Locations[i])
                        if (x.Equals(loc))
                            return i;
            return 0;
        }

        public static string[][] Locations = new string[][]
        {
            new string[] { "Route 2", "Route 3", "Santalune Forest", "Route 22" },                      // 0 + 1
            new string[] { "Azure Bay", "Route 4", "Route 8", "Route 10", "Route 15", "Route 20" },     // 1 + 2
            new string[] { "Route 5", "Route 11", "Route 12", "Route 14", "Route 21" },                 // 2 + 3
            new string[] { "Route 18", "Route 19", "Pokemon Village" },                                 // 3 + 4
          //new string[] { "Route 7", "All caves"},                                                     // 1 + 1
          //new string[] { "Elsewhere" },                                                               // 0 + 0
        };

        public static string[] SurfLocations = { "Magma/Aqua Hideout", "Battle Resort", "Underwater"};

    }
}
