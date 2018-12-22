using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolGameflowQueueReward
    {
        [JsonProperty("isChampionPointsEnabled")]
        public bool IsChampionPointsEnabled { get; set; }
        [JsonProperty("isIpEnabled")]
        public bool IsIpEnabled { get; set; }
        [JsonProperty("isXpEnabled")]
        public bool IsXpEnabled { get; set; }
        [JsonProperty("partySizeIpRewards")]
        public int[] PartySizeIpRewards { get; set; }
    }
}
