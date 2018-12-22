using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
