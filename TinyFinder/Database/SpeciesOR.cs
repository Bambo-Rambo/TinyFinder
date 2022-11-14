using System;
using System.Collections.Generic;
using System.Linq;

namespace TinyFinder
{
    internal class SpeciesOR : LocationsORAS
    {
        public static List<Location> WildLocationsOR()
        {
            List<Location> locations = WildLocations();

            foreach (Location loc in locations)
            {
                switch (loc.Name)
                {
                    case "Battle Resort":
                        loc.SurfTable = new ushort[] { 73, 458, 279, 279, 226, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 223, };
                        loc.SuperTable = new ushort[] { 223, 223, 224, };
                        break;

                    case "Cave of Origin":
                        loc.CaveTable = new ushort[] { 42, 303, 42, 42, 303, 42, 42, 303, 42, 42, 42, 303, };
                        loc.HordeTable = new ushort[] { 41, 41, 41, };
                        break;

                    case "Dewford Town":
                        loc.SurfTable = new ushort[] { 72, 278, 72, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 320, 320, };
                        break;

                    case "Ever Grande City":
                        loc.SurfTable = new ushort[] { 72, 279, 73, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 370, 320, };
                        loc.SuperTable = new ushort[] { 370, 320, 222, };
                        break;

                    case "Fiery Path":
                        loc.CaveTable = new ushort[] { 322, 322, 322, 322, 109, 109, 109, 218, 324, 66, 88, 88, };
                        loc.HordeTable = new ushort[] { 322, 109, 218, };
                        loc.DexNavTable = new ushort[] { 524, 50, 236, };
                        break;

                    case "Granite Cave - 1F":
                        loc.CaveTable = new ushort[] { 41, 41, 41, 41, 296, 296, 296, 296, 63, 63, 74, 74, };
                        loc.HordeTable = new ushort[] { 41, 296, 296, };
                        loc.DexNavTable = new ushort[] { 532, 610, 95, };
                        break;

                    case "Granite Cave - B1F":
                        loc.CaveTable = new ushort[] { 41, 41, 41, 304, 304, 304, 296, 296, 63, 63, 63, 63, };
                        loc.HordeTable = new ushort[] { 41, 304, 304, };
                        loc.DexNavTable = new ushort[] { 532, 610, 95, };
                        break;

                    case "Granite Cave - B2F":
                        loc.CaveTable = new ushort[] { 41, 41, 41, 304, 304, 304, 63, 63, 303, 303, 303, 303, };
                        loc.HordeTable = new ushort[] { 41, 304, 303, };
                        loc.SmashTable = new ushort[] { 74, 74, 299, 74, 74, };
                        loc.DexNavTable = new ushort[] { 532, 610, 95, };
                        break;

                    case "Jagged Pass":
                        loc.GrassTable = new ushort[] { 322, 322, 322, 322, 66, 66, 66, 66, 325, 325, 325, 325, };
                        loc.HordeTable = new ushort[] { 66, 325, 66, };
                        loc.DexNavTable = new ushort[] { 77, 56, 236, };
                        break;

                    case "Lilycove City":
                        loc.SurfTable = new ushort[] { 72, 278, 72, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 320, 120, };
                        loc.SmashTable = new ushort[] { 75, 75, 75, 75, 75, };
                        break;

                    case "Magma Hideout":
                        loc.SurfTable = new ushort[] { 72, 72, 72, 72, 72, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 320, 120, };
                        break;

                    case "Meteor Falls - Entrance":
                        loc.CaveTable = new ushort[] { 41, 41, 41, 41, 41, 41, 338, 338, 41, 41, 338, 338, };
                        loc.HordeTable = new ushort[] { 41, 41, 41, };
                        loc.SurfTable = new ushort[] { 41, 41, 338, 42, 338, };
                        loc.OldTable = new ushort[] { 129, 118, 129, };
                        loc.GoodTable = new ushort[] { 129, 118, 339, };
                        loc.SuperTable = new ushort[] { 339, 339, 339, };
                        loc.DexNavTable = new ushort[] { 633, 621, 35, };
                        break;

                    case "Meteor Falls - Not Entrance":
                        loc.CaveTable = new ushort[] { 42, 42, 42, 42, 42, 42, 338, 338, 42, 42, 338, 338, };
                        loc.HordeTable = new ushort[] { 41, 41, 41, };
                        loc.SurfTable = new ushort[] { 42, 42, 338, 338, 338, };
                        loc.OldTable = new ushort[] { 129, 118, 129, };
                        loc.GoodTable = new ushort[] { 129, 118, 339, };
                        loc.SuperTable = new ushort[] { 339, 339, 340, };
                        loc.DexNavTable = new ushort[] { 633, 621, 35, };
                        break;

                    case "Meteor Falls - Deep":
                        loc.CaveTable = new ushort[] { 42, 42, 42, 42, 371, 338, 338, 371, 371, 371, 338, 338, };
                        loc.HordeTable = new ushort[] { 41, 41, 371, };
                        loc.DexNavTable = new ushort[] { 633, 621, 35, };
                        break;

                    case "M. Cave - North of Fallarbor":
                        loc.CaveTable = new ushort[] { 602, 602, 602, 602, 602, 602, 79, 79, 79, 79, 79, 79, };
                        break;

                    case "M. Cave - North of Fortree":
                        loc.CaveTable = new ushort[] { 599, 599, 599, 602, 602, 602, 530, 530, 530, 95, 95, 95, };
                        loc.SmashTable = new ushort[] { 75, 75, 525, 75, 75, };
                        break;

                    case "M. Cave - North of 124":
                        loc.CaveTable = new ushort[] { 599, 599, 599, 599, 599, 599, 563, 563, 563, 563, 563, 563, };
                        loc.SmashTable = new ushort[] { 75, 75, 525, 75, 75, };
                        break;

                    case "M. Cave - North of 132":
                        loc.CaveTable = new ushort[] { 602, 602, 602, 530, 530, 530, 132, 132, 132, 132, 132, 132, };
                        break;

                    case "M. Cave - South of Pacifidlog":
                        loc.CaveTable = new ushort[] { 602, 602, 602, 602, 602, 602, 563, 563, 563, 79, 79, 79, };
                        break;

                    case "M. Cave - South of 107":
                        loc.CaveTable = new ushort[] { 201, 201, 201, 201, 201, 201, 201, 201, 201, 201, 201, 201, };
                        break;

                    case "M. Cave - West of Rustboro":
                        loc.CaveTable = new ushort[] { 599, 599, 599, 599, 599, 599, 602, 602, 602, 602, 602, 602, };
                        loc.SmashTable = new ushort[] { 75, 75, 525, 75, 75, };
                        break;

                    case "M. Cave - Southeast of 129":
                        loc.CaveTable = new ushort[] { 602, 602, 602, 602, 602, 602, 95, 95, 95, 95, 95, 95, };
                        loc.SmashTable = new ushort[] { 75, 75, 525, 75, 75, };
                        break;

                    case "M. Forest - East of Mossdeep":
                        loc.GrassTable = new ushort[] { 114, 114, 114, 431, 431, 431, 191, 191, 191, 572, 572, 572, };
                        break;

                    case "M. Forest - North of Lilycove":
                        loc.GrassTable = new ushort[] { 114, 114, 114, 432, 432, 432, 191, 191, 191, 421, 421, 421, };
                        break;

                    case "M. Forest - North of 111":
                        loc.GrassTable = new ushort[] { 402, 402, 402, 402, 402, 402, 636, 636, 636, 636, 636, 636, };
                        break;

                    case "M. Forest - West of 114":
                        loc.GrassTable = new ushort[] { 114, 114, 114, 432, 432, 432, 191, 191, 191, 548, 548, 548, };
                        break;

                    case "M. Forest - North of 124":
                        loc.GrassTable = new ushort[] { 114, 114, 114, 432, 432, 432, 191, 191, 191, 37, 37, 37, };
                        break;

                    case "M. Forest - West of 105":
                        loc.GrassTable = new ushort[] { 205, 205, 205, 205, 205, 205, 440, 440, 440, 440, 440, 440, };
                        loc.SmashTable = new ushort[] { 75, 75, 75, 75, 75, };
                        break;

                    case "M. Forest - South of 109":
                        loc.GrassTable = new ushort[] { 531, 531, 531, 531, 531, 531, 531, 531, 531, 191, 191, 191, };
                        break;

                    case "M. Forest - South of 132":
                        loc.GrassTable = new ushort[] { 191, 191, 191, 191, 191, 191, 548, 548, 548, 531, 531, 531, };
                        break;

                    case "M. Island - South of 132":
                        loc.GrassTable = new ushort[] { 517, 517, 517, 517, 517, 517, 132, 132, 132, 132, 132, 132, };
                        break;

                    case "M. Island - North of 113":
                        loc.GrassTable = new ushort[] { 555, 555, 555, 555, 555, 555, 636, 636, 636, 636, 636, 636, };
                        break;

                    case "M. Island - North of 124":
                        loc.GrassTable = new ushort[] { 49, 49, 49, 523, 523, 523, 178, 178, 178, 53, 53, 53, };
                        break;

                    case "M. Island - North of 125":
                        loc.GrassTable = new ushort[] { 432, 432, 432, 432, 432, 432, 137, 137, 137, 137, 137, 137, };
                        break;

                    case "M. Island - West of 104":
                        loc.GrassTable = new ushort[] { 49, 49, 49, 523, 523, 523, 178, 178, 178, 555, 555, 555, };
                        break;
                    case "M. Island - West of Dewford":
                        loc.GrassTable = new ushort[] { 49, 49, 49, 523, 523, 523, 178, 178, 178, 114, 114, 114, };
                        break;

                    case "M. Island - South of Pacifidlog":
                        loc.GrassTable = new ushort[] { 531, 531, 531, 531, 531, 531, 531, 531, 531, 178, 178, 178, };
                        loc.SmashTable = new ushort[] { 75, 75, 688, 75, 75, };
                        break;

                    case "M. Island - South of 134":
                        loc.GrassTable = new ushort[] { 49, 49, 49, 523, 523, 523, 178, 178, 178, 556, 556, 556, };
                        loc.SmashTable = new ushort[] { 75, 75, 688, 75, 75, };
                        break;

                    case "M. Mountain - North of 125":
                        loc.GrassTable = new ushort[] { 531, 531, 531, 531, 531, 531, 440, 440, 440, 114, 114, 114, };
                        loc.SmashTable = new ushort[] { 75, 75, 558, 75, 75, };
                        break;

                    case "M. Mountain - East of 125":
                        loc.GrassTable = new ushort[] { 555, 555, 555, 555, 555, 555, 240, 240, 240, 240, 240, 240, };
                        break;

                    case "M. Mountain - North of Lilycove":
                        loc.GrassTable = new ushort[] { 205, 205, 205, 232, 232, 232, 402, 402, 402, 627, 627, 627, };
                        break;

                    case "M. Mountain - Northeast of 125":
                        loc.GrassTable = new ushort[] { 205, 205, 205, 232, 232, 232, 402, 402, 402, 629, 629, 629, };
                        break;

                    case "M. Mountain - West of 104":
                        loc.GrassTable = new ushort[] { 205, 205, 205, 232, 232, 232, 402, 402, 402, 234, 234, 234, };
                        break;

                    case "M. Mountain - South of 129":
                        loc.GrassTable = new ushort[] { 523, 523, 523, 523, 523, 523, 239, 239, 239, 239, 239, 239, };
                        break;

                    case "M. Mountain - South of 131":
                        loc.GrassTable = new ushort[] { 205, 205, 205, 232, 232, 232, 402, 402, 402, 203, 203, 203, };
                        break;

                    case "M. Mountain - Southeast of 129":
                        loc.GrassTable = new ushort[] { 178, 178, 178, 178, 178, 178, 517, 517, 517, 137, 137, 137, };
                        loc.SmashTable = new ushort[] { 75, 75, 558, 75, 75, };
                        break;

                    case "Mossdeep City":
                        loc.SurfTable = new ushort[] { 72, 279, 73, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 320, 320, };
                        break;


                    case "Mt. Pyre - Inside":
                        loc.CaveTable = new ushort[] { 353, 355, 353, 353, 355, 353, 353, 355, 353, 353, 355, 355, };
                        loc.HordeTable = new ushort[] { 353, 353, 353, };
                        break;

                    case "Mt. Pyre - Outside":
                        loc.GrassTable = new ushort[] { 353, 353, 353, 353, 307, 307, 307, 307, 37, 37, 278, 278, };
                        loc.HordeTable = new ushort[] { 353, 307, 37, };
                        loc.DexNavTable = new ushort[] { 605, 436, 58, };
                        break;

                    case "Mt. Pyre - Summit":
                        loc.GrassTable = new ushort[] { 353, 353, 353, 353, 307, 307, 307, 307, 37, 37, 358, 358, };
                        //loc.HordeTable = new ushort[] { 353, 307, 37, };
                        //loc.DexNavTable = new ushort[] { 605, 436, 58, };
                        break;


                    case "New Mauville":
                        loc.CaveTable = new ushort[] { 81, 81, 81, 81, 81, 100, 100, 100, 100, 100, 100, 100, };
                        loc.HordeTable = new ushort[] { 100, 81, 100, };
                        break;

                    case "Pacifidlog Town":
                        loc.SurfTable = new ushort[] { 72, 279, 73, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 320, 320, };
                        break;

                    case "Petalburg City":
                        loc.SurfTable = new ushort[] { 183, 184, 283, 284, 184, };
                        loc.OldTable = new ushort[] { 129, 118, 129, };
                        loc.GoodTable = new ushort[] { 129, 118, 341, };
                        loc.SuperTable = new ushort[] { 341, 341, 341, };
                        break;

                    case "Petalburg Woods":
                        loc.GrassTable = new ushort[] { 263, 263, 263, 265, 265, 265, 266, 268, 285, 276, 287, 287, };
                        loc.HordeTable = new ushort[] { 265, 263, 285 };
                        loc.DexNavTable = new ushort[] { 546, 46, 708 };
                        break;


                    case "Route 101":
                        loc.GrassTable = new ushort[] { 265, 265, 265, 265, 263, 263, 263, 263, 261, 261, 261, 261, };
                        loc.HordeTable = new ushort[] { 263, 263, 261, };
                        loc.DexNavTable = new ushort[] { 506, 570, 540, };
                        break;

                    case "Route 102":
                        loc.GrassTable = new ushort[] { 263, 263, 263, 265, 265, 265, 261, 261, 273, 273, 280, 283, };
                        loc.HordeTable = new ushort[] { 263, 273, 280, };
                        loc.SurfTable = new ushort[] { 183, 184, 283, 284, 184, };
                        loc.OldTable = new ushort[] { 129, 118, 129, };
                        loc.GoodTable = new ushort[] { 129, 118, 341, };
                        loc.SuperTable = new ushort[] { 341, 341, 341, };
                        loc.DexNavTable = new ushort[] { 506, 574, 535, };
                        break;

                    case "Route 103":
                        loc.GrassTable = new ushort[] { 263, 263, 263, 263, 261, 261, 261, 261, 278, 278, 278, 278, };
                        loc.HordeTable = new ushort[] { 263, 261, 278, };
                        loc.SurfTable = new ushort[] { 72, 278, 72, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 320, 320, };
                        loc.DexNavTable = new ushort[] { 506, 441, 422, };
                        break;

                    case "Route 104 - North":
                        loc.GrassTable = new ushort[] { 263, 263, 263, 263, 265, 265, 265, 265, 276, 276, 278, 278, };
                        loc.HordeTable = new ushort[] { 263, 263, 278, };
                        loc.SurfTable = new ushort[] { 278, 278, 278, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 129, 129, };
                        loc.GoodTable = new ushort[] { 129, 129, 129, };
                        loc.SuperTable = new ushort[] { 129, 129, 129, };
                        loc.DexNavTable = new ushort[] { 519, 540, 441, };
                        break;

                    case "Route 104 - South":
                        loc.GrassTable = new ushort[] { 263, 263, 263, 263, 265, 265, 265, 265, 278, 278, 276, 276, };
                        loc.HordeTable = new ushort[] { 263, 263, 276, };
                        loc.SurfTable = new ushort[] { 278, 278, 278, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 129, 129, };
                        loc.GoodTable = new ushort[] { 129, 129, 129, };
                        loc.SuperTable = new ushort[] { 129, 129, 129, };
                        loc.DexNavTable = new ushort[] { 519, 441, 540, };
                        break;

                    case "Route 105":
                        loc.SurfTable = new ushort[] { 72, 278, 72, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 320, 320, };
                        loc.DexNavTable = new ushort[] { 592, 690, 98, };
                        break;

                    case "Route 106":
                        loc.SurfTable = new ushort[] { 72, 278, 72, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 320, 320, };
                        loc.DexNavTable = new ushort[] { 592, 690, 98, };
                        break;

                    case "Route 107":
                        loc.SurfTable = new ushort[] { 72, 278, 72, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 320, 320, };
                        loc.DexNavTable = new ushort[] { 592, 690, 98, };
                        break;

                    case "Route 108":
                        loc.SurfTable = new ushort[] { 72, 278, 72, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 320, 320, };
                        loc.DexNavTable = new ushort[] { 592, 690, 98, };
                        break;

                    case "Route 109":
                        loc.SurfTable = new ushort[] { 72, 278, 72, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 320, 320, };
                        loc.DexNavTable = new ushort[] { 592, 690, 98, };
                        break;

                    case "Route 110":
                        loc.GrassTable = new ushort[] { 309, 309, 309, 309, 263, 316, 43, 278, 312, 312, 100, 312, };
                        loc.HordeTable = new ushort[] { 81, 312, 312, };
                        loc.SurfTable = new ushort[] { 72, 278, 72, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 320, 320, };
                        loc.DexNavTable = new ushort[] { 568, 441, 422, };
                        break;

                    case "Route 111":
                        loc.SurfTable = new ushort[] { 183, 184, 283, 284, 184, };
                        loc.OldTable = new ushort[] { 129, 118, 129, };
                        loc.GoodTable = new ushort[] { 129, 118, 339, };
                        loc.SuperTable = new ushort[] { 339, 339, 339, };
                        loc.SmashTable = new ushort[] { 74, 74, 74, 74, 74, };
                        break;

                    case "Route 111 - Desert":
                        loc.GrassTable = new ushort[] { 27, 27, 27, 27, 328, 328, 331, 331, 343, 343, 343, 343, };
                        loc.HordeTable = new ushort[] { 27, 27, 27, };
                        loc.DexNavTable = new ushort[] { 551, 557, 443, };
                        break;

                    case "Route 112 - North":
                        loc.GrassTable = new ushort[] { 322, 322, 322, 322, 322, 322, 66, 66, 66, 322, 66, 66, };
                        loc.HordeTable = new ushort[] { 322, 66, 322, };
                        loc.DexNavTable = new ushort[] { 77, 538, 236, };
                        break;

                    case "Route 112 - South":
                        loc.GrassTable = new ushort[] { 322, 322, 322, 322, 322, 322, 66, 66, 66, 66, 66, 66, };
                        loc.HordeTable = new ushort[] { 322, 66, 322, };
                        break;

                    case "Route 113":
                        loc.GrassTable = new ushort[] { 327, 327, 327, 327, 327, 327, 27, 27, 27, 27, 227, 227, };
                        loc.HordeTable = new ushort[] { 327, 327, 227, };
                        loc.DexNavTable = new ushort[] { 559, 707, 626, };
                        break;

                    case "Route 114":
                        loc.GrassTable = new ushort[] { 333, 333, 333, 333, 274, 274, 274, 274, 335, 335, 335, 283, };
                        loc.HordeTable = new ushort[] { 333, 273, 333 };
                        loc.SurfTable = new ushort[] { 183, 184, 283, 284, 184, };
                        loc.OldTable = new ushort[] { 129, 118, 129, };
                        loc.GoodTable = new ushort[] { 129, 118, 339, };
                        loc.SuperTable = new ushort[] { 339, 339, 339, };
                        loc.SmashTable = new ushort[] { 74, 74, 74, 74, 74, };
                        loc.DexNavTable = new ushort[] { 451, 200, 535, };
                        break;

                    case "Route 115":
                        loc.GrassTable = new ushort[] { 333, 333, 333, 333, 276, 276, 276, 276, 278, 39, 39, 39, };
                        loc.HordeTable = new ushort[] { 333, 333, 333, };
                        loc.SurfTable = new ushort[] { 72, 278, 72, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 320, 320, };
                        loc.DexNavTable = new ushort[] { 519, 595, 133, };
                        break;

                    case "Route 116":
                        loc.GrassTable = new ushort[] { 263, 263, 263, 293, 293, 293, 290, 290, 276, 276, 300, 300, };
                        loc.HordeTable = new ushort[] { 263, 290, 300, };
                        loc.DexNavTable = new ushort[] { 519, 200, 35, };
                        break;

                    case "Route 117":
                        loc.GrassTable = new ushort[] { 263, 263, 263, 315, 315, 314, 314, 43, 183, 183, 313, 283, };
                        loc.HordeTable = new ushort[] { 43, 315, 183, };
                        loc.SurfTable = new ushort[] { 183, 184, 283, 284, 184, };
                        loc.OldTable = new ushort[] { 129, 118, 129, };
                        loc.GoodTable = new ushort[] { 129, 118, 341, };
                        loc.SuperTable = new ushort[] { 341, 341, 342, };
                        loc.DexNavTable = new ushort[] { 19, 585, 535, };
                        break;

                    case "Route 118":
                        loc.GrassTable = new ushort[] { 264, 264, 264, 264, 309, 309, 309, 309, 278, 278, 352, 352, };
                        loc.LongTable = new ushort[] { 264, 264, 264, 264, 309, 309, 309, 309, 279, 279, 352, 352, };
                        loc.HordeTable = new ushort[] { 309, 278, 352, };
                        loc.SurfTable = new ushort[] { 72, 278, 72, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 318, };
                        loc.SuperTable = new ushort[] { 318, 318, 319, };
                        loc.DexNavTable = new ushort[] { 20, 404, 190, };
                        break;

                    case "Route 119":
                        loc.LongTable = new ushort[] { 264, 264, 264, 264, 44, 44, 44, 44, 357, 357, 352, 352, };
                        loc.HordeTable = new ushort[] { 43, 43, 43 };
                        loc.SurfTable = new ushort[] { 72, 278, 72, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 349, };
                        loc.GoodTable = new ushort[] { 129, 318, 349, };
                        loc.SuperTable = new ushort[] { 318, 319, 349, };
                        break;

                    case "Route 119 - Feebas":
                        loc.OldTable = new ushort[] { 129, 72, 349, };
                        loc.GoodTable = new ushort[] { 349, 349, 349, };
                        loc.SuperTable = new ushort[] { 349, 349, 349, };
                        break;

                    case "Route 120 - East":
                        loc.LongTable = new ushort[] { 264, 264, 264, 264, 44, 44, 44, 44, 357, 359, 352, 352, };
                        loc.HordeTable = new ushort[] { 43, 183, 352, };
                        loc.SurfTable = new ushort[] { 184, 283, 184, 284, 184, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 339, };
                        loc.SuperTable = new ushort[] { 339, 339, 339, };
                        break;

                    case "Route 120 - West":
                        loc.LongTable = new ushort[] { 264, 264, 264, 264, 44, 44, 44, 44, 357, 359, 352, 352, };
                        loc.HordeTable = new ushort[] { 43, 183, 352, };
                        loc.SurfTable = new ushort[] { 184, 283, 184, 284, 184, };
                        loc.OldTable = new ushort[] { 129, 118, 129, };
                        loc.GoodTable = new ushort[] { 129, 118, 339, };
                        loc.SuperTable = new ushort[] { 339, 339, 339, };
                        break;

                    case "Route 121":
                        loc.GrassTable = new ushort[] { 264, 264, 264, 353, 353, 353, 44, 44, 44, 279, 352, 352, };
                        loc.LongTable = new ushort[] { 264, 264, 264, 353, 353, 353, 44, 44, 44, 279, 352, 352, };
                        loc.HordeTable = new ushort[] { 353, 278, 352, };
                        loc.DexNavTable = new ushort[] { 605, 97, 190, };
                        break;

                    case "Route 122":
                        loc.SurfTable = new ushort[] { 72, 278, 72, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 320, 320, };
                        loc.DexNavTable = new ushort[] { 592, 456, 594, };
                        break;

                    case "Route 123":
                        loc.LongTable = new ushort[] { 264, 264, 264, 353, 353, 353, 44, 44, 44, 279, 352, 352, };
                        loc.HordeTable = new ushort[] { 353, 278, 352, };
                        loc.SurfTable = new ushort[] { 183, 283, 184, 284, 184, };
                        loc.OldTable = new ushort[] { 129, 118, 129, };
                        loc.GoodTable = new ushort[] { 129, 118, 341, };
                        loc.SuperTable = new ushort[] { 341, 341, 342, };
                        loc.DexNavTable = new ushort[] { 592, 456, 594, };
                        break;

                    case "Route 124":
                        loc.SurfTable = new ushort[] { 72, 279, 73, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 320, 320, };
                        loc.DexNavTable = new ushort[] { 592, 456, 594, };
                        break;

                    case "Route 125":
                        loc.SurfTable = new ushort[] { 72, 279, 73, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 320, 320, };
                        loc.DexNavTable = new ushort[] { 592, 456, 86, };
                        break;

                    case "Route 126":
                        loc.SurfTable = new ushort[] { 72, 279, 73, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 320, 320, };
                        loc.DexNavTable = new ushort[] { 592, 456, 594, };
                        break;

                    case "Route 127":
                        loc.SurfTable = new ushort[] { 72, 279, 73, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 320, 320, };
                        loc.DexNavTable = new ushort[] { 592, 456, 594, };
                        break;

                    case "Route 128":
                        loc.SurfTable = new ushort[] { 72, 279, 73, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 370, 320, };
                        loc.SuperTable = new ushort[] { 370, 320, 222, };
                        loc.DexNavTable = new ushort[] { 592, 456, 594, };
                        break;

                    case "Route 129":
                        loc.SurfTable = new ushort[] { 72, 279, 73, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 320, 320, };
                        loc.DexNavTable = new ushort[] { 592, 456, 594, };
                        break;

                    case "Route 130":
                        loc.SurfTable = new ushort[] { 72, 279, 73, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 116, 117, };
                        loc.DexNavTable = new ushort[] { 592, 456, 594, };
                        break;

                    case "Route 131":
                        loc.SurfTable = new ushort[] { 72, 279, 73, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 116, 117, };
                        loc.DexNavTable = new ushort[] { 592, 456, 594, };
                        break;

                    case "Route 132":
                        loc.SurfTable = new ushort[] { 72, 279, 73, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 116, 117, };
                        loc.DexNavTable = new ushort[] { 592, 456, 594, };
                        break;

                    case "Route 133":
                        loc.SurfTable = new ushort[] { 72, 279, 73, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 116, 117, };
                        loc.DexNavTable = new ushort[] { 592, 456, 594, };
                        break;

                    case "Route 134":
                        loc.SurfTable = new ushort[] { 72, 278, 72, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 116, 117, };
                        loc.DexNavTable = new ushort[] { 592, 456, 594, };
                        break;


                    case "Rusturf Tunnel":
                        loc.GrassTable = new ushort[] { 293, 293, 293, 293, 293, 293, 293, 293, 293, 293, 293, 293, };
                        loc.HordeTable = new ushort[] { 293, 293, 293, };
                        loc.SmashTable = new ushort[] { 74, 74, 74, 74, 74, };
                        break;


                    case "Safari Zone Area 1":
                        loc.GrassTable = new ushort[] { 54, 84, 84, 84, 54, 44, 44, 44, 25, 25, 25, 25, };
                        loc.LongTable = new ushort[] { 54, 84, 84, 84, 54, 44, 44, 44, 203, 203, 203, 203, };
                        loc.HordeTable = new ushort[] { 84, 43, 54, };
                        loc.SurfTable = new ushort[] { 54, 54, 54, 54, 54, };
                        loc.OldTable = new ushort[] { 129, 118, 129, };
                        loc.GoodTable = new ushort[] { 129, 118, 129, };
                        loc.SuperTable = new ushort[] { 119, 119, 119, };
                        loc.DexNavTable = new ushort[] { 14, 427, 17 };
                        break;

                    case "Safari Zone - Area 2":
                        loc.GrassTable      = new ushort[] { 54, 84, 84, 84, 54, 44, 44, 44, 178, 178, 178, 178, };
                        loc.LongTable       = new ushort[] { 54, 84, 84, 84, 54, 44, 44, 44, 202, 202, 202, 202, };
                        loc.HordeTable      = new ushort[] { 84, 43, 54, };
                        loc.SurfTable       = new ushort[] { 54, 54, 54, 54, 54, };
                        loc.OldTable        = new ushort[] { 129, 118, 129, };
                        loc.GoodTable       = new ushort[] { 129, 118, 129, };
                        loc.SuperTable      = new ushort[] { 119, 119, 119, };
                        loc.DexNavTable     = new ushort[] { 14, 427, 17 };
                        break;

                    case "Safari Zone - Area 3":
                        loc.GrassTable = new ushort[] { 54, 84, 84, 84, 54, 44, 44, 44, 111, 111, 111, 111, };
                        loc.LongTable = new ushort[] { 54, 84, 84, 84, 54, 44, 44, 44, 214, 214, 214, 214, };
                        loc.HordeTable = new ushort[] { 84, 43, 54, };
                        loc.SurfTable = new ushort[] { 54, 54, 54, 54, 54, };
                        loc.OldTable = new ushort[] { 129, 118, 129, };
                        loc.GoodTable = new ushort[] { 129, 118, 129, };
                        loc.SuperTable = new ushort[] { 119, 119, 119, };
                        loc.DexNavTable = new ushort[] { 14, 427, 17 };
                        break;

                    case "Safari Zone - Area 4":
                        loc.GrassTable = new ushort[] { 54, 84, 84, 84, 54, 44, 44, 44, 232, 232, 232, 232, };
                        loc.LongTable = new ushort[] { 54, 84, 84, 84, 54, 44, 44, 44, 127, 127, 127, 127, };
                        loc.HordeTable = new ushort[] { 84, 43, 54, };
                        loc.SurfTable = new ushort[] { 54, 54, 54, 54, 54, };
                        loc.OldTable = new ushort[] { 129, 118, 129, };
                        loc.GoodTable = new ushort[] { 129, 118, 129, };
                        loc.SuperTable = new ushort[] { 119, 119, 119, };
                        loc.DexNavTable = new ushort[] { 14, 427, 17 };
                        break;

                    case "Scorched Slab":
                        loc.CaveTable = new ushort[] { 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, };
                        loc.HordeTable = new ushort[] { 41, 41, 41, };
                        loc.SurfTable = new ushort[] { 41, 42, 42, 42, 42, };
                        loc.OldTable = new ushort[] { 129, 118, 129, };
                        loc.GoodTable = new ushort[] { 129, 118, 339, };
                        loc.SuperTable = new ushort[] { 339, 339, 339, };
                        break;

                    case "Sea Mauville - Outside":
                        loc.SurfTable = new ushort[] { 72, 278, 72, 278, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 320, 320, };
                        break;

                    case "Sea Mauville - Inside":
                        loc.SurfTable = new ushort[] { 72, 72, 72, 72, 72, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 320, 320, };
                        break;

                    case "Sealed Chamber":
                        loc.SurfTable = new ushort[] { 72, 41, 72, 42, 42, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 116, 116, };
                        break;

                    case "Seafloor Cavern":
                        loc.SurfTable = new ushort[] { 42, 73, 73, 42, 42, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 320, 320, };
                        break;

                    case "Seafloor Cavern - Inside":
                        loc.CaveTable = new ushort[] { 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, 42, };
                        loc.HordeTable = new ushort[] { 41, 41, 41, };
                        loc.SurfTable = new ushort[] { 73, 42, 73, 42, 42, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 320, 320, };
                        loc.SmashTable = new ushort[] { 75, 75, 75, 75, 75, };
                        break;

                    case "Shoal Cave - Low tide":
                        loc.CaveTable = new ushort[] { 42, 42, 42, 42, 363, 363, 364, 364, 364, 364, 361, 361, };
                        loc.HordeTable = new ushort[] { 41, 363, 363, };
                        loc.SmashTable = new ushort[] { 75, 75, 75, 75, 75, };
                        loc.DexNavTable = new ushort[] { 613, 225, 87 };
                        break;

                    case "Shoal Cave - High tide":
                        loc.CaveTable = new ushort[] { 42, 42, 42, 42, 363, 363, 364, 364, 364, 364, 364, 364, };
                        loc.HordeTable = new ushort[] { 363, 41, 41, };
                        loc.SurfTable = new ushort[] { 72, 42, 73, 42, 42, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 320, 320, };
                        loc.DexNavTable = new ushort[] { 613, 225, 87 };
                        break;

                    case "Shoal Cave - Frozen area":
                        loc.CaveTable = new ushort[] { 363, 364, 364, 364, 361, 361, 361, 361, 42, 42, 42, 42, };
                        loc.HordeTable = new ushort[] { 41, 363, 361, };
                        break;


                    case "Sky Pillar":
                        loc.CaveTable = new ushort[] { 42, 42, 42, 344, 344, 344, 168, 168, 168, 303, 303, 303, };
                        loc.HordeTable = new ushort[] { 42, 168, 333, };
                        break;

                    case "Slateport City":
                        loc.SurfTable = new ushort[] { 72, 278, 72, 279, 279, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 72, 320, };
                        loc.SuperTable = new ushort[] { 320, 320, 320, };
                        break;

                    case "Sootopolis City":
                        loc.SurfTable = new ushort[] { 129, 129, 129, 129, 129, };
                        loc.OldTable = new ushort[] { 129, 129, 129, };
                        loc.GoodTable = new ushort[] { 129, 129, 129, };
                        loc.SuperTable = new ushort[] { 129, 129, 130, };
                        break;

                    case "Underwater - Route 128":
                        loc.SurfTable = new ushort[] { 170, 366, 171, 222, 369, };
                        break;

                    case "Underwater - Elsewhere":
                        loc.SurfTable = new ushort[] { 170, 366, 171, 369, 369, };
                        break;

                    case "Victory Road - Default":
                        loc.CaveTable = new ushort[] { 42, 42, 297, 303, 305, 305, 294, 294, 308, 308, 297, 297, };
                        loc.HordeTable = new ushort[] { 41, 304, 294, };
                        loc.SurfTable = new ushort[] { 72, 42, 73, 42, 42, };
                        loc.OldTable = new ushort[] { 129, 72, 129, };
                        loc.GoodTable = new ushort[] { 129, 370, 320, };
                        loc.SuperTable = new ushort[] { 370, 320, 320, };
                        break;

                    case "Victory Road - 2F":
                        loc.CaveTable = new ushort[] { 42, 42, 297, 303, 305, 305, 294, 294, 308, 308, 297, 297, };
                        loc.SurfTable = new ushort[] { 42, 42, 42, 42, 42, };
                        loc.OldTable = new ushort[] { 129, 118, 129, };
                        loc.GoodTable = new ushort[] { 129, 118, 339, };
                        loc.SuperTable = new ushort[] { 339, 339, 339, };
                        break;

                }
            }

            return locations;

        }
    }
}
