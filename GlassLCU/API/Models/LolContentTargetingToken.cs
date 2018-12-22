using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolContentTargetingToken
    {
        [JsonProperty("entitlements")]
        public string[] Entitlements { get; set; }
    }
}
