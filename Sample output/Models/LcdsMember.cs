using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LcdsMember
    {
        [JsonProperty("hasDelegatedInvitePower")]
        public bool HasDelegatedInvitePower { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }
    }
}
