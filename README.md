# TinyFinder

### Note: Recent Citra builds will generate a slightly different Initial seed each time you load a game, making consistent seed RNG abuse impossible. Canary 2610 and Nightly 1915 are tested versions proved to be working fine.

Windows forms app for assisting with RNG abuse (mainly TinyMT) in Pokemon gen 6 games.

It aims to be a more user friendly version of Tiny Timeline Tool in 3DS RNG Tool, including various fixes, enhancements and new features.

Also provides a MT seed searcher for various things (specific PID/EC search, multi shiny hordes etc) as well as Time Finder for both MT and TinyMT initial seed manipulation.

### TinyMT differences from 3DS RNG Tool

* Index search by date (Citra only - mainly useful for ID, DexNav and Radar RNG)
* Index filtering
* Mapped wild encounter slots and held items
* DexNav RNG support (Egg moves are not predicted)
* Complete Normal Wild RNG support for every location. Indexes that would generate hordes instead, are not shown. The NPC influence is accounted for, as well
* Complete Horde RNG support for every location, including caves, 
either by using honey or by moving (stable delay unlike Honey/Sweet Scent - in ORAS only possible at Long grass).
The NPC influence is accounted for, as well
* Fishing RNG with predicted delay and rod usage from bag calculating the future character blinks (no timeline needed and every index is hittable)
* Honey Wild RNG support for places that don't generate hordes
* Allow Poke Radar usage from the bag instead of the Y menu (no timeline needed and every index is hittable)
* XY Victory Road swooping encounters (Sync is calculated differently)
* Minor performance improvements
* TinyMT Timeline calibration is not implemented. 
While it is required for XY ID RNG, nature sync for stationaries, and rock smash, other methods including: 
wild, hordes, dexnav, radar, fishing etc, can be done way faster using the bag method (see [RNG Guides](https://github.com/Bambo-Rambo/RNG-Guides)).
Index filtering can still be used for fishing and rock smash to avoid scrolling in 3DS RNG Tool.


### Step 1 - Calibration

If using the Date Searcher, you need to set the Citra RTC to 20xx-01-01 13:00:00 (Fixed Mode) and use CitraRNG to read the initial TinyMT state.
**The date must be 20xx-01-01 13:00:00 no matter what.** You can calibrate using a year of your choice but the month must be **JANUARY.** Not to be confused with the month selection in *Settings* which searches for results in the selected month.

The calibration screens can be seen in the following images. The first 2 are for ID RNG while the other 2 for every other method. 

**Do NOT advance to a later screen in any case otherwise the program won't be able to calibrate.**

![alt text](https://i.imgur.com/ErdQIpn.png) 
![alt text](https://i.imgur.com/QeYvYQV.png)
![alt text](https://i.imgur.com/oh7Fu7b.png) ![alt text](https://i.imgur.com/l8SLKbb.png)

### Step 2 - Settings

As explained above, if you are using the Date Searcher, the month selection is only for searching results in the desired month. 

If you are doing Normal Wild RNG, it's important to choose your location. 
The encounter ratio changes depending on your choice but you can edit it regardless. 

If you are doing Horde RNG by moving, the same things apply.

For radar put the number of your party and the chain length. If 0, the tool will search for the desired slot and sync. 
If > 0, it will search for shiny patches since the slot is the one you have been chaining for while sync is decided when you step into the patch. 
(It's not possible to generate shiny patches if current chain = 0). 
Check the Boost box only if the radar-exclusive music currently plays in the background. 

### Step 3 - Preferences

The "Ignore Filters" button will show all the results for the given state and method without messing with the already selected filters.

For ID RNG, pick the desired TID/SID combo and choose how many indexes you want the program to find before stopping the search. Full ID RNG guide [here](https://github.com/Bambo-Rambo/RNG-Guides/blob/main/Gen6TidSidRNG.md).

For Normal Wild RNG, choose the desired slot(s), if you want to sync the nature check the sync button to filter the results. If playing ORAS, choose the desired black/white flute level impact. Set to 0 if don't care. Full Wild/FS guide [here](https://github.com/Bambo-Rambo/RNG-Guides/blob/main/NormalWild-FS-RNG.md).

Fishing and Rock Smash work in a similar way, just fill in the filters.

Poke Radar RNG is split in 2 categories:
- Chain length -> 0 
- Chain length -> higher than 0

When chain = 0, you search and RNG for slot and sync. Activate the radar anytime and when inside the target index, step inside the patch.

When chain > 0, you search and RNG for guaranteed shiny patches. Remember that shininess is TinyMT dependant in that case. Simply activate the radar from the bag during the shiny (blue) index and a shiny patch will be generated! Keep in mind that not all shiny patches glow, so you need to check their exact locations in the tool. Double click inside an index to do that. 'C' means "Character" and is always in the middle of the array. 'S' means shiny and is the one you are gonna be stepping in while the rest are "Good" (G), "Bad" (B) and "Empty" (X) which break the chain and must be avoided. The slot will be the one you chained for, while sync is decided when you enter the patch so you need to RNG for it after the patch generation as well.

For DexNav read the [main guide](https://github.com/Bambo-Rambo/RNG-Guides/blob/main/DexNavRNG.md) as well as the [extra info](https://github.com/Bambo-Rambo/RNG-Guides/blob/main/ExtraInfo.md) including slots etc. They explain everything.

Finally, Swooping is pretty simple. The encounter slots are (1-8) for Fearow, (9-10) for Skarmory and (11-12) for Hydreigon. 
In 3DS RNG Tool, set the delay to +40. 
This is the recommended spot:

![](https://i.imgur.com/HLl4wmj.png)

If you are using the Date Searcher and you haven't calibrated already, the tool **will need some time** when you press the "Calibrate and Search" button and it will not calibrate again until you manually edit the Initial State.

### Credits
* wwwwwwzx and zep715 for reverse engineering gen 6 games. wwwwwwzx also for 3DS RNG Tool
* Real96, zaksabeast, Admiral-Fish and Parzival/StarfBerry for their researches on the MT seed generation
* shiny finder for mapping wild encounter slots
