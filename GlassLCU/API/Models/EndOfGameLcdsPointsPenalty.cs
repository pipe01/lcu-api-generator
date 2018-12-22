using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class EndOfGameLcdsPointsPenalty
    {
        [JsonProperty("penalty")]
        public float Penalty { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
