using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
