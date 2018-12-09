using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolGameQueuesLoginDataPacket
    {
        [JsonProperty("gameTypeConfigs")]
        public LolGameQueuesQueueGameTypeConfig[] GameTypeConfigs { get; set; }
    }
}
