using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolAccountVerificationLoginSession
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("state")]
        public LolAccountVerificationLoginSessionState State { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("username")]
        public string Username { get; set; }
    }
}
