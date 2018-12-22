using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolCollectionsCollectionsSummonerSpells
    {
        [JsonProperty("spells")]
        public long[] Spells { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
