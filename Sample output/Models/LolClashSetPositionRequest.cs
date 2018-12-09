using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashSetPositionRequest
    {
        [JsonProperty("position")]
        public Position Position { get; set; }
    }
}
