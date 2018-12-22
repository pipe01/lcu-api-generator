using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashSetPositionRequest
    {
        [JsonProperty("position")]
        public Position Position { get; set; }
    }
}
