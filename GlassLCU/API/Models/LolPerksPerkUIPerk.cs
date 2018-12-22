using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPerksPerkUIPerk
    {
        [JsonProperty("iconPath")]
        public string IconPath { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("longDesc")]
        public string LongDesc { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("shortDesc")]
        public string ShortDesc { get; set; }
        [JsonProperty("tooltip")]
        public string Tooltip { get; set; }
    }
}
