using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
