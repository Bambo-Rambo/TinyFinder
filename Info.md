# General
The TinyMT algorithm in gen 6 games is being used to decide various things including when an encounter is triggered, the encounter slot, the nature sync etc. 
To get a shiny, you must fit your desired main frame inside the appropriate index that generates the desired result.

# Generation
Unlike the main seed, the TinyMT seed depends solely on your system's current RTC when you boot the game. 
On Citra, it can be abused very easily by setting the RTC to fixed mode but on console it's about milisecond accuracy. 
Citra does not support miliseconds yet so for every second you add, the TinyMT initial seed is increased by 1000 (0x3E8 in hex).

Like the main seed, a 32 bit hex number is generated which is what we call the "TinyMT initial seed". 
It then passes through the "init()" function to generate the initial state which is an array consisting of four 32 bit hex numbers or simply a 128 bit hex number. 
Each state passes through the "nextState()" function to generate the next result. 
In order to calculate the results for a given state, we pass it through the "temper()" function which returns a 32 bit hex number in what I will call "Hex Rand". 

The TID and SID generation is based on the Hex Rand. The first half is the SID in decimal while the second half, the TID in decimal. 
So for example if the Hex Rand's value is 0xFDCB8660, the TID is: decimal(0x8660) -> 34400 and the SID is: decimal(FDCB) -> 64971.

To generate the results for other methods like wild RNG, hordes etc, the Hex Rand passes through a final function (Rand(n)) 
where  [0-n)  is the range of possible results in what I will call Int Rand. For the most cases, n = 100.

It's important to note, that every time a variable (sync, ratio, slot etc) is calculated, the Int Rand advances by one.
This is important for the randomness of the results but is also necessary for one more reason. Read below.

If rand < 50, the nature syncs for that index. Also for normal Wild/Fishing/Friend Safari, the encounter ratio, becomes the Rand's value. 
If both sync and ratio were using the same rand value, then every wild Pokemon, would have its nature synced no matter what since the encounter ratio would have to be < 13 
for a successful encounter which means that it would be < 50 as well.
The same goes for the rest of the variables. The possible slots would have been 1, 2, 3, 4 only, while the white flute effect would be always 1.

# Conclusions - Interesting facts

For what described above, it's impossible for some specific consecutive combinations to occur. For example in Poke Radar RNG, it's impossible to find 2 consecutive slot 12
indexes that also sync the nature. This happens because every time you come across a slot 12, 
it means that the rand value of the next index is always 99 no matter what, so no sync for
the next index. As for the rest of the methods, here are some examples of specific index combinations:

### Normal Wid

- For caves (Ratio = 7) it's impossible to have 2 consecutive encounters whose slots are 2 or higher
- For grass (Ratio = 13) it's impossible to have 2 consecutive encounters whose slots are 3 or higher
- For grass with illumise leading (Ratio = 26) it's impossible to have 2 consecutive encounters whose slots are 4 or higher
- For grass with illumise leading + O-power (max Ratio = 78) it's impossible to have 2 consecutive encounters whose slots are 9 or higher

The same occur for Friend Safari. Consider FS slot 1 as slots 1/2/3 in Normal Wild, slot 2 as slots 4/5/6/7 and slot 3 as slots 8/9/10/11/12.

### Fishing

- Without leading with Suction Cups (ratio = 49), it's impossible to have 2 consecutive encounter whose slots are 2 or higher
- Leading with Suction Cups (ratio = 98), you can find 2 consecutive slots 3 that also sync, and both their white flute effects are 4, 
but it's pointless since you replace the Synchronizer with Suction Cups anyway.
Funnily enough, the 1st flute will always be 4 (the rarest) while the second can be any.

### Rock Smash

Rock smash doesn't have encounter ratio but rather "encounter case" (it uses Rand(3) instead of Rand(100) to calculate it). 
If the value is 0 you get a Pokemon, if it's 1 you get item, and for value = 2 you get nothing.

- You can find 2 successful consecutive slots 5. 
The first one will always sync and it's flute value will always be be 4 while the second will never sync and it's flute value can be any.

