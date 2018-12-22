using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClubsPublicClubServiceTag
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("tag")]
        public string Tag { get; set; }
    }
}
