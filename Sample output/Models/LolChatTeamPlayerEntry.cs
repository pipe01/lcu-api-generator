using Newtonsoft.Json;

namespace LCU_API_Generator
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
