using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPremadeVoiceEntitlementsToken
    {
        [JsonProperty("entitlements")]
        public string[] Entitlements { get; set; }
    }
}
