using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolGeoinfoWhereAmIRequest
    {
        [JsonProperty("ipAddress")]
        public string IpAddress { get; set; }
    }
}
