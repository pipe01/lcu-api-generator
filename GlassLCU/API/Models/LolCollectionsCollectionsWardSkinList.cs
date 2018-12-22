using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolCollectionsCollectionsWardSkinList
    {
        [JsonProperty("wardSkinList")]
        public long[] WardSkinList { get; set; }
    }
}
