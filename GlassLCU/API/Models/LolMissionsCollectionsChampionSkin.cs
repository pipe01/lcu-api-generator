using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMissionsCollectionsChampionSkin
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("ownership")]
        public LolMissionsCollectionsOwnership Ownership { get; set; }
    }
}
