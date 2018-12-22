using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolHonorV2DynamicHonorMessage
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}
