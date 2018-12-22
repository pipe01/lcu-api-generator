using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyPartiesInvitationPlayerAnalytics
    {
        [JsonProperty("puuid")]
        public string Puuid { get; set; }
        [JsonProperty("role")]
        public string Role { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}