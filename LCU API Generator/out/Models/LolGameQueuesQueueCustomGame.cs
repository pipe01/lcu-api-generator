using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolGameQueuesQueueCustomGame
    {
        [JsonProperty("gameServerRegions")]
        public string[] GameServerRegions { get; set; }
        [JsonProperty("queueAvailability")]
        public LolGameQueuesQueueAvailability QueueAvailability { get; set; }
        [JsonProperty("spectatorPolicies")]
        public LolGameQueuesQueueCustomGameSpectatorPolicy[] SpectatorPolicies { get; set; }
        [JsonProperty("spectatorSlotLimit")]
        public int SpectatorSlotLimit { get; set; }
        [JsonProperty("subcategories")]
        public LolGameQueuesQueueCustomGameSubcategory[] Subcategories { get; set; }
    }
}