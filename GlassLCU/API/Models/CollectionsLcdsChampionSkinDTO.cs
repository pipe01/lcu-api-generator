using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class CollectionsLcdsChampionSkinDTO
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("endDate")]
        public long EndDate { get; set; }
        [JsonProperty("freeToPlayReward")]
        public bool FreeToPlayReward { get; set; }
        [JsonProperty("lastSelected")]
        public bool LastSelected { get; set; }
        [JsonProperty("owned")]
        public bool Owned { get; set; }
        [JsonProperty("purchaseDate")]
        public long PurchaseDate { get; set; }
        [JsonProperty("skinId")]
        public int SkinId { get; set; }
        [JsonProperty("sources")]
        public string[] Sources { get; set; }
        [JsonProperty("stillObtainable")]
        public bool StillObtainable { get; set; }
        [JsonProperty("winCountRemaining")]
        public int WinCountRemaining { get; set; }
    }
}
