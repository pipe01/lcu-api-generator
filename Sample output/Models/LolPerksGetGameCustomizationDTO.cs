using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPerksGetGameCustomizationDTO
    {
        [JsonProperty("queueType")]
        public string QueueType { get; set; }
    }
}
