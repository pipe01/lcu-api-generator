using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolSuggestedPlayersSuggestedPlayersQueue
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("minLevel")]
        public int MinLevel { get; set; }
    }
}
