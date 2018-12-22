using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class CollectionsLcdsChampionDTO
    {
        [JsonProperty("active")]
        public bool Active { get; set; }
        [JsonProperty("botEnabled")]
        public bool BotEnabled { get; set; }
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("championSkins")]
        public CollectionsLcdsChampionSkinDTO[] ChampionSkins { get; set; }
        [JsonProperty("endDate")]
        public long EndDate { get; set; }
        [JsonProperty("freeToPlay")]
        public bool FreeToPlay { get; set; }
        [JsonProperty("freeToPlayReward")]
        public bool FreeToPlayReward { get; set; }
        [JsonProperty("owned")]
        public bool Owned { get; set; }
        [JsonProperty("purchaseDate")]
        public long PurchaseDate { get; set; }
        [JsonProperty("purchased")]
        public long Purchased { get; set; }
        [JsonProperty("rankedPlayEnabled")]
        public bool RankedPlayEnabled { get; set; }
        [JsonProperty("sources")]
        public string[] Sources { get; set; }
        [JsonProperty("winCountRemaining")]
        public int WinCountRemaining { get; set; }
    }
}