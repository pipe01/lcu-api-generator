using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolStoreFeaturedPageDTO
    {
        [JsonProperty("Player")]
        public LolStorePlayer Player { get; set; }
    }
}
