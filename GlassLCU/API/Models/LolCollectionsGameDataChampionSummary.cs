using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolCollectionsGameDataChampionSummary
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
