using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolSuggestedPlayersSuggestedPlayersFriend
    {
        [JsonProperty("availability")]
        public string Availability { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
