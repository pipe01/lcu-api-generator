//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChampSelectLegacyTeamBoost
    {
        [JsonProperty("availableSkins")]
        public long[] AvailableSkins { get; set; }
        [JsonProperty("ipReward")]
        public long IpReward { get; set; }
        [JsonProperty("ipRewardForPurchaser")]
        public long IpRewardForPurchaser { get; set; }
        [JsonProperty("price")]
        public long Price { get; set; }
        [JsonProperty("skinUnlockMode")]
        public string SkinUnlockMode { get; set; }
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }
        [JsonProperty("unlocked")]
        public bool Unlocked { get; set; }
    }
}
