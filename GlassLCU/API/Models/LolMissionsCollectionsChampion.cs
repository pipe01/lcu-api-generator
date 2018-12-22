using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMissionsCollectionsChampion
    {
        [JsonProperty("freeToPlay")]
        public bool FreeToPlay { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("ownership")]
        public LolMissionsCollectionsOwnership Ownership { get; set; }
        [JsonProperty("skins")]
        public LolMissionsCollectionsChampionSkin[] Skins { get; set; }
    }
}