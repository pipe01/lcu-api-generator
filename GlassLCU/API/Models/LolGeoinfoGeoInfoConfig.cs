using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolGeoinfoGeoInfoConfig
    {
        [JsonProperty("Enabled")]
        public bool Enabled { get; set; }
    }
}
