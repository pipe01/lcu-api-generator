using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolGameSettingsLoginSession
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("gasToken")]
        public object GasToken { get; set; }
        [JsonProperty("state")]
        public LolGameSettingsLoginSessionStates State { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}