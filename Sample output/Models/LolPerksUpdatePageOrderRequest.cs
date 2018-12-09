using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPerksUpdatePageOrderRequest
    {
        [JsonProperty("destinationPageId")]
        public int DestinationPageId { get; set; }
        [JsonProperty("offset")]
        public int Offset { get; set; }
        [JsonProperty("targetPageId")]
        public int TargetPageId { get; set; }
    }
}
