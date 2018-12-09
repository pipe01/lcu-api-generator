using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolContentTargetingPlatformConfig
    {
        [JsonProperty("ABTestFilterEnabled")]
        public bool ABTestFilterEnabled { get; set; }
        [JsonProperty("ABTestFilterGroups")]
        public long ABTestFilterGroups { get; set; }
        [JsonProperty("ABTestFilterSalt")]
        public long ABTestFilterSalt { get; set; }
        [JsonProperty("Enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("EntitlementsFilterEnabled")]
        public bool EntitlementsFilterEnabled { get; set; }
        [JsonProperty("EntitlementsPrefix")]
        public string EntitlementsPrefix { get; set; }
        [JsonProperty("LaneFilterEnabled")]
        public bool LaneFilterEnabled { get; set; }
        [JsonProperty("LaneFilterThreshold")]
        public int LaneFilterThreshold { get; set; }
        [JsonProperty("LevelFilterEnabled")]
        public bool LevelFilterEnabled { get; set; }
        [JsonProperty("LocationFiltersEnabled")]
        public bool LocationFiltersEnabled { get; set; }
        [JsonProperty("Mapping")]
        public string Mapping { get; set; }
        [JsonProperty("MasteryFilterChampionLimit")]
        public int MasteryFilterChampionLimit { get; set; }
        [JsonProperty("MasteryFilterDaysSinceLastPlayed")]
        public int MasteryFilterDaysSinceLastPlayed { get; set; }
        [JsonProperty("MasteryFilterEnabled")]
        public bool MasteryFilterEnabled { get; set; }
        [JsonProperty("MasteryFilterLevelThreshold")]
        public int MasteryFilterLevelThreshold { get; set; }
        [JsonProperty("RankFilterEnabled")]
        public bool RankFilterEnabled { get; set; }
        [JsonProperty("RankedFilterEnabled")]
        public bool RankedFilterEnabled { get; set; }
        [JsonProperty("RevivalFilterEnabled")]
        public bool RevivalFilterEnabled { get; set; }
        [JsonProperty("RevivalFilterThreshold")]
        public int RevivalFilterThreshold { get; set; }
    }
}
