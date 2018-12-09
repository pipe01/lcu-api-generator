using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeRewardsLoginSeriesSettings
    {
        [JsonProperty("allRewardsClaimed")]
        public bool AllRewardsClaimed { get; set; }
        [JsonProperty("lastCompletedMissionDate")]
        public long LastCompletedMissionDate { get; set; }
        [JsonProperty("lastCompletedMissionInternalName")]
        public string LastCompletedMissionInternalName { get; set; }
    }
}
