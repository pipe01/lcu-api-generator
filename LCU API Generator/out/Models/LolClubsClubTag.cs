using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClubsClubTag
    {
        [JsonProperty("tag")]
        public string Tag { get; set; }
    }
}
