using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace TinyFinder
{
    internal class TableORAS : LocationsORAS
    {
        public static List<Location> EncounterTable(bool OmegaRuby)
        {
            List<Location> locations = WildLocations();

            foreach (Location loc in locations)
            {
                switch (loc.Map)
                {

					case 210:		// Battle Resort
						loc.SurfTable = new ushort[]		{ 73, 458, 279, 279, 226 };
						loc.SurfLevel = new int[]			{ 35, 35, 35, 40, 40 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 223 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 223, 223, 224 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						break;

					case 112:		// Cave of Origin
						if (OmegaRuby)
						{
							loc.CaveTable = new ushort[]	{ 42, 303, 42, 42, 303, 42, 42, 303, 42, 42, 42, 303 };
						}
						else
						{
							loc.CaveTable = new ushort[]	{ 42, 302, 42, 42, 302, 42, 42, 302, 42, 42, 42, 302 };
						}
						loc.WildLevel = new int[]			{ 33, 33, 34, 34, 34, 35, 35, 35, 36, 36, 36, 36 };
						loc.HordeTable1 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeTable2 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeTable3 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeLevel = new int[]			{ 18, 18, 18 };
						break;

					case 8:		// Dewford Town
						loc.SurfTable = new ushort[]		{ 72, 278, 72, 279, 279 };
						loc.SurfLevel = new int[]			{ 20, 20, 25, 25, 30 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 320, 320 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						break;

					case 21:		// Ever Grande City
						loc.SurfTable = new ushort[]		{ 72, 279, 73, 279, 279 };
						loc.SurfLevel = new int[]			{ 25, 25, 30, 30, 35 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 370, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 370, 320, 222 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						break;

					case 85:		// Fiery Path
						if (OmegaRuby)
						{
							loc.CaveTable = new ushort[]	{ 322, 322, 322, 322, 109, 109, 109, 218, 324, 66, 88, 88 };
						}
						else
						{
							loc.CaveTable = new ushort[]	{ 322, 322, 322, 322, 88, 88, 88, 218, 324, 66, 109, 109 };
						}
						loc.WildLevel = new int[]			{ 13, 14, 15, 16, 14, 15, 16, 15, 15, 15, 15, 15 };
						loc.HordeTable1 = new ushort[]		{ 322, 322, 322, 322, 322 };
						if (OmegaRuby)
						{
							loc.HordeTable2 = new ushort[]	{ 109, 109, 109, 109, 109 };
						}
						else
						{
							loc.HordeTable2 = new ushort[]	{ 88, 88, 88, 88, 88 };
						}
						loc.HordeTable3 = new ushort[]		{ 218, 218, 218, 218, 218 };
						loc.HordeLevel = new int[]			{ 8, 8, 8 };
						loc.DexNavTable = new ushort[]		{ 524, 50, 236 };
						loc.DexNavLevel = 15;
						break;

					case 78:		// Granite Cave - 1F
						loc.CaveTable = new ushort[]		{ 41, 41, 41, 41, 296, 296, 296, 296, 63, 63, 74, 74 };
						loc.WildLevel = new int[]			{ 9, 10, 11, 12, 9, 10, 11, 12, 10, 12, 10, 12 };
						loc.HordeTable1 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeTable2 = new ushort[]		{ 296, 296, 74, 296, 296 };
						loc.HordeTable3 = new ushort[]		{ 296, 296, 296, 296, 296 };
						loc.HordeLevel = new int[]			{ 6, 6, 6 };
						loc.DexNavTable = new ushort[]		{ 532, 610, 95 };
						loc.DexNavLevel = 12;
						break;

					case 79:		// Granite Cave - B1F
						loc.CaveTable = new ushort[]		{ 41, 41, 41, 304, 304, 304, 296, 296, 63, 63, 63, 63 };
						loc.WildLevel = new int[]			{ 10, 11, 12, 10, 11, 12, 10, 12, 10, 12, 12, 12 };
						loc.HordeTable1 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeTable2 = new ushort[]		{ 304, 304, 304, 304, 304 };
						loc.HordeTable3 = new ushort[]		{ 304, 304, 304, 304, 304 };
						loc.HordeLevel = new int[]			{ 6, 6, 6 };
						loc.DexNavTable = new ushort[]		{ 532, 610, 95 };
						loc.DexNavLevel = 12;
						break;

					case 80:		// Granite Cave - B2F
						if (OmegaRuby)
						{
							loc.CaveTable = new ushort[]	{ 41, 41, 41, 304, 304, 304, 63, 63, 303, 303, 303, 303 };
						}
						else
						{
							loc.CaveTable = new ushort[]	{ 41, 41, 41, 304, 304, 304, 63, 63, 302, 302, 302, 302 };
						}
						loc.WildLevel = new int[]			{ 10, 11, 12, 10, 11, 12, 10, 12, 10, 12, 12, 12 };
						loc.HordeTable1 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeTable2 = new ushort[]		{ 304, 304, 304, 304, 304 };
						if (OmegaRuby)
						{
							loc.HordeTable3 = new ushort[]	{ 303, 303, 303, 303, 303 };
						}
						else
						{
							loc.HordeTable3 = new ushort[]	{ 302, 302, 302, 302, 302 };
						}
						loc.HordeLevel = new int[]			{ 6, 6, 6 };
						loc.SmashTable = new ushort[]		{ 74, 74, 299, 74, 299 };
						loc.SmashLevel = new int[]			{ 10, 11, 10, 12, 12 };
						loc.DexNavTable = new ushort[]		{ 532, 610, 95 };
						loc.DexNavLevel = 12;
						break;

					case 84:		// Jagged Pass
						loc.GrassTable = new ushort[]		{ 322, 322, 322, 322, 66, 66, 66, 66, 325, 325, 325, 325 };
						loc.WildLevel = new int[]			{ 18, 19, 20, 21, 18, 19, 20, 21, 18, 19, 20, 21 };
						loc.HordeTable1 = new ushort[]		{ 66, 66, 66, 66, 66 };
						loc.HordeTable2 = new ushort[]		{ 325, 325, 325, 325, 325 };
						loc.HordeTable3 = new ushort[]		{ 66, 66, 66, 66, 66 };
						loc.HordeLevel = new int[]			{ 10, 10, 10 };
						loc.DexNavTable = new ushort[]		{ 77, 56, 236 };
						loc.DexNavLevel = 21;
						break;

					case 18:		// Lilycove City
						loc.SurfTable = new ushort[]		{ 72, 278, 72, 279, 279 };
						loc.SurfLevel = new int[]			{ 20, 20, 25, 25, 30 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 320, 120 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						loc.SmashTable = new ushort[]		{ 75, 75, 75, 75, 75 };
						loc.SmashLevel = new int[]			{ 28, 29, 30, 31, 31 };
						break;

					case 512:		// M. Cave - North of 124
						loc.CaveTable = new ushort[]		{ 599, 599, 599, 599, 599, 599, 563, 563, 563, 563, 563, 563 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						loc.SmashTable = new ushort[]		{ 75, 75, 525, 75, 75 };
						loc.SmashLevel = new int[]			{ 35, 36, 37, 37, 38 };
						break;

					case 513:		// M. Cave - North of 132
						loc.CaveTable = new ushort[]		{ 602, 602, 602, 530, 530, 530, 132, 132, 132, 132, 132, 132 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						break;

					case 515:		// M. Cave - North of Fallarbor
						loc.CaveTable = new ushort[]		{ 602, 602, 602, 602, 602, 602, 79, 79, 79, 79, 79, 79 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						break;

					case 509:		// M. Cave - North of Fortree
						loc.CaveTable = new ushort[]		{ 599, 599, 599, 602, 602, 602, 530, 530, 530, 95, 95, 95 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						loc.SmashTable = new ushort[]		{ 75, 75, 525, 75, 75 };
						loc.SmashLevel = new int[]			{ 35, 36, 37, 37, 38 };
						break;

					case 511:		// M. Cave - South of 107
						loc.CaveTable = new ushort[]		{ 201, 201, 201, 201, 201, 201, 201, 201, 201, 201, 201, 201 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						break;

					case 510:		// M. Cave - South of Pacifidlog
						loc.CaveTable = new ushort[]		{ 602, 602, 602, 602, 602, 602, 563, 563, 563, 79, 79, 79 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						break;

					case 514:		// M. Cave - Southeast of 129
						loc.CaveTable = new ushort[]		{ 602, 602, 602, 602, 602, 602, 95, 95, 95, 95, 95, 95 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						loc.SmashTable = new ushort[]		{ 75, 75, 525, 75, 75 };
						loc.SmashLevel = new int[]			{ 35, 36, 37, 37, 38 };
						break;

					case 508:		// M. Cave - West of Rustboro
						loc.CaveTable = new ushort[]		{ 599, 599, 599, 599, 599, 599, 602, 602, 602, 602, 602, 602 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						loc.SmashTable = new ushort[]		{ 75, 75, 525, 75, 75 };
						loc.SmashLevel = new int[]			{ 35, 36, 37, 37, 38 };
						break;

					case 184:		// M. Forest - East of Mossdeep
						loc.GrassTable = new ushort[]		{ 114, 114, 114, 431, 431, 431, 191, 191, 191, 572, 572, 572 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						break;

					case 191:		// M. Forest - North of 111
						loc.GrassTable = new ushort[]		{ 402, 402, 402, 402, 402, 402, 636, 636, 636, 636, 636, 636 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						break;

					case 185:		// M. Forest - North of 124
						loc.GrassTable = new ushort[]		{ 114, 114, 114, 432, 432, 432, 191, 191, 191, 37, 37, 37 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						break;

					case 187:		// M. Forest - North of Lilycove
						loc.GrassTable = new ushort[]		{ 114, 114, 114, 432, 432, 432, 191, 191, 191, 421, 421, 421 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						break;

					case 190:		// M. Forest - South of 109
						loc.GrassTable = new ushort[]		{ 531, 531, 531, 531, 531, 531, 531, 531, 531, 191, 191, 191 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						break;

					case 188:		// M. Forest - South of 132
						loc.GrassTable = new ushort[]		{ 191, 191, 191, 191, 191, 191, 548, 548, 548, 531, 531, 531 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						break;

					case 189:		// M. Forest - West of 105
						loc.GrassTable = new ushort[]		{ 205, 205, 205, 205, 205, 205, 440, 440, 440, 440, 440, 440 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						loc.SmashTable = new ushort[]		{ 75, 75, 75, 75, 75 };
						loc.SmashLevel = new int[]			{ 33, 34, 35, 36, 36 };
						break;

					case 186:		// M. Forest - West of 114
						loc.GrassTable = new ushort[]		{ 114, 114, 114, 432, 432, 432, 191, 191, 191, 548, 548, 548 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						break;

					case 206:		// M. Island - North of 113
						loc.GrassTable = new ushort[]		{ 555, 555, 555, 555, 555, 555, 636, 636, 636, 636, 636, 636 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						break;

					case 202:		// M. Island - North of 124
						loc.GrassTable = new ushort[]		{ 49, 49, 49, 523, 523, 523, 178, 178, 178, 53, 53, 53 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						break;

					case 207:		// M. Island - North of 125
						loc.GrassTable = new ushort[]		{ 432, 432, 432, 432, 432, 432, 137, 137, 137, 137, 137, 137 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						break;

					case 205:		// M. Island - South of 132
						loc.GrassTable = new ushort[]		{ 517, 517, 517, 517, 517, 517, 132, 132, 132, 132, 132, 132 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						break;

					case 201:		// M. Island - South of 134
						loc.GrassTable = new ushort[]		{ 49, 49, 49, 523, 523, 523, 178, 178, 178, 556, 556, 556 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						loc.SmashTable = new ushort[]		{ 75, 75, 688, 75, 75 };
						loc.SmashLevel = new int[]			{ 35, 36, 37, 37, 38 };
						break;

					case 204:		// M. Island - South of Pacifidlog
						loc.GrassTable = new ushort[]		{ 531, 531, 531, 531, 531, 531, 531, 531, 531, 178, 178, 178 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						loc.SmashTable = new ushort[]		{ 75, 75, 688, 75, 75 };
						loc.SmashLevel = new int[]			{ 35, 36, 37, 37, 38 };
						break;

					case 200:		// M. Island - West of 104
						loc.GrassTable = new ushort[]		{ 49, 49, 49, 523, 523, 523, 178, 178, 178, 555, 555, 555 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						break;

					case 203:		// M. Island - West of Dewford
						loc.GrassTable = new ushort[]		{ 49, 49, 49, 523, 523, 523, 178, 178, 178, 114, 114, 114 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						break;

					case 463:		// M. Mountain - East of 125
						loc.GrassTable = new ushort[]		{ 555, 555, 555, 555, 555, 555, 240, 240, 240, 240, 240, 240 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						break;

					case 466:		// M. Mountain - North of 125
						loc.GrassTable = new ushort[]		{ 531, 531, 531, 531, 531, 531, 440, 440, 440, 114, 114, 114 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						loc.SmashTable = new ushort[]		{ 75, 75, 558, 75, 75 };
						loc.SmashLevel = new int[]			{ 35, 36, 37, 37, 38 };
						break;

					case 460:		// M. Mountain - North of Lilycove
						loc.GrassTable = new ushort[]		{ 205, 205, 205, 232, 232, 232, 402, 402, 402, 627, 627, 627 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						break;

					case 461:		// M. Mountain - Northeast of 125
						loc.GrassTable = new ushort[]		{ 205, 205, 205, 232, 232, 232, 402, 402, 402, 629, 629, 629 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						break;

					case 464:		// M. Mountain - South of 129
						loc.GrassTable = new ushort[]		{ 523, 523, 523, 523, 523, 523, 239, 239, 239, 239, 239, 239 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						break;

					case 462:		// M. Mountain - South of 131
						loc.GrassTable = new ushort[]		{ 205, 205, 205, 232, 232, 232, 402, 402, 402, 203, 203, 203 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						break;

					case 465:		// M. Mountain - Southeast of 129
						loc.GrassTable = new ushort[]		{ 178, 178, 178, 178, 178, 178, 517, 517, 517, 137, 137, 137 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						loc.SmashTable = new ushort[]		{ 75, 75, 558, 75, 75 };
						loc.SmashLevel = new int[]			{ 35, 36, 37, 37, 38 };
						break;

					case 208:		// M. Mountain - West of 104
						loc.GrassTable = new ushort[]		{ 205, 205, 205, 232, 232, 232, 402, 402, 402, 234, 234, 234 };
						loc.WildLevel = new int[]			{ 38, 37, 36, 38, 37, 36, 38, 37, 36, 36, 37, 38 };
						break;

					case 71:		// Meteor Falls - 1F 1R
						if (OmegaRuby)
						{
							loc.CaveTable = new ushort[]	{ 41, 41, 41, 41, 41, 41, 338, 338, 41, 41, 338, 338 };
						}
						else
						{
							loc.CaveTable = new ushort[]	{ 41, 41, 41, 41, 41, 41, 337, 337, 41, 41, 337, 337 };
						}
						loc.WildLevel = new int[]			{ 16, 16, 17, 17, 18, 18, 16, 17, 19, 19, 18, 19 };
						loc.HordeTable1 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeTable2 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeTable3 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeLevel = new int[]			{ 9, 9, 9 };
						if (OmegaRuby)
						{
							loc.SurfTable = new ushort[]	{ 41, 41, 338, 42, 338 };
						}
						else
						{
							loc.SurfTable = new ushort[]	{ 41, 41, 337, 42, 337 };
						}
						loc.SurfLevel = new int[]			{ 15, 20, 20, 25, 25 };
						loc.OldTable = new ushort[]			{ 129, 118, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 118, 339 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 339, 339, 339 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						loc.DexNavTable = new ushort[]		{ 633, 621, 35 };
						loc.DexNavLevel = 19;
						break;

					case 72:        // Meteor Falls - 1F 2R, B1F 1R
                        if (OmegaRuby)
						{
							loc.CaveTable = new ushort[]	{ 42, 42, 42, 42, 42, 42, 338, 338, 42, 42, 338, 338 };
						}
						else
						{
							loc.CaveTable = new ushort[]	{ 42, 42, 42, 42, 42, 42, 337, 337, 42, 42, 337, 337 };
						}
						loc.WildLevel = new int[]			{ 37, 37, 38, 38, 39, 39, 37, 38, 40, 40, 39, 40 };
						loc.HordeTable1 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeTable2 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeTable3 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeLevel = new int[]			{ 20, 20, 20 };
						if (OmegaRuby)
						{
							loc.SurfTable = new ushort[]	{ 42, 42, 338, 338, 338 };
						}
						else
						{
							loc.SurfTable = new ushort[]	{ 42, 42, 337, 337, 337 };
						}
						loc.SurfLevel = new int[]			{ 30, 35, 30, 35, 40 };
						loc.OldTable = new ushort[]			{ 129, 118, 129 };
						loc.OldLevel = new int[]			{ 10, 10, 5 };
						loc.GoodTable = new ushort[]		{ 129, 118, 339 };
						loc.GoodLevel = new int[]			{ 30, 30, 30 };
						loc.SuperTable = new ushort[]		{ 339, 339, 340 };
						loc.SuperLevel = new int[]			{ 30, 35, 40 };
						loc.DexNavTable = new ushort[]		{ 633, 621, 35 };
						loc.DexNavLevel = 40;
						break;

					case 74:		// Meteor Falls - B1F2
						if (OmegaRuby)
						{
							loc.CaveTable = new ushort[]	{ 42, 42, 42, 42, 371, 338, 338, 371, 371, 371, 338, 338 };
						}
						else
						{
							loc.CaveTable = new ushort[]	{ 42, 42, 42, 42, 371, 337, 337, 371, 371, 371, 337, 337 };
						}
						loc.WildLevel = new int[]			{ 37, 38, 39, 40, 37, 37, 38, 38, 39, 40, 39, 40 };
						loc.HordeTable1 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeTable2 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeTable3 = new ushort[]		{ 371, 371, 371, 371, 371 };
						loc.HordeLevel = new int[]			{ 20, 20, 20 };
						if (OmegaRuby)
						{
							loc.SurfTable = new ushort[]	{ 42, 42, 338, 338, 338 };
						}
						else
						{
							loc.SurfTable = new ushort[]	{ 42, 42, 337, 337, 337 };
						}
						loc.SurfLevel = new int[]			{ 30, 35, 30, 35, 40 };
						loc.OldTable = new ushort[]			{ 129, 118, 129 };
						loc.OldLevel = new int[]			{ 10, 10, 5 };
						loc.GoodTable = new ushort[]		{ 129, 118, 339 };
						loc.GoodLevel = new int[]			{ 30, 30, 30 };
						loc.SuperTable = new ushort[]		{ 339, 339, 340 };
						loc.SuperLevel = new int[]			{ 30, 35, 40 };
						loc.DexNavTable = new ushort[]		{ 633, 621, 35 };
						loc.DexNavLevel = 40;
						break;

					case 19:		// Mossdeep City
						loc.SurfTable = new ushort[]		{ 72, 279, 73, 279, 279 };
						loc.SurfLevel = new int[]			{ 25, 25, 30, 30, 35 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 320, 320 };
						loc.SuperLevel = new int[]			{ 25, 30, 40 };
						break;

					case 86:		// Mt. Pyre - Inside
						loc.CaveTable = new ushort[]		{ 353, 355, 353, 353, 355, 353, 353, 355, 353, 353, 355, 355 };
						loc.WildLevel = new int[]			{ 28, 28, 29, 29, 29, 30, 30, 30, 31, 31, 31, 31 };
						loc.HordeTable1 = new ushort[]		{ 353, 353, 353, 353, 353 };
						loc.HordeTable2 = new ushort[]		{ 353, 353, 353, 353, 353 };
						loc.HordeTable3 = new ushort[]		{ 353, 353, 353, 353, 353 };
						loc.HordeLevel = new int[]			{ 15, 15, 15 };
						break;

					case 90:		// Mt. Pyre - Outside
						loc.GrassTable = new ushort[]		{ 353, 353, 353, 353, 307, 307, 307, 307, 37, 37, 278, 278 };
						loc.WildLevel = new int[]			{ 28, 29, 30, 31, 28, 29, 30, 31, 29, 31, 30, 30 };
						loc.HordeTable1 = new ushort[]		{ 353, 353, 353, 353, 353 };
						loc.HordeTable2 = new ushort[]		{ 307, 307, 307, 307, 307 };
						loc.HordeTable3 = new ushort[]		{ 37, 37, 37, 37, 37 };
						loc.HordeLevel = new int[]			{ 15, 15, 15 };
						loc.DexNavTable = new ushort[]		{ 605, 436, 58 };
						loc.DexNavLevel = 31;
						break;

					case 91:		// Mt. Pyre - Summit
						loc.GrassTable = new ushort[]		{ 353, 353, 353, 353, 307, 307, 307, 307, 37, 37, 358, 358 };
						loc.WildLevel = new int[]			{ 28, 29, 30, 31, 28, 29, 30, 31, 29, 31, 30, 30 };
						loc.HordeTable1 = new ushort[]		{ 353, 353, 353, 353, 353 };
						loc.HordeTable2 = new ushort[]		{ 307, 307, 307, 307, 307 };
						loc.HordeTable3 = new ushort[]		{ 37, 37, 37, 37, 37 };
						loc.HordeLevel = new int[]			{ 15, 15, 15 };
						loc.DexNavTable = new ushort[]		{ 605, 436, 58 };
						loc.DexNavLevel = 31;
						break;

					case 139:		// New Mauville
						loc.CaveTable = new ushort[]		{ 81, 81, 81, 81, 81, 100, 100, 100, 100, 100, 100, 100 };
						loc.WildLevel = new int[]			{ 22, 23, 24, 25, 25, 22, 23, 24, 25, 25, 25, 25 };
						loc.HordeTable1 = new ushort[]		{ 100, 100, 100, 100, 100 };
						loc.HordeTable2 = new ushort[]		{ 81, 81, 81, 81, 81 };
						loc.HordeTable3 = new ushort[]		{ 100, 100, 100, 100, 100 };
						loc.HordeLevel = new int[]			{ 12, 12, 12 };
						break;

					case 12:		// Pacifidlog Town
						loc.SurfTable = new ushort[]		{ 72, 279, 73, 279, 279 };
						loc.SurfLevel = new int[]			{ 25, 25, 30, 30, 35 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 320, 320 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						break;

					case 13:		// Petalburg City
						loc.SurfTable = new ushort[]		{ 183, 184, 283, 284, 184 };
						loc.SurfLevel = new int[]			{ 15, 20, 15, 25, 25 };
						loc.OldTable = new ushort[]			{ 129, 118, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 118, 341 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 341, 341, 341 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						break;

					case 82:		// Petalburg Woods
						loc.GrassTable = new ushort[]		{ 263, 263, 263, 265, 265, 265, 266, 268, 285, 276, 287, 287 };
						loc.WildLevel = new int[]			{ 4, 5, 6, 4, 5, 6, 6, 6, 5, 5, 5, 5 };
						loc.HordeTable1 = new ushort[]		{ 265, 265, 265, 265, 265 };
						loc.HordeTable2 = new ushort[]		{ 263, 263, 263, 263, 263 };
						loc.HordeTable3 = new ushort[]		{ 285, 285, 285, 285, 285 };
						loc.HordeLevel = new int[]			{ 3, 3, 3 };
						loc.DexNavTable = new ushort[]		{ 546, 46, 708 };
						loc.DexNavLevel = 6;
						break;

					case 23:		// Route 101
						loc.GrassTable = new ushort[]		{ 265, 265, 265, 265, 263, 263, 263, 263, 261, 261, 261, 261 };
						loc.WildLevel = new int[]			{ 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
						loc.HordeTable1 = new ushort[]		{ 263, 263, 263, 263, 263 };
						loc.HordeTable2 = new ushort[]		{ 263, 263, 263, 263, 263 };
						loc.HordeTable3 = new ushort[]		{ 261, 261, 261, 261, 261 };
						loc.HordeLevel = new int[]			{ 2, 2, 2 };
						loc.DexNavTable = new ushort[]		{ 506, 570, 540 };
						loc.DexNavLevel = 2;
						break;

					case 24:		// Route 102
						if (OmegaRuby)
						{
							loc.GrassTable = new ushort[]	{ 263, 263, 263, 265, 265, 265, 261, 261, 273, 273, 280, 283 };
						}
						else
						{
							loc.GrassTable = new ushort[]	{ 263, 263, 263, 265, 265, 265, 261, 261, 270, 270, 280, 283 };
						}
						loc.WildLevel = new int[]			{ 2, 3, 3, 2, 3, 3, 2, 3, 2, 3, 3, 3 };
						loc.HordeTable1 = new ushort[]		{ 263, 263, 263, 263, 263 };
						if (OmegaRuby)
						{
							loc.HordeTable2 = new ushort[]	{ 273, 273, 273, 273, 273 };
						}
						else
						{
							loc.HordeTable2 = new ushort[]	{ 270, 270, 270, 270, 270 };
						}
						loc.HordeTable3 = new ushort[]		{ 280, 280, 280, 280, 280 };
						loc.HordeLevel = new int[]			{ 2, 2, 2 };
						loc.SurfTable = new ushort[]		{ 183, 184, 283, 284, 184 };
						loc.SurfLevel = new int[]			{ 15, 20, 20, 25, 25 };
						loc.OldTable = new ushort[]			{ 129, 118, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 118, 341 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 341, 341, 341 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						loc.DexNavTable = new ushort[]		{ 506, 574, 535 };
						loc.DexNavLevel = 3;
						break;

					case 25:		// Route 103
						loc.GrassTable = new ushort[]		{ 263, 263, 263, 263, 261, 261, 261, 261, 278, 278, 278, 278 };
						loc.WildLevel = new int[]			{ 2, 2, 3, 3, 2, 2, 3, 3, 2, 3, 3, 3 };
						loc.HordeTable1 = new ushort[]		{ 263, 263, 263, 263, 263 };
						loc.HordeTable2 = new ushort[]		{ 261, 261, 261, 261, 261 };
						loc.HordeTable3 = new ushort[]		{ 278, 278, 278, 278, 278 };
						loc.HordeLevel = new int[]			{ 2, 2, 2 };
						loc.SurfTable = new ushort[]		{ 72, 278, 72, 279, 279 };
						loc.SurfLevel = new int[]			{ 20, 20, 25, 25, 30 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 320, 320 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						if (OmegaRuby)
						{
							loc.DexNavTable = new ushort[]	{ 506, 441, 422 };
						}
						else
						{
							loc.DexNavTable = new ushort[]	{ 506, 441, 723 };
						}
						loc.DexNavLevel = 3;
						break;

					case 26:		// Route 104 - North
						loc.GrassTable = new ushort[]		{ 263, 263, 263, 263, 265, 265, 265, 265, 276, 276, 278, 278 };
						loc.WildLevel = new int[]			{ 4, 5, 6, 7, 4, 5, 6, 7, 5, 7, 5, 7 };
						loc.HordeTable1 = new ushort[]		{ 263, 263, 263, 263, 263 };
						loc.HordeTable2 = new ushort[]		{ 263, 263, 263, 263, 263 };
						loc.HordeTable3 = new ushort[]		{ 276, 276, 276, 276, 276 };
						loc.HordeLevel = new int[]			{ 3, 3, 3 };
						loc.SurfTable = new ushort[]		{ 278, 278, 278, 279, 279 };
						loc.SurfLevel = new int[]			{ 15, 20, 20, 25, 25 };
						loc.OldTable = new ushort[]			{ 129, 129, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 129, 129 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 129, 129, 129 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						loc.DexNavTable = new ushort[]		{ 519, 540, 441 };
						loc.DexNavLevel = 7;
						break;

					case 27:		// Route 104 - South
						loc.GrassTable = new ushort[]		{ 263, 263, 263, 263, 265, 265, 265, 265, 278, 278, 276, 276 };
						loc.WildLevel = new int[]			{ 2, 3, 4, 5, 2, 3, 4, 5, 3, 5, 3, 5 };
						loc.HordeTable1 = new ushort[]		{ 263, 263, 263, 263, 263 };
						loc.HordeTable2 = new ushort[]		{ 263, 263, 263, 263, 263 };
						loc.HordeTable3 = new ushort[]		{ 278, 278, 278, 278, 278 };
						loc.HordeLevel = new int[]			{ 2, 2, 2 };
						loc.SurfTable = new ushort[]		{ 278, 278, 278, 279, 279 };
						loc.SurfLevel = new int[]			{ 15, 20, 20, 25, 25 };
						loc.OldTable = new ushort[]			{ 129, 129, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 129, 129 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 129, 129, 129 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						loc.DexNavTable = new ushort[]		{ 519, 441, 540 };
						loc.DexNavLevel = 5;
						break;

					case 28:		// Route 105
						loc.SurfTable = new ushort[]		{ 72, 278, 72, 279, 279 };
						loc.SurfLevel = new int[]			{ 20, 20, 25, 25, 30 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 320, 320 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						if (OmegaRuby)
						{
							loc.DexNavTable = new ushort[]	{ 592, 690, 98 };
						}
						else
						{
							loc.DexNavTable = new ushort[]	{ 592, 692, 98 };
						}
						loc.DexNavLevel = 25;
						break;

					case 29:		// Route 106
						loc.SurfTable = new ushort[]		{ 72, 278, 72, 279, 279 };
						loc.SurfLevel = new int[]			{ 20, 20, 25, 25, 30 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 320, 320 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						if (OmegaRuby)
						{
							loc.DexNavTable = new ushort[]	{ 592, 690, 98 };
						}
						else
						{
							loc.DexNavTable = new ushort[]	{ 592, 692, 98 };
						}
						loc.DexNavLevel = 25;
						break;

					case 30:		// Route 107
						loc.SurfTable = new ushort[]		{ 72, 278, 72, 279, 279 };
						loc.SurfLevel = new int[]			{ 20, 20, 25, 25, 30 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 320, 320 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						if (OmegaRuby)
						{
							loc.DexNavTable = new ushort[]	{ 592, 690, 98 };
						}
						else
						{
							loc.DexNavTable = new ushort[]	{ 592, 692, 98 };
						}
						loc.DexNavLevel = 25;
						break;

					case 64:		// Route 107 - Underwater
						loc.GrassTable = new ushort[]		{ 170, 170, 170, 170, 170, 366, 366, 366, 171, 171, 369, 369 };
						loc.WildLevel = new int[]			{ 25, 25, 25, 25, 25, 30, 30, 30, 30, 30, 30, 35 };
						break;

					case 31:		// Route 108
						loc.SurfTable = new ushort[]		{ 72, 278, 72, 279, 279 };
						loc.SurfLevel = new int[]			{ 20, 20, 25, 25, 30 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 320, 320 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						if (OmegaRuby)
						{
							loc.DexNavTable = new ushort[]	{ 592, 690, 98 };
						}
						else
						{
							loc.DexNavTable = new ushort[]	{ 592, 692, 98 };
						}
						loc.DexNavLevel = 25;
						break;

					case 32:		// Route 109
						loc.SurfTable = new ushort[]		{ 72, 278, 72, 279, 279 };
						loc.SurfLevel = new int[]			{ 20, 20, 25, 25, 30 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 320, 320 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						if (OmegaRuby)
						{
							loc.DexNavTable = new ushort[]	{ 592, 690, 98 };
						}
						else
						{
							loc.DexNavTable = new ushort[]	{ 592, 692, 98 };
						}
						loc.DexNavLevel = 25;
						break;

					case 33:		// Route 110
						if (OmegaRuby)
						{
							loc.GrassTable = new ushort[]	{ 309, 309, 309, 309, 263, 316, 43, 278, 312, 312, 100, 312 };
						}
						else
						{
							loc.GrassTable = new ushort[]	{ 309, 309, 309, 309, 263, 316, 43, 278, 311, 311, 100, 311 };
						}
						loc.WildLevel = new int[]			{ 10, 11, 12, 13, 13, 13, 13, 13, 11, 12, 13, 13 };
						loc.HordeTable1 = new ushort[]		{ 81, 81, 81, 81, 81 };
						if (OmegaRuby)
						{
							loc.HordeTable2 = new ushort[]	{ 312, 312, 312, 312, 312 };
						}
						else
						{
							loc.HordeTable2 = new ushort[]	{ 311, 311, 311, 311, 311 };
						}
						if (OmegaRuby)
						{
							loc.HordeTable3 = new ushort[]	{ 312, 312, 312, 311, 312 };
						}
						else
						{
							loc.HordeTable3 = new ushort[]	{ 311, 312, 311, 311, 311 };
						}
						loc.HordeLevel = new int[]			{ 6, 6, 6 };
						loc.SurfTable = new ushort[]		{ 72, 278, 72, 279, 279 };
						loc.SurfLevel = new int[]			{ 20, 20, 25, 25, 30 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 320, 320 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						if (OmegaRuby)
						{
							loc.DexNavTable = new ushort[]	{ 568, 441, 422 };
						}
						else
						{
							loc.DexNavTable = new ushort[]	{ 568, 441, 723 };
						}
						loc.DexNavLevel = 13;
						break;

					case 37:		// Route 111
						loc.SurfTable = new ushort[]		{ 183, 184, 283, 284, 184 };
						loc.SurfLevel = new int[]			{ 15, 20, 20, 25, 25 };
						loc.OldTable = new ushort[]			{ 129, 118, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 118, 339 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 339, 339, 339 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						loc.SmashTable = new ushort[]		{ 74, 74, 74, 74, 74 };
						loc.SmashLevel = new int[]			{ 13, 14, 15, 16, 16 };
						break;

					case 35:		// Route 111 - Desert
						loc.GrassTable = new ushort[]		{ 27, 27, 27, 27, 328, 328, 331, 331, 343, 343, 343, 343 };
						loc.WildLevel = new int[]			{ 20, 21, 22, 23, 20, 22, 21, 23, 21, 23, 23, 23 };
						loc.HordeTable1 = new ushort[]		{ 27, 27, 27, 27, 27 };
						loc.HordeTable2 = new ushort[]		{ 27, 27, 27, 27, 27 };
						loc.HordeTable3 = new ushort[]		{ 27, 27, 27, 27, 27 };
						loc.HordeLevel = new int[]			{ 11, 11, 11 };
						loc.DexNavTable = new ushort[]		{ 551, 557, 443 };
						loc.DexNavLevel = 23;
						break;

					case 38:		// Route 112 - North
						loc.GrassTable = new ushort[]		{ 322, 322, 322, 322, 322, 322, 66, 66, 66, 322, 66, 66 };
						loc.WildLevel = new int[]			{ 14, 15, 15, 16, 16, 17, 14, 15, 16, 17, 17, 17 };
						loc.HordeTable1 = new ushort[]		{ 322, 322, 322, 322, 322 };
						loc.HordeTable2 = new ushort[]		{ 66, 66, 66, 66, 66 };
						loc.HordeTable3 = new ushort[]		{ 322, 322, 322, 322, 322 };
						loc.HordeLevel = new int[]			{ 8, 8, 8 };
						if (OmegaRuby)
						{
							loc.DexNavTable = new ushort[]	{ 77, 538, 236 };
						}
						else
						{
							loc.DexNavTable = new ushort[]	{ 77, 539, 236 };
						}
						loc.DexNavLevel = 17;
						break;

					case 39:		// Route 112 - South
						loc.GrassTable = new ushort[]		{ 322, 322, 322, 322, 322, 322, 66, 66, 66, 66, 66, 66 };
						loc.WildLevel = new int[]			{ 13, 14, 14, 15, 15, 16, 13, 14, 15, 16, 16, 16 };
						loc.HordeTable1 = new ushort[]		{ 322, 322, 322, 322, 322 };
						loc.HordeTable2 = new ushort[]		{ 66, 66, 66, 66, 66 };
						loc.HordeTable3 = new ushort[]		{ 322, 322, 322, 322, 322 };
						loc.HordeLevel = new int[]			{ 8, 8, 8 };
						if (OmegaRuby)
						{
							loc.DexNavTable = new ushort[]	{ 77, 538, 236 };
						}
						else
						{
							loc.DexNavTable = new ushort[]	{ 77, 539, 236 };
						}
						loc.DexNavLevel = 16;
						break;

					case 40:		// Route 113
						loc.GrassTable = new ushort[]		{ 327, 327, 327, 327, 327, 327, 27, 27, 27, 27, 227, 227 };
						loc.WildLevel = new int[]			{ 15, 16, 16, 17, 17, 18, 15, 16, 17, 18, 16, 18 };
						loc.HordeTable1 = new ushort[]		{ 327, 327, 327, 327, 327 };
						loc.HordeTable2 = new ushort[]		{ 327, 327, 327, 327, 327 };
						loc.HordeTable3 = new ushort[]		{ 227, 227, 227, 227, 227 };
						loc.HordeLevel = new int[]			{ 9, 9, 9 };
						loc.DexNavTable = new ushort[]		{ 559, 707, 626 };
						loc.DexNavLevel = 18;
						break;

					case 41:		// Route 114
						if (OmegaRuby)
						{
							loc.GrassTable = new ushort[]	{ 333, 333, 333, 333, 274, 274, 274, 274, 335, 335, 335, 283 };
						}
						else
						{
							loc.GrassTable = new ushort[]	{ 333, 333, 333, 333, 271, 271, 271, 271, 336, 336, 336, 283 };
						}
						loc.WildLevel = new int[]			{ 16, 17, 18, 19, 16, 17, 18, 19, 17, 19, 19, 19 };
						loc.HordeTable1 = new ushort[]		{ 333, 333, 333, 333, 333 };
						if (OmegaRuby)
						{
							loc.HordeTable2 = new ushort[]	{ 273, 273, 273, 273, 273 };
						}
						else
						{
							loc.HordeTable2 = new ushort[]	{ 270, 270, 270, 333, 270 };
						}
						loc.HordeTable3 = new ushort[]		{ 333, 333, 333, 333, 333 };
						loc.HordeLevel = new int[]			{ 9, 9, 9 };
						loc.SurfTable = new ushort[]		{ 183, 184, 283, 284, 184 };
						loc.SurfLevel = new int[]			{ 15, 20, 20, 25, 25 };
						loc.OldTable = new ushort[]			{ 129, 118, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 118, 339 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 339, 339, 339 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						loc.SmashTable = new ushort[]		{ 74, 74, 74, 74, 74 };
						loc.SmashLevel = new int[]			{ 15, 10, 20, 5, 5 };
						loc.DexNavTable = new ushort[]		{ 451, 200, 535 };
						loc.DexNavLevel = 19;
						break;

					case 42:		// Route 115
						loc.GrassTable = new ushort[]		{ 333, 333, 333, 333, 276, 276, 276, 276, 278, 39, 39, 39 };
						loc.WildLevel = new int[]			{ 17, 18, 19, 20, 17, 18, 19, 20, 20, 18, 18, 20 };
						loc.HordeTable1 = new ushort[]		{ 333, 333, 333, 333, 333 };
						loc.HordeTable2 = new ushort[]		{ 333, 333, 333, 333, 333 };
						loc.HordeTable3 = new ushort[]		{ 333, 333, 333, 333, 333 };
						loc.HordeLevel = new int[]			{ 10, 10, 10 };
						loc.SurfTable = new ushort[]		{ 72, 278, 72, 279, 279 };
						loc.SurfLevel = new int[]			{ 20, 20, 25, 25, 30 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 320, 320 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						loc.DexNavTable = new ushort[]		{ 519, 200, 35 };
						loc.DexNavLevel = 20;
						break;

					case 43:		// Route 116
						loc.GrassTable = new ushort[]		{ 263, 263, 263, 293, 293, 293, 290, 290, 276, 276, 300, 300 };
						loc.WildLevel = new int[]			{ 6, 7, 8, 5, 6, 7, 6, 8, 6, 8, 8, 8 };
						loc.HordeTable1 = new ushort[]		{ 263, 263, 263, 263, 263 };
						loc.HordeTable2 = new ushort[]		{ 290, 290, 290, 290, 290 };
						loc.HordeTable3 = new ushort[]		{ 300, 300, 300, 300, 300 };
						loc.HordeLevel = new int[]			{ 4, 4, 4 };
						loc.DexNavTable = new ushort[]		{ 519, 595, 133 };
						loc.DexNavLevel = 8;
						break;

					case 44:		// Route 117
						if (OmegaRuby)
						{
							loc.GrassTable = new ushort[]	{ 263, 263, 263, 315, 315, 314, 314, 43, 183, 183, 313, 283 };
						}
						else
						{
							loc.GrassTable = new ushort[]	{ 263, 263, 263, 315, 315, 313, 313, 43, 183, 183, 314, 283 };
						}
						loc.WildLevel = new int[]			{ 12, 13, 14, 12, 14, 11, 13, 14, 11, 13, 14, 14 };
						loc.HordeTable1 = new ushort[]		{ 43, 43, 43, 43, 263 };
						loc.HordeTable2 = new ushort[]		{ 315, 315, 315, 315, 315 };
						loc.HordeTable3 = new ushort[]		{ 183, 183, 183, 183, 183 };
						loc.HordeLevel = new int[]			{ 7, 7, 7 };
						loc.SurfTable = new ushort[]		{ 183, 184, 283, 284, 184 };
						loc.SurfLevel = new int[]			{ 15, 20, 20, 25, 25 };
						loc.OldTable = new ushort[]			{ 129, 118, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 118, 341 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 341, 341, 342 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						loc.DexNavTable = new ushort[]		{ 19, 585, 535 };
						loc.DexNavLevel = 14;
						break;

					case 45:		// Route 118
						loc.GrassTable = new ushort[]		{ 264, 264, 264, 264, 309, 309, 309, 309, 278, 278, 352, 352 };
						loc.WildLevel = new int[]			{ 21, 22, 23, 24, 21, 22, 23, 24, 22, 24, 24, 24 };
						loc.LongTable = new ushort[]		{ 264, 264, 264, 309, 309, 309, 264, 309, 279, 279, 352, 352 };
						loc.HordeTable1 = new ushort[]		{ 309, 309, 309, 309, 309 };
						loc.HordeTable2 = new ushort[]		{ 278, 278, 278, 278, 278 };
						loc.HordeTable3 = new ushort[]		{ 352, 352, 352, 352, 352 };
						loc.HordeLevel = new int[]			{ 12, 12, 12 };
						loc.SurfTable = new ushort[]		{ 72, 278, 72, 279, 279 };
						loc.SurfLevel = new int[]			{ 20, 20, 25, 25, 30 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 318 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 318, 318, 319 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						loc.DexNavTable = new ushort[]		{ 20, 404, 190 };
						loc.DexNavLevel = 24;
						break;

					case 46:		// Route 119
						loc.LongTable = new ushort[]		{ 264, 264, 264, 264, 44, 44, 44, 44, 357, 357, 352, 352 };
						loc.WildLevel = new int[]			{ 22, 23, 24, 25, 22, 23, 24, 25, 23, 25, 25, 25 };
						loc.HordeTable1 = new ushort[]		{ 43, 43, 43, 43, 43 };
						loc.HordeTable2 = new ushort[]		{ 43, 43, 43, 43, 43 };
						loc.HordeTable3 = new ushort[]		{ 43, 43, 43, 43, 43 };
						loc.HordeLevel = new int[]			{ 12, 12, 12 };
						loc.SurfTable = new ushort[]		{ 72, 278, 72, 279, 279 };
						loc.SurfLevel = new int[]			{ 20, 20, 25, 25, 30 };
						loc.OldTable = new ushort[]			{ 129, 72, 349 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 318, 349 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 318, 319, 349 };
						loc.SuperLevel = new int[]			{ 35, 40, 35 };
						break;

					case 48:		// Route 120 - East
						loc.LongTable = new ushort[]		{ 264, 264, 264, 264, 44, 44, 44, 44, 357, 359, 352, 352 };
						loc.WildLevel = new int[]			{ 24, 25, 26, 27, 24, 25, 26, 27, 27, 27, 27, 27 };
						loc.HordeTable1 = new ushort[]		{ 43, 43, 43, 43, 43 };
						loc.HordeTable2 = new ushort[]		{ 183, 183, 183, 183, 183 };
						loc.HordeTable3 = new ushort[]		{ 352, 352, 352, 352, 352 };
						loc.HordeLevel = new int[]			{ 13, 13, 13 };
						loc.SurfTable = new ushort[]		{ 184, 283, 184, 284, 184 };
						loc.SurfLevel = new int[]			{ 20, 20, 25, 25, 30 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 339 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 339, 339, 339 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						break;

					case 49:		// Route 120 - West
						loc.LongTable = new ushort[]		{ 264, 264, 264, 264, 44, 44, 44, 44, 357, 359, 352, 352 };
						loc.WildLevel = new int[]			{ 24, 25, 26, 27, 24, 25, 26, 27, 27, 27, 27, 27 };
						loc.HordeTable1 = new ushort[]		{ 43, 43, 43, 43, 43 };
						loc.HordeTable2 = new ushort[]		{ 183, 183, 183, 183, 183 };
						loc.HordeTable3 = new ushort[]		{ 352, 352, 352, 352, 352 };
						loc.HordeLevel = new int[]			{ 13, 13, 13 };
						loc.SurfTable = new ushort[]		{ 184, 283, 184, 284, 184 };
						loc.SurfLevel = new int[]			{ 20, 20, 25, 25, 30 };
						loc.OldTable = new ushort[]			{ 129, 118, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 118, 339 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 339, 339, 339 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						break;

					case 50:		// Route 121
						loc.GrassTable = new ushort[]		{ 264, 264, 264, 353, 353, 353, 44, 44, 44, 279, 352, 352 };
						loc.WildLevel = new int[]			{ 28, 29, 30, 27, 28, 29, 28, 29, 30, 30, 30, 30 };
						loc.LongTable = new ushort[]		{ 264, 264, 264, 353, 353, 353, 44, 44, 44, 279, 352, 352 };
						loc.HordeTable1 = new ushort[]		{ 353, 353, 353, 353, 353 };
						loc.HordeTable2 = new ushort[]		{ 278, 278, 278, 278, 278 };
						loc.HordeTable3 = new ushort[]		{ 352, 352, 352, 352, 352 };
						loc.HordeLevel = new int[]			{ 15, 15, 15 };
						loc.DexNavTable = new ushort[]		{ 605, 97, 190 };
						loc.DexNavLevel = 30;
						break;

					case 51:		// Route 122
						loc.SurfTable = new ushort[]		{ 72, 278, 72, 279, 279 };
						loc.SurfLevel = new int[]			{ 20, 20, 25, 25, 30 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 320, 320 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						loc.DexNavTable = new ushort[]		{ 592, 456, 594 };
						loc.DexNavLevel = 25;
						break;

					case 52:		// Route 123
						loc.LongTable = new ushort[]		{ 264, 264, 264, 353, 353, 353, 44, 44, 44, 279, 352, 352 };
						loc.WildLevel = new int[]			{ 29, 30, 31, 28, 29, 30, 29, 30, 31, 31, 31, 31 };
						loc.HordeTable1 = new ushort[]		{ 353, 353, 353, 353, 353 };
						loc.HordeTable2 = new ushort[]		{ 278, 278, 278, 278, 278 };
						loc.HordeTable3 = new ushort[]		{ 352, 352, 352, 352, 352 };
						loc.HordeLevel = new int[]			{ 15, 15, 15 };
						loc.SurfTable = new ushort[]		{ 183, 283, 184, 284, 184 };
						loc.SurfLevel = new int[]			{ 20, 20, 25, 25, 30 };
						loc.OldTable = new ushort[]			{ 129, 118, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 118, 341 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 341, 341, 342 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						break;

					case 53:		// Route 124
						loc.SurfTable = new ushort[]		{ 72, 279, 73, 279, 279 };
						loc.SurfLevel = new int[]			{ 25, 25, 30, 30, 35 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 320, 320 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						loc.DexNavTable = new ushort[]		{ 592, 456, 594 };
						loc.DexNavLevel = 30;
						break;

					case 65:		// Route 124 - Underwater
						loc.GrassTable = new ushort[]		{ 170, 170, 170, 170, 170, 366, 366, 366, 171, 171, 369, 369 };
						loc.WildLevel = new int[]			{ 25, 25, 25, 25, 25, 30, 30, 30, 30, 30, 30, 35 };
						break;

					case 54:		// Route 125
						loc.SurfTable = new ushort[]		{ 72, 279, 73, 279, 279 };
						loc.SurfLevel = new int[]			{ 25, 25, 30, 30, 35 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 320, 320 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						loc.DexNavTable = new ushort[]		{ 592, 456, 86 };
						loc.DexNavLevel = 30;
						break;

					case 55:		// Route 126
						loc.SurfTable = new ushort[]		{ 72, 279, 73, 279, 279 };
						loc.SurfLevel = new int[]			{ 25, 25, 30, 30, 35 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 320, 320 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						loc.DexNavTable = new ushort[]		{ 592, 456, 594 };
						loc.DexNavLevel = 30;
						break;

					case 66:		// Route 126 - Underwater
						loc.GrassTable = new ushort[]		{ 170, 170, 170, 170, 170, 366, 366, 366, 171, 171, 369, 369 };
						loc.WildLevel = new int[]			{ 25, 25, 25, 25, 25, 30, 30, 30, 30, 30, 30, 35 };
						break;

					case 56:		// Route 127
						loc.SurfTable = new ushort[]		{ 72, 279, 73, 279, 279 };
						loc.SurfLevel = new int[]			{ 25, 25, 30, 30, 35 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 320, 320 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						loc.DexNavTable = new ushort[]		{ 592, 456, 594 };
						loc.DexNavLevel = 30;
						break;

					case 57:		// Route 128
						loc.SurfTable = new ushort[]		{ 72, 279, 73, 279, 279 };
						loc.SurfLevel = new int[]			{ 25, 25, 30, 30, 35 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 370, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 370, 320, 222 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						loc.DexNavTable = new ushort[]		{ 592, 456, 594 };
						loc.DexNavLevel = 30;
						break;

					case 68:		// Route 128 - Underwater
						loc.GrassTable = new ushort[]		{ 170, 170, 170, 170, 170, 366, 366, 366, 171, 171, 222, 369 };
						loc.WildLevel = new int[]			{ 25, 25, 25, 25, 25, 30, 30, 30, 30, 30, 30, 35 };
						break;

					case 58:		// Route 129
						loc.SurfTable = new ushort[]		{ 72, 279, 73, 279, 279 };
						loc.SurfLevel = new int[]			{ 25, 25, 30, 30, 35 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 320, 320 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						loc.DexNavTable = new ushort[]		{ 592, 456, 594 };
						loc.DexNavLevel = 30;
						break;

					case 69:		// Route 129 - Underwater
						loc.GrassTable = new ushort[]		{ 170, 170, 170, 170, 170, 366, 366, 366, 171, 171, 369, 369 };
						loc.WildLevel = new int[]			{ 25, 25, 25, 25, 25, 30, 30, 30, 30, 30, 30, 35 };
						break;

					case 59:		// Route 130
						loc.SurfTable = new ushort[]		{ 72, 279, 73, 279, 279 };
						loc.SurfLevel = new int[]			{ 25, 25, 30, 30, 35 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 116, 117 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						loc.DexNavTable = new ushort[]		{ 592, 456, 594 };
						loc.DexNavLevel = 30;
						break;

					case 70:		// Route 130 - Underwater
						loc.GrassTable = new ushort[]		{ 170, 170, 170, 170, 170, 366, 366, 366, 171, 171, 369, 369 };
						loc.WildLevel = new int[]			{ 25, 25, 25, 25, 25, 30, 30, 30, 30, 30, 30, 35 };
						break;

					case 60:		// Route 131
						loc.SurfTable = new ushort[]		{ 72, 279, 73, 279, 279 };
						loc.SurfLevel = new int[]			{ 25, 25, 30, 30, 35 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 116, 117 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						loc.DexNavTable = new ushort[]		{ 592, 456, 594 };
						loc.DexNavLevel = 30;
						break;

					case 61:		// Route 132
						loc.SurfTable = new ushort[]		{ 72, 279, 73, 279, 279 };
						loc.SurfLevel = new int[]			{ 25, 25, 30, 30, 35 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 116, 117 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						loc.DexNavTable = new ushort[]		{ 592, 456, 594 };
						loc.DexNavLevel = 30;
						break;

					case 62:		// Route 133
						loc.SurfTable = new ushort[]		{ 72, 279, 73, 279, 279 };
						loc.SurfLevel = new int[]			{ 25, 25, 30, 30, 35 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 116, 117 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						loc.DexNavTable = new ushort[]		{ 592, 456, 594 };
						loc.DexNavLevel = 30;
						break;

					case 63:		// Route 134
						loc.SurfTable = new ushort[]		{ 72, 278, 72, 279, 279 };
						loc.SurfLevel = new int[]			{ 20, 20, 25, 25, 30 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 116, 117 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						loc.DexNavTable = new ushort[]		{ 592, 456, 594 };
						loc.DexNavLevel = 30;
						break;

					case 75:		// Rusturf Tunnel
						loc.CaveTable = new ushort[]		{ 293, 293, 293, 293, 293, 293, 293, 293, 293, 293, 293, 293 };
						loc.WildLevel = new int[]			{ 7, 7, 8, 8, 8, 9, 9, 9, 10, 10, 10, 10 };
						loc.HordeTable1 = new ushort[]		{ 293, 293, 293, 293, 293 };
						loc.HordeTable2 = new ushort[]		{ 293, 293, 293, 293, 293 };
						loc.HordeTable3 = new ushort[]		{ 293, 293, 293, 293, 293 };
						loc.HordeLevel = new int[]			{ 5, 5, 5 };
						loc.SmashTable = new ushort[]		{ 74, 74, 74, 74, 74 };
						loc.SmashLevel = new int[]			{ 14, 15, 16, 17, 17 };
						break;

					case 222:		// Safari Zone - Area 1
						loc.GrassTable = new ushort[]		{ 54, 84, 84, 84, 54, 44, 44, 44, 25, 25, 25, 25 };
						loc.WildLevel = new int[]			{ 27, 28, 29, 30, 29, 28, 29, 30, 28, 30, 30, 30 };
						loc.LongTable = new ushort[]		{ 54, 84, 84, 84, 54, 44, 44, 44, 203, 203, 203, 203 };
						loc.HordeTable1 = new ushort[]		{ 84, 84, 84, 84, 84 };
						loc.HordeTable2 = new ushort[]		{ 43, 43, 43, 43, 43 };
						loc.HordeTable3 = new ushort[]		{ 54, 54, 54, 54, 54 };
						loc.HordeLevel = new int[]			{ 15, 15, 15 };
						loc.SurfTable = new ushort[]		{ 54, 54, 54, 54, 54 };
						loc.SurfLevel = new int[]			{ 20, 20, 25, 30, 30 };
						loc.OldTable = new ushort[]			{ 129, 118, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 118, 129 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 119, 119, 119 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						loc.DexNavTable = new ushort[]		{ 14, 427, 17 };
						loc.DexNavLevel = 30;
						break;

					case 221:		// Safari Zone - Area 2
						loc.GrassTable = new ushort[]		{ 54, 84, 84, 84, 54, 44, 44, 44, 178, 178, 178, 178 };
						loc.WildLevel = new int[]			{ 27, 28, 29, 30, 29, 28, 29, 30, 28, 30, 30, 30 };
						loc.LongTable = new ushort[]		{ 54, 84, 84, 84, 54, 44, 44, 44, 202, 202, 202, 202 };
						loc.HordeTable1 = new ushort[]		{ 84, 84, 84, 84, 84 };
						loc.HordeTable2 = new ushort[]		{ 43, 43, 43, 43, 43 };
						loc.HordeTable3 = new ushort[]		{ 54, 54, 54, 54, 54 };
						loc.HordeLevel = new int[]			{ 15, 15, 15 };
						loc.SurfTable = new ushort[]		{ 54, 54, 54, 54, 54 };
						loc.SurfLevel = new int[]			{ 20, 20, 25, 30, 30 };
						loc.OldTable = new ushort[]			{ 129, 118, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 118, 129 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 119, 119, 119 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						loc.DexNavTable = new ushort[]		{ 14, 427, 17 };
						loc.DexNavLevel = 30;
						break;

					case 219:		// Safari Zone - Area 3
						loc.GrassTable = new ushort[]		{ 54, 84, 84, 84, 54, 44, 44, 44, 111, 111, 111, 111 };
						loc.WildLevel = new int[]			{ 27, 28, 29, 30, 29, 28, 29, 30, 28, 30, 30, 30 };
						loc.LongTable = new ushort[]		{ 54, 84, 84, 84, 54, 44, 44, 44, 214, 214, 214, 214 };
						loc.HordeTable1 = new ushort[]		{ 84, 84, 84, 84, 84 };
						loc.HordeTable2 = new ushort[]		{ 43, 43, 43, 43, 43 };
						loc.HordeTable3 = new ushort[]		{ 54, 54, 54, 54, 54 };
						loc.HordeLevel = new int[]			{ 15, 15, 15 };
						loc.SurfTable = new ushort[]		{ 54, 54, 54, 54, 54 };
						loc.SurfLevel = new int[]			{ 20, 20, 25, 30, 30 };
						loc.OldTable = new ushort[]			{ 129, 118, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 118, 129 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 119, 119, 119 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						loc.DexNavTable = new ushort[]		{ 14, 17, 427 };
						loc.DexNavLevel = 30;
						break;

					case 220:		// Safari Zone - Area 4
						loc.GrassTable = new ushort[]		{ 54, 84, 84, 84, 54, 44, 44, 44, 232, 232, 232, 232 };
						loc.WildLevel = new int[]			{ 27, 28, 29, 30, 29, 28, 29, 30, 28, 30, 30, 30 };
						loc.LongTable = new ushort[]		{ 54, 84, 84, 84, 54, 44, 44, 44, 127, 127, 127, 127 };
						loc.HordeTable1 = new ushort[]		{ 84, 84, 84, 84, 84 };
						loc.HordeTable2 = new ushort[]		{ 43, 43, 43, 43, 43 };
						loc.HordeTable3 = new ushort[]		{ 54, 54, 54, 54, 54 };
						loc.HordeLevel = new int[]			{ 15, 15, 15 };
						loc.SurfTable = new ushort[]		{ 54, 54, 54, 54, 54 };
						loc.SurfLevel = new int[]			{ 20, 20, 25, 30, 30 };
						loc.OldTable = new ushort[]			{ 129, 118, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 118, 129 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 119, 119, 119 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						loc.DexNavTable = new ushort[]		{ 14, 17, 427 };
						loc.DexNavLevel = 30;
						break;

					case 164:		// Scorched Slab - 1F
						loc.CaveTable = new ushort[]		{ 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42 };
						loc.WildLevel = new int[]			{ 26, 26, 27, 27, 27, 28, 28, 28, 29, 29, 29, 29 };
						loc.SurfTable = new ushort[]		{ 41, 42, 42, 42, 42 };
						loc.SurfLevel = new int[]			{ 20, 25, 25, 30, 30 };
						loc.OldTable = new ushort[]			{ 129, 118, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 118, 339 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 339, 339, 339 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						break;

					case 165:		// Scorched Slab - B1F
						loc.CaveTable = new ushort[]		{ 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42 };
						loc.WildLevel = new int[]			{ 26, 26, 27, 27, 27, 28, 28, 28, 29, 29, 29, 29 };
						loc.HordeTable1 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeTable2 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeTable3 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeLevel = new int[]			{ 14, 14, 14 };
						loc.SurfTable = new ushort[]		{ 41, 42, 42, 42, 42 };
						loc.SurfLevel = new int[]			{ 20, 25, 25, 30, 30 };
						loc.OldTable = new ushort[]			{ 129, 118, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 10 };
						loc.GoodTable = new ushort[]		{ 129, 118, 339 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 339, 339, 339 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						break;

					case 166:		// Scorched Slab - B2F-BF3
						loc.CaveTable = new ushort[]		{ 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42 };
						loc.WildLevel = new int[]			{ 26, 26, 27, 27, 27, 28, 28, 28, 29, 29, 29, 29 };
						loc.HordeTable1 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeTable2 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeTable3 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeLevel = new int[]			{ 14, 14, 14 };
						break;

					case 146:		// Sea Mauville - Inside
						loc.SurfTable = new ushort[]		{ 72, 72, 72, 72, 72 };
						loc.SurfLevel = new int[]			{ 15, 15, 20, 20, 25 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 320, 320 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						break;

					case 145:		// Sea Mauville - Outside
						loc.SurfTable = new ushort[]		{ 72, 278, 72, 278, 279 };
						loc.SurfLevel = new int[]			{ 15, 15, 20, 20, 25 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 320, 320 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						break;

					case 100:		// Seafloor Cavern - 1, 2, 4
						loc.CaveTable = new ushort[]		{ 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42 };
						loc.WildLevel = new int[]			{ 33, 33, 34, 34, 34, 35, 35, 35, 36, 36, 36, 36 };
						loc.HordeTable1 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeTable2 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeTable3 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeLevel = new int[]			{ 18, 18, 18 };
						loc.SmashTable = new ushort[]		{ 75, 75, 75, 75, 75 };
						loc.SmashLevel = new int[]			{ 33, 34, 35, 36, 36 };
						break;

					case 104:		// Seafloor Cavern - 3, 7, 8, 9
						loc.CaveTable = new ushort[]		{ 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42 };
						loc.WildLevel = new int[]			{ 33, 33, 34, 34, 34, 35, 35, 35, 36, 36, 36, 36 };
						loc.HordeTable1 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeTable2 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeTable3 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeLevel = new int[]			{ 18, 18, 18 };
						break;

					case 102:		// Seafloor Cavern - 5, 6
						loc.CaveTable = new ushort[]		{ 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42 };
						loc.WildLevel = new int[]			{ 33, 33, 34, 34, 34, 35, 35, 35, 36, 36, 36, 36 };
						loc.HordeTable1 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeTable2 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeTable3 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeLevel = new int[]			{ 18, 18, 18 };
						loc.SurfTable = new ushort[]		{ 73, 42, 73, 42, 42 };
						loc.SurfLevel = new int[]			{ 25, 25, 30, 30, 35 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 10 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 320, 320 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						break;

					case 99:		// Seafloor Cavern - Entrance
						loc.SurfTable = new ushort[]		{ 42, 73, 73, 42, 42 };
						loc.SurfLevel = new int[]			{ 25, 30, 35, 30, 35 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 10, 5 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 30, 30, 30 };
						loc.SuperTable = new ushort[]		{ 320, 320, 320 };
						loc.SuperLevel = new int[]			{ 30, 35, 40 };
						break;

					case 162:		// Sealed Chamber
						loc.SurfTable = new ushort[]		{ 72, 41, 72, 42, 42 };
						loc.SurfLevel = new int[]			{ 20, 20, 25, 25, 30 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 116, 116 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						break;

					case 132:		// Shoal Cave - High tide
						loc.CaveTable = new ushort[]		{ 42, 42, 42, 42, 363, 363, 364, 364, 364, 364, 364, 364 };
						loc.WildLevel = new int[]			{ 31, 32, 33, 34, 31, 31, 32, 32, 33, 34, 34, 34 };
						loc.HordeTable1 = new ushort[]		{ 363, 363, 363, 363, 363 };
						loc.HordeTable2 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeTable3 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeLevel = new int[]			{ 17, 17, 17 };
						loc.SurfTable = new ushort[]		{ 72, 42, 73, 42, 42 };
						loc.SurfLevel = new int[]			{ 25, 25, 30, 30, 35 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 320, 320 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						loc.DexNavTable = new ushort[]		{ 613, 225, 87 };
						loc.DexNavLevel = 34;
						break;

					case 134:		// Shoal Cave - Ice room
						loc.CaveTable = new ushort[]		{ 363, 364, 364, 364, 361, 361, 361, 361, 42, 42, 42, 42 };
						loc.WildLevel = new int[]			{ 31, 32, 33, 34, 31, 32, 33, 34, 31, 32, 33, 34 };
						loc.HordeTable1 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeTable2 = new ushort[]		{ 363, 363, 363, 363, 363 };
						loc.HordeTable3 = new ushort[]		{ 361, 361, 361, 361, 361 };
						loc.HordeLevel = new int[]			{ 17, 17, 17 };
						break;

					case 130:		// Shoal Cave - Low tide
						loc.CaveTable = new ushort[]		{ 42, 42, 42, 42, 363, 363, 364, 364, 364, 364, 361, 361 };
						loc.WildLevel = new int[]			{ 31, 32, 33, 34, 31, 31, 32, 32, 33, 34, 34, 34 };
						loc.HordeTable1 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeTable2 = new ushort[]		{ 363, 363, 363, 363, 363 };
						loc.HordeTable3 = new ushort[]		{ 363, 363, 363, 363, 363 };
						loc.HordeLevel = new int[]			{ 17, 17, 17 };
						loc.SmashTable = new ushort[]		{ 75, 75, 75, 75, 75 };
						loc.SmashLevel = new int[]			{ 31, 32, 33, 34, 34 };
						loc.DexNavTable = new ushort[]		{ 613, 225, 87 };
						loc.DexNavLevel = 34;
						break;

					case 176:		// Sky Pillar
						if (OmegaRuby)
						{
							loc.CaveTable = new ushort[]	{ 42, 42, 42, 344, 344, 344, 168, 168, 168, 303, 303, 303 };
						}
						else
						{
							loc.CaveTable = new ushort[]	{ 42, 42, 42, 344, 344, 344, 168, 168, 168, 302, 302, 302 };
						}
						loc.WildLevel = new int[]			{ 44, 45, 46, 44, 45, 46, 44, 45, 46, 44, 45, 46 };
						loc.HordeTable1 = new ushort[]		{ 42, 42, 42, 42, 42 };
						loc.HordeTable2 = new ushort[]		{ 168, 168, 168, 168, 168 };
						loc.HordeTable3 = new ushort[]		{ 333, 333, 333, 333, 333 };
						loc.HordeLevel = new int[]			{ 23, 23, 23 };
						break;

					case 14:		// Slateport City
						loc.SurfTable = new ushort[]		{ 72, 278, 72, 279, 279 };
						loc.SurfLevel = new int[]			{ 20, 20, 25, 25, 30 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 320, 320 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						break;

					case 20:		// Sootopolis City
						loc.SurfTable = new ushort[]		{ 129, 129, 129, 129, 129 };
						loc.SurfLevel = new int[]			{ 30, 25, 35, 35, 35 };
						loc.OldTable = new ushort[]			{ 129, 129, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 129, 129 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 129, 129, 130 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						break;

					case 92:		// Team Magma/Aqua Hideout
						loc.SurfTable = new ushort[]		{ 72, 72, 72, 72, 72 };
						loc.SurfLevel = new int[]			{ 20, 20, 25, 25, 30 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 72, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 320, 320, 120 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						break;

					case 126:		// Victory Road - 2F
						loc.SurfTable = new ushort[]		{ 42, 42, 42, 42, 42 };
						loc.SurfLevel = new int[]			{ 25, 30, 35, 40, 40 };
						loc.OldTable = new ushort[]			{ 129, 118, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 118, 339 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 339, 339, 339 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
						break;

					case 123:		// Victory Road - Default
						if (OmegaRuby)
						{
							loc.CaveTable = new ushort[]	{ 42, 42, 297, 303, 305, 305, 294, 294, 308, 308, 297, 297 };
						}
						else
						{
							loc.CaveTable = new ushort[]	{ 42, 42, 297, 302, 305, 305, 294, 294, 308, 308, 297, 297 };
						}
						loc.WildLevel = new int[]			{ 37, 39, 38, 40, 37, 39, 37, 39, 38, 40, 40, 40 };
						loc.HordeTable1 = new ushort[]		{ 41, 41, 41, 41, 41 };
						loc.HordeTable2 = new ushort[]		{ 304, 304, 304, 304, 304 };
						loc.HordeTable3 = new ushort[]		{ 294, 294, 294, 294, 294 };
						loc.HordeLevel = new int[]			{ 20, 20, 20 };
						loc.SurfTable = new ushort[]		{ 72, 42, 73, 42, 42 };
						loc.SurfLevel = new int[]			{ 25, 30, 35, 40, 40 };
						loc.OldTable = new ushort[]			{ 129, 72, 129 };
						loc.OldLevel = new int[]			{ 10, 5, 15 };
						loc.GoodTable = new ushort[]		{ 129, 370, 320 };
						loc.GoodLevel = new int[]			{ 25, 25, 25 };
						loc.SuperTable = new ushort[]		{ 370, 320, 320 };
						loc.SuperLevel = new int[]			{ 35, 30, 40 };
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
