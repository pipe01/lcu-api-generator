using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCollectionsCollectionsSummonerBackdrop
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("backdropImage")]
        public string BackdropImage { get; set; }
        [JsonProperty("backdropMaskColor")]
        public string BackdropMaskColor { get; set; }
        [JsonProperty("backdropType")]
        public LolCollectionsCollectionsSummonerBackdropType BackdropType { get; set; }
        [JsonProperty("backdropVideo")]
        public string BackdropVideo { get; set; }
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }
        [JsonProperty("puuid")]
        public string Puuid { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}