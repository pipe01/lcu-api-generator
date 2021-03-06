//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class RecofrienderConfig
    {
        [JsonProperty("ContactDetailsUrlTemplate")]
        public string ContactDetailsUrlTemplate { get; set; }
        [JsonProperty("ContactsUrlTemplate")]
        public string ContactsUrlTemplate { get; set; }
        [JsonProperty("EnableSocial")]
        public bool EnableSocial { get; set; }
        [JsonProperty("EnabledNetworks")]
        public string[] EnabledNetworks { get; set; }
        [JsonProperty("ExternalCallTimeoutSeconds")]
        public long ExternalCallTimeoutSeconds { get; set; }
        [JsonProperty("FaqLink")]
        public string FaqLink { get; set; }
    }
}
