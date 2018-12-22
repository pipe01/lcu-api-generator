using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class ClashRewardConfigClient
    {
        [JsonProperty("entries")]
        public ClashRewardConfigEntry[] Entries { get; set; }
        [JsonProperty("grantToSub")]
        public bool GrantToSub { get; set; }
        [JsonProperty("keyDef")]
        public ClashRewardKeyType[] KeyDef { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
