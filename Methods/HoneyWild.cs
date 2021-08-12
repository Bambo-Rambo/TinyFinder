namespace TinyFinder
{
    class HoneyWild
    {
        public byte slot, flute, item, randInt, slotLine, advances;
        public bool Sync;
        public uint[] temp = new uint[4];

        TinyMT tinyhoney = new TinyMT();
        SlotData data = new SlotData();

        public void results(uint[] current, bool oras, bool cave, bool water, byte party, byte location)
        {
            current.CopyTo(temp, 0);

            tinyhoney.nextState(temp);
            randInt = tinyhoney.Rand(temp, 100);

            if (cave)
                advances = 3;
            else
            {
                if (!oras)
                    advances = 27;
                else
                {
                    if (!water)
                        advances = 15;
                    else
                    {
                        switch (location)
                        {
                            case 0:
                                advances = 15;
                                break;
                            case 1:
                                advances = 6;
                                break;
                            case 2:
                                advances = 16;
                                break;
                            case 3:
                                advances = 3;
                                break;
                        }
                    }
                }
            }

            for (byte i = 0; i < advances + (3 * party); i++)
                tinyhoney.nextState(temp);

            Sync = tinyhoney.Rand(temp, 100) < 50;

            tinyhoney.nextState(temp);
            slot = data.getSlot(tinyhoney.Rand(temp, 100), slotLine);

            if (oras)
            {
                tinyhoney.nextState(temp);
                if (tinyhoney.Rand(temp, 100) < 40)
                    flute = 1;
                else if (tinyhoney.Rand(temp, 100) < 70)
                    flute = 2;
                else if (tinyhoney.Rand(temp, 100) < 90)
                    flute = 3;
                else flute = 4;
            }

            tinyhoney.nextState(temp);
            tinyhoney.nextState(temp);
            if (tinyhoney.Rand(temp, 100) < 50)
                item = 50;
            else if (tinyhoney.Rand(temp, 100) < 55)
                item = 5;
            else if (tinyhoney.Rand(temp, 100) < 56)
                item = 1;
            else item = 0;
        }
    }
}
