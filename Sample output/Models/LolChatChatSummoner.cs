using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChatChatSummoner
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }
    }
}
