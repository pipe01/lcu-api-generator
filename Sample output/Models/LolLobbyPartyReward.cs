using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyPartyReward
    {
        [JsonProperty("premadeSize")]
        public int PremadeSize { get; set; }
        [JsonProperty("type")]
        public LolLobbyLobbyPartyRewardType Type { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
