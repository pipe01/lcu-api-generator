using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRegaliaRegaliaLoadout
    {
        [JsonProperty("REGALIA_BANNER_SLOT")]
        public LolRegaliaItemKey REGALIA_BANNER_SLOT { get; set; }
        [JsonProperty("REGALIA_CREST_SLOT")]
        public LolRegaliaItemKey REGALIA_CREST_SLOT { get; set; }
    }
}
