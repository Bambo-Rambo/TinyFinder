# TinyFinder

This program is based on the Tiny Timeline Tool in 3DS RNG Tool. 
It's main purpose, is to get rid of the timeline needed for most cases in gen 6 RNG, making things easier.

### Features not included in 3DS RNG Tool

* Index search by date (Citra only - mainly useful for ID, DexNav and Radar RNG)
* Index filtering depending on the user's preferences
* DexNav RNG support (Egg moves are not predicted)
* Normal Wild RNG support for every location. Indexes that generate hordes instead, are not shown. The NPC influence is accounted for, as well.
* Support for Horde RNG in caves (Honey). Also, for triggering hordes by moving (stable delay unlike Honey/Sweet Scent - in ORAS only possible at Long grass). Location matters and the NPC influence is accounted for, as well.
* Wild RNG using honey for places that allow it (those that don't generate hordes).
* Option to use the Poke Radar from the bag instead of the Y menu (makes every index reachable).
* Support for Swopping encounters in XY Victory Road (since Sync is calculated differently).


### Step 1 - Calibration

If you are using the Date Searcher, you need to set the Citra RTC to 20xx-01-01 13:00:00 (Fixed Mode) and put the result you get from CitraRNG.
**The date must be 20xx-01-01 13:00:00 no matter what.** You can calibrate using a year of your choice but the month must be **JANUARY.** Not to be confused with the month selection in the second box which searches for results in the desired month of your choice.
You can see the calibration screens in the following images. The first 2 are for ID RNG while the other 2 for every other method. 

**Do NOT advance to a later screen in any case otherwise the program won't be able to calibrate.**

![alt text](https://i.imgur.com/ErdQIpn.png) 
![alt text](https://i.imgur.com/QeYvYQV.png)
![alt text](https://i.imgur.com/oh7Fu7b.png) ![alt text](https://i.imgur.com/l8SLKbb.png)

### Step 2 - Settings

As explained above, if you are using the Date Searcher, the month selection is only for searching results in the desired month. 

If you are doing Normal Wild RNG, choose the location since the results vary depending on it. 
The encounter ratio changes depending on your choice but you can edit it regardless. 

If you are doing Horde RNG and the "Trigger by turn" button is checked, the same things apply.

For radar put the number of your party and the chain length. If 0, the tool will search for the desired slot and sync. 
If > 0, it will search for shiny patches since the slot is the one you have been chaining for while sync is decided when you step into the patch. 
(It's not possible to generate shiny patches if current chain = 0). 
Check the Boost box only if the radar-exclusive music currently plays in the background. 
If you are using the Radar device from the bag (recommended), check the "corresponding" box.

### Step 3 - Preferences

The "Ignore Filters" button will show all the results for the given state and method without messing with the already selected filters.

For ID RNG, pick the desired TID/SID combo and choose how many indexes you want the program to find before stopping the search. It's suggested to make it search for only 1 because the list doesn't get updated until it finds them all. Full ID RNG guide [here](https://github.com/Bambo-Rambo/RNG-Guides/blob/main/Gen6TidSidRNG.md).

For Normal Wild RNG, choose the desired slot(s), if you want to sync the nature check the sync button to filter the results. If playing ORAS, choose the desired black/white flute level impact. Set to 0 if don't care. Full Wild/FS guide [here](https://github.com/Bambo-Rambo/RNG-Guides/blob/main/NormalWild-FS-RNG.md).

Fishing and Rock Smash work in a similar way, just fill in the filters.

Poke Radar RNG is split in 2 categories:
- Chain length -> 0 
- Chain length -> higher than 0

When chain == 0, you search and RNG for slot and sync. Activate the radar anytime and when inside the target index, step inside the patch.

When chain > 0, you search and RNG for guaranteed shiny patches. Remember that shininess is TinyMT dependant in that case. Simply activate the radar during the shiny (blue) index and a shiny patch will be generated! Keep in mind that not all shiny patches glow, so you need to check their exact locations in the tool. Double click inside an index to do that. 'C' means "Character" and is always in the middle of the array. 'S' means shiny and is the one you are gonna be stepping in while the rest are "Good" (G), "Bad" (B) and "Empty" (X) which break the chain and must be avoided. The slot will be the one you chained for, while sync is decided when you enter the patch so you need to RNG for it after the patch generation as well.

For DexNav read the [main guide](https://github.com/Bambo-Rambo/RNG-Guides/blob/main/DexNavRNG.md) as well as the [extra info](https://github.com/Bambo-Rambo/RNG-Guides/blob/main/ExtraInfo.md) including slots etc. They explain everything.

Finally, Swooping is pretty simple. The encounter slots are (1-8) for Fearow, (9-10) for Skarmory and (11-12) for Hydreigon. In 3DS RNG Tool, set the delay to +40.

If you haven't calibrated already, the tool **will take some time** to do so when you hit the "Search" button and it will not calibrate again until you change the Initial State.

### Credits
wwwwwwzx and zep715 for reverse engineering gen 6 games. wwwwwwzx also for 3DS RNG Tool
