using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolCareerStatsEntitlementsToken
    {
        [JsonProperty("entitlements")]
        public string[] Entitlements { get; set; }
    }
}
