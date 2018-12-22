using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class EndOfGameLcdsRawStatDTO
    {
        [JsonProperty("statTypeName")]
        public string StatTypeName { get; set; }
        [JsonProperty("value")]
        public long Value { get; set; }
    }
}
