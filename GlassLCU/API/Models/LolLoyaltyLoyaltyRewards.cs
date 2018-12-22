using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLoyaltyLoyaltyRewards
    {
        [JsonProperty("championIds")]
        public int[] ChampionIds { get; set; }
        [JsonProperty("freeRewardedChampionsCount")]
        public int FreeRewardedChampionsCount { get; set; }
        [JsonProperty("freeRewardedSkinsCount")]
        public int FreeRewardedSkinsCount { get; set; }
        [JsonProperty("global")]
        public LolLoyaltyGlobalRewards Global { get; set; }
        [JsonProperty("ipBoost")]
        public int IpBoost { get; set; }
        [JsonProperty("skinIds")]
        public int[] SkinIds { get; set; }
        [JsonProperty("xpBoost")]
        public int XpBoost { get; set; }
    }
}
