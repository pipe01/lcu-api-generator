using Newtonsoft.Json;

namespace LCU_API_Generator
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
