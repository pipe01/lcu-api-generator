using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPurchaseWidgetLoginSession
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("idToken")]
        public string IdToken { get; set; }
        [JsonProperty("state")]
        public LolPurchaseWidgetLoginSessionStates State { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}