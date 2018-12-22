using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChampionsCollectionsChampionSkinEmblem
    {
        [JsonProperty("emblemPath")]
        public LolChampionsCollectionsChampionSkinEmblemPath EmblemPath { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("positions")]
        public LolChampionsCollectionsChampionSkinEmblemPosition Positions { get; set; }
    }
}