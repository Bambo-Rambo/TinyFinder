# General
The TinyMT algorithm in gen 6 games is being used to decide various things including when an encounter is triggered, the encounter slot, the nature sync etc. 

# Generation
Unlike the main seed, the TinyMT seed depends solely on your system's current RTC when you boot the game. 
On Citra, it can be abused very easily by setting the RTC to fixed mode but on console it's about milisecond accuracy. 
Citra does not support miliseconds yet so for every second added to the RTC, the TinyMT initial seed is increased by 1000 (0x3E8 in hex).

Like the main seed, a 32 bit hex number is generated which is what we call the "TinyMT initial seed". 
It passes through the "init()" function to generate the initial state which is an array consisting of four 32 bit hex numbers or simply a 128 bit hex number. 
Each state then passes through the "nextState()" function to generate the next result. 
In order to calculate the results for a given state, we pass it through the "temper()" function which returns a 32 bit hex number in what I will call "Hex Rand". 

The TID and SID generation is based on the Hex Rand. The first half is the SID while the second half, the TID - both in decimal. 
So for example if the Hex Rand's value is 0xFDCB8660, the TID is: decimal(0x8660) = 34400 and the SID is: decimal(FDCB) = 64971.

To generate the results for other methods like wild RNG, hordes etc, the Hex Rand passes through a final function (Rand(n)) 
where  [0-n)  is the range of possible results in what I will call Int Rand. For the most cases, n = 100.

It's important to note, that every time a variable (sync, ratio, slot etc) is calculated, the Int Rand advances by one.
This is important for the randomness of the results but is also necessary for one more reason. Read below.

If rand < 50, the nature syncs for that index. Also for normal Wild/Fishing/Friend Safari, the encounter ratio, becomes the Rand's value. 
If both sync and ratio were using the same rand value, then every wild Pokemon, would have its nature synced no matter what since the encounter ratio would have to be < 13 
for a successful encounter which means that it would be < 50 as well.
The same goes for the rest of the variables. The possible slots would have been 1, 2, 3, 4 only, while the flute effect would be always 1.

# Interesting observations

### Normal Wild / Horde

We tend to forget that hordes can also be triggered by moving in the grass/cave/whatever. During a successful encounter (depends on the ratio), if rand(100) < 5, a horde is generated instead of a single encounter. In XY, it can be done at any place that generates hordes, but in ORAS, it's only possible at Long Grass. This actually explains a lot of things and in fact, hordes are the reason why Normal Wild RNG in most XY places is affected. 

So, the rand(100) for normal wild is supposed to check nature syncing, if < 50, the nature syncs. But for places that can generate a horde by moving, sync should use a different value because if both variables were using the same rand(100), then every successful horde encounter by step, would sync the nature since rand(100) would be < 5 and thus < 50 as well. For that reason, one extra rand call is performed before syncing for those places that obviously affects the rest of the variables as well (encounter ratio, slot etc). For consistency purposes, the developers could make this rand call occur in every place regardless of the possible horde generatio, but code-related, this would be a bad implementation, an unnecessary rand call would never be good. By the way, the NPC influence has to be taken into account before the first rand call, otherwise it will give the wrong rand(100) value. Finally and for a currently unknown reason, they decided to force one extra rand call for grass/flowers in XY before the slot generation.

To summarize:
* The NPC influence can advance up to 2 indexes at the moment you get control of your character by exiting the X menu. It needs to be calculated first.
* +1 advance before sync if the place can generate hordes (most XY places including caves, long grass only in ORAS).
* +1 advance before slot if RNG abusing in XY tall grass/flowers.

Examples:
* Kalos Route 2: Quiet place and only 1 advance before slot since XY tall grass and doesn't have hordes.
* Kalos Route 7: Quiet place. 1 advance before sync since hordes are possible and 1 more advance since XY tall grass/flowers.
* Kalos Route 11: Noisy place. 1 advance before anything, 1 advance before sync since hordes are possible and 1 more advance since XY tall grass/flowers.
* Kalos Route 16: Quiet place and no extra advances since hordes cannot be triggered by moving and isn't XY tall grass/flowers. Can be done with 3DS RNG Tool.
* Kalos Route 18: Very noisy place. 2 advances before anything, 1 advance before sync since hordes are possible and 1 more advance since XY tall grass/flowers.
* Kalos Caves: Quiet places. Only 1 advance before sync since hordes are possible and nothing else since not XY tall grass/flowers.
* Hoenn Route 101: Same as Kalos Route 16.
* Hoenn Route 117: Noisy place. 1 advance before anything and no extra advances since hordes cannot be triggered by moving and isn't XY tall grass/flowers.
* Hoenn Route 118: Quiet place. If in tall grass, the same as Route 101. If in Long grass, 1 advance before sync since hordes by moving are possible and nothing else since it isn't XY tall grass/flowers.
* Hoenn Route 118: Quiet place with long grass only. Same as Route 118 long grass.
* Hoenn Route 123: Noisy place. 1 advance before anything and 1 more before sync since hordes are possible by moving and nothing else since it isn't XY tall grass/flowers.
* Hoenn Caves: Same as Kalos Route 16.

# Consecutive cases

For what described above, it's impossible for some specific consecutive combinations to occur. For example in Poke Radar RNG, it's impossible to find 2 consecutive slot 12
indexes that also sync the nature. This happens because every time you come across a slot 12, 
it means that the rand value of the next index is always 99 no matter what, so no sync for
the next index. As for the rest of the methods, here are some examples of specific index combinations:

### Normal Wid

* For caves (Ratio = 7) it's impossible to have 2 consecutive encounters whose slots are 2 or higher
* For grass (Ratio = 13) it's impossible to have 2 consecutive encounters whose slots are 3 or higher
* For grass with illumise leading (Ratio = 26) it's impossible to have 2 consecutive encounters whose slots are 4 or higher
* For grass with illumise leading + O-power (max Ratio = 78) it's impossible to have 2 consecutive encounters whose slots are 9 or higher

The same occur for Friend Safari. Consider FS slot 1 as slots 1/2/3 in Normal Wild, slot 2 as slots 4/5/6/7 and slot 3 as slots 8/9/10/11/12.

### Fishing

* Without leading with Suction Cups (ratio = 49), it's impossible to have 2 consecutive encounter whose slots are 2 or higher
* Leading with Suction Cups (ratio = 98), you can find 2 consecutive slots 3 that also sync, and both their white flute effects are 4, 
but it's pointless since you replace the Synchronizer with Suction Cups anyway.
Funnily enough, the 1st flute will always be 4 (the rarest) while the second can be any.

### Rock Smash

Rock smash doesn't have encounter ratio but rather "encounter case" (it uses Rand(3) instead of Rand(100) to calculate it). 
If the value is 0 you get a Pokemon, if it's 1 you get item, and for value = 2 you get nothing.

* You can find 2 successful consecutive slots 5. 
The first one will always sync and it's flute value will always be be 4 while the second will never sync and it's flute value can be any.

