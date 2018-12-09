using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyCollectionsChampionMinimal
    {
        [JsonProperty("active")]
        public bool Active { get; set; }
        [JsonProperty("disabledQueues")]
        public string[] DisabledQueues { get; set; }
        [JsonProperty("freeToPlay")]
        public bool FreeToPlay { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("ownership")]
        public LolLobbyCollectionsOwnership Ownership { get; set; }
    }
}
