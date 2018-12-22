using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolGeoinfoWhereAmIRequest
    {
        [JsonProperty("ipAddress")]
        public string IpAddress { get; set; }
    }
}
