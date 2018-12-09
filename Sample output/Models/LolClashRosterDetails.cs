using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashRosterDetails
    {
        [JsonProperty("iconColorId")]
        public int IconColorId { get; set; }
        [JsonProperty("iconId")]
        public int IconId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("shortName")]
        public string ShortName { get; set; }
    }
}
