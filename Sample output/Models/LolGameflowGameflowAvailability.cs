//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolGameflowGameflowAvailability
    {
        [JsonProperty("isAvailable")]
        public bool IsAvailable { get; set; }
        [JsonProperty("state")]
        public LolGameflowGameflowAvailabilityState State { get; set; }
    }
}
