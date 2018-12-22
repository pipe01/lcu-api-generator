using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
