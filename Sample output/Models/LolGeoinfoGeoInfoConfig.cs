using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolGeoinfoGeoInfoConfig
    {
        [JsonProperty("Enabled")]
        public bool Enabled { get; set; }
    }
}
