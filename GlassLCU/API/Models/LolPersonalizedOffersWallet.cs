using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPersonalizedOffersWallet
    {
        [JsonProperty("rp")]
        public long Rp { get; set; }
    }
}
