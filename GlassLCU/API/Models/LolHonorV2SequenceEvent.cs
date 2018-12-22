using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolHonorV2SequenceEvent
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("priority")]
        public int Priority { get; set; }
    }
}
