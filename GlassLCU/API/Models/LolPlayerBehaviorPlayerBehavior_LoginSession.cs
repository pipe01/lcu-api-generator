using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPlayerBehaviorPlayerBehavior_LoginSession
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("error")]
        public LolPlayerBehaviorPlayerBehavior_LoginError Error { get; set; }
        [JsonProperty("state")]
        public LolPlayerBehaviorPlayerBehavior_LoginSessionState State { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
