using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyLcdsDynamicClientConfig
    {
        [JsonProperty("PartyRewards")]
        public LolLobbyLcdsPartyRewardsConfig PartyRewards { get; set; }
    }
}
