

namespace TinyFinder
{
    class Horde
    {
        public byte slot, HA, randInt, extra = 3;
        public bool sync;
        public byte[] flutes = new byte[5], items = new byte[5];
        public uint[] temp = new uint[4];
        public TinyMT tinyhorde = new TinyMT();
        public SlotData data = new SlotData();

        public Horde(uint[] current, byte party, bool oras, bool cave)
        {

            current.CopyTo(temp, 0);
            tinyhorde.nextState(temp);
            randInt = tinyhorde.Rand(temp, 100);

            if (!cave)
            {
                if (oras)
                    extra = 15;
                else extra = 27;
            }

            for (byte i = 0; i < (3 * party + extra); i++)
                tinyhorde.nextState(temp);

            sync = tinyhorde.Rand(temp, 100) < 50;

            tinyhorde.nextState(temp);
            slot = data.getSlot(tinyhorde.Rand(temp, 100), 2);

            tinyhorde.nextState(temp);
            if (tinyhorde.Rand(temp, 100) < 20)
            {
                tinyhorde.nextState(temp);
                HA = (byte)(tinyhorde.Rand(temp, 5) + 1);
            }

            tinyhorde.nextState(temp);
            if (oras)
            {
                for (byte i = 0; i < 5; i++)
                {
                    if (tinyhorde.Rand(temp, 100) < 40)
                        flutes[i] = 1;
                    else if (tinyhorde.Rand(temp, 100) < 70)
                        flutes[i] = 2;
                    else if (tinyhorde.Rand(temp, 100) < 90)
                        flutes[i] = 3;
                    else flutes[i] = 4;
                    tinyhorde.nextState(temp);
                }
            }


            tinyhorde.nextState(temp);
            for (byte i = 0; i < 5; i++)
            {
                if (tinyhorde.Rand(temp, 100) < 50)
                    items[i] = 50;
                else if (tinyhorde.Rand(temp, 100) < 55)
                    items[i] = 5;
                else if (tinyhorde.Rand(temp, 100) < 56)
                    items[i] = 1;
                else items[i] = 0;
                tinyhorde.nextState(temp);
            }

        }


    }
}
