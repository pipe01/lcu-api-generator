using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolActiveBoostsLoginDataPacket
    {
        [JsonProperty("timeUntilFirstWinOfDay")]
        public long TimeUntilFirstWinOfDay { get; set; }
    }
}
