# TinyFinder
This tool can be used either as a Date Searcher on Citra Emulator or as a Generator for a given Tiny state on both console/Emulator.

- Step 1 - Calibration

If you are using the Date Searcher, you need to set the Citra RTC to 20xx-01-01 13:00:00 and put the result you get from CitraRNG.
**The date must be 20xx-01-01 13:00:00 no matter what.** You can calibrate using a year of your choice but the month in Citra RTC must be **JANUARY.** Not to be confuses with the month selection in the second box which searches for results in the desired month of your choice.
You can see the calibration screens in the following images. The first 2 are for ID RNG while the other 2 for every other method. 

**Do NOT advance to a later screen in any case otherwise the program won't be able to calibrate.**

![alt text](https://i.imgur.com/ErdQIpn.png) 
![alt text](https://i.imgur.com/QeYvYQV.png)
![alt text](https://i.imgur.com/oh7Fu7b.png) ![alt text](https://i.imgur.com/l8SLKbb.png)

- Step 2 - Settings

Fill in the boxes, depending of the situation. As explained above, the month selection is only for searching results in the desired month. If you are doing Normal Wild RNG in XY, choose your locations as the results vary depending on it.


- Step 3 - Preferences

If you haven't calibrated already, the tool **will take some time** to do so once you hit the "Search" button and it will not calibrate again until you change the Tiny State.

For ID RNG in any version, pick the desired TID/SID combo and ignore the "Find at least" numbox for now.

For Normal Wild RNG, choose the desired slot(s), if you want to sync the nature check the sync button to filter the results and choose how many indexes you want the program to find before stopping the search. If you are doing XY wild RNG and have the cave button checked along with a location in the "Settings" Groupbox, the tool will give priority to the cave button. If playing ORAS, check the desired white flute level impact. Set to 0 if don't care.

Fishing, Rock Smash, Hordes and Friend Safari work in a similar way, just fill in the filters.

Poke Radar RNG is split in 2 categories:
- Chain length -> 0 
- Chain length -> higher than 0

For the first option, fill in the filters and the tool will search for indexes that also activate the "anxious" music (yellow ones in 3DS RNG Tool). 

To get the slot, sync and item probability, you need to **step** inside the patch during the index.

To trigger the anxious music, you need to **activate** the radar during the index. Stay in front of the patch and RNG for the desired slot then defeat the Pokemon. If you didn’t break your chain, the music will activate.

The second option, will search for guaranteed shiny patches. Remember that shininess depends on TinyMT when chain is higher than 0. Simply activate the radar during the index when the chain is 1 or higher and a shiny patch will be generated! Keep in mind that not all shiny patches glow, so you need to check 3DS RNG Tool to see which the shiny one is. The slot will be the one you chained for, while sync is decided when you enter the patch so you need to RNG for it as well afterwards.

# Notes:
For Normal Wild and Hordes, 3DS RNG Tool uses a specific pattern which does not apply the same for every place. Hordes are different when you RNG inside a cave for both versions, while Normal Wild in XY is different as well depending on the place. This tool accounts for all these so just choose the location and you will get the correct results. You can use [my fork version of 3DS RNG Tool](https://github.com/Bambo-Rambo/3DSRNGTool) that fixes Hordes in caves, but for wild just use this tool until I update 3DS RNG Tool again. Poke Radar also shows the same behavior but is more predictable and easy to deal with. It will be fixed in a later release of this tool.

Due to Blink(+1) and Blink(+2), it's somewhat hard to predict if an index is hitable consistently before checking it on 3DS RNG Tool. Just try some of them until you find one that can be hit for sure. Some indexes also last for very few main frames (usually 12-20) due to Blink(+1) so you need to avoid those as well. This does not apply to ID and Horde RNGs since every index is hitable.

# Credits
wwwwwwzx for 3DS RNG Tool
