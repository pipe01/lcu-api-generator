using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyLcdsPartyRewardsConfig
    {
        [JsonProperty("Enabled")]
        public bool Enabled { get; set; }
    }
}
