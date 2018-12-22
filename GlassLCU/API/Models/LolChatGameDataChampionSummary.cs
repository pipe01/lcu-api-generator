using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChatGameDataChampionSummary
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}