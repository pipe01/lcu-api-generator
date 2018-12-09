using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolGeoinfoGeoInfo
    {
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("region")]
        public string Region { get; set; }
    }
}
