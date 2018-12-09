using Newtonsoft.Json;

namespace LCU_API_Generator
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
