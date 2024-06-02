using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimitedHarvests
{
    public sealed class ModConfig
    {
        public bool GentleJunimos { get; set; }
        public bool AllowOverride { get; set; }
        public string HarvestCountMethod { get; set; }

        public string RandomizationSetting { get; set; }
        public int UpperRandModifier { get; set; }
        public int LowerRandModifier { get; set; }
        public int BaseHarvests { get; set; }

        public ModConfig()
        {
            GentleJunimos = false;
            AllowOverride = true;
            HarvestCountMethod = "Harvests per Season";

            RandomizationSetting = "None";
            UpperRandModifier = 2;
            LowerRandModifier = 2;
            BaseHarvests = 5;
        }
     }
}
