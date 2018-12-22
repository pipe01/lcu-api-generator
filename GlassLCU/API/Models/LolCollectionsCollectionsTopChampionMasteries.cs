using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolCollectionsCollectionsTopChampionMasteries
    {
        [JsonProperty("masteries")]
        public LolCollectionsCollectionsChampionMastery[] Masteries { get; set; }
        [JsonProperty("score")]
        public long Score { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
