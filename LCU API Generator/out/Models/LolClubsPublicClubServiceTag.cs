using Newtonsoft.Json;

namespace LCU_API_Generator
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
