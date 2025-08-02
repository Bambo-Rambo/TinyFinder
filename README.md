# TinyFinder

### Note: Your Emulator may generate a slightly different Initial seed each time you load a game, making fully consistent seed RNG abuse impossible. Find your most consistent seed and use that one for calibration.

Windows forms app with many exclusive features for assisting with RNG abuse (mainly TinyMT) in generation 6 Pokemon games.

Also provides a MT seed searcher for various things (specific PID/EC search, multi shiny hordes etc) as well as Time Finders for both MT and TinyMT initial seed manipulation.

### Features

* Index search by date (Emulator only - mainly useful for ID, DexNav and possibly Radar RNG)
* Index filtering
* Mapped wild encounter slots and held items
* DexNav RNG support with egg move prediction
* Complete Normal Wild RNG support for every location. The NPC influence is already accounted for
* Complete Horde RNG support
Hordes can be triggered either by using honey or by moving (stable delay unlike Honey/Sweet Scent - in ORAS only possible at Long grass)
* Fishing RNG with predicted delay and rod usage from bag calculating the upcoming character blinks
* Honey Wild RNG support for places that don't have hordes
* Poke Radar usage from the bag instead of the Y menu
* XY Victory Road swooping encounters

Note that TinyMT Timeline calibration is not implemented at all.
While it is required for XY ID RNG, nature sync for stationaries, and rock smash, other methods including: 
wild, hordes, dexnav, radar, fishing etc, can be done way faster using the bag method (see [RNG Guides](https://github.com/Bambo-Rambo/RNG-Guides)).

Rock Smash RNG is currently possible only with 3DS RNG Tool. 
Tiny Finder only shows the existing reults for a given seed, not how to hit them.
In the future you can expect full support though since it's possible to use it from the party.

### Step 1 - Calibration (Emulator only)

If using the Date Searcher, you need to set your Emulator's RTC to 20xx-01-01 13:00:00 (Fixed Mode) and use PokeReader to read the initial TinyMT seed.
**The date must be 20xx-01-01 13:00:00 no matter what.** You can calibrate using a year of your choice but the month must be **JANUARY.** Not to be confused with the month selection in *Settings* which searches for results in the selected month.

![](https://raw.githubusercontent.com/Bambo-Rambo/TinyFinder/refs/heads/main/Images/Tiny1.png)

### Step 2 - Settings

As explained above, if you are using the Date Searcher, the month selection is only for searching results within the desired month or later. 

If you are doing Normal Wild or moving Horde RNG, it's important to choose your location. 
The encounter ratio changes depending on the location and it's not recommended to mess with at all.

For Pokeradar, if your current chain length is 0, the tool will search for the desired slot and sync. 
If > 0, it will search for shiny patches since the slot is the one you have been chaining for while sync is decided when you step into the patch. 
(It's not possible to generate shiny patches if current chain = 0). 
Check the Boost box only if the radar-exclusive music currently plays in the background. 

It's essential that your party's Pokemon number is accurate otherwise the tool will give you wrong instructions.

### Step 3 - Preferences

The `Ignore Filters` button will show all results for a given seed/state without messing with the already selected filters.

For ID RNG, pick the desired TID/SID combo or you can uncheck either of the 2 you don't care about if you want more results to choose from (mainly a specific date). 
Full ID RNG guide [here](https://github.com/Bambo-Rambo/RNG-Guides/blob/main/Gen6TidSidRNG.md).

For Normal Wild RNG, choose the desired slot(s), if you want to sync the nature check the sync button to filter the results. 
If playing ORAS, choose the desired black/white flute level impact. Leave to 0 if don't care. Full Wild/FS guide [here](https://github.com/Bambo-Rambo/RNG-Guides/blob/main/NormalWild-FS-RNG.md).

Fishing and Rock Smash work in a similar way, just fill in the filters.

Poke Radar RNG is split in 2 categories:
- Chain length -> 0 
- Chain length -> higher than 0

When chain = 0, you search and RNG for slot and sync. Activate the radar anytime and when inside the target index, step inside the patch.

When chain > 0, you search and RNG for guaranteed shiny patches. Remember that shininess is TinyMT dependant in that case. 
Simply activate the radar from the bag during the shiny (blue) index and a shiny patch will be generated! 
Keep in mind that not all shiny patches glow, so you need to check their exact locations in the tool. 
Double click inside an index to do that. 'C' means "Character" and is always in the middle of the array. 
'S' means shiny and is the one you are gonna be stepping in while the rest are "Good" (G), "Bad" (B) and "Empty" (X) which break the chain and must be avoided. 
The slot will be the one you chained for, while sync is decided when you enter the patch so you need to RNG for it after the patch generation as well.

For DexNav you can read the [main guide](https://github.com/Bambo-Rambo/RNG-Guides/blob/main/DexNavRNG.md) as well as some [extra notes](https://github.com/Bambo-Rambo/RNG-Guides/blob/main/ExtraInfo.md). 
They explain everything.

Finally, Swooping is pretty simple. The encounter slots are (1-8) for Fearow, (9-10) for Skarmory and (11-12) for Hydreigon. 
In 3DS RNG Tool, set the delay to +40. 
This is the recommended spot:

![](https://raw.githubusercontent.com/Bambo-Rambo/TinyFinder/refs/heads/main/Images/Tiny2.png)

### Credits
* wwwwwwzx and zep715 for reverse engineering gen 6 games. wwwwwwzx also for 3DS RNG Tool
* Real96, zaksabeast, Admiral-Fish and Parzival/StarfBerry for their researches on the MT seed generation
* kwsch for pk3DS allowing me to dump tons of stuff including egg move slots, encounter tables, level up moves etc
