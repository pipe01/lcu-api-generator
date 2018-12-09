using Newtonsoft.Json;

namespace LCU_API_Generator
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
