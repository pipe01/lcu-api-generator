using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolItemSetsGameDataChampion
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }
    }
}
