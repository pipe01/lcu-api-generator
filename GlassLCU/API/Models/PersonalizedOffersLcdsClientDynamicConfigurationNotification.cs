using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PersonalizedOffersLcdsClientDynamicConfigurationNotification
    {
        [JsonProperty("configs")]
        public string Configs { get; set; }
        [JsonProperty("delta")]
        public bool Delta { get; set; }
    }
}
