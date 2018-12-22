using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMatchHistoryMatchHistoryPlayerChampMasteryDelta
    {
        [JsonProperty("grade")]
        public string Grade { get; set; }
    }
}
