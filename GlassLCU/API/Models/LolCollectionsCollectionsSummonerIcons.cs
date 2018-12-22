using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolCollectionsCollectionsSummonerIcons
    {
        [JsonProperty("icons")]
        public int[] Icons { get; set; }
        [JsonProperty("summonerIcons")]
        public LolCollectionsCollectionsSummonerIcon[] SummonerIcons { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
