using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChatTeamPlayerEntry
    {
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("summonerInternalName")]
        public string SummonerInternalName { get; set; }
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }
    }
}
