using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
