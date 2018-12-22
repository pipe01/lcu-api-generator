using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
