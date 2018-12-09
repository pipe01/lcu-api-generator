using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCollectionsCollectionsSummonerIcon
    {
        [JsonProperty("iconId")]
        public int IconId { get; set; }
        [JsonProperty("ownership")]
        public LolCollectionsCollectionsOwnership Ownership { get; set; }
    }
}
