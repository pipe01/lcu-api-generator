using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPerksGetGameCustomizationDTO
    {
        [JsonProperty("queueType")]
        public string QueueType { get; set; }
    }
}
