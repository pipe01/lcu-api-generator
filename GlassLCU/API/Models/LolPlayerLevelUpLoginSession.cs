using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPlayerLevelUpLoginSession
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("state")]
        public LolPlayerLevelUpLoginSessionStates State { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
