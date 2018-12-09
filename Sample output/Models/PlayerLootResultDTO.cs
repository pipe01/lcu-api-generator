using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class PlayerLootResultDTO
    {
        [JsonProperty("added")]
        public PlayerLootDTO[] Added { get; set; }
        [JsonProperty("details")]
        public string Details { get; set; }
        [JsonProperty("redeemed")]
        public string[] Redeemed { get; set; }
        [JsonProperty("removed")]
        public PlayerLootDTO[] Removed { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
