using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCollectionsCollectionsWardSkinList
    {
        [JsonProperty("wardSkinList")]
        public long[] WardSkinList { get; set; }
    }
}
