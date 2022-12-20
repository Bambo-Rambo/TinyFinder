using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TinyFinder.Main
{
    internal class SortRowsTinyMT
    {
        public void SortRows(List<Index> list, string field, int direction)
        {
            try
            {
                switch (field)
                {
                    case "RTC":
                        list.Sort((x, y) => x.RTC.CompareTo(y.RTC) * direction);
                        break;
                    case "IndexValue":
                        list.Sort((x, y) => x.IndexValue.CompareTo(y.IndexValue) * direction);
                        break;
                    case "trainerID":
                        list.Sort((x, y) => x.trainerID.CompareTo(y.trainerID) * direction);
                        break;
                    case "secretID":
                        list.Sort((x, y) => x.secretID.CompareTo(y.secretID) * direction);
                        break;
                    case "TSV":
                        list.Sort((x, y) => x.TSV.CompareTo(y.TSV) * direction);
                        break;
                    case "TRV":
                        list.Sort((x, y) => x.TRV.CompareTo(y.TRV) * direction);
                        break;
                    case "randhex":
                        list.Sort((x, y) => x.randhex.CompareTo(y.randhex) * direction);
                        break;
                    case "encounter":   // Ratio
                        list.Sort((x, y) => x.encounter.CompareTo(y.encounter) * direction);
                        break;
                    case "slot":
                        list.Sort((x, y) => x.slot.CompareTo(y.slot) * direction);
                        break;
                    case "SpeciesName":
                        list.Sort((x, y) => x.SpeciesName.CompareTo(y.SpeciesName) * direction);
                        break;
                    case "flute":
                        list.Sort((x, y) => x.flute.CompareTo(y.flute) * direction);
                        break;
                    case "Level":
                        list.Sort((x, y) => x.Level.CompareTo(y.Level) * direction);
                        break;
                    case "item":
                        list.Sort((x, y) => x.item.CompareTo(y.item) * direction);
                        break;
                    case "ActualDelay":
                        list.Sort((x, y) => x.ActualDelay.CompareTo(y.ActualDelay) * direction);
                        break;
                    case "timeline":
                        list.Sort((x, y) => x.timeline.CompareTo(y.timeline) * direction);
                        break;
                    case "HordeHA":
                        list.Sort((x, y) => x.HordeHA.CompareTo(y.HordeHA) * direction);
                        break;
                    case "HordeFlutes":
                        list.Sort((x, y) => x.HordeFlutes.CompareTo(y.HordeFlutes) * direction);
                        break;
                    case "Music":
                        list.Sort((x, y) => x.Music.CompareTo(y.Music) * direction);
                        break;
                    case "right":
                        list.Sort((x, y) => x.right.CompareTo(y.right) * direction);
                        break;
                    case "up":
                        list.Sort((x, y) => x.up.CompareTo(y.up) * direction);
                        break;
                    case "Type":
                        list.Sort((x, y) => x.Type.CompareTo(y.Type) * direction);
                        break;
                    case "DexNavHA":
                        list.Sort((x, y) => x.DexNavHA.CompareTo(y.DexNavHA) * direction);
                        break;
                    case "potential":
                        list.Sort((x, y) => x.potential.CompareTo(y.potential) * direction);
                        break;
                    case "rand100":
                        list.Sort((x, y) => x.rand100.CompareTo(y.rand100) * direction);
                        break;
                    case "Tiny3":
                        list.Sort((x, y) => x.Tiny3.CompareTo(y.Tiny3) * direction);
                        break;
                    case "Tiny2":
                        list.Sort((x, y) => x.Tiny2.CompareTo(y.Tiny2) * direction);
                        break;
                    case "Tiny1":
                        list.Sort((x, y) => x.Tiny1.CompareTo(y.Tiny1) * direction);
                        break;
                    case "Tiny0":
                        list.Sort((x, y) => x.Tiny0.CompareTo(y.Tiny0) * direction);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Invalid request");
            }
        }
    }
}
