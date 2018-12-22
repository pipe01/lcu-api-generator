using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLootCollectionsSummonerIcons
    {
        [JsonProperty("icons")]
        public int[] Icons { get; set; }
    }
}
