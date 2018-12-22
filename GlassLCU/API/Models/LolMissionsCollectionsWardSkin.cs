using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMissionsCollectionsWardSkin
    {
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("ownership")]
        public LolMissionsCollectionsOwnership Ownership { get; set; }
    }
}
