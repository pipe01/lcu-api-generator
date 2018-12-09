using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCollectionsSummonerProfile
    {
        [JsonProperty("backgroundSkinId")]
        public int BackgroundSkinId { get; set; }
    }
}
