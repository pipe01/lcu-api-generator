using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RecofrienderLoginSession
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("gasToken")]
        public object GasToken { get; set; }
        [JsonProperty("idToken")]
        public string IdToken { get; set; }
        [JsonProperty("state")]
        public RecofrienderLoginSessionStates State { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
