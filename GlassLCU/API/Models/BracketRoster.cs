using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class BracketRoster
    {
        [JsonProperty("logo")]
        public int Logo { get; set; }
        [JsonProperty("logoColor")]
        public int LogoColor { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("rosterId")]
        public long RosterId { get; set; }
        [JsonProperty("shortName")]
        public string ShortName { get; set; }
    }
}
