using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChampSelectLegacyCollectionsChampion
    {
        [JsonProperty("freeToPlay")]
        public bool FreeToPlay { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("ownership")]
        public LolChampSelectLegacyCollectionsOwnership Ownership { get; set; }
    }
}
