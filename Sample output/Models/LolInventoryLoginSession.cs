//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolInventoryLoginSession
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("gasToken")]
        public object GasToken { get; set; }
        [JsonProperty("idToken")]
        public string IdToken { get; set; }
        [JsonProperty("puuid")]
        public string Puuid { get; set; }
        [JsonProperty("state")]
        public LolInventoryLoginSessionStates State { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
