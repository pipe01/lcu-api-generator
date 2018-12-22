using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashGameflowAvailability
    {
        [JsonProperty("isAvailable")]
        public bool IsAvailable { get; set; }
    }
}
