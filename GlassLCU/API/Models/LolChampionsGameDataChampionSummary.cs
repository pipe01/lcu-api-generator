using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChampionsGameDataChampionSummary
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
