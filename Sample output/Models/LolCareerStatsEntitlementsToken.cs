using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCareerStatsEntitlementsToken
    {
        [JsonProperty("entitlements")]
        public string[] Entitlements { get; set; }
    }
}