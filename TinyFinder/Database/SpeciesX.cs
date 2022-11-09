using System;
using System.Collections.Generic;
using System.Linq;

namespace TinyFinder
{
    internal class SpeciesX : LocationsXY
    {
        public static List<Location> WildLocationsX()
        {
            List<Location> locations = WildLocations();

            foreach (Location loc in locations)
            {
                switch (loc.Name)
                {
                    case "Ambrette Town":
                        loc.SurfTable = new ushort[] { 72, 320, 72, 72, 320, };
                        loc.OldTable = new ushort[] { 370, 370, 370, };
                        loc.GoodTable = new ushort[] { 692, 116, 692, };
                        loc.SuperTable = new ushort[] { 369, 693, 117, };
                        loc.SmashTable = new ushort[] { 557, 688, 557, 688, 557, };
                        break;

                    case "Azure Bay":
                        loc.GrassTable = new ushort[] { 79, 79, 79, 441, 441, 441, 79, 686, 102, 686, 441, 441, };
                        loc.HordeTable = new ushort[] { 278, 79, 102 };
                        loc.SurfTable = new ushort[] { 72, 72, 458, 72, 131, };
                        loc.OldTable = new ushort[] { 370, 370, 370, };
                        loc.GoodTable = new ushort[] { 223, 170, 223, };
                        loc.SuperTable = new ushort[] { 594, 224, 171, };
                        loc.SmashTable = new ushort[] { 557, 688, 557, 688, 557, };
                        break;

                    case "Connecting Cave":
                        loc.CaveTable = new ushort[] { 293, 293, 293, 307, 307, 307, 41, 41, 41, 610, 610, 610, };
                        loc.HordeTable = new ushort[] { 293, 41, 610, };
                        break;

                    case "Couriway Town":
                        loc.SurfTable = new ushort[] { 271, 419, 271, 419, 271, };
                        loc.OldTable = new ushort[] { 60, 60, 60, };
                        loc.GoodTable = new ushort[] { 725, 61, 725, };
                        loc.SuperTable = new ushort[] { 61, 550, 61, };
                        break;

                    case "Cyllage City":
                        loc.SurfTable = new ushort[] { 72, 320, 72, 72, 320, };
                        loc.OldTable = new ushort[] { 370, 370, 370, };
                        loc.GoodTable = new ushort[] { 692, 116, 692, };
                        loc.SuperTable = new ushort[] { 369, 693, 117, };
                        loc.SmashTable = new ushort[] { 557, 95, 557, 95, 95, };
                        break;

                    case "Frost Cavern":
                        loc.CaveTable = new ushort[] { 221, 221, 712, 712, 614, 614, 124, 124, 93, 93, 615, 93, }; 
                        loc.HordeTable = new ushort[] { 582, 613, 238, };
                        loc.SurfTable = new ushort[] { 61, 419, 61, 419, 61, };
                        loc.OldTable = new ushort[] { 60, 60, 60, };
                        loc.GoodTable = new ushort[] { 725, 61, 725, };
                        loc.SuperTable = new ushort[] { 61, 550, 61, };
                        break;

                    case "Laverre City":
                        loc.OldTable = new ushort[] { 60, 60, 60, };
                        loc.GoodTable = new ushort[] { 725, 61, 725, };
                        loc.SuperTable = new ushort[] { 61, 550, 61, };
                        break;

                    case "Santalune Forest":
                        loc.GrassTable = new ushort[] { 664, 664, 13, 13, 661, 511, 513, 515, 10, 25, 14, 25, };
                        break;

                    case "Terminus Cave":
                        loc.CaveTable = new ushort[] { 305, 305, 28, 28, 632, 632, 632, 632, 75, 75, 75, 75, };
                        loc.HordeTable = new ushort[] { 632, 74, 304, };
                        loc.SmashTable = new ushort[] { 75, 75, 75, 213, 213, };
                        break;

                    case "Glittering Cave":
                        //loc.CaveTable = new ushort[] { 66, 66, 66, 111, 95, 104, 104, 338, 337, 115, 303, 303, };
                        loc.SmashTable = new ushort[] { 557, 95, 557, 95, 95, };
                        break;

                    case "Reflection Cave":
                        loc.CaveTable = new ushort[] { 122, 122, 577, 577, 524, 524, 703, 433, 202, 433, 302, 302, };
                        loc.HordeTable = new ushort[] { 439, 524, 524, };
                        loc.HordeTable2 = new ushort[] { 0, 0, 703, };
                        break;

                    case "Lost Hotel":
                        loc.CaveTable = new ushort[] { 82, 82, 624, 624, 607, 607, 101, 101, 707, 707, 707, 707, };
                        break;

                    case "Parfum Palace":
                        loc.OldTable = new ushort[] { 129, 129, 129, };
                        loc.GoodTable = new ushort[] { 118, 341, 118, };
                        loc.SuperTable = new ushort[] { 130, 119, 342, };
                        break;

                    case "Route 2":
                        loc.GrassTable = new ushort[] { 659, 659, 263, 661, 661, 16, 664, 664, 13, 263, 16, 13, };
                        break;

                    case "Route 3":
                        loc.GrassTable = new ushort[] { 659, 659, 399, 399, 661, 661, 16, 412, 298, 206, 25, 25, };
                        loc.SurfTable = new ushort[] { 284, 183, 284, 183, 284, };
                        loc.OldTable = new ushort[] { 129, 129, 129, };
                        loc.GoodTable = new ushort[] { 118, 341, 118, };
                        loc.SuperTable = new ushort[] { 130, 119, 342, };
                        break;

                    case "Route 4":
                        loc.RedTable = new ushort[] { 669, 669, 669, 165, 165, 165, 406, 415, 300, 280, 727, 729, };
                        loc.YellowTable = new ushort[] { 726, 726, 726, 415, 415, 415, 406, 165, 300, 280, 727, 729, };
                        break;

                    case "Route 5":
                        loc.GrassTable = new ushort[] { 659, 659, 659, 676, 676, 674, 673, 84, 316, 63, 311, 311, };
                        loc.PurpleTable = new ushort[] { 673, 673, 673, 674, 674, 676, 659, 84, 316, 63, 311, 311, };
                        loc.HordeTable = new ushort[] { 316, 559, 311, };
                        break;

                    case "Route 6":
                        loc.LongTable = new ushort[] { 43, 43, 43, 161, 161, 290, 677, 677, 679, 679, 352, 352, };
                        break;

                    case "Route 7":
                        loc.GrassTable = new ushort[] { 453, 453, 453, 313, 314, 684, 235, 580, 315, 453, 727, 729, };
                        loc.YellowTable = new ushort[] { 726, 726, 726, 313, 314, 684, 235, 580, 315, 453, 727, 729, };
                        loc.PurpleTable = new ushort[] { 728, 728, 728, 313, 314, 684, 235, 580, 315, 453, 727, 729, };
                        loc.HordeTable = new ushort[] { 187, 54, 315, };
                        break;

                    case "Route 8":
                        loc.GrassTable = new ushort[] { 425, 425, 425, 325, 325, 359, 619, 686, 335, 686, 371, 371, };
                        loc.YellowTable = new ushort[] { 619, 619, 619, 359, 359, 325, 425, 686, 335, 686, 371, 371, };
                        loc.HordeTable = new ushort[] { 278, 335, 276, };
                        loc.SurfTable = new ushort[] { 72, 320, 72, 72, 320, };
                        loc.OldTable = new ushort[] { 370, 370, 370, };
                        loc.GoodTable = new ushort[] { 692, 120, 692, };
                        loc.SuperTable = new ushort[] { 211, 693, 121, };
                        loc.SmashTable = new ushort[] { 557, 688, 557, 688, 557, };
                        break;

                    case "Route 9":
                        loc.RideTable = new ushort[] { 551, 551, 551, 551, 449, 449, 449, 449, 694, 694, 694, 694, };
                        break;

                    case "Route 10":
                        loc.GrassTable = new ushort[] { 622, 622, 622, 561, 561, 701, 701, 209, 228, 133, 587, 587, };
                        loc.YellowTable = new ushort[] { 209, 209, 209, 228, 228, 133, 133, 622, 561, 701, 587, 587, };
                        loc.HordeTable = new ushort[] { 299, 193, 228, };
                        break;

                    case "Route 11":
                        loc.GrassTable = new ushort[] { 297, 297, 539, 539, 397, 397, 434, 433, 33, 30, 702, 702, };
                        loc.HordeTable = new ushort[] { 32, 434, 396, };
                        break;

                    case "Route 12":
                        loc.GrassTable = new ushort[] { 79, 79, 79, 441, 441, 441, 241, 128, 102, 127, 417, 417, };
                        loc.YellowTable = new ushort[] { 241, 241, 241, 128, 128, 128, 79, 441, 102, 127, 417, 417, };
                        loc.HordeTable = new ushort[] { 278, 179, 128, };
                        loc.SurfTable = new ushort[] { 72, 72, 458, 72, 131, };
                        loc.OldTable = new ushort[] { 370, 370, 370, };
                        loc.GoodTable = new ushort[] { 223, 366, 223, };
                        loc.SuperTable = new ushort[] { 222, 224, 367, };
                        loc.SmashTable = new ushort[] { 557, 688, 557, 688, 557, };
                        break;

                    case "Route 13":
                        loc.GrassTable = new ushort[] { 51, 51, 51, 51, 328, 328, 328, 328, 443, 443, 443, 443, };
                        loc.SmashTable = new ushort[] { 75, 218, 75, 218, 75, };
                        break;

                    case "Route 14":
                        loc.GrassTable = new ushort[] { 451, 451, 70, 70, 195, 704, 588, 616, 455, 93, 455, 455, };
                        loc.SwampTable = new ushort[] { 195, 195, 195, 704, 704, 618, 618, 588, 616, 93, 455, 455, };
                        loc.HordeTable = new ushort[] { 69, 451, 23, };
                        loc.SurfTable = new ushort[] { 195, 618, 704, 618, 618, };
                        loc.OldTable = new ushort[] { 60, 60, 60, };
                        loc.GoodTable = new ushort[] { 339, 61, 339, };
                        loc.SuperTable = new ushort[] { 61, 340, 61, };
                        break;

                    case "Route 15":
                        loc.GrassTable = new ushort[] { 262, 262, 262, 451, 451, 624, 505, 590, 590, 707, 707, 707, };
                        loc.RedTable = new ushort[] { 505, 505, 505, 624, 624, 451, 262, 590, 590, 707, 707, 707, };
                        loc.HordeTable = new ushort[] { 590, 198, 707, };
                        loc.SurfTable = new ushort[] { 271, 419, 271, 419, 271, };
                        loc.OldTable = new ushort[] { 60, 60, 60, };
                        loc.GoodTable = new ushort[] { 725, 61, 725, };
                        loc.SuperTable = new ushort[] { 61, 550, 61, };
                        break;

                    case "Route 16":
                        loc.LongTable = new ushort[] { 730, 730, 730, 710, 710, 731, 708, 590, 590, 707, 707, 732, };
                        loc.YellowTable = new ushort[] { 70, 70, 451, 451, 419, 419, 708, 590, 590, 707, 707, 707, };
                        loc.HordeTable = new ushort[] { 590, 198, 707, };
                        loc.SurfTable = new ushort[] { 271, 419, 271, 419, 271, };
                        loc.OldTable = new ushort[] { 60, 60, 60, };
                        loc.GoodTable = new ushort[] { 725, 61, 725, };
                        loc.SuperTable = new ushort[] { 61, 550, 61, };
                        break;

                    case "Route 17":
                        loc.RideTable = new ushort[] { 459, 459, 459, 215, 225, 225, 225, 225, 215, 215, 215, 460, };
                        break;

                    case "Route 18":
                        loc.GrassTable = new ushort[] { 533, 533, 533, 324, 324, 28, 305, 632, 75, 75, 631, 631, };
                        loc.RedTable = new ushort[] { 305, 305, 305, 28, 28, 324, 533, 632, 75, 75, 631, 631, };
                        loc.HordeTable = new ushort[] { 75, 632, 632, };
                        loc.SmashTable = new ushort[] { 75, 75, 75, 213, 213, };
                        break;

                    case "Route 19":
                        loc.YellowTable = new ushort[] { 195, 195, 195, 705, 705, 70, 452, 588, 616, 93, 455, 455, };
                        loc.PurpleTable = new ushort[] { 452, 452, 452, 70, 70, 705, 195, 588, 616, 93, 455, 455, };
                        loc.SwampTable = new ushort[] { 195, 195, 195, 705, 705, 618, 618, 588, 616, 93, 455, 455, };
                        loc.HordeTable = new ushort[] { 70, 207, 24, };
                        loc.SurfTable = new ushort[] { 195, 618, 705, 618, 705, };
                        loc.OldTable = new ushort[] { 60, 60, 60, };
                        loc.GoodTable = new ushort[] { 339, 61, 339, };
                        loc.SuperTable = new ushort[] { 61, 340, 186, };
                        break;

                    case "Route 20":
                        loc.GrassTable = new ushort[] { 164, 164, 164, 39, 39, 709, 576, 591, 591, 591, 571, 571, };
                        loc.RedTable = new ushort[] { 576, 576, 576, 709, 709, 39, 164, 591, 591, 591, 571, 571, };
                        loc.HordeTable = new ushort[] { 590, 709, 709, };
                        break;

                    case "Route 21":
                        loc.RedTable = new ushort[] { 217, 217, 217, 334, 334, 217, 327, 327, 419, 123, 123, 123, };
                        loc.PurpleTable = new ushort[] { 419, 419, 419, 334, 334, 419, 327, 327, 217, 123, 123, 123, };
                        loc.HordeTable = new ushort[] { 327, 333, 123, };
                        loc.SurfTable = new ushort[] { 271, 419, 271, 419, 271, };
                        loc.OldTable = new ushort[] { 60, 60, 60, };
                        loc.GoodTable = new ushort[] { 725, 61, 147, };
                        loc.SuperTable = new ushort[] { 61, 550, 148, };
                        break;

                    case "Route 22":
                        loc.GrassTable = new ushort[] { 659, 659, 667, 667, 54, 399, 298, 298, 83, 206, 447, 447, };
                        loc.YellowTable = new ushort[] { 400, 400, 54, 54, 667, 660, 184, 184, 83, 206, 447, 447, };
                        loc.SurfTable = new ushort[] { 54, 54, 54, 184, 184, };
                        loc.OldTable = new ushort[] { 129, 129, 129, };
                        loc.GoodTable = new ushort[] { 118, 318, 118, };
                        loc.SuperTable = new ushort[] { 130, 119, 319, };
                        break;


                    // The rods cannot be seperated depending on the location so we need to map ALL 3 of them every time
                    // for every location that supports them
                    case "Victory Road - Default":
                        loc.CaveTable = new ushort[] { 533, 533, 533, 621, 621, 93, 75, 75, 108, 108, 634, 634, };
                        loc.HordeTable = new ushort[] { 74, 75, 108, };
                        loc.SurfTable = new ushort[] { 61, 419, 61, 419, 61, };
                        loc.OldTable = new ushort[] { 60, 60, 60, };
                        loc.GoodTable = new ushort[] { 725, 61, 725, };
                        loc.SuperTable = new ushort[] { 61, 550, 61, };
                        loc.SmashTable = new ushort[] { 75, 75, 75, 213, 213, };
                        break;
                    case "Victory Road Inside 1/4":
                        loc.HordeTable = new ushort[] { 74, 419, 108, };
                        break;
                    case "Victory Road Outside":
                        loc.SurfTable = new ushort[] { 271, 419, 271, 419, 271, };
                        loc.OldTable = new ushort[] { 60, 60, 60, };
                        loc.GoodTable = new ushort[] { 725, 61, 725, };
                        loc.SuperTable = new ushort[] { 61, 550, 61, };
                        loc.SwoopingTable = new ushort[] { 22, 22, 22, 22, 22, 22, 22, 22, 227, 227, 635, 635, };
                        break;
                    case "Victory Road Exit":
                        loc.OldTable = new ushort[] { 60, 60, 60, };
                        loc.GoodTable = new ushort[] { 725, 61, 725, };
                        loc.SuperTable = new ushort[] { 61, 550, 62, };
                        break;


                    case "Pokemon Village":
                        loc.YellowTable = new ushort[] { 576, 576, 576, 132, 132, 39, 164, 591, 591, 571, 571, 571, };
                        loc.PurpleTable = new ushort[] { 164, 164, 164, 39, 39, 132, 576, 591, 591, 571, 571, 571, };
                        loc.HordeTable = new ushort[] { 590, 60, 271, };
                        loc.SurfTable = new ushort[] { 271, 61, 271, 61, 271, };
                        loc.OldTable = new ushort[] { 60, 60, 60, };
                        loc.GoodTable = new ushort[] { 725, 61, 725, };
                        loc.SuperTable = new ushort[] { 61, 550, 61, };
                        break;

                    case "Shalour City":
                        loc.SurfTable = new ushort[] { 72, 72, 458, 72, 458, };
                        loc.OldTable = new ushort[] { 370, 370, 370, };
                        loc.GoodTable = new ushort[] { 223, 170, 223, };
                        loc.SuperTable = new ushort[] { 594, 224, 171, };
                        break;

                }
            }

            return locations;

        }
    }
}
