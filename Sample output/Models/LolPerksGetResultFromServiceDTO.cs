using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPerksGetResultFromServiceDTO
    {
        [JsonProperty("error")]
        public string Error { get; set; }
        [JsonProperty("result")]
        public string Result { get; set; }
    }
}
