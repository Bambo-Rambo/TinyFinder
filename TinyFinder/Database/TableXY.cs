using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TinyFinder
{
    internal class TableXY : LocationsXY
    {
        public static List<Location> EncounterTable(bool X)
        {
            List<Location> locations = WildLocations();

            foreach (Location loc in locations)
            {
                switch (loc.Map)
                {

					case 45:		// Ambrette Town
						loc.SurfTable = new ushort[]		{ 72, 320, 72, 72, 320 };
						loc.SurfLevel = new int[]			{ 25, 25, 26, 27, 27 };
						loc.OldTable = new ushort[]			{ 370, 370, 370 };
						loc.OldLevel = new int[]			{ 15, 15, 15 };
						if (X)
						{
							loc.GoodTable = new ushort[]	{ 692, 116, 692 };
						}
						else
						{
							loc.GoodTable = new ushort[]	{ 690, 116, 690 };
						}
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						if (X)
						{
							loc.SuperTable = new ushort[]	{ 369, 693, 117 };
						}
						else
						{
							loc.SuperTable = new ushort[]	{ 369, 691, 117 };
						}
						loc.SuperLevel = new int[]			{ 35, 35, 35 };
						loc.SmashTable = new ushort[]		{ 557, 688, 557, 688, 557 };
						if (X)
						{
							loc.SmashLevel = new int[]		{ 18, 18, 19, 20, 20 };
						}
						else
						{
							loc.SmashLevel = new int[]		{ 13, 13, 14, 15, 15 };
						}
						break;

					case 357:		// Azure Bay
						loc.GrassTable = new ushort[]		{ 79, 79, 79, 441, 441, 441, 79, 686, 102, 686, 441, 441 };
						loc.WildLevel = new int[]			{ 25, 26, 27, 25, 26, 27, 27, 26, 26, 27, 27, 27 };
						loc.HordeTable1 = new ushort[]		{ 278, 278, 278, 278, 278 };
						loc.HordeTable2 = new ushort[]		{ 79, 79, 79, 79, 79 };
						loc.HordeTable3 = new ushort[]		{ 102, 102, 102, 102, 102 };
						loc.HordeLevel = new int[]			{ 13, 13, 14 };
						loc.SurfTable = new ushort[]		{ 72, 72, 458, 72, 131 };
						loc.SurfLevel = new int[]			{ 25, 26, 27, 27, 27 };
						loc.OldTable = new ushort[]			{ 370, 370, 370 };
						loc.OldLevel = new int[]			{ 15, 15, 15 };
						loc.GoodTable = new ushort[]		{ 223, 170, 223 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 594, 224, 171 };
						loc.SuperLevel = new int[]			{ 35, 35, 35 };
						loc.SmashTable = new ushort[]		{ 557, 688, 557, 688, 557 };
						loc.SmashLevel = new int[]			{ 23, 23, 24, 25, 25 };
						break;

					case 334:		// Connecting Cave
						loc.CaveTable = new ushort[]		{ 293, 293, 293, 307, 307, 307, 41, 41, 41, 610, 610, 610 };
						loc.WildLevel = new int[]			{ 13, 14, 15, 13, 14, 15, 13, 14, 15, 13, 14, 15 };
						loc.HordeTable1 = new ushort[]		{ 293, 293, 293, 293, 293 };
						loc.HordeTable2 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeTable3 = new ushort[]		{ 610, 610, 610, 610, 610 };
						loc.HordeLevel = new int[]			{ 7, 8, 8 };
						break;

					case 38:		// Couriway Town
						loc.SurfTable = new ushort[]		{ 271, 419, 271, 419, 271 };
						loc.SurfLevel = new int[]			{ 44, 44, 45, 46, 46 };
						loc.OldTable = new ushort[]			{ 60, 60, 60 };
						loc.OldLevel = new int[]			{ 25, 25, 25 };
						if (X)
						{
							loc.GoodTable = new ushort[]	{ 725, 61, 725 };
						}
						else
						{
							loc.GoodTable = new ushort[]	{ 550, 61, 550 };
						}
						loc.GoodLevel = new int[]			{ 35, 35, 35 };
						if (X)
						{
							loc.SuperTable = new ushort[]	{ 61, 550, 61 };
						}
						else
						{
							loc.SuperTable = new ushort[]	{ 61, 725, 61 };
						}
						loc.SuperLevel = new int[]			{ 45, 45, 45 };
						break;

					case 157:		// Cyllage City
						loc.SurfTable = new ushort[]		{ 72, 320, 72, 72, 320 };
						loc.SurfLevel = new int[]			{ 25, 25, 26, 27, 27 };
						loc.OldTable = new ushort[]			{ 370, 370, 370 };
						loc.OldLevel = new int[]			{ 15, 15, 15 };
						if (X)
						{
							loc.GoodTable = new ushort[]	{ 692, 116, 692 };
						}
						else
						{
							loc.GoodTable = new ushort[]	{ 690, 116, 690 };
						}
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						if (X)
						{
							loc.SuperTable = new ushort[]	{ 369, 693, 117 };
						}
						else
						{
							loc.SuperTable = new ushort[]	{ 369, 691, 117 };
						}
						loc.SuperLevel = new int[]			{ 35, 35, 35 };
						if (X)
						{
							loc.SmashTable = new ushort[]	{ 557, 95, 557, 95, 95 };
						}
						else
						{
							loc.SmashTable = new ushort[]	{ 557, 688, 557, 688, 557 };
						}
						if (X)
						{
							loc.SmashLevel = new int[]		{ 15, 15, 17, 16, 17 };
						}
						else
						{
							loc.SmashLevel = new int[]		{ 13, 13, 14, 15, 15 };
						}
						break;

					case 314:		// Frost Cavern - Default
						loc.CaveTable = new ushort[]		{ 221, 221, 712, 712, 614, 614, 124, 124, 93, 93, 615, 93 };
						loc.WildLevel = new int[]			{ 38, 39, 39, 40, 39, 40, 39, 40, 38, 39, 40, 40 };
						loc.HordeTable1 = new ushort[]		{ 582, 582, 582, 582, 582 };
						loc.HordeTable2 = new ushort[]		{ 613, 613, 613, 613, 613 };
						loc.HordeTable3 = new ushort[]		{ 238, 238, 238, 238, 238 };
						loc.HordeLevel = new int[]			{ 20, 20, 21 };
						break;

					case 315:		// Frost Cavern - Main 2F
						if (X)
						{
							loc.CaveTable = new ushort[]	{ 221, 221, 712, 712, 614, 614, 124, 124, 93, 93, 615, 93 };
						}
						else
						{
							loc.CaveTable = new ushort[]	{ 221, 221, 712, 712, 614, 614, 124, 124, 93, 93, 93, 93 };
						}
						loc.WildLevel = new int[]			{ 38, 39, 39, 40, 39, 40, 39, 40, 38, 39, 40, 40 };
						loc.HordeTable1 = new ushort[]		{ 582, 582, 582, 582, 582 };
						loc.HordeTable2 = new ushort[]		{ 613, 613, 613, 613, 613 };
						loc.HordeTable3 = new ushort[]		{ 238, 238, 238, 238, 238 };
						loc.HordeLevel = new int[]			{ 20, 20, 21 };
						loc.SurfTable = new ushort[]		{ 61, 419, 61, 419, 61 };
						loc.SurfLevel = new int[]			{ 38, 38, 39, 40, 40 };
						loc.OldTable = new ushort[]			{ 60, 60, 60 };
						loc.OldLevel = new int[]			{ 20, 20, 20 };
						if (X)
						{
							loc.GoodTable = new ushort[]	{ 725, 61, 725 };
						}
						else
						{
							loc.GoodTable = new ushort[]	{ 550, 61, 550 };
						}
						loc.GoodLevel = new int[]			{ 30, 30, 30 };
						if (X)
						{
							loc.SuperTable = new ushort[]	{ 61, 550, 61 };
						}
						else
						{
							loc.SuperTable = new ushort[]	{ 61, 725, 61 };
						}
						loc.SuperLevel = new int[]			{ 40, 40, 40 };
						break;

					case 303:		// Glittering Cave
						loc.CaveTable = new ushort[]		{ 66, 66, 66, 111, 95, 104, 104, 338, 337, 115, 303, 303 };
						loc.WildLevel = new int[]			{ 15, 16, 17, 17, 17, 15, 16, 17, 17, 17, 15, 16 };
                        loc.SmashTable = new ushort[]		{ 557, 95, 557, 95, 95 };
                        loc.SmashLevel = new int[]			{ 15, 15, 17, 16, 17 };
                        break;

					case 200:		// Laverre City
						loc.OldTable = new ushort[]			{ 60, 60, 60 };
						loc.OldLevel = new int[]			{ 15, 15, 15 };
						if (X)
						{
							loc.GoodTable = new ushort[]	{ 725, 61, 725 };
						}
						else
						{
							loc.GoodTable = new ushort[]	{ 550, 61, 550 };
						}
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						if (X)
						{
							loc.SuperTable = new ushort[]	{ 61, 550, 61 };
						}
						else
						{
							loc.SuperTable = new ushort[]	{ 61, 725, 61 };
						}
						loc.SuperLevel = new int[]			{ 35, 35, 35 };
						break;

					case 349:		// Lost Hotel
						loc.CaveTable = new ushort[]		{ 82, 82, 624, 624, 607, 607, 101, 101, 707, 707, 707, 707 };
						loc.WildLevel = new int[]			{ 37, 38, 36, 37, 37, 38, 37, 38, 36, 37, 38, 38 };
						break;

					case 302:		// Parfum Palace
						loc.OldTable = new ushort[]			{ 129, 129, 129 };
						loc.OldLevel = new int[]			{ 15, 15, 15 };
						loc.GoodTable = new ushort[]		{ 118, 341, 118 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 130, 119, 342 };
						loc.SuperLevel = new int[]			{ 35, 35, 35 };
						break;

					case 318:		// Pokémon Village
						loc.YellowTable = new ushort[]		{ 575, 575, 575, 132, 132, 39, 164, 591, 591, 571, 571, 571 };
						loc.YellowLevel = new int[]			{ 48, 49, 50, 48, 49, 50, 50, 49, 50, 48, 49, 50 };
						loc.PurpleTable = new ushort[]		{ 164, 164, 164, 39, 39, 132, 575, 591, 591, 571, 571, 571 };
						loc.PurpleLevel = new int[]			{ 48, 49, 50, 48, 49, 50, 50, 49, 50, 48, 49, 50 };
						loc.HordeTable1 = new ushort[]		{ 590, 590, 590, 590, 590 };
						loc.HordeTable2 = new ushort[]		{ 60, 60, 60, 60, 60 };
						loc.HordeTable3 = new ushort[]		{ 271, 271, 271, 271, 271 };
						loc.HordeLevel = new int[]			{ 25, 25, 25 };
						loc.SurfTable = new ushort[]		{ 271, 61, 271, 61, 271 };
						loc.SurfLevel = new int[]			{ 48, 48, 49, 50, 50 };
						loc.OldTable = new ushort[]			{ 60, 60, 60 };
						loc.OldLevel = new int[]			{ 30, 30, 30 };
						if (X)
						{
							loc.GoodTable = new ushort[]	{ 725, 61, 725 };
						}
						else
						{
							loc.GoodTable = new ushort[]	{ 550, 61, 550 };
						}
						loc.GoodLevel = new int[]			{ 40, 40, 40 };
						if (X)
						{
							loc.SuperTable = new ushort[]	{ 61, 550, 61 };
						}
						else
						{
							loc.SuperTable = new ushort[]	{ 61, 725, 61 };
						}
						loc.SuperLevel = new int[]			{ 50, 50, 50 };
						break;

					case 305:		// Reflection Cave
						loc.CaveTable = new ushort[]		{ 122, 122, 577, 577, 524, 524, 703, 433, 202, 433, 302, 302 };
						loc.WildLevel = new int[]			{ 22, 23, 22, 23, 21, 22, 23, 21, 22, 22, 22, 23 };
						loc.HordeTable1 = new ushort[]		{ 439, 439, 439, 439, 439 };
						loc.HordeTable2 = new ushort[]		{ 524, 524, 524, 524, 524 };
						loc.HordeTable3 = new ushort[]		{ 524, 524, 524, 703, 524 };
						loc.HordeLevel = new int[]			{ 11, 11, 11 };
						break;

					case 268:		// Route 10
						if (X)
						{
							loc.GrassTable = new ushort[]	{ 622, 622, 622, 561, 561, 701, 701, 209, 228, 133, 587, 587 };
						}
						else
						{
							loc.GrassTable = new ushort[]	{ 622, 622, 622, 561, 561, 701, 701, 209, 309, 133, 587, 587 };
						}
						loc.WildLevel = new int[]			{ 19, 20, 21, 19, 20, 19, 20, 21, 21, 21, 19, 20 };
						if (X)
						{
							loc.YellowTable = new ushort[]	{ 209, 209, 209, 228, 228, 133, 133, 622, 561, 701, 587, 587 };
						}
						else
						{
							loc.YellowTable = new ushort[]	{ 209, 209, 209, 309, 309, 133, 133, 622, 561, 701, 587, 587 };
						}
						loc.YellowLevel = new int[]			{ 19, 20, 21, 19, 20, 19, 20, 21, 21, 21, 19, 20 };
						loc.HordeTable1 = new ushort[]		{ 299, 299, 299, 299, 299 };
						loc.HordeTable2 = new ushort[]		{ 193, 193, 193, 193, 193 };
						if (X)
						{
							loc.HordeTable3 = new ushort[]	{ 228, 228, 228, 228, 228 };
						}
						else
						{
							loc.HordeTable3 = new ushort[]	{ 309, 309, 309, 309, 309 };
						}
						loc.HordeLevel = new int[]			{ 10, 10, 11 };
						break;

					case 269:		// Route 11
						if (X)
						{
							loc.GrassTable = new ushort[]	{ 297, 297, 539, 539, 397, 397, 434, 433, 33, 30, 702, 702 };
						}
						else
						{
							loc.GrassTable = new ushort[]	{ 297, 297, 538, 538, 397, 397, 434, 433, 33, 30, 702, 702 };
						}
						loc.WildLevel = new int[]			{ 22, 23, 22, 23, 22, 23, 21, 21, 21, 21, 21, 22 };
						loc.HordeTable1 = new ushort[]		{ 32, 29, 32, 32, 32 };
						loc.HordeTable2 = new ushort[]		{ 434, 434, 434, 434, 434 };
						loc.HordeTable3 = new ushort[]		{ 396, 396, 396, 396, 396 };
						loc.HordeLevel = new int[]			{ 11, 11, 12 };
						break;

					case 270:		// Route 12
						if (X)
						{
							loc.GrassTable = new ushort[]	{ 79, 79, 79, 441, 441, 441, 241, 128, 102, 127, 417, 417 };
						}
						else
						{
							loc.GrassTable = new ushort[]	{ 79, 79, 79, 441, 441, 441, 241, 128, 102, 214, 417, 417 };
						}
						loc.WildLevel = new int[]			{ 23, 24, 25, 23, 24, 25, 25, 25, 24, 25, 23, 24 };
						if (X)
						{
							loc.YellowTable = new ushort[]	{ 128, 128, 128, 241, 241, 241, 441, 79, 102, 127, 417, 417 };
						}
						else
						{
							loc.YellowTable = new ushort[]	{ 128, 128, 128, 241, 241, 241, 441, 79, 102, 214, 417, 417 };
						}
						loc.YellowLevel = new int[]			{ 25, 26, 27, 25, 26, 27, 27, 27, 26, 27, 25, 26 };
						loc.HordeTable1 = new ushort[]		{ 278, 278, 278, 278, 278 };
						loc.HordeTable2 = new ushort[]		{ 179, 179, 179, 179, 179 };
						if (X)
						{
							loc.HordeTable3 = new ushort[]	{ 128, 241, 128, 128, 128 };
						}
						else
						{
							loc.HordeTable3 = new ushort[]	{ 128, 128, 128, 241, 128 };
						}
						loc.HordeLevel = new int[]			{ 13, 13, 14 };
						loc.SurfTable = new ushort[]		{ 72, 72, 458, 72, 131 };
						loc.SurfLevel = new int[]			{ 25, 26, 27, 27, 27 };
						/*loc.OldTable = new ushort[]			{ 370, 370, 370 };
						loc.OldLevel = new int[]			{ 15, 15, 15 };
						loc.GoodTable = new ushort[]		{ 223, 366, 223 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						if (X)
						{
							loc.SuperTable = new ushort[]	{ 222, 224, 367 };
						}
						else
						{
							loc.SuperTable = new ushort[]	{ 222, 224, 368 };
						}
						loc.SuperLevel = new int[]			{ 35, 35, 35 };
						// 1 NPC but on different spot than wild, let's avoid confusion since species are available elsewhere
						loc.SmashTable = new ushort[]		{ 557, 688, 557, 688, 557 };
						loc.SmashLevel = new int[]		{ 23, 23, 24, 25, 25 };*/
						break;

					case 272:		// Route 13
					   //loc.SwampTable = new ushort[]		{ 51, 51, 51, 51, 328, 328, 328, 328, 443, 443, 443, 443 };
					   //loc.SwampLevel = new int[]			{ 26, 27, 27, 28, 26, 27, 27, 28, 26, 27, 27, 28 };
						loc.SmashTable = new ushort[]		{ 75, 218, 75, 218, 75 };
						loc.SmashLevel = new int[]			{ 26, 26, 27, 28, 28 };
						break;

					case 273:		// Route 14
						loc.GrassTable = new ushort[]		{ 451, 451, 70, 70, 195, 704, 588, 616, 455, 93, 455, 455 };
						loc.WildLevel = new int[]			{ 30, 31, 31, 32, 30, 30, 30, 30, 30, 31, 31, 32 };
						loc.SwampTable = new ushort[]		{ 195, 195, 195, 704, 704, 618, 618, 588, 616, 93, 455, 455 };
						loc.SwampLevel = new int[]			{ 30, 31, 32, 31, 32, 31, 32, 30, 30, 31, 31, 32 };
						loc.HordeTable1 = new ushort[]		{ 69, 69, 69, 69, 69 };
						loc.HordeTable2 = new ushort[]		{ 451, 451, 451, 451, 451 };
						loc.HordeTable3 = new ushort[]		{ 23, 23, 23, 23, 23 };
						loc.HordeLevel = new int[]			{ 16, 16, 17 };
						loc.SurfTable = new ushort[]		{ 195, 618, 704, 618, 618 };
						loc.SurfLevel = new int[]			{ 30, 30, 31, 31, 32 };
						loc.OldTable = new ushort[]			{ 60, 60, 60 };
						loc.OldLevel = new int[]			{ 15, 15, 15 };
						loc.GoodTable = new ushort[]		{ 339, 61, 339 };
						loc.GoodLevel = new int[]			{ 25, 35, 35 };
						loc.SuperTable = new ushort[]		{ 61, 340, 61 };
						loc.SuperLevel = new int[]			{ 35, 35, 35 };
						break;

					case 275:		// Route 15
						if (X)
						{
							loc.GrassTable = new ushort[]	{ 262, 262, 262, 451, 451, 624, 505, 590, 590, 707, 707, 707 };
						}
						else
						{
							loc.GrassTable = new ushort[]	{ 510, 510, 510, 451, 451, 624, 505, 590, 590, 707, 707, 707 };
						}
						loc.WildLevel = new int[]			{ 34, 35, 36, 34, 35, 36, 36, 34, 35, 34, 35, 36 };
						if (X)
						{
							loc.RedTable = new ushort[]		{ 505, 505, 505, 624, 624, 451, 262, 590, 590, 707, 707, 707 };
						}
						else
						{
							loc.RedTable = new ushort[]		{ 505, 505, 505, 624, 624, 451, 510, 590, 590, 707, 707, 707 };
						}
						loc.RedLevel = new int[]			{ 34, 35, 36, 34, 35, 36, 36, 34, 35, 34, 35, 36 };
						loc.HordeTable1 = new ushort[]		{ 198, 198, 198, 198, 198 };
						loc.HordeTable2 = new ushort[]		{ 590, 590, 590, 590, 590 };
						loc.HordeTable3 = new ushort[]		{ 707, 707, 707, 707, 707 };
						loc.HordeLevel = new int[]			{ 18, 18, 19 };
						loc.SurfTable = new ushort[]		{ 271, 419, 271, 419, 271 };
						loc.SurfLevel = new int[]			{ 34, 34, 35, 36, 36 };
						loc.OldTable = new ushort[]			{ 60, 60, 60 };
						loc.OldLevel = new int[]			{ 15, 15, 15 };
						if (X)
						{
							loc.GoodTable = new ushort[]	{ 725, 61, 725 };
						}
						else
						{
							loc.GoodTable = new ushort[]	{ 550, 61, 550 };
						}
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						if (X)
						{
							loc.SuperTable = new ushort[]	{ 61, 550, 61 };
						}
						else
						{
							loc.SuperTable = new ushort[]	{ 61, 725, 61 };
						}
						loc.SuperLevel = new int[]			{ 35, 35, 35 };
						break;

					case 276:		// Route 16
						loc.LongTable = new ushort[]		{ 710, 710, 710, 734, 734, 735, 708, 590, 590, 707, 707, 736 };
						loc.WildLevel = new int[]			{ 34, 34, 35, 35, 36, 36, 35, 34, 36, 34, 35, 36 };
						loc.YellowTable = new ushort[]		{ 70, 70, 451, 451, 419, 419, 708, 590, 590, 707, 707, 707 };
						loc.YellowLevel = new int[]			{ 35, 36, 34, 35, 35, 36, 35, 34, 36, 34, 35, 36 };
						loc.HordeTable1 = new ushort[]		{ 198, 198, 198, 198, 198 };
						loc.HordeTable2 = new ushort[]		{ 590, 590, 590, 590, 590 };
						loc.HordeTable3 = new ushort[]		{ 707, 707, 707, 707, 707 };
						loc.HordeLevel = new int[]			{ 18, 18, 19 };
						loc.SurfTable = new ushort[]		{ 271, 419, 271, 419, 271 };
						loc.SurfLevel = new int[]			{ 34, 34, 35, 36, 36 };
						loc.OldTable = new ushort[]			{ 60, 60, 60 };
						loc.OldLevel = new int[]			{ 15, 15, 15 };
						if (X)
						{
							loc.GoodTable = new ushort[]	{ 725, 61, 725 };
						}
						else
						{
							loc.GoodTable = new ushort[]	{ 550, 61, 550 };
						}
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						if (X)
						{
							loc.SuperTable = new ushort[]	{ 61, 550, 61 };
						}
						else
						{
							loc.SuperTable = new ushort[]	{ 61, 725, 61 };
						}
						loc.SuperLevel = new int[]			{ 35, 35, 35 };
						break;

					case 278:		// Route 17
						loc.RideTable = new ushort[]		{ 459, 459, 459, 215, 225, 225, 225, 225, 215, 215, 215, 460 };
						loc.WildLevel = new int[]			{ 38, 39, 39, 39, 38, 39, 39, 40, 38, 40, 40, 40 };
						break;

					case 279:		// Route 18
						if (X)
						{
							loc.GrassTable = new ushort[]	{ 533, 533, 533, 324, 324, 28, 305, 632, 75, 75, 631, 631 };
						}
						else
						{
							loc.GrassTable = new ushort[]	{ 533, 533, 533, 324, 324, 28, 247, 632, 75, 75, 631, 631 };
						}
						loc.WildLevel = new int[]			{ 44, 45, 46, 44, 45, 46, 46, 44, 45, 46, 45, 46 };
						if (X)
						{
							loc.RedTable = new ushort[]		{ 305, 305, 305, 28, 28, 324, 533, 632, 75, 75, 631, 631 };
						}
						else
						{
							loc.RedTable = new ushort[]		{ 247, 247, 247, 28, 28, 324, 533, 632, 75, 75, 631, 631 };
						}
						loc.RedLevel = new int[]			{ 44, 45, 46, 44, 45, 46, 46, 44, 45, 46, 45, 46 };
						loc.HordeTable1 = new ushort[]		{ 74, 74, 74, 74, 74 };
						loc.HordeTable2 = new ushort[]		{ 632, 632, 632, 632, 632 };
						loc.HordeTable3 = new ushort[]		{ 632, 632, 632, 631, 632 };
						if (X)
						{
							loc.HordeLevel = new int[]		{ 23, 23, 23 };
						}
						else
						{
							loc.HordeLevel = new int[]		{ 23, 23, 24 };
						}
                        // 1 NPC but on different spot than wild, let's avoid confusion since species are available elsewhere
                        //loc.SmashTable = new ushort[]		{ 75, 75, 75, 213, 213 };
                        //loc.SmashLevel = new int[]		{ 44, 45, 46, 44, 46 };
                        break;

					case 281:		// Route 19
						loc.YellowTable = new ushort[]		{ 195, 195, 195, 705, 705, 70, 452, 588, 616, 93, 455, 455 };
						loc.YellowLevel = new int[]			{ 46, 47, 48, 46, 47, 48, 48, 47, 47, 47, 46, 48 };
						loc.PurpleTable = new ushort[]		{ 452, 452, 452, 70, 70, 705, 195, 588, 616, 93, 455, 455 };
						loc.PurpleLevel = new int[]			{ 46, 47, 48, 46, 47, 48, 48, 47, 47, 47, 46, 48 };
						loc.SwampTable = new ushort[]		{ 195, 195, 195, 705, 705, 618, 618, 588, 616, 93, 455, 455 };
						loc.SwampLevel = new int[]			{ 46, 47, 48, 47, 48, 47, 48, 47, 47, 47, 46, 48 };
						loc.HordeTable1 = new ushort[]		{ 70, 70, 70, 70, 70 };
						loc.HordeTable2 = new ushort[]		{ 207, 207, 207, 207, 207 };
						loc.HordeTable3 = new ushort[]		{ 24, 24, 24, 24, 24 };
						loc.HordeLevel = new int[]			{ 24, 24, 25 };
						loc.SurfTable = new ushort[]		{ 195, 618, 705, 618, 705 };
						loc.SurfLevel = new int[]			{ 46, 46, 47, 48, 48 };
						loc.OldTable = new ushort[]			{ 60, 60, 60 };
						loc.OldLevel = new int[]			{ 25, 25, 25 };
						loc.GoodTable = new ushort[]		{ 339, 61, 339 };
						loc.GoodLevel = new int[]			{ 35, 35, 35 };
						loc.SuperTable = new ushort[]		{ 61, 340, 186 };
						loc.SuperLevel = new int[]			{ 45, 45, 50 };
						break;

					case 259:		// Route 2
						if (X)
						{
							loc.GrassTable = new ushort[]	{ 659, 659, 263, 661, 661, 16, 664, 664, 13, 263, 16, 13 };
						}
						else
						{
							loc.GrassTable = new ushort[]	{ 659, 659, 263, 661, 661, 16, 664, 664, 10, 263, 16, 10 };
						}
						loc.WildLevel = new int[]			{ 2, 3, 3, 2, 3, 3, 2, 3, 3, 4, 4, 4 };
						break;

					case 282:		// Route 20
						loc.GrassTable = new ushort[]		{ 164, 164, 164, 39, 39, 709, 575, 591, 591, 591, 571, 571 };
						loc.WildLevel = new int[]			{ 48, 49, 50, 48, 49, 50, 50, 48, 49, 50, 48, 50 };
						loc.RedTable = new ushort[]			{ 575, 575, 575, 709, 709, 39, 164, 591, 591, 591, 571, 571 };
						loc.RedLevel = new int[]			{ 48, 49, 50, 48, 49, 50, 50, 48, 49, 50, 48, 50 };
						loc.HordeTable1 = new ushort[]		{ 590, 590, 590, 590, 590 };
						loc.HordeTable2 = new ushort[]		{ 709, 709, 709, 709, 709 };
						loc.HordeTable3 = new ushort[]		{ 709, 709, 709, 185, 709 };
						loc.HordeLevel = new int[]			{ 25, 25, 25 };
						break;

					case 283:		// Route 21
						loc.RedTable = new ushort[]			{ 217, 217, 217, 334, 334, 217, 327, 327, 419, 123, 123, 123 };
						loc.RedLevel = new int[]			{ 50, 51, 52, 50, 51, 50, 50, 52, 52, 50, 51, 52 };
						loc.PurpleTable = new ushort[]		{ 419, 419, 419, 334, 334, 419, 327, 327, 217, 123, 123, 123 };
						loc.PurpleLevel = new int[]			{ 50, 51, 52, 50, 51, 50, 50, 52, 52, 50, 51, 52 };
						loc.HordeTable1 = new ushort[]		{ 327, 327, 327, 327, 327 };
						loc.HordeTable2 = new ushort[]		{ 333, 333, 333, 333, 333 };
						loc.HordeTable3 = new ushort[]		{ 123, 123, 123, 123, 123 };
						loc.HordeLevel = new int[]			{ 26, 26, 27 };
						loc.SurfTable = new ushort[]		{ 271, 419, 271, 419, 271 };
						loc.SurfLevel = new int[]			{ 50, 50, 51, 52, 52 };
						loc.OldTable = new ushort[]			{ 60, 60, 60 };
						loc.OldLevel = new int[]			{ 30, 30, 30 };
						loc.GoodTable = new ushort[]		{ 550, 61, 147 };
						loc.GoodLevel = new int[]			{ 40, 40, 40 };
						loc.SuperTable = new ushort[]		{ 61, 550, 148 };
						loc.SuperLevel = new int[]			{ 50, 50, 50 };
						break;

					case 285:		// Route 22
						loc.GrassTable = new ushort[]		{ 659, 659, 667, 667, 54, 399, 298, 298, 83, 206, 447, 447 };
						loc.WildLevel = new int[]			{ 5, 6, 5, 6, 6, 6, 6, 7, 7, 7, 6, 7 };
						loc.YellowTable = new ushort[]		{ 400, 400, 54, 54, 667, 660, 184, 184, 83, 206, 447, 447 };
						loc.YellowLevel = new int[]			{ 26, 27, 25, 26, 25, 27, 25, 26, 26, 26, 25, 26 };
						loc.SurfTable = new ushort[]		{ 54, 54, 54, 184, 184 };
						loc.SurfLevel = new int[]			{ 25, 26, 27, 25, 27 };
						loc.OldTable = new ushort[]			{ 129, 129, 129 };
						loc.OldLevel = new int[]			{ 15, 15, 15 };
						loc.GoodTable = new ushort[]		{ 118, 318, 118 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 130, 119, 319 };
						loc.SuperLevel = new int[]			{ 35, 35, 35 };
						break;

					case 260:		// Route 3
						loc.GrassTable = new ushort[]		{ 659, 659, 399, 399, 661, 661, 16, 412, 298, 206, 25, 25 };
						loc.WildLevel = new int[]			{ 3, 4, 3, 4, 3, 5, 4, 5, 5, 5, 4, 5 };
						loc.SurfTable = new ushort[]		{ 284, 183, 284, 183, 284 };
						loc.SurfLevel = new int[]			{ 25, 25, 26, 27, 27 };
						loc.OldTable = new ushort[]			{ 129, 129, 129 };
						loc.OldLevel = new int[]			{ 15, 15, 15 };
						loc.GoodTable = new ushort[]		{ 118, 341, 118 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 130, 119, 342 };
						loc.SuperLevel = new int[]			{ 35, 35, 35 };
						break;

					case 261:		// Route 4
						loc.RedTable = new ushort[]			{ 669, 669, 669, 165, 165, 165, 406, 415, 300, 280, 727, 729 };
						loc.RedLevel = new int[]			{ 6, 7, 8, 6, 7, 8, 8, 8, 8, 8, 7, 8 };
						loc.YellowTable = new ushort[]		{ 726, 726, 726, 415, 415, 415, 406, 165, 300, 280, 727, 729 };
						loc.YellowLevel = new int[]			{ 6, 7, 8, 6, 7, 8, 8, 8, 8, 8, 7, 8 };
						break;

					case 262:		// Route 5
						if (X)
						{
							loc.GrassTable = new ushort[]	{ 659, 659, 659, 676, 676, 674, 672, 84, 316, 63, 311, 311 };
						}
						else
						{
							loc.GrassTable = new ushort[]	{ 659, 659, 659, 676, 676, 674, 672, 84, 316, 63, 312, 312 };
						}
						loc.WildLevel = new int[]			{ 8, 9, 10, 8, 9, 10, 10, 10, 10, 10, 9, 10 };
						if (X)
						{
							loc.PurpleTable = new ushort[]	{ 672, 672, 672, 674, 674, 676, 659, 84, 316, 63, 311, 311 };
						}
						else
						{
							loc.PurpleTable = new ushort[]	{ 672, 672, 672, 674, 674, 676, 659, 84, 316, 63, 312, 312 };
						}
						loc.PurpleLevel = new int[]			{ 8, 9, 10, 8, 9, 10, 10, 10, 10, 10, 9, 10 };
						loc.HordeTable1 = new ushort[]		{ 316, 316, 316, 316, 316 };
						loc.HordeTable2 = new ushort[]		{ 559, 559, 559, 559, 559 };
						if (X)
						{
							loc.HordeTable3 = new ushort[]	{ 311, 311, 311, 312, 311 };
						}
						else
						{
							loc.HordeTable3 = new ushort[]	{ 312, 312, 312, 311, 312 };
						}
						loc.HordeLevel = new int[]			{ 5, 5, 6 };
						break;

					case 263:		// Route 6
						loc.LongTable = new ushort[]		{ 43, 43, 43, 161, 161, 290, 677, 677, 679, 679, 352, 352 };
						loc.WildLevel = new int[]			{ 10, 11, 12, 10, 11, 12, 11, 12, 11, 12, 11, 12 };
                      //loc.AmbushTable = new ushort[]		{ 543, 543, 543, 543, 543, 543, 543, 543, 531, 531, 531, 531 };
                      //loc.AmbushLevel = new int[]			{ 10, 10, 10, 10, 11, 11, 12, 12, 10, 11, 12, 12 };
                        break;

					case 264:		// Route 7
						if (X)
						{
							loc.GrassTable = new ushort[]	{ 453, 453, 453, 313, 314, 684, 235, 580, 315, 453, 727, 729 };
						}
						else
						{
							loc.GrassTable = new ushort[]	{ 453, 453, 453, 313, 314, 682, 235, 580, 315, 453, 727, 729 };
						}
						loc.WildLevel = new int[]			{ 12, 13, 14, 13, 13, 14, 14, 14, 14, 14, 13, 14 };
						if (X)
						{
							loc.YellowTable = new ushort[]	{ 726, 726, 726, 313, 314, 684, 235, 580, 315, 453, 727, 729 };
						}
						else
						{
							loc.YellowTable = new ushort[]	{ 726, 726, 726, 313, 314, 682, 235, 580, 315, 453, 727, 729 };
						}
						loc.YellowLevel = new int[]			{ 12, 13, 14, 13, 13, 14, 14, 14, 14, 14, 13, 14 };
						if (X)
						{
							loc.PurpleTable = new ushort[]	{ 728, 728, 728, 313, 314, 684, 235, 580, 315, 453, 727, 729 };
						}
						else
						{
							loc.PurpleTable = new ushort[]	{ 728, 728, 728, 313, 314, 682, 235, 580, 315, 453, 727, 729 };
						}
						loc.PurpleLevel = new int[]			{ 12, 13, 14, 13, 13, 14, 14, 14, 14, 14, 13, 14 };
						loc.HordeTable1 = new ushort[]		{ 187, 187, 187, 187, 187 };
						loc.HordeTable2 = new ushort[]		{ 54, 54, 54, 54, 54 };
						loc.HordeTable3 = new ushort[]		{ 315, 315, 315, 315, 315 };
						if (X)
						{
							loc.HordeLevel = new int[]		{ 7, 7, 8 };
						}
						else
						{
							loc.HordeLevel = new int[]		{ 7, 8, 7 };
						}
						break;

					case 266:		// Route 8
						if (X)
						{
							loc.GrassTable = new ushort[]	{ 425, 425, 425, 325, 325, 359, 619, 686, 335, 686, 371, 371 };
						}
						else
						{
							loc.GrassTable = new ushort[]	{ 425, 425, 425, 325, 325, 359, 619, 686, 336, 686, 371, 371 };
						}
						loc.WildLevel = new int[]			{ 13, 14, 15, 13, 14, 15, 15, 14, 14, 15, 14, 15 };
						if (X)
						{
							loc.YellowTable = new ushort[]	{ 619, 619, 619, 359, 359, 325, 425, 686, 335, 686, 371, 371 };
						}
						else
						{
							loc.YellowTable = new ushort[]	{ 619, 619, 619, 359, 359, 325, 425, 686, 336, 686, 371, 371 };
						}
						loc.YellowLevel = new int[]			{ 13, 14, 15, 13, 14, 15, 15, 14, 14, 15, 14, 15 };
						loc.HordeTable1 = new ushort[]		{ 278, 278, 278, 278, 278 };
						if (X)
						{
							loc.HordeTable2 = new ushort[]	{ 335, 336, 335, 335, 335 };
						}
						else
						{
							loc.HordeTable2 = new ushort[]	{ 336, 335, 336, 336, 336 };
						}
						loc.HordeTable3 = new ushort[]		{ 276, 276, 276, 276, 276 };
						loc.HordeLevel = new int[]			{ 7, 8, 7 };
						loc.SurfTable = new ushort[]		{ 72, 320, 72, 72, 320 };
						loc.SurfLevel = new int[]			{ 25, 25, 26, 27, 27 };
						loc.OldTable = new ushort[]			{ 370, 370, 370 };
						loc.OldLevel = new int[]			{ 15, 15, 15 };
						if (X)
						{
							loc.GoodTable = new ushort[]	{ 692, 120, 692 };
						}
						else
						{
							loc.GoodTable = new ushort[]	{ 690, 90, 690 };
						}
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						if (X)
						{
							loc.SuperTable = new ushort[]	{ 211, 693, 121 };
						}
						else
						{
							loc.SuperTable = new ushort[]	{ 211, 691, 91 };
						}
						loc.SuperLevel = new int[]			{ 35, 35, 35 };
						loc.SmashTable = new ushort[]		{ 557, 688, 557, 688, 557 };
						if (X)
						{
							loc.SmashLevel = new int[]		{ 18, 18, 19, 20, 20 };
						}
						else
						{
							loc.SmashLevel = new int[]		{ 13, 13, 14, 15, 15 };
						}
						break;

					case 267:		// Route 9
						loc.RideTable = new ushort[]		{ 551, 551, 551, 551, 449, 449, 449, 449, 694, 694, 694, 694 };
						loc.WildLevel = new int[]			{ 15, 16, 16, 17, 15, 16, 16, 17, 15, 16, 16, 17 };
						break;

					case 286:		// Santalune Forest
						if (X)
						{
							loc.GrassTable = new ushort[]	{ 664, 664, 13, 13, 661, 511, 513, 515, 10, 25, 14, 25 };
						}
						else
						{
							loc.GrassTable = new ushort[]	{ 664, 664, 10, 10, 661, 511, 513, 515, 13, 25, 11, 25 };
						}
						loc.WildLevel = new int[]			{ 2, 3, 2, 3, 4, 4, 4, 4, 2, 3, 4, 4 };
						break;

					case 172:		// Shalour City
						loc.SurfTable = new ushort[]		{ 72, 72, 458, 72, 458 };
						loc.SurfLevel = new int[]			{ 25, 26, 27, 27, 27 };
						loc.OldTable = new ushort[]			{ 370, 370, 370 };
						loc.OldLevel = new int[]			{ 15, 15, 15 };
						loc.GoodTable = new ushort[]		{ 223, 170, 223 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 594, 224, 171 };
						loc.SuperLevel = new int[]			{ 35, 35, 35 };
						break;

					case 343:		// Terminus Cave
						if (X)
						{
							loc.CaveTable = new ushort[]	{ 305, 305, 28, 28, 632, 632, 632, 632, 75, 75, 75, 75 };
						}
						else
						{
							loc.CaveTable = new ushort[]	{ 247, 247, 28, 28, 632, 632, 632, 632, 75, 75, 75, 75 };
						}
						loc.WildLevel = new int[]			{ 45, 46, 45, 46, 44, 44, 45, 46, 44, 45, 46, 46 };
						loc.HordeTable1 = new ushort[]		{ 632, 632, 632, 632, 632 };
						loc.HordeTable2 = new ushort[]		{ 74, 74, 74, 74, 74 };
						if (X)
						{
							loc.HordeTable3 = new ushort[]	{ 304, 304, 304, 304, 304 };
						}
						else
						{
							loc.HordeTable3 = new ushort[]	{ 246, 246, 246, 246, 246 };
						}
						loc.HordeLevel = new int[]			{ 23, 23, 24 };
						loc.SmashTable = new ushort[]		{ 75, 75, 75, 213, 213 };
						loc.SmashLevel = new int[]			{ 44, 45, 46, 44, 46 };
						break;

					case 322:		// Victory Road - Entrance
						loc.CaveTable = new ushort[]		{ 533, 533, 533, 621, 621, 93, 75, 75, 108, 108, 634, 634 };
						loc.WildLevel = new int[]			{ 57, 58, 59, 58, 59, 58, 57, 58, 58, 59, 59, 59 };
						loc.HordeTable1 = new ushort[]		{ 74, 74, 74, 74, 74 };
						loc.HordeTable2 = new ushort[]		{ 419, 419, 419, 419, 419 };
						loc.HordeTable3 = new ushort[]		{ 108, 108, 108, 108, 108 };
						loc.HordeLevel = new int[]			{ 28, 29, 30 };
						loc.SurfTable = new ushort[]		{ 61, 419, 61, 419, 61 };
						loc.SurfLevel = new int[]			{ 57, 57, 58, 59, 59 };
						loc.OldTable = new ushort[]			{ 60, 60, 60 };
						loc.OldLevel = new int[]			{ 35, 35, 35 };
						if (X)
						{
							loc.GoodTable = new ushort[]	{ 725, 61, 725 };
						}
						else
						{
							loc.GoodTable = new ushort[]	{ 550, 61, 550 };
						}
						loc.GoodLevel = new int[]			{ 45, 45, 45 };
						if (X)
						{
							loc.SuperTable = new ushort[]	{ 61, 550, 61 };
						}
						else
						{
							loc.SuperTable = new ushort[]	{ 61, 725, 61 };
						}
						loc.SuperLevel = new int[]			{ 55, 55, 55 };
						loc.SmashTable = new ushort[]		{ 75, 75, 75, 213, 213 };
						loc.SmashLevel = new int[]			{ 57, 58, 59, 57, 59 };
						break;

					case 328:		// Victory Road - Exit
						loc.CaveTable = new ushort[]		{ 533, 533, 533, 621, 621, 93, 75, 75, 108, 108, 634, 634 };
						loc.WildLevel = new int[]			{ 57, 58, 59, 58, 59, 58, 57, 58, 58, 59, 59, 59 };
						loc.HordeTable1 = new ushort[]		{ 74, 74, 74, 74, 74 };
						loc.HordeTable2 = new ushort[]		{ 419, 419, 419, 419, 419 };
						loc.HordeTable3 = new ushort[]		{ 108, 108, 108, 108, 108 };
						loc.HordeLevel = new int[]			{ 28, 29, 30 };
						loc.SurfTable = new ushort[]		{ 61, 419, 61, 419, 61 };
						loc.SurfLevel = new int[]			{ 57, 57, 58, 59, 59 };
						loc.OldTable = new ushort[]			{ 60, 60, 60 };
						loc.OldLevel = new int[]			{ 35, 35, 35 };
						if (X)
						{
							loc.GoodTable = new ushort[]	{ 725, 61, 725 };
						}
						else
						{
							loc.GoodTable = new ushort[]	{ 550, 61, 550 };
						}
						loc.GoodLevel = new int[]			{ 45, 45, 45 };
						if (X)
						{
							loc.SuperTable = new ushort[]	{ 61, 550, 62 };
						}
						else
						{
							loc.SuperTable = new ushort[]	{ 61, 725, 62 };
						}
						loc.SuperLevel = new int[]			{ 55, 55, 60 };
						break;

					case 324:		// Victory Road - Middle
						loc.CaveTable = new ushort[]		{ 533, 533, 533, 621, 621, 93, 75, 75, 108, 108, 634, 634 };
						loc.WildLevel = new int[]			{ 57, 58, 59, 58, 59, 58, 57, 58, 58, 59, 59, 59 };
						loc.HordeTable1 = new ushort[]		{ 74, 74, 74, 74, 74 };
						loc.HordeTable2 = new ushort[]		{ 75, 75, 75, 75, 75 };
						loc.HordeTable3 = new ushort[]		{ 108, 108, 108, 108, 108 };
						loc.HordeLevel = new int[]			{ 28, 29, 30 };
						loc.SmashTable = new ushort[]		{ 75, 75, 75, 213, 213 };
						loc.SmashLevel = new int[]			{ 57, 58, 59, 57, 59 };
						break;

					case 327:		// Victory Road - Outside
						loc.SurfTable = new ushort[]		{ 271, 419, 271, 419, 271 };
						loc.SurfLevel = new int[]			{ 57, 57, 58, 59, 59 };
						loc.OldTable = new ushort[]			{ 60, 60, 60 };
						loc.OldLevel = new int[]			{ 35, 35, 35 };
						if (X)
						{
							loc.GoodTable = new ushort[]	{ 725, 61, 725 };
						}
						else
						{
							loc.GoodTable = new ushort[]	{ 550, 61, 550 };
						}
						loc.GoodLevel = new int[]			{ 45, 45, 45 };
						if (X)
						{
							loc.SuperTable = new ushort[]	{ 61, 550, 61 };
						}
						else
						{
							loc.SuperTable = new ushort[]	{ 61, 725, 61 };
						}
						loc.SuperLevel = new int[]			{ 55, 55, 55 };
                        loc.AmbushTable = new ushort[]		{ 22, 22, 22, 22, 22, 22, 22, 22, 227, 227, 635, 635, };
						loc.AmbushLevel = new int[]			{ 57, 58, 59, 58, 59, 58, 57, 58, 57, 59, 59, 59, };
                        break;

					default:
						MessageBox.Show("No location found: " + loc.Name);
						break;

                }
            }

            return locations;

        }
    }
}
