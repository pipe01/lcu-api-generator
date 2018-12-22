using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolGameQueuesLoginDataPacket
    {
        [JsonProperty("gameTypeConfigs")]
        public LolGameQueuesQueueGameTypeConfig[] GameTypeConfigs { get; set; }
    }
}
