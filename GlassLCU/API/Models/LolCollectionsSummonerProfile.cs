using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolCollectionsSummonerProfile
    {
        [JsonProperty("backgroundSkinId")]
        public int BackgroundSkinId { get; set; }
    }
}
