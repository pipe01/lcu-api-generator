using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolCollectionsCollectionsRuneBook
    {
        [JsonProperty("pages")]
        public LolCollectionsCollectionsRunePage[] Pages { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
