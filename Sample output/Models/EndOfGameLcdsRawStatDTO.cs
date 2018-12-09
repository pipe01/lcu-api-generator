using Newtonsoft.Json;

namespace LCU_API_Generator
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
