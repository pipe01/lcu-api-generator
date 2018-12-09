using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashSuggestedInvite
    {
        [JsonProperty("suggesterSummonerId")]
        public long SuggesterSummonerId { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
