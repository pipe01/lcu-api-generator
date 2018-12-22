using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
