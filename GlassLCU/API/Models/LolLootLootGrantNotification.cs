using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLootLootGrantNotification
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("lootName")]
        public string LootName { get; set; }
        [JsonProperty("messageKey")]
        public string MessageKey { get; set; }
        [JsonProperty("msgId")]
        public string MsgId { get; set; }
        [JsonProperty("playerGrade")]
        public string PlayerGrade { get; set; }
        [JsonProperty("playerId")]
        public long PlayerId { get; set; }
    }
}