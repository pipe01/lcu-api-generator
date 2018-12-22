using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolStoreBundled
    {
        [JsonProperty("flexible")]
        public bool Flexible { get; set; }
        [JsonProperty("items")]
        public LolStoreBundledItem[] Items { get; set; }
        [JsonProperty("minimumPrices")]
        public LolStoreBundledItemCost[] MinimumPrices { get; set; }
    }
}
