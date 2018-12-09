using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolActiveBoostsLoginDataPacket
    {
        [JsonProperty("timeUntilFirstWinOfDay")]
        public long TimeUntilFirstWinOfDay { get; set; }
    }
}
