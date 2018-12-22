using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LCDSGlobalRewards
    {
        [JsonProperty("allChampions")]
        public bool AllChampions { get; set; }
    }
}
