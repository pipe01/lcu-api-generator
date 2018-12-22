using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyLcdsPartyRewardsConfig
    {
        [JsonProperty("Enabled")]
        public bool Enabled { get; set; }
    }
}
