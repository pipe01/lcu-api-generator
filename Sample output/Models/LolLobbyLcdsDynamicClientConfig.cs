using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyLcdsDynamicClientConfig
    {
        [JsonProperty("PartyRewards")]
        public LolLobbyLcdsPartyRewardsConfig PartyRewards { get; set; }
    }
}