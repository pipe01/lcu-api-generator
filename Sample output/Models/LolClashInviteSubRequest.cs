using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashInviteSubRequest
    {
        [JsonProperty("replacedSummonerId")]
        public long ReplacedSummonerId { get; set; }
        [JsonProperty("substituteSummonerId")]
        public long SubstituteSummonerId { get; set; }
    }
}
