### [Latest Commit](https://drive.google.com/uc?export=download&confirm=_P8B&id=1YM70LKOh8XLdlOEcnvayKMpZju-kup1-)

# TinyFinder

- Search for the desired index by date (Searcher - Citra only)
- Find the desired index for a given state (Generator - 3ds/Citra)
- Normal Wild and Horde RNG have been fixed. All locations are supported (including caves) and you don't have to worry about the NPC influence either
[Suggested Spots for X/Y](https://imgur.com/a/pGk0bhM). For caves, route 6 and route 9, spot doesn't matter. OR/AS work fine as well.

# Step 1 - Calibration

If you are using the Date Searcher, you need to set the Citra RTC to 20xx-01-01 13:00:00 and put the result you get from CitraRNG.
**The date must be 20xx-01-01 13:00:00 no matter what.** You can calibrate using a year of your choice but the month must be **JANUARY.** Not to be confused with the month selection in the second box which searches for results in the desired month of your choice.
You can see the calibration screens in the following images. The first 2 are for ID RNG while the other 2 for every other method. 

**Do NOT advance to a later screen in any case otherwise the program won't be able to calibrate.**

![alt text](https://i.imgur.com/ErdQIpn.png) 
![alt text](https://i.imgur.com/QeYvYQV.png)
![alt text](https://i.imgur.com/oh7Fu7b.png) ![alt text](https://i.imgur.com/l8SLKbb.png)

# Step 2 - Settings

Fill in the boxes, depending of the situation. As explained above, the month selection is only for searching results in the desired month. If you are doing Normal Wild RNG in XY, choose the location since the results vary depending on it or check the cave box if you are doing it in a cave. The encounter ratio changes depending on your choice but you can edit it regardless. For radar put the number of your party and the chain length. If 0, the tool will search for the desired slot and sync. If > 0, it will search for shiny patches since the slot is the one you have been chaining for while sync is decided when you step into the patch. (It's not possible to generate shiny patches if current chain == 0). Check the Boost box only if the radar-exclusive music currently plays in the background.


# Step 3 - Preferences

If you haven't calibrated already, the tool **will take some time** to do so when you hit the "Search" button and it will not calibrate again until you change the Initial State.

For ID RNG, pick the desired TID/SID combo and choose how many indexes you want the program to find before stopping the search. It's suggested to make it search for only 1 because the list doesn't get updated until it has found them all.

For Normal Wild RNG, choose the desired slot(s), if you want to sync the nature check the sync button to filter the results. If playing ORAS, choose the desired white flute level impact. Set to 0 if don't care.

Fishing, Rock Smash, Hordes and Friend Safari work in a similar way, just fill in the filters.

As said above, Poke Radar RNG is split in 2 categories:
- Chain length -> 0 
- Chain length -> higher than 0

When chain == 0, you search and RNG for slot and sync. Activate the radar anytime and when inside the target index, step inside the patch.

When chain > 0, you search and RNG for guaranteed shiny patches. Remember that shininess is TinyMT dependant in that case. Simply activate the radar during the shiny (blue) index and a shiny patch will be generated! Keep in mind that not all shiny patches glow, so you need to check their exact locations in the tool. Double click inside an index to do that. 'C' means "Character" and is always in the middle of the array. 'S' means shiny and is the one you are gonna be stepping in while the rest are "Good" (G), "Bad" (B) and "Empty" (X) which break the chain and must be avoided. The slot will be the one you chained for, while sync is decided when you enter the patch so you need to RNG for it afterwards as well.

# Credits
wwwwwwzx for 3DS RNG Tool
